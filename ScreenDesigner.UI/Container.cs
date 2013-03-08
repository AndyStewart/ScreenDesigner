using Autofac;

namespace ScreenDesigner.UI
{
    public static class Container
    {
        public static IContainer Create()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ScreenDesignerModule>();
            var container = builder.Build();
            return container;
        }
    }
}