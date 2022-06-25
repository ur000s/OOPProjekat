using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class PredavacPredmet
    {
        public PredavacPredmet(int predmetID,  int predavacID )
        {
            PredmetID = predmetID;
            PredavacID = predavacID;
        }

        [Key]
        [ForeignKey("Predmet")]
        public int PredmetID { get; set; }
        public virtual Predmet Predmet { get; set; }

        [Key]
        [ForeignKey("Predavac")]
        public int PredavacID { get; set; }
        public virtual Predavac Predavac{ get; set; }
    }
}
