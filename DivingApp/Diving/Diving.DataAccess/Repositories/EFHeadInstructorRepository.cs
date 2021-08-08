using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diving.DataAccess.Repositories
{
    public class EFHeadInstructorRepository : IHeadInstructorRepository
    {
        public HeadInstructor Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public HeadInstructor Add(HeadInstructor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<HeadInstructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public HeadInstructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<HeadInstructor> GetWithCriteria(Func<HeadInstructor, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public IList<HeadInstructor> GetWithCriteria(Expression<Func<HeadInstructor, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public HeadInstructor Update(HeadInstructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
