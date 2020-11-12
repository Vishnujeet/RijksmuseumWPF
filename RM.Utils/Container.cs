using Microsoft.Practices.Unity;

namespace RM.Utils
{
   public static class Container
    {
        private static IUnityContainer container;

        public static IUnityContainer Instance
        {
            get
            {
                if (container == null)
                {
                    container = new UnityContainer();
                }
                return container;
            }
            set
            {
                if (value != container && container != null)
                {
                    container.Dispose();
                }

                container = value;
            }
        }

        public static T Resolve<T>(params ResolverOverride[] overrides)
        {
            return Instance.Resolve<T>(overrides);
        }

        public static T Resolve<T>(string name, params ResolverOverride[] overrides)
        {
            return Instance.Resolve<T>(name, overrides);
        }

    }
}