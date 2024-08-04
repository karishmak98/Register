using RegisterForm.Data;
using RegisterForm.Repository.IRepository;

namespace RegisterForm.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            User = new UserRepository(_context);
        }

        public IUserRepository User { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
