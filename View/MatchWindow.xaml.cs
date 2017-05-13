using MahApps.Metro.Controls;
using System.Windows.Input;

namespace MMAApp.View
{
    /// <summary>
    /// Interaction logic for MatchWindow.xaml
    /// </summary>
    public partial class MatchWindow : MetroWindow
    {
        private int _headStrike1;
        private int _bodyStrike1;
        private int _legStrike1;

        private int _headStrike2;
        private int _bodyStrike2;
        private int _legStrike2;

        public MatchWindow()
        {
            InitializeComponent();
            //this.DataContext = new MatchWindowViewModel();
            _headStrike1 = 0;
            _bodyStrike1 = 0;
            _legStrike1 = 0;

            _headStrike2 = 0;
            _bodyStrike2 = 0;
            _legStrike2 = 0;
            
            Head1.Text = _headStrike1.ToString();
            Body1.Text = _bodyStrike1.ToString();
            Leg1.Text = _legStrike1.ToString();

            Head2.Text = _headStrike2.ToString();
            Body2.Text = _bodyStrike2.ToString();
            Leg2.Text = _legStrike2.ToString();

        }

       
      
        private void Strike_Event(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Q:
                           
                _headStrike1++;
                Head1.Text = _headStrike1.ToString();
                break;

                case Key.W:

                    _bodyStrike1++;
                    Body1.Text = _bodyStrike1.ToString();
                    break;

                case Key.E:

                    _legStrike1++;
                    Leg1.Text = _legStrike1.ToString();
                    break;

                case Key.I:

                    _headStrike2++;
                    Head2.Text = _headStrike2.ToString();
                    break;

                case Key.O:

                    _bodyStrike2++;
                    Body2.Text = _bodyStrike2.ToString();
                    break;

                case Key.P:

                    _legStrike2++;
                    Leg2.Text = _legStrike2.ToString();
                    break;


            }


           
        }
    }
}
