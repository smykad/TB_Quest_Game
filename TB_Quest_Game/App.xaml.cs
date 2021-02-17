using System.Windows;
using TB_Quest_Game.Presentation.Views;

namespace TB_Quest_Game
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartingScreen startingScreen = new StartingScreen();
            startingScreen.Show();
        }
    }
}
