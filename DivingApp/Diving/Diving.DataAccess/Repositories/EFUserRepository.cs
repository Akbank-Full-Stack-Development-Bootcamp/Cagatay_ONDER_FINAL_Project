using Diving.DataAccess.Data;
using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diving.DataAccess.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private DivingDbContext dbContext;

        public EFUserRepository(DivingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetWithCriteria(Func<User, bool> criteria)
        {
            return GetAll().Where(criteria).ToList();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
