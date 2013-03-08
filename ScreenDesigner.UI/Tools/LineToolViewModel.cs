using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class LineToolViewModel : ToolViewModelBase
    {
        private readonly ElementFactoryBase _elementFactoryBase;
        private DelegateCommand addTool;

        public LineToolViewModel(ElementFactoryBase elementFactoryBase)
        {
            _elementFactoryBase = elementFactoryBase;
        }

        public override string Name { get { return "Line"; } }

        public override DelegateCommand AddTool { get { return addTool; } }

        public override void Initialise(ScreenEditorViewModelBase screen)
        {
            addTool = new DelegateCommand(() => screen.Add(_elementFactoryBase.CreateLine()));
        }
    }
}