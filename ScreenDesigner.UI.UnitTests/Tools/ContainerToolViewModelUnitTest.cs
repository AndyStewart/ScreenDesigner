using Moq;
using Xunit;

namespace ScreenDesigner.UI.UnitTests.Tools
{
    using ScreenDesigner.UI.Tools;

    public class ContainerToolViewModelUnitTest
    {
        [Fact]
        public void AddToolCommand_WhenExecuted_AddsContainerElementToScreen()
        {
            var fakeScreenEditor = new Mock<ScreenEditorViewModelBase>();
            var fakeElementFactory = new Mock<ElementViewModelFactoryBase>();
            
            var containerElement = new ContainerElementViewModel();
            fakeElementFactory.Setup(q => q.CreateContainer()).Returns(containerElement);

            var tool = new ContainerToolViewModel(fakeElementFactory.Object);
            tool.Initialise(fakeScreenEditor.Object);
            tool.AddTool.Execute(null);

            fakeScreenEditor.Verify(q => q.Add(containerElement));
        }
    }
}