using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using reto4.Models;

namespace reto4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BDController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Person> Get()
        {
            using (var context = new AdventureWorks2019Context())
            {
                //get all People
                return context.People.ToList();

                //get Person by BussinesEntityID
                return context.People.Where(pe => pe.BusinessEntityId == 1).ToList();

            }
        }
        
        [HttpGet]
        public IEnumerable<Culture> Get()
        {
            using (var context = new AdventureWorks2019Context())
            {
                //Add culture
                Culture culture = new Culture();
                culture.CultureId = "VOT";
                culture.Name = "Danzas";

                context.Cultures.Add(culture);
                context.SaveChanges();
                return context.Cultures.Where(cul => cul.CultureId == "VOT").ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            using (var context = new AdventureWorks2019Context())
            {
                //delete BussinesEntityAddress
                Person persona = context.People.Where(per => per.BusinessEntityId == 2).FirstOrDefault();
                context.People.Remove(persona);

                context.SaveChanges();

                return context.People.Where(per => per.BusinessEntityId == 2).ToList();
            }
        }
    }
}
