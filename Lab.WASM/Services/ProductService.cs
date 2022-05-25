using Lab.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lab.WASM.Services
{
    public class ProductService : IService<Product>
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("/api/Products/" + id);
        }

        public async Task<List<Product>> GetAll()
        {
            List<Product> products = await httpClient.GetFromJsonAsync<List<Product>>("/api/Products");
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            Product product = await httpClient.GetFromJsonAsync<Product>("/api/Products" + id);
            return product;
        }

        public async Task Insert(Product item)
        {
            await httpClient.PostAsJsonAsync<Product>("/api/Products", item);
        }

        public async Task Update(Product item)
        {
            await httpClient.PutAsJsonAsync<Product>("/api/Products"+item.Id,item);
        }
    }
}
