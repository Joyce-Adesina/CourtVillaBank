using CourtVillaBank.Model.Model;
using CourtVillaBank.Repository.Data;
using CourtVillaBank.Repository.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace CourtVillaBank.Repository.Repository.Implementation
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<User> _users;

        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
           _users = appDbContext.Set<User>();
        }

        public void UpdateUser(User user)
        {
            _users.Update(user);
        }
        public async Task< User>GetUserById(int id)
        {
            return await _users.Where(u => u.Id == id).Include(u => u.Accounts).SingleOrDefaultAsync();
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _users.Where(u=>u.Email== email).FirstOrDefaultAsync();
           
        }
        public async Task <IEnumerable<User>> GetAllUsers()
        {
            return await _users.Include(u=>u.Accounts).ToListAsync();
        }

    }
}