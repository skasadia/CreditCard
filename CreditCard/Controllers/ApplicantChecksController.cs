using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditCard.Model;
using Microsoft.AspNetCore.Mvc;

namespace CreditCard.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ApplicantChecksController : ControllerBase
    {
        private readonly appContext appContext;

        public ApplicantChecksController(appContext appContext)
        {
            this.appContext = appContext;

        }

        [HttpGet(Name = nameof(GetApplicants))]
        [ProducesResponseType(200)]
        public ActionResult<Collection<ApplicantEntity>> GetApplicants()
        {
            var entity =  appContext.Applicants.ToArray();

            var collection = new Collection<ApplicantEntity>
            {
                Href = Url.Link(nameof(GetApplicants), null),
                Value = entity
            };
            return collection;
        }

        [HttpPost("addApplicant", Name = nameof(AddApplicantDetail))]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public ActionResult<Cards> AddApplicantDetail([FromBody] Applicant ap)
        {
            //var applicant = await appContext.Applicants.FindAsync(applicantId);
            //if(applicant != null)

            var newApplicant = appContext.Applicants.Add(new ApplicantEntity
            {
                Id = Guid.NewGuid(),
                fisrtName = ap.fisrtName,
                dateOfBirth = ap.dateOfBirth,
                income = ap.income,
                lastName = ap.lastName,

            });


            var created = appContext.SaveChanges();

            var TodayDate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")); //Remove time 
            var dob = DateTime.Parse(ap.dateOfBirth);

            var age = TodayDate.Year - dob.Year;

            var card = new Cards();

            if (age <18)
            {
                Record_Search();

                return BadRequest(new ApiError($"no credit cards are available"));
            }
            else
            {
                if(ap.income>0 && ap.income <= 30000)
                {
                     card = appContext.Cards.Where(x => x.cardName.ToLower().Contains("vanquis card")).ToList().First();

                    Record_Search();

                    return card;
                }
                if (ap.income > 0 && ap.income >= 40000)
                {
                    

                    card = appContext.Cards.Where(x => x.cardName.ToLower().Contains("barclay card")).ToList().First();
                      Record_Search();
                    return card;
                }
                if (ap.income == 0 )
                {
                    Record_Search();
                    return BadRequest(new ApiError($"no credit cards are available"));

                }

           
           }       

            void Record_Search()
            {

                var search = appContext.searchResults.Add(new Results
                {
                    Id = Guid.NewGuid(),
                    fisrtName = ap.fisrtName,
                    lastName = ap.lastName,
                    dateOfBirth = ap.dateOfBirth,
                    income = ap.income,

                    cardName = card.cardName,
                    cardApr = card.cardApr,
                    promoMessage = card.promoMessage,


                });
                 created = appContext.SaveChanges();
            }
          

            throw new NotImplementedException();
        }


    }
}