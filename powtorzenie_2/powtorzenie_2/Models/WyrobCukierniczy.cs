using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace powtorzenie_2.Models
{
    public class WyrobCukierniczy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdWyrobuCukierniczego { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public float CenaZaSzt { get; set; }
        [Required]
        public string Typ { get; set; }
    }
}
