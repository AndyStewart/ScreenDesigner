using Xunit;

namespace ScreenDesigner.UnitTests
{
    public class ElementFactoryTests
    {
        [Fact] 
        public void CreateLine_Default_CreatesLineElement()
        {
            var factory = new ElementFactory();
            var element = factory.CreateLine();
            Assert.IsType<LineElement>(element);
        }

        [Fact]
        public void CreateContainer_Default_CreateContainer()
        {
            var factory = new ElementFactory();
            var element = factory.CreateContainer();
            Assert.IsType<ContainerElement>(element);            
        }

        [Fact]
        public void CreateLabel_Default_CreatesLabel()
        {
            var factory = new ElementFactory();
            var element = factory.CreateLabel();
            Assert.IsType<LabelElement>(element);
        }

        [Fact]
        public void CreateLabel_Default_SetsDefaultText()
        {
            var factory = new ElementFactory();
            var label = factory.CreateLabel();

            Assert.Equal("Label", label.Text);
        }
    }
}