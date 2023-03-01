using Medication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class UserService : IUserService
    {

        private IUserRepository _IUserRepository;
        public Task<User> getUser(string userName, string password)
        {

        }
    }
}
