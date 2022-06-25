using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Odsek
    {
        public Odsek(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
    
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual List<Ispit> Ispiti { get; set; }
        public virtual List<Upisan> Upisani { get; set; }
    }
}
