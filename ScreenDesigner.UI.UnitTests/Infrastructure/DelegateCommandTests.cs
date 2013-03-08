using ScreenDesigner.UI.Infrastructure;
using Xunit;

namespace ScreenDesigner.UI.UnitTests.Infrastructure
{
    public class DelegateCommandTests
    {
        [Fact]
        public void Execute_WithAction_ExecutesAction()
        {
            var fired = false;
            var command = new DelegateCommand(() => fired = true);
            command.Execute(null);
            
            Assert.True(fired); 
        }
    }
}