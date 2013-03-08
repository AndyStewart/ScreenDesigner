using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class ContainerToolViewModel : ToolViewModelBase
    {
        public override string Name
        {
            get { return "Container"; }
        }

        public override DelegateCommand AddTool
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}