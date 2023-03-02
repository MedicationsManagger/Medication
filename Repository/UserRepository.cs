using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medication;

namespace Repository
{
    public class UserRepository: IUserRepository
    {
        MedicationsContext _medicationsContext;
        public UserRepository(MedicationsContext medicationsContext)
        {
            _medicationsContext = medicationsContext;
        }

        public async Task<User> getUser(string userName, string password)
        {
            var user = (from u in _medicationsContext.Users
                        where u.EmailAddress == userName & u.Password == password
                        select u);

            return user.FirstOrDefault();
            
        }



        
    }
}
