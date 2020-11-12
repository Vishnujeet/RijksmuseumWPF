using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using RM.Common;
using RM.Service;
using RM.Utils;
using RM.TestUtils;
using RM.ViewModel;
using RM.ViewModel.Screen;

namespace RM.UnitTest
{
    [TestFixture]
    public class TestArtViewerViewModel
    {
        private Mock<IDataContextProvider> mockDataContextProvider;
        private Mock<IViewActivator> mockViewActivator;
        private Mock<IRMService> mockIRMService;
        private ArtObjectViewModel artObjectViewModel;
        private Mock<IArtViewerViewModel> mockArtViewerViewModel;
        [SetUp]
        public void SetUp()
        {
            mockDataContextProvider = Container.Instance.RegisterMock<IDataContextProvider>();
            mockViewActivator = new Mock<IViewActivator>();
            mockIRMService = Container.Instance.RegisterMock<IRMService>();
            mockArtViewerViewModel = Container.Instance.RegisterMock<IArtViewerViewModel>();
            artObjectViewModel = new ArtObjectViewModel();
        }


        [Test]
        public void GetArtGetDetailsCommand()
        {
            mockIRMService.Setup(x => x.GetArtObjectDetails(It.IsAny<string>())).Returns(Task.FromResult(new SingleArt()));

            //mockDataContextProvider.SetupGet(x => x.MainScreenViewModel.EmployeeInfoViewModel)
            //    .Returns(mockEmployeeInfo.Object);
            artObjectViewModel.GetDetailsCommand.Execute(null);
        }
    }
}
