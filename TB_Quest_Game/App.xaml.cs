using System.Windows;
using TB_Quest_Game.Business;

namespace TB_Quest_Game
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            GameBusiness gameBusiness = new GameBusiness();
        }
    }
}
