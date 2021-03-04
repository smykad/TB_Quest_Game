using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Character : ObservableObject
    {

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }

        #endregion

        #region Constructors

        public Character()
        {

        }
        public Character(int id, string name, int health)
        {
            Id = id;
            Name = name;
            Health = health;
        }

        #endregion

        #region Methods

        #endregion
    }
}
