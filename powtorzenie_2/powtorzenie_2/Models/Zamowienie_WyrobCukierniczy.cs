using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace powtorzenie_2.Models
{
    public class Zamowienie_WyrobCukierniczy
    {
        [ForeignKey("WyrobCukierniczy")]
        public int? IdWyrobuCukierniczego { get; set; }
        public virtual WyrobCukierniczy WyrobCukierniczy { get; set; }
        [ForeignKey("Zamowienie")]
        public int? IdZamowienia { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
        [Required]
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }
    }
}
