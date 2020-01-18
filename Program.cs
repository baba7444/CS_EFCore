using System;
using System.Linq;

namespace CS_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ManageDatabase();

                using (var ctx = new Models.PersonDBContext())
                {
                    var person = new Models.Person();
                    person.PersonName = "Name 2";
                    person.Age = 30;
                    person.Gender = "Female";

                    ctx.Persons.Add(person);
                    ctx.SaveChanges();

                    Console.WriteLine("added person");

                    foreach (var p in ctx.Persons.ToList())
                    {
                        Console.WriteLine($"{p.PersonName} {p.Age} {p.Gender}");
                    }

                };
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }
            Console.ReadLine(); 
        }


        static void ManageDatabase()
        {
            using (var ctx = new Models.PersonDBContext() )
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
            }
        
        
        }

    }
}
