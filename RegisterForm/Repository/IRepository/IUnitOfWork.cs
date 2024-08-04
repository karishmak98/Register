namespace RegisterForm.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        void Save();
    }
}
