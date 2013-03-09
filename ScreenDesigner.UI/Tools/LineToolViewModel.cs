namespace ScreenDesigner.UI.Tools
{
    using ScreenDesigner.UI.Infrastructure;

    public class LineToolViewModel : ToolViewModelBase
    {
        private readonly ElementViewModelFactoryBase _elementFactoryBase;
        private DelegateCommand addTool;

        public LineToolViewModel(ElementViewModelFactoryBase elementFactoryBase)
        {
            this._elementFactoryBase = elementFactoryBase;
        }

        public override string Name { get { return "Line"; } }

        public override DelegateCommand AddTool { get { return this.addTool; } }

        public override void Initialise(ScreenEditorViewModelBase screen)
        {
            this.addTool = new DelegateCommand(() => this.Execute(screen));
        }

        private void Execute(ScreenEditorViewModelBase screen)
        {
            var element = this._elementFactoryBase.CreateLine();
            screen.Add(element);
        }
    }
}