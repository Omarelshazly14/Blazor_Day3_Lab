using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab.WASM.Services
{
    public interface IService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
