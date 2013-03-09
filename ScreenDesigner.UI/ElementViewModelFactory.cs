namespace ScreenDesigner.UI
{
    using AutoMapper;

    public class ElementViewModelFactory : ElementViewModelFactoryBase
    {
        private readonly ElementFactoryBase elementFactory;

        private readonly LineElementViewModel.Factory lineElementFactory;

        private readonly LabelElementViewModel.Factory labelElementFactory;

        private readonly ContainerElementViewModel.Factory containerElementFactory;

        public ElementViewModelFactory(ElementFactoryBase elementFactory, LineElementViewModel.Factory lineElementFactory, LabelElementViewModel.Factory labelElementFactory, ContainerElementViewModel.Factory containerElementFactory)
        {
            this.elementFactory = elementFactory;
            this.lineElementFactory = lineElementFactory;
            this.labelElementFactory = labelElementFactory;
            this.containerElementFactory = containerElementFactory;
        }

        public override ElementViewModelBase CreateLine()
        {
            return lineElementFactory();
        }

        public override ElementViewModelBase CreateContainer()
        {
            return containerElementFactory();
        }

        public override ElementViewModelBase CreateLabel()
        {
            var element = this.elementFactory.CreateLabel();

            Mapper.CreateMap<LabelElement, LabelElementViewModel>();
            return Mapper.Map((LabelElement)element, labelElementFactory());
        }
    }
}