using System.Collections.Generic;
using DiceRoller.Entities;

namespace DiceRoller.Interfaces
{
    public interface iManager
    {
        void AddRoll(Roll roll);

        List<Roll> GetRolls();
    }
}