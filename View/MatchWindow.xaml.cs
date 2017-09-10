using MahApps.Metro.Controls;
using MMAApp.Model;
using MMAApp.ViewModel;
using System.Collections.Generic;
using System.Timers;
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

        Results f1Results { get; set; }
        Results f2Results { get; set; }

        public List<Results> MatchResults { get; set; }

        private int _secondCounter = 0;
        private const long _roundLength = 300000; // 5mins
        private const long _timerInterval = 1000; //1s
        
        private MatchWindowViewModel _vm;


        /// <summary>
        /// constructor
        /// </summary>
        public MatchWindow()
        {    
            InitializeComponent();
            InitUI();
            InitTimer();
        }

        private void InitTimer()
        {
            Timer timer = new Timer(_roundLength); //magic number
            timer.Interval = _timerInterval;
            timer.Enabled = true;
            timer.Elapsed += OnTimedEvent;
        }


        /// <summary>
        /// setup for UI
        /// </summary>
        private void InitUI()
        {
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

            _vm = new MatchWindowViewModel();
        }

        /// <summary>
        /// executes when interval elapsed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                _secondCounter++;
                CounterLabel.Text = _secondCounter.ToString();
            });
            
        }


        /// <summary>
        /// event fires when the relevant key is pressed 
        /// calls AddPointToFighter in VM
        /// updates TextBlocks property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Strike_Event(object sender, System.Windows.Input.KeyEventArgs e)
        {
            _vm.AddPointToFigther(e.Key);

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
