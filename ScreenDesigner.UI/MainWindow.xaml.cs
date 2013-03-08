using System.Windows;
using Autofac;  

namespace ScreenDesigner.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var container = Container.Create();
            DataContext = container.Resolve<ScreenEditorViewModelBase>();
        }
    }
}
