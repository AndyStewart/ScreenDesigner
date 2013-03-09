namespace ScreenDesigner
{
    public class ElementFactory : ElementFactoryBase
    {
        public override Element CreateLine()
        {
            return new LineElement();
        }

        public override Element CreateContainer()
        {
            return new ContainerElement();
        }

        public override Element CreateLabel()
        {
            return new LabelElement()
                {
                    Text = "Label"
                };
        }
    }
}