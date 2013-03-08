using System.Collections.Generic;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public abstract class ScreenEditorViewModelBase
    {
        public abstract IEnumerable<ToolViewModelBase> Tools { get; set; }
    }
}