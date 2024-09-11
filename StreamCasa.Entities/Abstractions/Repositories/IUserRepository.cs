namespace StreamCasa.Entities.Abstractions.Repositories
{
    public interface IUserRepository : IBaseRepository<Users>
    {

        Task<Users> GetByUsernameAndPassword(Users user);

    }
}
