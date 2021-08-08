using AutoMapper;
using Diving.Business.DataTransferObject;
using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business.Mapper
{
   public  class MappingProfile: Profile
   {
        public MappingProfile()
        {
            CreateMap<DivingSchools, DivingSchoolResponseList>().ReverseMap();
            CreateMap<DivingSchools, AddNewDivingSchoolRequest>().ReverseMap();
            CreateMap<DivingSchools, EditDivingSchoolRequest>().ReverseMap();
        }
   }
}
