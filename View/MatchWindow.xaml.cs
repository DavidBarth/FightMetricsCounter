using MahApps.Metro.Controls;

namespace MMAApp.View
{
    /// <summary>
    /// Interaction logic for MatchWindow.xaml
    /// </summary>
    public partial class MatchWindow : MetroWindow
    {
        public MatchWindow()
        {
            InitializeComponent();
            _headStrike1 = 0;
            Head1.Text = 0.ToString();
        }

        private int _headStrike1;
      
        private void HeadStrike_Event(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Q)
            {
                _headStrike1+=1;
                Head1.Text = _headStrike1.ToString(); 
            }
        }
    }
}
