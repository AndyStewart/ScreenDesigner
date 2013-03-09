using Moq;
using Xunit;

namespace ScreenDesigner.UI.UnitTests.Tools
{
    using ScreenDesigner.UI.Tools;

    public class LabelToolViewModelUnitTest
    {
        [Fact]
        public void AddToolCommand_WhenExecuted_AddsLabelElementToScreen()
        {
            var fakeScreenEditor = new Mock<ScreenEditorViewModelBase>();
            var fakeElementFactory = new Mock<ElementViewModelFactoryBase>();
            
            var labelElement = new LabelElementViewModel();
            fakeElementFactory.Setup(q => q.CreateLabel()).Returns(labelElement);

            var tool = new LabelToolViewModel(fakeElementFactory.Object);
            tool.Initialise(fakeScreenEditor.Object);
            tool.AddTool.Execute(null);

            fakeScreenEditor.Verify(q => q.Add(labelElement));
        }
    }
}