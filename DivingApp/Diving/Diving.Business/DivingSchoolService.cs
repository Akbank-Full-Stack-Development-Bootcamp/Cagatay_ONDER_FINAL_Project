using AutoMapper;
using Diving.Business.DataTransferObject;
using Diving.Business.Extensions;
using Diving.DataAccess.Repositories;
using Diving.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business
{
    public class DivingSchoolService : IDivingSchoolService
    {
        private readonly IDivingSchoolsRepository divingSchoolsRepository;
        private readonly IMapper mapper;

        public DivingSchoolService(IDivingSchoolsRepository divingSchoolsRepository,IMapper mapper)
        {
            this.divingSchoolsRepository = divingSchoolsRepository;
            this.mapper = mapper;
        }

        public int AddDivingSchools(AddNewDivingSchoolRequest request)
        {
            var newDivingSchool = request.ConvertToDivingSchools(mapper);
            divingSchoolsRepository.Add(newDivingSchool);
            return newDivingSchool.Id;
        }

        public void DeleteDivingSchool(int id)
        {
            divingSchoolsRepository.Delete(id);
        }

        public IList<DivingSchoolResponseList> GetAllDivingSchools()
        {
            var dtoList = divingSchoolsRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public DivingSchoolResponseList GetDivingSchoolById(int id)
        {
            DivingSchools divingSchools = divingSchoolsRepository.GetById(id);
            return divingSchools.ConvertFromEntity(mapper);
        }

        public int UpdateDivingSchool(EditDivingSchoolRequest request)
        {
            var divingSchool = request.ConvertToEntity(mapper);
            int id = divingSchoolsRepository.Update(divingSchool).Id;
            return id;
        }
    }
}
