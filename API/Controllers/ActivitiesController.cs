using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase {
        private readonly IMediator mediator;

        public ActivitiesController(IMediator mediator) {
            this.mediator = mediator;
        }

        // GET: api/<ActivitiesController>
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> Get() {
            return await mediator.Send(new List.Query());
        }

        // GET api/<ActivitiesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> Get(Guid id) {
            return await mediator.Send(new Details.Query { ID = id });
        }

        // POST api/<ActivitiesController>
        [HttpPost]
        public async Task<ActionResult<Unit>> Post([FromBody] Create.Command command) {
            return await mediator.Send(command);
        }

        // PUT api/<ActivitiesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Put(Guid id, [FromBody] Edit.Command command) {
            command.ID = id;
            return await mediator.Send(command);
        }

        // DELETE api/<ActivitiesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(Guid id) {
            return await mediator.Send(new Delete.Command { ID = id });
        }
    }
}
