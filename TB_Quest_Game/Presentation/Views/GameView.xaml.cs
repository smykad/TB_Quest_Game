using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TB_Quest_Game.Presentation.ViewModels;

namespace TB_Quest_Game.Presentation.Views
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : Window
    {
        GameViewModel _gameViewModel;
        public GameView(GameViewModel gameViewModel)
        {
            _gameViewModel = gameViewModel;
            InitializeComponent();
        }

        private void Quit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
