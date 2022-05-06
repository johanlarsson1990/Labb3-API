using Labb3Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Models
{
    public class Labb3DbContext : DbContext
    {
        public Labb3DbContext(DbContextOptions<Labb3DbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PersonHobby> PersonHobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data

            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, FirstName = "Johan", LastName = "Larsson", PhoneNumber = "0738051775" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, FirstName = "Ida", LastName = "Johansson", PhoneNumber = "07224566888" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, FirstName = "Anton", LastName = "Johansson", PhoneNumber = "0703693366" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 4, FirstName = "Jennié", LastName = "Croné", PhoneNumber = "0737654489" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 5, FirstName = "Lotta", LastName = "Eriksson", PhoneNumber = "0708763244" });

            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 1, Title = "League of Legends", Description = "A rpg computer game thats played 5 vs 5 on a medium map size" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 2, Title = "Soccer", Description = "The American way of playing football" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 3, Title = "Padel", Description = "A Tennis like game thats played in a closed glass cage" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 4, Title = "Coding", Description = "Creating apps/games & and much more in diffrent languages such as C#, javascript, python, C++" });

            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 1, HobbyId = 1, PersonId = 4, URL = "sv.wikipedia.org/wiki/League_of_Legends" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 2, HobbyId = 2, PersonId = 3, URL = "en.wikipedia.org/wiki/Association_football" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 3, HobbyId = 3, PersonId = 1, URL = "sv.wikipedia.org/wiki/Padel" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 4, HobbyId = 4, PersonId = 5, URL = "en.wikipedia.org/wiki/Coding" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 5, HobbyId = 4, PersonId = 2, URL = "sv.wikipedia.org/wiki/C%2B%2B" });

            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 1, HobbyId = 1, PersonId = 4 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 2, HobbyId = 2, PersonId = 3 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 3, HobbyId = 3, PersonId = 1 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 4, HobbyId = 4, PersonId = 5 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 5, HobbyId = 4, PersonId = 2 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 6, HobbyId = 3, PersonId = 2 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 7, HobbyId = 2, PersonId = 1 });
        }
    }
}