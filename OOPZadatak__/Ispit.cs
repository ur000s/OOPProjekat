using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Ispit
    {
        public Ispit(int studentID, int predavacID, int predmetID, DateOnly datumPolaganja, int ocena)
        {
            StudentID = studentID;
            PredavacID = predavacID;
            PredmetID = predmetID;
            DatumPolaganja = datumPolaganja;
            Ocena = ocena;
        }
    
        [Key]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        [Key]
        [ForeignKey("Predavac")]
        public int PredavacID { get; set; }
        public virtual Predavac Predavac { get; set; }

        [Key]
        [ForeignKey("Predmet")]
        public int PredmetID { get; set; }
        public virtual Predmet Predmet { get; set; }

        public DateOnly DatumPolaganja { get; set; }
        public int Ocena { get; set; }

    }
}
