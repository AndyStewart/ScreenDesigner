namespace ScreenDesigner.UI.Tools
{
    using ScreenDesigner.UI.Infrastructure;

    public class LabelToolViewModel : ToolViewModelBase
    {
        private readonly ElementViewModelFactoryBase _elementFactoryBase;
        private DelegateCommand _addTool;

        public LabelToolViewModel(ElementViewModelFactoryBase elementFactoryBase)
        {
            this._elementFactoryBase = elementFactoryBase;
        }

        public override string Name
        {
            get { return "Label"; }
        }

        public override DelegateCommand AddTool
        {
            get { return this._addTool; }
        }

        public override void Initialise(ScreenEditorViewModelBase screen)
        {
            this._addTool = new DelegateCommand(() => screen.Add(this._elementFactoryBase.CreateLabel()));
        }
    }
}