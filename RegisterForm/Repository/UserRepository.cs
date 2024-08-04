using RegisterForm.Data;
using RegisterForm.Models;
using RegisterForm.Repository.IRepository;
using System.Linq.Expressions;

namespace RegisterForm.Repository
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context):base(context)
        {
                _context = context;
        }

        public void Update(User user)
        {
           _context.Users.Update(user);
        }
    }
}
