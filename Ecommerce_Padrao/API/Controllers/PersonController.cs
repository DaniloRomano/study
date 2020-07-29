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
        #region Properties
        private IPersonService personService;
        #endregion
        #region Constructor
        public PersonController(IPersonService _personService)
        {
            personService = _personService;
        }
        #endregion
        [Authorize(Roles = "atendente")]
        [HttpGet("{userId}")]
        [ProducesResponseType(typeof(DefaultReturn<Models.Person.Person>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Get(Guid userId)
        {
            try
            {
                DefaultReturn<Models.Person.Person> response = new DefaultReturn<Models.Person.Person>();
                response.dataReturn = personService.Get(userId);
                return StatusCode(200, response);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}