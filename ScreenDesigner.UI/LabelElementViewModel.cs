namespace ScreenDesigner.UI
{
    public class LabelElementViewModel : ElementViewModelBase
    {
        public string Text { get; set; }

        public delegate LabelElementViewModel Factory();
    }
}