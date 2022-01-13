using CreditCard.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCard
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            await AddTestData(
                services.GetRequiredService<appContext>());
        }

        public static async Task AddTestData(appContext context)
        {
            if (context.Applicants.Any())
            {
                // Already has data
                return;
            }

           

            context.Applicants.Add(new ApplicantEntity
            {
                Id = Guid.Parse("301df04d-8679-4b1b-ab92-0a586ae53d08"),
                fisrtName  = "Salman",
                lastName ="Patel",
                dateOfBirth = "10/01/1993",
                income = 40000,
                
            });

            context.Applicants.Add(new ApplicantEntity
            {
                Id = Guid.Parse("301df04d-8679-4b1b-ab92-0a586ae52d08"),
                fisrtName = "Ryan",
                lastName = "Jarvis",
                dateOfBirth = "10/11/1993",
                income = 40000,

            });

            if (context.Cards.Any())
            {
                // Already has data
                return;
            }

            context.Cards.Add(new Cards
            {
                Id = Guid.Parse("ee2b83be-91db-4de5-8122-35a9e9195976"),
                cardName = "Barclay Card",
                cardApr = "29.3%",
                promoMessage = "100% Pre Approved"
            });

            context.Cards.Add(new Cards
            {
                Id = Guid.Parse("ee2b83be-91db-4de5-8122-35a9e9195956"),
                cardName = "Vanquis card",
                cardApr = "33.3%",
                promoMessage = "100% Pre Approved"
            });


            await context.SaveChangesAsync();
        }

    }
}
