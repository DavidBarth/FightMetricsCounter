﻿using MMAApp.Extensions;
using MMAApp.Model;
using MMAApp.Services;
using MMAApp.Utility;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MMAApp.ViewModel
{
    class StartWindowViewModel :ViewModelBase
    {

        private ObservableCollection<Fighter> _fighter;
        /// <summary>
        /// binds to the select figther list view
        /// </summary>
        public ObservableCollection<Fighter> Fighters
        {
            get
            {
                return _fighter;
            }
            set
            {
                _fighter = value;
            }
        }

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

        private IDialogService _dialogService { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        public StartWindowViewModel()
        {
            LoadCommands();
            InitializeUI();
            
        }


        public List<Results> results { get; set; }
        private void OnResultReceived(List<Results> obj)
        {
            results = obj;
            

            
            MessageBox.Show("All good");
           
        }

        /// <summary>
        /// commands for buttons
        /// </summary>
        private void LoadCommands()
        {
            AddFighterCommand = new CustomCommand(AddFighter, CanAddFighter);
            StartMetricsCommand = new CustomCommand(SartMetrics, CanStartMetrics);
            
            //Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessage);
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
                if (CheckNumberOfFigthers())
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
            if (FigthersForMatch.Contains(SelectedFigther))
            {
                MessageBox.Show("Figther is already in the list!");
            }
            else
            {
                FigthersForMatch.Add(SelectedFigther);
            }
                       
        }

        /// <summary>
        /// will determine if command can be invoked or not
        /// two fighters should be in the list
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        private bool CanStartMetrics(object obj)
        {
            
            if (CheckNumberOfFigthers())
                return true;
            return false;
            
        }
        /// <summary>
        /// Open new window for metrics operations
        /// Send list of selected fighters to MatchWindow
        /// </summary>
        /// <param name="obj"></param>
        private void SartMetrics(object obj)
        {
            Messenger.Default.Send(FigthersForMatch);
            _dialogService.ShowDialog();
        }

                
        
        /// <summary>
        /// initializes UI
        /// </summary>
        private void InitializeUI()
        {
            LoadData();
            FigthersForMatch = new ObservableCollection<Fighter>();
            _dialogService = new DialogService();
        }

        /// <summary>
        /// populates Figther list
        /// </summary>
        private void LoadData()
        {
            IDataService dataService = new DataService();
            Fighters = dataService.GetFighters().ToObservableCollection();
            
        }

        /// <summary>
        /// helper to check number of fighters in the list
        /// </summary>
        /// <returns></returns>
        private bool CheckNumberOfFigthers()
        {    
            if (FigthersForMatch.Count == 2)
                return true;
            return false;
        
        }
    }
}
