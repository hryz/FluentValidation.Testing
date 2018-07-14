using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<C>> Get(CancellationToken ct) => throw new NotImplementedException();

        [HttpGet("{id}")]
        public Task<C> Get(int id, CancellationToken ct) => throw new NotImplementedException();

        [HttpPost]
        public Task Post(C value, CancellationToken ct) => throw new NotImplementedException();

        [HttpPut("{id}")]
        public Task Put(int id, C value, CancellationToken ct) => throw new NotImplementedException();

        [HttpDelete("{id}")]
        public Task Delete(int id, CancellationToken ct) => throw new NotImplementedException();
    }
}
