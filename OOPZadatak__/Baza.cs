using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZadatak__
{
    public class Baza:DbContext
    {
       public DbSet<Ispit> Ispit { get; set; }
       public DbSet<Odsek> Odsek { get; set; }
       public DbSet<Predavac> Predavac { get; set; }
       public DbSet<PredavacPredmet> PredavacPredmet { get; set; }
       public DbSet<Predavanje> Predavanje { get; set; }
       public DbSet<Predmet> Predmet { get; set; }
       public DbSet<Student> Student { get; set; }
       public DbSet<Upisan> Upisan { get; set; }

    }
}
