using System.Collections.Generic;
using System.Linq;

using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    using System.Collections.ObjectModel;

    public class ScreenEditorViewModel : ScreenEditorViewModelBase
    {
        public ScreenEditorViewModel(IEnumerable<ToolViewModelBase> tools)
        {
            Tools = tools;
            Tools.ToList().ForEach(t => t.Initialise(this));  
            Elements = new ObservableCollection<ElementViewModelBase>();
        }

        public override IEnumerable<ToolViewModelBase> Tools { get; set; }

        public override void Add(ElementViewModelBase element)
        {
            Elements.Add(element);
        }

        public ElementViewModelBase CurrentElement { get; set; }

        public ObservableCollection<ElementViewModelBase> Elements { get; set; }
    }
}