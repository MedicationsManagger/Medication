using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;
using Medication;

namespace Services
{
    public interface IUserService
    {
        public Task<User> getUser(string userName, string password);
        

    }
}
