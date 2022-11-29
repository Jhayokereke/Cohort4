using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRecordApp
{
    public class SportRecord
    {
        public string SportCategory { get; set; }
        public Competitor FirstPosition { get; set; }
        public Competitor SecondPosition { get; set; }
        public Competitor ThirdPosition { get; set; }

        public override string ToString()
        {
            return $"Sport: {SportCategory}\nWinner: {FirstPosition}\n1st Runner Up: {SecondPosition}\n2nd Runner Up: {ThirdPosition}";
        }
    }
}
