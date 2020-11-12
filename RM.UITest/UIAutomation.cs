using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace RM.UITest
{
    public class UIAutomation
    {
        private WindowsDriver<WindowsElement> app;
        private DesiredCapabilities appCapabilities;
        private Process wadProcess;
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/";
        private AppiumWebElement newOrderButton => app.FindElementByXPath("//Button/Text[@Name='Start New Order']/..");
        private Dictionary<string, string> windows;

        [SetUp]
        public void FixtureSetUp()
        {
            var WAD = Path.GetFullPath("C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe");
            Assert.IsTrue(File.Exists(WAD),
                "Could not find WinAppDriver, it is required to run these tests, please install it, then " + WAD +
                " should exist");
            wadProcess = new Process {StartInfo = {FileName = WAD}};
            Assert.IsTrue(wadProcess.Start());
        }

        [SetUp]
        public void Initialize()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            appCapabilities = new DesiredCapabilities();
            var path = Path.GetFullPath(appPath + "\\RM.exe");
            Assert.IsTrue(File.Exists(path),
                "Expected to find OemUiTool executable at location " + path +
                " but didn't. Make sure to run the debug build of the UI application first.");
            appCapabilities.SetCapability("app", path);
            appCapabilities.SetCapability("appWorkingDir", Path.GetFullPath(appPath));
            app = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            windows = new Dictionary<string, string> {[app.Title] = app.CurrentWindowHandle};
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            if (wadProcess != null && wadProcess.HasExited == false) wadProcess.Kill();
        }

        [Test]
        public void ScreenSizeTest()
        {
            app.Manage().Window.Size = new Size(950, 700);
            app.Manage().Window.Size = new Size(400, 700);
            app.Manage().Window.Size = new Size(1400, 700);
        }
    }
}