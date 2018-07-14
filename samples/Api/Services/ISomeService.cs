using System;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface ISomeService
    {
        Task<int> GetInt(Guid id);
    }
}