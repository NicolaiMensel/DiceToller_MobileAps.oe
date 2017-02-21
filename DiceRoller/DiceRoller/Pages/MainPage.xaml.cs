using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoller.DLLFacade;
using DiceRoller.Entities;
using DiceRoller.Interfaces;
using DiceRoller.Managers;
using DiceRoller.Pages;
using Xamarin.Forms;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        private static iManager _diceHitsIManager;
        public MainPage()
        {
            _diceHitsIManager = new Facade().GetDiceHitsManager();
            initData();
        }

        private void initData()
        {
            StackLayout mainLayout = new StackLayout();
            StackLayout resultLayout = new StackLayout();
            Picker dicePicker = new Picker() {Title = "Select amount of dices.."};
            dicePicker.Items.Add("1");
            dicePicker.Items.Add("2");
            dicePicker.Items.Add("3");
            dicePicker.Items.Add("4");
            dicePicker.Items.Add("5");
            dicePicker.Items.Add("6");
            Button rollBtn = new Button() {Text = "Roll"};
            rollBtn.Clicked += (sender, args) => RollDices(int.Parse(dicePicker.Items[dicePicker.SelectedIndex]), resultLayout);

            Button historyBtn = new Button() {Text = "History"};
            historyBtn.Clicked += (sender, args) => GoToHistoryPage();
            mainLayout.Children.Add(historyBtn);
            mainLayout.Children.Add(dicePicker);
            mainLayout.Children.Add(rollBtn);
            mainLayout.Children.Add(resultLayout);

            Content = mainLayout;
        }

        private void RollDices(int diceNr, StackLayout resultLayout)
        {
            resultLayout.Children.Clear();
            Random randomNumber = new Random();
            Roll roll = new Roll();
            for (int i = 0; i < diceNr; i++)
            {
                Label diceResult = new Label();
                DiceHit diceHit = new DiceHit {Value = randomNumber.Next(1, 6)};
                roll.DiceHits.Add(diceHit);
                diceResult.Text = "Dice nr. " + (i + 1) + " = " + diceHit.Value;
                resultLayout.Children.Add(diceResult);
            }
            _diceHitsIManager.AddRoll(roll);
        }

        private async void GoToHistoryPage()
        {
            await Navigation.PushAsync(new History());
        }
    }
}
