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

        private Results result1;
        private Results result2;

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
            result1 = new Results();
            result2 = new Results();
            Figther1.Results.Add(result1);
            Fighter2.Results.Add(result2);
        }


        /// <summary>
        /// add poinst according to value of key param
        /// </summary>
        /// <param name="key"></param>
        public void AddPointToFigther(Key key)
        {
            if (key.ToString()=="Q")
            {
                result1.headShot++;
            }

            if (key.ToString()=="W")
            {
                result1.bodyShot++;
            }

            if (key.ToString()=="E")
            {
                result1.legShot++;
            }

            if (key.ToString()=="I")
            {
                result2.headShot++;
            }

            if (key.ToString()=="O")
            {
                result2.bodyShot++;
            }

            if (key.ToString()=="P")
            {
                result2.legShot++;
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
