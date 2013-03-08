using System.Linq;
using Moq;
using Ploeh.AutoFixture;
using ScreenDesigner.UI.Tools;
using Xunit;

namespace ScreenDesigner.UI.UnitTests
{
    public class ScreenEditorViewModelTests
    {
        [Fact]
        public void Ctor_WithTools_ShowsTools()
        {
            var fixture = new Fixture();
            var tools = fixture.CreateMany<Mock<ToolViewModelBase>>(3)
                                .Select(q => q.Object)
                                .ToArray();

            var viewModel = new ScreenEditorViewModel(tools);
            
            Assert.Equal(3, viewModel.Tools.Count());
            Assert.Equal(tools, viewModel.Tools);
        }
    }
}