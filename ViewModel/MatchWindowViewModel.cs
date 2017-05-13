using MMAApp.Model;
using MMAApp.Utility;
using System.Collections.ObjectModel;
using System.Linq;

namespace MMAApp.ViewModel
{
    public class MatchWindowViewModel
    {
        public ObservableCollection<Fighter> FightersInMatch { get; set; }

        public Fighter Figther1 { get; set; }
        public Fighter Figther2 { get; set; }

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
        private void OnFigthersReceived(ObservableCollection<Fighter> figthers)
        {
            FightersInMatch = figthers;
            Figther1 = FightersInMatch.First();
            Figther2 = FightersInMatch.Last();
        }
    }
}
