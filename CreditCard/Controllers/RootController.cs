using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CreditCard.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRoot))] //it should handale Get verb 
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null), //abs RRL
                ApplicantChecks = new
                {
                    href = Url.Link(
                        nameof(ApplicantChecksController.GetApplicants), null)
                },
                addApplicantChecks = new
                {
                    href = Url.Link(
                        nameof(ApplicantChecksController.AddApplicantDetail), null)
                },
                search = new
                {
                    href = Url.Link(
                        nameof(SearchesController.Getseacrhes), null)
                },

                
            };

            return Ok(response);


        }
    }
}