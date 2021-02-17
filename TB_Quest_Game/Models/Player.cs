using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Player: Character
    {
        #region Properties

        public int Lives { get; set; }
        public int ExperiencePoints { get; set; }

        #endregion

        #region Constructors
        public Player()
        {

        }
        public Player(int id, string name, bool isActive, int lives, int experiencePoints)
            :base(id, name, isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
            Lives = lives;
            ExperiencePoints = experiencePoints;
        }
        #endregion

        #region Methods

        #endregion
    }
}
