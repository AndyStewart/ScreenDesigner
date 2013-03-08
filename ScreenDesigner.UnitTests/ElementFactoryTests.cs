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
    }
}