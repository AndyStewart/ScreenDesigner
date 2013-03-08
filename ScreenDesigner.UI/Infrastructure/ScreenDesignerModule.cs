using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace ScreenDesigner.UI.Infrastructure
{
    public class ScreenDesignerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var uiAssembly = Assembly.GetExecutingAssembly();
            var domainAssembly = Assembly.Load("ScreenDesigner");
            builder.RegisterAssemblyTypes(uiAssembly, domainAssembly)
                .AsImplementedInterfaces()
                .As(q => q.BaseType);
        }
    }
}