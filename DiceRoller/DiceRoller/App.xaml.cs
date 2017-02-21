using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DiceRoller
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            NavigationPage nav = new NavigationPage(new DiceRoller.MainPage());
            MainPage = nav;
        }
    }
}
