using CourtVillaBank.Model.Model;

namespace CourtVillaBank.Repository.Repository.Abstraction
{
    public interface IUserRepository : IGenericRepository<User>
    {

        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        void UpdateUser(User user);
        Task<User> GetUserByEmail(string email);
    }
}
