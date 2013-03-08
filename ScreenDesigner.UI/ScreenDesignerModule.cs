using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace ScreenDesigner.UI
{
    public class ScreenDesignerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var uiAssembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(uiAssembly)
                .AsImplementedInterfaces()
                .As(q => q.BaseType);
        }
    }
}