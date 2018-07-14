using System;
using System.Threading.Tasks;

namespace Api.Services
{
    public class SomeService : ISomeService
    {
        public Task<int> GetInt(Guid id) => Task.FromResult(42);
    }
}