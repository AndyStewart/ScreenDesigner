namespace ScreenDesigner.UI.UnitTests
{
    using Xunit;

    public class ElementViewModelFactoryTests
    {
        [Fact]
        public void CreateLine_NewElement_CreatesLineViewModel()
        {
            var factory = new ElementViewModelFactory();
            var line = factory.CreateLine();

            Assert.NotNull(line);
            Assert.IsType<LineElementViewModel>(line);
        }

        [Fact]
        public void CreateLabel_NewElement_CreatesLabelViewModel()
        {
            var factory = new ElementViewModelFactory();
            var label = factory.CreateLabel();

            Assert.NotNull(label);
            Assert.IsType<LabelElementViewModel>(label);
        }

        [Fact]
        public void CreateLabel_NewElement_CreatesContainerViewModel()
        {
            var factory = new ElementViewModelFactory();
            var container = factory.CreateContainer();

            Assert.NotNull(container);
            Assert.IsType<ContainerElementViewModel>(container);
        }
    }
}