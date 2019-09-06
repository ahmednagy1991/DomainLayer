using Service.Models;


namespace Service.RepositoryAbstraction
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        UserModel GetByActivationCode(string Activation);
        UserModel GetUser(string username,string password);
    }
}
