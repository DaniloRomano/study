using Default.Return;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Person;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [Authorize(Roles = "atendente")]
        [HttpGet("{userId}")]
        [ProducesResponseType(typeof(DefaultReturn<Models.Person.Person>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Get(
            [FromServices] IPersonService personService,
            Guid userId
            )
        {
            try
            {
                DefaultReturn<Models.Person.Person> response = new DefaultReturn<Models.Person.Person>();
                response.dataReturn = personService.Get(new Models.Person.Person
                {
                    UserId = userId
                });
                return StatusCode(200, response);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}