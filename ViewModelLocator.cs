using MMAApp.ViewModel;

namespace MMAApp
{
    /// <summary>
    /// Returns the required ViewModel
    /// </summary>
    class ViewModelLocator
    {
        private static StartWindowViewModel startWindowViewModel = new StartWindowViewModel();
        private static MatchWindowViewModel matchWindowViewModel = new MatchWindowViewModel();
        

        public static StartWindowViewModel StartWindowViewModel
        {
            get { return startWindowViewModel; }
        }

        public static MatchWindowViewModel MatchWindowViewModel
        {
            get { return matchWindowViewModel; }
        }
        
    }
}
