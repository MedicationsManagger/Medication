using Medication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entites;

namespace Services
{
    public class UserService : IUserService
    {
        private IUserRepository _UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }
        public async Task<User> getUser(string userName, string password)
        {
            return await _UserRepository.getUser(userName, password);
        }
        public async Task<User> addUser(User user)
        {
            return await _UserRepository.addUser(user);
        }
        public async Task  updateUser(User user)
        {
             await _UserRepository.updateUser(user);
            return;
        }

       
    }
}
