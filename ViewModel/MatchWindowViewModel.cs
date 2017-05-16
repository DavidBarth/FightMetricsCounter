using MMAApp.Model;
using MMAApp.Utility;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace MMAApp.ViewModel
{
    class MatchWindowViewModel:ViewModelBase
    {
        
       /* private int _headStrikeA { get; set; }
        public int HeadStrikeA
        {
            get
            {
                return _headStrikeA;
            }

            set
            {
                _headStrikeA = value;
                OnPropertyChanged();
            }
        }
        */

        public ObservableCollection<Fighter> FightersInMatch { get; set; }

        public Fighter Figther1 { get; set; }
        public Fighter Fighter2 { get; set; }

        private Results r1;
        private Results r2;

        /// <summary>
        /// constructor
        /// </summary>
        public MatchWindowViewModel()
        {
            Messenger.Default.Register<ObservableCollection<Fighter>>(this, OnFigthersReceived);
            InitUI();
          
        }

        /// <summary>
        /// sets up UI
        /// </summary>
        private void InitUI()
        {
            Figther1 = new Fighter();
            Fighter2 = new Fighter();
            r1 = new Results();
            r2 = new Results();
            Figther1.Results.Add(r1);
            Fighter2.Results.Add(r2);
        }


        /// <summary>
        /// add poinst according to value of key param
        /// </summary>
        /// <param name="key"></param>
        public void AddPointToFigther(Key key)
        {
            if (key.ToString().Equals("Q"))
            {
                r1.hS++;
            }

            if (key.ToString().Equals("W"))
            {
                r1.bS++;
            }

            if (key.ToString().Equals("E"))
            {
                r1.lS++;
            }

            if (key.ToString().Equals("I"))
            {
                r2.hS++;
            }

            if (key.ToString().Equals("O"))
            {
                r2.bS++;
            }

            if (key.ToString().Equals("P"))
            {
                r2.lS++;
            }
        }


      
        /// <summary>
        /// Assign message parameter to local var
        /// </summary>
        private void OnFigthersReceived(ObservableCollection<Fighter> figthers)
        {
            FightersInMatch = figthers;
            Figther1 = FightersInMatch.First();
            Fighter2 = FightersInMatch.Last();
        }

       


    }
}
