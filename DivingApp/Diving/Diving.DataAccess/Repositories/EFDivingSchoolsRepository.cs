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
    public class EFDivingSchoolsRepository : IDivingSchoolsRepository
    {
        private DivingDbContext dbContext;

        public EFDivingSchoolsRepository(DivingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public DivingSchools Add(DivingSchools entity)
        {
            dbContext.DivingSchools.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }
        public void Delete(int id)
        {
            dbContext.DivingSchools.Remove(GetById(id));
            dbContext.SaveChanges();
        }

        public IList<DivingSchools> GetAll()
        {
            return dbContext.DivingSchools.ToList();
        }

        public DivingSchools GetById(int id)
        {
            return dbContext.DivingSchools.FirstOrDefault(x => x.Id == id);
        }

        public IList<DivingSchools> GetWithCriteria(Func<DivingSchools, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public DivingSchools Update(DivingSchools entity)
        {
            dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return entity;
        }
    }
}
