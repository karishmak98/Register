using RegisterForm.Models;

namespace RegisterForm.Repository.IRepository
{
    public interface IUserRepository:IRepository<User>
    {
        void Update(User user);
    }
}
