using ScreenDesigner.UI.Infrastructure;

namespace ScreenDesigner.UI.Tools
{
    public abstract class ToolViewModelBase
    {
        public abstract string Name { get; }
        public abstract DelegateCommand AddTool { get; }
    }
}