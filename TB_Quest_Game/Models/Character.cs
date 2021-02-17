using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Character
    {

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Constructors

        public Character()
        {

        }
        public Character(int id, string name, bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        #endregion

        #region Methods

        #endregion
    }
}
