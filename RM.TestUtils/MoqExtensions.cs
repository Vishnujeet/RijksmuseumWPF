using System.Linq;
using Microsoft.Practices.Unity;
using Moq;

namespace RM.TestUtils
{
    public static class MoqExtensions
    {

        public static Mock<T> RegisterMock<T>(this IUnityContainer container) where T : class
        {
            var mock = new Mock<T>();

            container.RegisterInstance(mock);
            container.RegisterInstance(mock.Object);

            return mock;
        }

        public static Mock<T> RegisterMock<T>(this IUnityContainer container, MockBehavior behaviour) where T : class
        {
            var mock = new Mock<T>(behaviour);

            container.RegisterInstance(mock);
            container.RegisterInstance(mock.Object);

            return mock;
        }

        public static Mock<T> RegisterMock<T>(this IUnityContainer container, string name, MockBehavior behavior, params object[] args) where T : class
        {
            var mock = new Mock<T>(behavior, args);

            container.RegisterInstance(name, mock);
            container.RegisterInstance(name, mock.Object);

            return mock;
        }

        public static Mock<T> RegisterMock<T>(this IUnityContainer container, string name) where T : class
        {
            var mock = new Mock<T>();

            container.RegisterInstance(name, mock);
            container.RegisterInstance(name, mock.Object);

            return mock;
        }

        public static bool IsMockRegistered<T>(this IUnityContainer container) where T : class
        {
            return container.Registrations.Any(x => x.RegisteredType == typeof(T));
        }

        /// <summary>
        /// Use this to add additional setups for a mock that is already registered. If the mock is not registered, returns null.
        /// </summary>
        public static Mock<T> GetMockFor<T>(this IUnityContainer container) where T : class
        {
            if (container.Registrations.All(x => x.RegisteredType != typeof(T)))
                return null;

            return container.Resolve<Mock<T>>();
        }

        public static void VerifyMockFor<T>(this IUnityContainer container) where T : class
        {
            container.Resolve<Mock<T>>().VerifyAll();
        }

    }
}
