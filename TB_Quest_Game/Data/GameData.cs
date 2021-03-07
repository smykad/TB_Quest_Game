using TB_Quest_Game.Models;

namespace TB_Quest_Game.Data
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Joe Cool",
                PlayerClass = Player.PlayerClassName.Warrior,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                LocationId = 0
            };
        }

        public static GameMapCoordinates InitialGameMapLocations()
        {
            return new GameMapCoordinates() { Row = 2, Column = 0 };
        }
        public static Map GameMap()
        {
            int rows = 3;
            int columns = 3;

            Map gameMap = new Map(rows, columns);

            // row 1

            gameMap.MapLocations[2, 0] = new Location()
            {
                Id = 1,
                Name = "1-1"
            };
            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 2,
                Name = "1-2"
            };
            gameMap.MapLocations[2, 2] = new Location()
            {
                Id = 3,
                Name = "1-3"
            };

            // row 2
            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 4,
                Name = "2-1"

            };
            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 5,
                Name = "2-2"
            };
            gameMap.MapLocations[1, 2] = new Location()
            {
                Id = 6,
                Name = "2-3"
            };
            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 7,
                Name = "3-1"
            };
            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 8,
                Name = "3-2"
            };
            gameMap.MapLocations[0, 2] = new Location()
            {
                Id = 9,
                Name = "3-3"
            };

            return gameMap;

        }
    }
}
