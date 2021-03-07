using System;
using System.Collections.Generic;
namespace TB_Quest_Game.Models
{
    public class Player: Character
    {
        #region Enums

        public enum PlayerClassName { Wizard, Warrior, Archer}

        #endregion

        #region Properties

        public int Lives { get; set; }
        public int ExperiencePoints { get; set; }
        public PlayerClassName PlayerClass { get; set; }

        #endregion

        #region Constructors
        public Player()
        {

        }
        public Player(int id, string name, int health, int lives, int experiencePoints, PlayerClassName playerClass)
            :base(id, name, health)
        {
            Lives = lives;
            ExperiencePoints = experiencePoints;
            PlayerClass = playerClass;
        }
        #endregion

        #region Methods

        #endregion
    }
}
