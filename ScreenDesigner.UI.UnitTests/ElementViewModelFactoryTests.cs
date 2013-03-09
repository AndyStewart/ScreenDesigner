namespace ScreenDesigner.UI.UnitTests
{
    using Moq;

    using Ploeh.AutoFixture;

    using Xunit;

    public class ElementViewModelFactoryTests
    {
        private static Mock<ElementFactory> fakeElementFactory;

        [Fact]
        public void CreateLine_NewElement_CreatesLineViewModel()
        {
            var factory = CreateFactory();
            var line = factory.CreateLine();

            Assert.NotNull(line);
            Assert.IsType<LineElementViewModel>(line);
        }

        [Fact]
        public void CreateLabel_NewElement_CreatesLabelViewModel()
        {
            var factory = CreateFactory();

            var fixture = new Fixture();
            var labelElement = fixture.Create<LabelElement>();
            fakeElementFactory.Setup(q => q.CreateLabel()).Returns(labelElement);

            var label = factory.CreateLabel();

            Assert.NotNull(label);
            Assert.IsType<LabelElementViewModel>(label);
        }
        
        [Fact]
        public void CreateLabel_NewElement_MapsElementToViewModel()
        {
            var factory = CreateFactory();

            var fixture = new Fixture();
            var labelElement = fixture.Create<LabelElement>();
            fakeElementFactory.Setup(q => q.CreateLabel()).Returns(labelElement);
            

            var labelViewModel = (LabelElementViewModel)factory.CreateLabel();

            Assert.Equal(labelElement.Text, labelViewModel.Text);
        }

        [Fact]
        public void CreateContainer_NewElement_CreatesContainerViewModel()
        {
            var factory = CreateFactory();
            var container = factory.CreateContainer();

            Assert.NotNull(container);
            Assert.IsType<ContainerElementViewModel>(container);
        }

        private static ElementViewModelFactory CreateFactory()
        {
            fakeElementFactory = new Mock<ElementFactory>();
            var factory = new ElementViewModelFactory(fakeElementFactory.Object, 
                                                        () => new LineElementViewModel(),
                                                        () => new LabelElementViewModel(),
                                                        () => new ContainerElementViewModel());
            return factory;
        }
    }
}