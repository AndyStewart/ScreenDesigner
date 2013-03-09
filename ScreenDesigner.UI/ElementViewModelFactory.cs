namespace ScreenDesigner.UI
{
    using AutoMapper;

    public class ElementViewModelFactory : ElementViewModelFactoryBase
    {
        private readonly ElementFactoryBase elementFactory;

        public ElementViewModelFactory(ElementFactoryBase elementFactory)
        {
            this.elementFactory = elementFactory;
        }

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
            var element = this.elementFactory.CreateLabel();

            Mapper.CreateMap<LabelElement, LabelElementViewModel>();
            return Mapper.Map<LabelElement, LabelElementViewModel>((LabelElement)element);
        }
    }
}