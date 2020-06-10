using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace powtorzenie_2.Models
{
    public class NoweZamowienie
    {
        public DateTime dataPrzyjecia { get; set; }
        public string uwagi { get; set; }
        public List<NoweZamowienieWyroby> wyroby { get; set; }
    }
}
