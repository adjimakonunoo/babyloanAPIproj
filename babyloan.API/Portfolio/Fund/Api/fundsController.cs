using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using babyloan.API.infrastructure.fineract.commons;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using babyloan.API.infrastructure.fineract;

namespace babyloan.API.Portfolio.Fund.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class fundsController : ControllerBase
    {
        private readonly FineractClient _fineractClient;
        public fundsController(FineractClient fineractClient)
        {
            _fineractClient = fineractClient;
        }

        // GET: api/funds
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/funds/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/funds
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/funds/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
