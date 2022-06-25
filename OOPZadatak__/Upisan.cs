using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Upisan
    {
        public Upisan( int studentID,int odsekID,int godinaStudije)
        {
            StudentID = studentID;
            OdsekID = odsekID;
            GodinaStudije = godinaStudije;
        }
        [Key]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        [Key]
        [ForeignKey("Odsek")]
        public int OdsekID { get; set; }
        public virtual Odsek Odsek { get; set; }

        public int GodinaStudije;

    }
}
