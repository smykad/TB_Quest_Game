using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TB_Quest_Game.Models;

namespace TB_Quest_Game.Presentation.ViewModels
{
    public class GameViewModel : ObservableObject
    {
        #region Fields

        private Map _gameMap;
        private Location _currentLocation;

        #endregion

        #region Properties

        public Player Player { get; set; }

        public Map GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }
        public Location CurrentLocation 
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
            }
          
        }

        #endregion

        #region Constructors

        public GameViewModel()
        {

        }
        

        public GameViewModel(
            Player player,
            Map gameMap,
            GameMapCoordinates currentLocationCoordinates)
        {
            Player = player;
            _gameMap = gameMap;
            _gameMap.CurrentLocationCoordinates = currentLocationCoordinates;
            CurrentLocation = _gameMap.CurrentLocation;
        }
        #endregion

        #region Methods


        public void MoveNorth()
        {
            _gameMap.MoveNorth();
            CurrentLocation = _gameMap.CurrentLocation;
        }

        public void MoveEast()
        {
            _gameMap.MoveEast();
                CurrentLocation = _gameMap.CurrentLocation;
        }

        public void MoveSouth()
        {
            _gameMap.MoveSouth();
            CurrentLocation = _gameMap.CurrentLocation; 
        }
        public void MoveWest()
        {   
            _gameMap.MoveWest();
            CurrentLocation = _gameMap.CurrentLocation;  
        }
        #endregion
    }
}
