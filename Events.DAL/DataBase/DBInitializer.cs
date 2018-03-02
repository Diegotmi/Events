using Events.DAL.DataBaseRepository;
using Events.DAL.DataBaseRepository.Implementations;
using Events.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class DbInitializer
{
    public static void Seed()
    {
        var ageRageRepository = new AgeRangeRepository();

        if (!ageRageRepository.GetAll().Any())
        {
            ageRageRepository.Insert(new AgeRange() { IdAgeRange = 1, Description = "Menor que 16 anos" });
            ageRageRepository.Insert(new AgeRange() { IdAgeRange = 2, Description = "Maior que 16 anos" });
            ageRageRepository.Insert(new AgeRange() { IdAgeRange = 3, Description = "Maior que 18 anos" });
        }
    }
}
