using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoller.Entities;
using DiceRoller.Interfaces;

namespace DiceRoller.Managers
{
    public class RollsManager : iManager
    {
        private List<Roll> _diceRolls;
        private static iManager instance;

        public static iManager GetDiceHistManager()
        {
            return instance ?? (instance = new RollsManager());
        }

        private RollsManager()
        {
            _diceRolls = new List<Roll>();
        }

        public void AddRoll(Roll roll)
        {
            _diceRolls.Add(roll);
        }

        public List<Roll> GetRolls()
        {
            return _diceRolls;
        }
    }
}
