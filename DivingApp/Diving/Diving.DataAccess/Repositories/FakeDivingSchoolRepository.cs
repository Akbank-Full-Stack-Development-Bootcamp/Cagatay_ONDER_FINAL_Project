using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diving.DataAccess.Repositories
{
    public class FakeDivingSchoolRepository : IDivingSchoolsRepository
    {
        public DivingSchools Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public DivingSchools Add(DivingSchools entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DivingSchools> GetAll()
        {
            return new List<DivingSchools> 
            {
                new DivingSchools { Id = 1, Name = "Marmaris Diving Center" }
            };
           
        }

        public DivingSchools GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DivingSchools> GetWithCriteria(Func<DivingSchools, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public IList<DivingSchools> GetWithCriteria(Expression<Func<DivingSchools, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public DivingSchools Update(DivingSchools entity)
        {
            throw new NotImplementedException();
        }
    }
}
