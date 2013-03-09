using ScreenDesigner.UI.Infrastructure;
using ScreenDesigner.UI.Tools;

namespace ScreenDesigner.UI
{
    public class LineToolViewModel : ToolViewModelBase
    {
        private readonly ElementViewModelFactoryBase _elementFactoryBase;
        private DelegateCommand addTool;

        public LineToolViewModel(ElementViewModelFactoryBase elementFactoryBase)
        {
            _elementFactoryBase = elementFactoryBase;
        }

        public override string Name { get { return "Line"; } }

        public override DelegateCommand AddTool { get { return addTool; } }

        public override void Initialise(ScreenEditorViewModelBase screen)
        {
            addTool = new DelegateCommand(() => this.Execute(screen));
        }

        private void Execute(ScreenEditorViewModelBase screen)
        {
            var element = this._elementFactoryBase.CreateLine();
            screen.Add(element);
        }
    }
}