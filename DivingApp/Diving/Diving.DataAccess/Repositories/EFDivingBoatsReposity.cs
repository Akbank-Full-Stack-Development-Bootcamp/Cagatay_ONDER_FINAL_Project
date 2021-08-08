using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diving.DataAccess.Repositories
{
    class EFDivingBoatsReposity : IDivingBoatsRepository
    {
        public DivingBoats Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public DivingBoats Add(DivingBoats entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DivingBoats> GetAll()
        {
            throw new NotImplementedException();
        }

        public DivingBoats GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DivingBoats> GetWithCriteria(Func<DivingBoats, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public IList<DivingBoats> GetWithCriteria(Expression<Func<DivingBoats, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public DivingBoats Update(DivingBoats entity)
        {
            throw new NotImplementedException();
        }
    }
}
