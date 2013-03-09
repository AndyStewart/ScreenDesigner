namespace ScreenDesigner.UI
{
    public class ElementViewModelFactory : ElementViewModelFactoryBase
    {
        public override ElementViewModelBase CreateLine()
        {
            return new LineElementViewModel();
        }

        public override ElementViewModelBase CreateContainer()
        {
            return new ContainerElementViewModel();
        }

        public override ElementViewModelBase CreateLabel()
        {
            return new LabelElementViewModel();
        }
    }
}