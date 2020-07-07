﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly DataContext context;

        public ValuesController(DataContext context) {
            this.context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get() {
            var values = await context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id) {
            var value = await context.Values.FindAsync(id);
            return Ok(value);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
