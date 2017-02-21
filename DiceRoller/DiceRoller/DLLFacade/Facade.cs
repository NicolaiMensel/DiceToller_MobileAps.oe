using DiceRoller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoller.Managers;

namespace DiceRoller.DLLFacade
{
   
    public class Facade
    {

        public iManager GetDiceHitsManager()
        {
            return RollsManager.GetDiceHistManager();
        }

        public DiceManager GetDiceManager()
        {
            return new DiceManager();
        }
    }
}
