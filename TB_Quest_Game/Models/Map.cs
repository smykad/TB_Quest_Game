using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Map
    {
        #region FIELDS

        private Location[,] _mapLocations;
        private int _maxRows, _maxColumns;
        private GameMapCoordinates _currentLocationCoordinates;

        #endregion

        #region PROPERTIES

        public Location[,] MapLocations
        {
            get { return _mapLocations; }
            set { _mapLocations = value; }
        }

        public GameMapCoordinates CurrentLocationCoordinates
        {
            get { return _currentLocationCoordinates; }
            set { _currentLocationCoordinates = value; }
        }

        public Location CurrentLocation
        {
            get { return _mapLocations[_currentLocationCoordinates.Row, _currentLocationCoordinates.Column]; }
        }

        #endregion


        #region CONSTRUCTORS

        public Map(int rows, int columns)
        {
            _maxRows = rows;
            _maxColumns = columns;
            _mapLocations = new Location[rows, columns];
        }

        #endregion


        #region METHODS

        public void MoveNorth()
        {
            if (_currentLocationCoordinates.Row > 0)
            {
                _currentLocationCoordinates.Row -= 1;
            }
        }

        public void MoveEast()
        {
            if (_currentLocationCoordinates.Column < _maxColumns - 1)
            {
                _currentLocationCoordinates.Column += 1;
            }
        }

        public void MoveSouth()
        {
            if (_currentLocationCoordinates.Row < _maxRows - 1)
            {
                _currentLocationCoordinates.Row += 1;
            }
        }

        public void MoveWest()
        {
            if (_currentLocationCoordinates.Column > 0)
            {
                _currentLocationCoordinates.Column -= 1;
            }
        }


        #endregion
    }
}
