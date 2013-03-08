using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class LabelToolViewModel : ToolViewModelBase
    {
        public override string Name
        {
            get { return "Label"; }
        }

        public override DelegateCommand AddTool
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}