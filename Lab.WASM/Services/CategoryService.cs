using Lab.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lab.WASM.Services
{
    public class CategoryService : IService<Category>
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("/api/Categories/"+id);
        }

        public async Task<List<Category>> GetAll()
        {
           List<Category> categories =  await httpClient.GetFromJsonAsync<List<Category>>("/api/Categories");
            return categories;
        }

        public async Task<Category> GetById(int id)
        {
            Category category = await httpClient.GetFromJsonAsync<Category>("/api/Categories");
            return category;
        }

        public async Task Insert(Category cat)
        {
            await httpClient.PostAsJsonAsync<Category>("/api/Categories",cat);
        }

        public async Task Update(Category cat)
        {
            await httpClient.PutAsJsonAsync<Category>("/api/Categories/{id}"+cat.Id,cat);
        }
    }
}
