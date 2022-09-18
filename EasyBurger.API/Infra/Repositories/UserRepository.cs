using EasyBurger.API.Infra.Contexts;
using EasyBurger.API.Models;

namespace EasyBurger.API.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(ApiContext context) : base(context)
        {
        }
    }
}
