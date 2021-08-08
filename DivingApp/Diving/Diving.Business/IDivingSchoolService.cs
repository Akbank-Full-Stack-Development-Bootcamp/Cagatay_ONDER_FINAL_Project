using Diving.Business.DataTransferObject;
using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business
{
    public interface IDivingSchoolService
    {
        IList<DivingSchoolResponseList> GetAllDivingSchools();
        int AddDivingSchools(AddNewDivingSchoolRequest request);
        DivingSchoolResponseList GetDivingSchoolById(int id);
        int UpdateDivingSchool(EditDivingSchoolRequest request);
        void DeleteDivingSchool(int id);
    }
}
