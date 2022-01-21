using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                //Cats
                  new Animal { AnimalId = 2, Name = "Luna", Species = "Cat", Age = 6, Gender = "Female", ArrivalDate =  new DateTime(2017, 2, 26)},
                  new Animal { AnimalId = 1, Name = "Milo", Species = "Cat", Age = 3, Gender = "Male",  ArrivalDate =  new DateTime(20120, 2, 26) },
                  new Animal { AnimalId = 3, Name = "Nala", Species = "Cat", Age = 3, Gender = "Female",  ArrivalDate =  new DateTime(2020, 2, 26) },
                  new Animal { AnimalId = 4, Name = "Leo", Species = "Cat", Age = 2, Gender = "Male",  ArrivalDate =  new DateTime(2021, 2, 26) },
                  new Animal { AnimalId = 5, Name = "Charlie", Species = "Cat", Age = 5, Gender = "Male",  ArrivalDate =  new DateTime(2018, 2, 26) },
                //Dogs
                  new Animal { AnimalId = 6, Name = "Daisy", Species = "Dog", Age = 2, Gender = "Female",  ArrivalDate =  new DateTime(2020, 2, 26) },
                  new Animal { AnimalId = 7, Name = "Bailey", Species = "Dog", Age = 1, Gender = "Female",  ArrivalDate =  new DateTime(2021, 2, 26) },
                  new Animal { AnimalId = 8, Name = "Lola", Species = "Dog", Age = 2, Gender = "Female",  ArrivalDate =  new DateTime(2021, 2, 26) },
                  new Animal { AnimalId = 9, Name = "Max", Species = "Dog", Age = 3, Gender = "Male",  ArrivalDate =  new DateTime(2019, 2, 26) },
                  new Animal { AnimalId = 10, Name = "Dule", Species = "Dog", Age = 2, Gender = "Male" ,  ArrivalDate = new DateTime(2022, 2, 26)}              
              );
        }
    }
}