using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<A>> Get(CancellationToken ct) => throw new NotImplementedException();

        [HttpGet("{id}")]
        public Task<A> Get(int id, CancellationToken ct) => throw new NotImplementedException();

        [HttpPost]
        public Task Post(A value, CancellationToken ct) => throw new NotImplementedException();

        [HttpPut("{id}")]
        public Task Put(int id, A value, CancellationToken ct) => throw new NotImplementedException();

        [HttpDelete("{id}")]
        public Task Delete(int id, CancellationToken ct) => throw new NotImplementedException();

        [HttpGet("foo")]
        public Paging ComplexObjectQueryString([FromQuery]Paging value) => value;

        [HttpGet("services/{id}")]
        public Task<int> InjectedServices(Guid id, [FromServices]ISomeService service) => service.GetInt(id);
    }
}
