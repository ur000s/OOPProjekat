using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Predmet
    {
        public Predmet(int id, string ime)
        {
            Id = id;
            Ime = ime;
        }
    
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }

        public virtual List<Ispit> Ispiti { get; set; }
        public virtual List<Predavanje> Predavanja { get; set; }
    }
}
