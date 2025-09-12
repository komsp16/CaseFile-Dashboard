using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces
{
    public interface IAsyncRepository<T> : IAsyncReadRepository<T> where T : class
    {
        //Task<T> AddAsync(T entity);
        //Task UpdateAsync(T entity);
        //Task DeleteAsync(T entity);
    }
}
