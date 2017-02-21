using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiceRoller.Managers
{
    public class DiceManager
    {
        private Dictionary<int, string> imageDirectories = new Dictionary<int, string>()
        {
            {1, "1.png"},
            {2, "2.png"},
            {3, "3.png"},
            {4, "4.png"},
            {5, "5.png"},
            {6, "6.png"}
        };

        public Image GetImageForDice(int diceNr)
        {
            Image image = new Image()
            {
                Margin = 4,
                Source = imageDirectories[diceNr],
                HeightRequest = 30,
                WidthRequest = 30
            };
            return image;
        } 
    }
}
