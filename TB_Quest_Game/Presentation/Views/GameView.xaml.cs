using System.Windows;
using TB_Quest_Game.Presentation.ViewModels;

namespace TB_Quest_Game.Presentation.Views
{
    public partial class GameView : Window
    {

        #region Fields
        GameViewModel _gameViewModel;
        #endregion

        #region Constructors
        public GameView(GameViewModel gameViewModel)
        {
            _gameViewModel = gameViewModel;
            
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void Quit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        private void WestTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameViewModel.MoveWest();
        }

        private void NorthTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameViewModel.MoveNorth();
        }

        private void EastTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameViewModel.MoveEast();
        }

        private void SouthTravelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameViewModel.MoveSouth();
        }
    }
}
