using MMAApp.View;
using System.Windows;

namespace MMAApp.Services
{
    /// <summary>
    /// service class for opening MatchWindow
    /// </summary>
    class DialogService : IDialogService
    {
        Window MatchWindow = null;

        public void CloseDialog()
        {
            if (MatchWindow != null)
                MatchWindow.Close();
        }

        public void ShowDialog()
        {
            MatchWindow = new MatchWindow();
            MatchWindow.ShowDialog(); 
        }
    }
}
