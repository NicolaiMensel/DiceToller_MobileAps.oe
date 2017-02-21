using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoller.DLLFacade;
using DiceRoller.Interfaces;
using DiceRoller.Managers;
using Xamarin.Forms;

namespace DiceRoller.Pages
{
    public partial class History : ContentPage
    {
        private static iManager _diceHitsMgr;
        private DiceManager _diceMgr;
        public History()
        {
            
            _diceHitsMgr = new Facade().GetDiceHitsManager();
            _diceMgr = new Facade().GetDiceManager();
            InitData();

        }

        private void InitData()
        {
            List<string> values = new List<string>();
            List<Image> images = new List<Image>();
            ListView items = new ListView();

            values.Add("Your History");
            foreach (var rolls in _diceHitsMgr.GetRolls())
            {
                values.Add(rolls.ToString());
                foreach (var hits in rolls.DiceHits)
                {
                    images.Add(_diceMgr.GetImageForDice(hits.Value));
                }
            }

            items.ItemsSource = values;
            

            Content = items;
        }
    }
}
