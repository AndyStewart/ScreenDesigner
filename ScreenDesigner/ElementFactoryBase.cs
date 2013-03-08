namespace ScreenDesigner
{
    public abstract class ElementFactoryBase
    {
        public abstract Element CreateLine();

        public abstract Element CreateContainer();

        public abstract Element CreateLabel();
    }
}