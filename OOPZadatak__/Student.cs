﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Student
    {
        [Key]
        public int Id { get; set; } //indeks?
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public virtual List<Ispit> Ispiti { get; set; }
        public virtual List<Predavanje> Predavavanja { get; set; }
    }
}
