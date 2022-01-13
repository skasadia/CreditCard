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
    public class SearchesController : ControllerBase
    {
        private readonly appContext appContext;

        public SearchesController(appContext appContext)
        {
            this.appContext = appContext;

        }

        [HttpGet(Name = nameof(Getseacrhes))]
        [ProducesResponseType(200)]
        public ActionResult<Collection<Results>> Getseacrhes()
        {
            var entity = appContext.searchResults.ToArray();

            var collection = new Collection<Results>
            {
                Href = Url.Link(nameof(Getseacrhes), null),
                Value = entity
            };
            return collection;
        }


    }
}