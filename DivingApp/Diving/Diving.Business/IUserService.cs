using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business
{
    public interface IUserService
    {
        User GetUser(string userName, string password);
        IList<User> GetAllAccounts();
    }
}
