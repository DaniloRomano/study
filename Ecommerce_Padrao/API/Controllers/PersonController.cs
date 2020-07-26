using Default.Return;
using Microsoft.AspNetCore.Mvc;
using Person.Class;
using Person.Class.Output;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(DefaultReturn<CustomerOutput>),200)]
        [ProducesResponseType(typeof(DefaultReturn<object>),400)]
        [ProducesErrorResponseType(typeof(DefaultReturn<Exception>))]
        public IActionResult Get(int id)
        {
            try
            {
                DefaultReturn<CustomerOutput> response = new DefaultReturn<CustomerOutput>();
                response.dataReturn = new CustomerOutput
                {
                    id = id,
                    name = "Teste"
                };
                return StatusCode(200, response);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}