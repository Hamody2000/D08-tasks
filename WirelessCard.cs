using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD08
{
    public class WirelessCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        private WirelessCard()
        {
            Id = 1;
            Name = "Intel";
            Year = 2005;
        }

     
        public static WirelessCard Card { get; }
            = new WirelessCard();
     
    }
}
