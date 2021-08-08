using Diving.DataAccess.Data;
using Diving.DataAccess.Repositories;
using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IList<User> GetAllAccounts()
        {
            var result = userRepository.GetAll().ToList();
            return result;
        }

        public User GetUser(string userName, string password)
        {
            return userRepository.GetWithCriteria(x => x.UserName == userName && x.Password == password).FirstOrDefault();
        }
    }
}
