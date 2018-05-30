﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Messages.API.Models;
using Messages.API.Services.Web;

namespace Lacqr.Controllers
{
    // [Produces("application/json")]
    [Route("[controller]")]
    public class MessagesController : Controller
    {
        private MessagesManagerWeb _manager;

        public MessagesController(MessagesManagerWeb m)
        {
            _manager = m;
        }
        // GET: api/Messages
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Messages/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Messages
        [HttpPost]
        public void Post([FromBody]NewMessage value)
        {
           
        }
        
        // PUT: api/Messages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
