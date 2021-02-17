using System.Windows;
using TB_Quest_Game.Presentation.ViewModels;


namespace TB_Quest_Game.Presentation.Views
{
    /// <summary>
    /// Interaction logic for RegisterPlayer.xaml
    /// </summary>
    public partial class RegisterPlayer : Window
    {
        RegisterViewModel _registerViewModel;
        public RegisterPlayer(RegisterViewModel registerViewModel)
        {
            _registerViewModel = registerViewModel;
            InitializeComponent();
        }
    }
}
