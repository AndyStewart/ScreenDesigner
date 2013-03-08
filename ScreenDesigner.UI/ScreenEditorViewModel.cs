using System.Collections.Generic;
using System.Linq;
using System.Windows;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class ScreenEditorViewModel : ScreenEditorViewModelBase
    {
        public ScreenEditorViewModel(IEnumerable<ToolViewModelBase> tools)
        {
            Tools = tools;
            Tools.ToList().ForEach(t => t.Initialise(this));
        }

        public override IEnumerable<ToolViewModelBase> Tools { get; set; }
        public override void Add(Element element)
        {
            MessageBox.Show("Added Element - " + element);
        }

        public Element CurrentElement { get; set; }
    }
}