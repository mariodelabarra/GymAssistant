using Dapper;
using GymAssistant.Common.Repository;
using DomainUser = GymAssistant.User.Domain.User;

namespace GymAssistant.User.Repository
{
    public interface IUserRepository
    {
        public Task<IEnumerable<DomainUser>> GetAllAsync();
    }

    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DomainUser>> GetAllAsync()
        {
            var query = "SELECT * FROM user";

            using(var connection = _context.CreateConnection())
            {
                return await connection.QueryAsync<DomainUser>(query);
            }
        }
    }
}
