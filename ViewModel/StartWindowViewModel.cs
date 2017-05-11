using MMAApp.Model;
using System.Collections.ObjectModel;

namespace MMAApp.ViewModel
{
    class StartWindowViewModel :ViewModelBase
    {
        /// <summary>
        /// binds to the select figther list view
        /// </summary>
        public ObservableCollection<Fighter> Figthers { get; set; }

        /// <summary>
        /// binds to the fighters selected for match list
        /// </summary>
        public ObservableCollection<Fighter> FigthersForMatch { get; set; }



        /// <summary>
        /// bind to the Fighter details 
        /// </summary>
        private Fighter _selectedFighter { get; set; }
        public Fighter SelectedFigther
        {
            get
            {
                return _selectedFighter;
            }
            set
            {
                _selectedFighter = value;
                OnPropertyChanged();

            }
        }

        /// <summary>
        /// binds to the selected figther for match 
        /// </summary>
        private Fighter _selectedFighterForMatch { get; set; }
        public Fighter SelectedFighterForMatch
        {
            get
            {
                return _selectedFighterForMatch;
            }
            set
            {
                _selectedFighterForMatch = value;
                OnPropertyChanged();
            }
        }

        public StartWindowViewModel()
        {
           LoadData();
        }

        public void LoadData()
        {
            Figthers = new ObservableCollection<Fighter>();
            Fighter f1 = new Fighter
            {
                Name = "Nate Diaz"
            };

            Fighter f2 = new Fighter
            {
                Name = "Connor McGregor"
            };

            Figthers.Add(f1);
            Figthers.Add(f2);
        }

        public bool CheckNumberOfSelectedFighters()
        {
            if (FigthersForMatch.Count == 2)
            {
                return true;
            }
            return false;

        }
    }
}
