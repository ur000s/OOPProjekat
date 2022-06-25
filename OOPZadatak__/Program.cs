using System;

namespace OOPZadatak__
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Baza()) 
            {
                Console.WriteLine(db.Database.CanConnect());
            }

        }
    }
}