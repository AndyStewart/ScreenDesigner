using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class ContainerToolViewModel : ToolViewModelBase
    {
        private readonly ElementFactoryBase _elementFactoryBase;
        private DelegateCommand _addTool;

        public ContainerToolViewModel(ElementFactoryBase elementFactoryBase)
        {
            _elementFactoryBase = elementFactoryBase;
        }

        public override string Name
        {
            get { return "Container"; }
        }

        public override DelegateCommand AddTool
        {
            get { return _addTool; }
        }

        public override void Initialise(ScreenEditorViewModelBase screen)
        {
            _addTool = new DelegateCommand(() => screen.Add(_elementFactoryBase.CreateContainer()));
        }
    }
}