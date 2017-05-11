using MahApps.Metro.Controls;
using MMAApp.ViewModel;

namespace MMAApp.View
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : MetroWindow
    {
        public StartWindow()
        {
            InitializeComponent();
            this.DataContext = new StartWindowViewModel();
        }
    }
}
