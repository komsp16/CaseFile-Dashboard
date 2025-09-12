using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces
{
    public interface IAsyncReadRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
       
        Task<int> CountAsync(ISpecification<T> spec);
    }
}
