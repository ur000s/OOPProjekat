using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    
    public class Predavac
    {
        public Predavac(int id, string ime, string prezime, string zvanje)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Zvanje = zvanje;
        }
    
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Zvanje { get; set; }
        public virtual List<Predavanje> Predavanja { get; set; }
        public virtual List<Ispit> Ispiti { get; set; }

    }
}
