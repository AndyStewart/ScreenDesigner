namespace ScreenDesigner.UI
{
    public abstract class ElementViewModelFactoryBase
    {
        public abstract ElementViewModelBase CreateLine();

        public abstract ElementViewModelBase CreateContainer();

        public abstract ElementViewModelBase CreateLabel();
    }
}