using TB_Quest_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace TB_Quest_Game.Presentation.Views
{
    /// <summary>
    /// Interaction logic for RegisterPlayer.xaml
    /// </summary>
    public partial class RegisterPlayer : Window
    {

        #region Fields
        private Player _player;
        #endregion

        #region Constructors
        public RegisterPlayer(Player player)
        {
            _player = player;
            InitializeComponent();
            SetupWindow();
        }
        #endregion

        #region Methods        
        private void SetupWindow()
        {
            List<string> roles = Enum.GetNames(typeof(Player.PlayerClassName)).ToList();
            PlayerClassComboBox.ItemsSource = roles;

            ErrorMessageTextBlock.Visibility = Visibility.Hidden;
        }

        private bool IsValidPlayer(out string errorMessage)
        {
            errorMessage = "";
            if(PlayerName.Text == "")
            {
                errorMessage += "Player name is required.";
            }
            else if (!PlayerName.Text.All(chr => char.IsLetter(chr)))
            {
                errorMessage += "Player name is invalid!";
            }
            else
            {
                _player.Name = PlayerName.Text;
            }

            return errorMessage == "" ? true : false;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsValidPlayer(out var errorMessage))
            {
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                ErrorMessageTextBlock.Visibility = Visibility.Hidden;
            }
            if(errorMessage == "")
            {
                Enum.TryParse(PlayerClassComboBox.SelectionBoxItem.ToString(), out Player.PlayerClassName playerClass);

                _player.PlayerClass = playerClass;
                Visibility = Visibility.Hidden;
            }
        }

        #endregion
    }
}
