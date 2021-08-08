using AutoMapper;
using Diving.Business.DataTransferObject;
using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business.Extensions
{
    public static class Conventers
    {
        public static List<DivingSchoolResponseList> ConvertToListResponse(this List<DivingSchools> divingSchools,IMapper mapper)
        {
            return mapper.Map<List<DivingSchoolResponseList>>(divingSchools);
        }
        public static DivingSchools ConvertToDivingSchools(this AddNewDivingSchoolRequest request, IMapper mapper)
        {
            return mapper.Map<DivingSchools>(request);
        }
        public static DivingSchoolResponseList ConvertFromEntity(this DivingSchools divingSchools, IMapper mapper)
        {
            return mapper.Map<DivingSchoolResponseList>(divingSchools);
        }
        public static DivingSchools ConvertToEntity(this EditDivingSchoolRequest divingSchools, IMapper mapper)
        {
            return mapper.Map<DivingSchools>(divingSchools);
        }

    }
    

}
