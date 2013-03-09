using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class LabelToolViewModel : ToolViewModelBase
    {
        private readonly ElementViewModelFactoryBase _elementFactoryBase;
        private DelegateCommand _addTool;

        public LabelToolViewModel(ElementViewModelFactoryBase elementFactoryBase)
        {
            _elementFactoryBase = elementFactoryBase;
        }

        public override string Name
        {
            get { return "Label"; }
        }

        public override DelegateCommand AddTool
        {
            get { return _addTool; }
        }

        public override void Initialise(ScreenEditorViewModelBase screen)
        {
            _addTool = new DelegateCommand(() => screen.Add(_elementFactoryBase.CreateLabel()));
        }
    }
}