using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class LineToolViewModel : ToolViewModelBase
    {
        public override string Name { get { return "Line"; } }

        public override DelegateCommand AddTool
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}