using EasyBurger.API.Infra.Contexts;
using EasyBurger.API.Models;

namespace EasyBurger.API.Infra.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(ApiContext context) : base(context)
        {
        }
    }
}
