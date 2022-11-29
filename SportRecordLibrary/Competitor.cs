using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRecordLibrary
{
    public class Competitor
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int TagNumber { get; set; }

        public override string ToString()
        {
            return $"Name:: {Name}, Country:: {Country}, Tag Number:: {TagNumber}";
        }
    }
}
