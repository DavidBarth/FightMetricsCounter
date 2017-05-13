using MMAApp.Model;
using MMAApp.Utility;
using System.Collections.ObjectModel;
using System.Windows.Input;

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


        public ICommand AddFighterCommand { get; set; }
        public ICommand StartMetricsCommand { get; set; }


        /// <summary>
        /// constructor
        /// </summary>
        public StartWindowViewModel()
        {
            LoadCommands();
            InitializeUI();
            
        }

        

        /// <summary>
        /// commands for buttons
        /// </summary>
        private void LoadCommands()
        {
            AddFighterCommand = new CustomCommand(AddFighter, CanAddFighter);
            StartMetricsCommand = new CustomCommand(SartMetrics, CanStartMetrics);
        }

        /// <summary>
        /// will determine if the command can be invoked or not
        /// a fighter should be selected
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        private bool CanAddFighter(object obj)
        {
            if (SelectedFigther != null)
            {
                if (FigthersForMatch.Count == 2)
                    return false;
                return true;
            }
            return false;
           
        }

        /// <summary>
        /// Adds figther to FigthersToMatch list
        /// </summary>
        /// <param name="obj"></param>
        private void AddFighter(object obj)
        {
            FigthersForMatch.Add(SelectedFigther);           
        }

        /// <summary>
        /// will determine if command can be invoked or not
        /// two fighters should be in the list
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        private bool CanStartMetrics(object obj)
        {
            return false;
        }
        /// <summary>
        /// Open new window to for metrics operations
        /// </summary>
        /// <param name="obj"></param>
        private void SartMetrics(object obj)
        {
            
        }

       
        
        /// <summary>
        /// initializes UI
        /// </summary>
        private void InitializeUI()
        {
            LoadData();
            FigthersForMatch = new ObservableCollection<Fighter>();
        }

        /// <summary>
        /// populates Figther list
        /// </summary>
        private void LoadData()
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

       
    }
}
