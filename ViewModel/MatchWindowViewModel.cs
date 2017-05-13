using MMAApp.Model;
using MMAApp.Utility;
using System.Collections.ObjectModel;

namespace MMAApp.ViewModel
{
    class MatchWindowViewModel
    {
        public ObservableCollection<Fighter> FightersInMatch { get; set; }


        /// <summary>
        /// constructor
        /// </summary>
        public MatchWindowViewModel()
        {
            Messenger.Default.Register<ObservableCollection<Fighter>>(this, OnFigthersReceived);
        }

        /// <summary>
        /// Assign message parameter to local var
        /// </summary>
        /// <param name="figthers"></param>
        private void OnFigthersReceived(ObservableCollection<Fighter> figthers)
        {
            FightersInMatch = figthers;
        }
    }
}
