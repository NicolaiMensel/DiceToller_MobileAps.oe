using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Entities
{
    public class Roll
    {
        public List<DiceHit> DiceHits { get; set; }
        public DateTime Time { get; set; }

        public Roll()
        {
            DiceHits = new List<DiceHit>();
            Time = DateTime.Now;
        }
        public override string ToString()
        {
            string text = Time.Hour + ":" + Time.Minute + " = ";
            foreach (var diceHit in DiceHits)
            {
                text += diceHit.Value + " ";
            }
            return text;
        }
    }
}
