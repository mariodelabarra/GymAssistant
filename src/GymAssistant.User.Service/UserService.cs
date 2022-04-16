using GymAssistant.User.Repository;
using DomainUser = GymAssistant.User.Domain.User;

namespace GymAssistant.User.Service
{
    public interface IUserService
    {
        public Task<IEnumerable<DomainUser>> GetAllAsync();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<DomainUser>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
