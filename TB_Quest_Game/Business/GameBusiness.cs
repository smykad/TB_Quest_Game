using TB_Quest_Game.Presentation.ViewModels;
using TB_Quest_Game.Presentation.Views;
using TB_Quest_Game.Models;
using TB_Quest_Game.Data;

namespace TB_Quest_Game.Business
{
    public class GameBusiness
    {
        #region Fields

        GameViewModel _gameViewModel;
        Player _player = new Player();
        bool _newPlayer = true;
        RegisterPlayer _registerPlayer;

        #endregion

        public GameBusiness()
        {
            RegisterPlayer();
            InstantiateAndShowView();
        }

        private void InstantiateAndShowView()
        {
            _gameViewModel = new GameViewModel(
                _player,
                GameData.GameMap(),
                GameData.InitialGameMapLocations()
                );
            GameView gameView = new GameView(_gameViewModel);

            gameView.DataContext = _gameViewModel;
            
            gameView.Show();
            
            _registerPlayer.Close();
        }

        private void RegisterPlayer()
        {
            if (_newPlayer)
            {
                _registerPlayer = new RegisterPlayer(_player);
                _registerPlayer.ShowDialog();
                _player.Health = 100;
                _player.Lives = 3;
                _player.Health = 100;
                _player.Lives = 3;
                _player.ExperiencePoints = 0;
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }


    }
}
