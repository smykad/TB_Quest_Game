using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Quest_Game.Presentation.ViewModels;
using TB_Quest_Game.Presentation.Views;
using TB_Quest_Game.Models;

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
            _gameViewModel = new GameViewModel(_player);
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
            }
        }


    }
}
