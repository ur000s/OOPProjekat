using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Predavanje
    {
        [Key]
        [ForeignKey("Predavac")]
        public int PredavacID { get; set; }
        public virtual Predavac Predavac { get; set; }

        [Key]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        [Key]
        [ForeignKey("Predmet")]
        public int PredmetID { get; set; }
        public virtual Predmet Predmet { get; set; }

        public bool GlavniPredavac { get; set; }
    }
}
