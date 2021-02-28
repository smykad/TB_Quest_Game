using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Quest_Game.Models;

namespace TB_Quest_Game.Presentation.ViewModels
{
    public class GameViewModel : ObservableObject
    {
        #region Properties

        public Player Player { get; set; }

        #endregion

        #region Constructors

        public GameViewModel()
        {

        }

        public GameViewModel(Player player)
        {
            Player = player;
        }
        #endregion
    }
}
