using System.Collections.Generic;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class ScreenEditorViewModel : ScreenEditorViewModelBase
    {
        public ScreenEditorViewModel(IEnumerable<ToolViewModelBase> tools)
        {
            Tools = tools; 
        }

        public override IEnumerable<ToolViewModelBase> Tools { get; set; }
    }
}