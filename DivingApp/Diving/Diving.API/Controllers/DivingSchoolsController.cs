using Diving.Business;
using Diving.Business.DataTransferObject;
using Diving.DataAccess.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diving.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DivingSchoolsController : ControllerBase
    {
        private readonly IDivingSchoolService divingSchoolService;

        public DivingSchoolsController(IDivingSchoolService divingSchoolService )
        {
            this.divingSchoolService = divingSchoolService;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var result = divingSchoolService.GetAllDivingSchools();
            return Ok(result);
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetById(int id)
        {
            var divingSchoolListResponse = divingSchoolService.GetDivingSchoolById(id);
            if(divingSchoolListResponse != null)
            {
                return Ok(divingSchoolListResponse);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddDivingSchools(AddNewDivingSchoolRequest request)
        {
            if (ModelState.IsValid)
            {
                int divingSchoolId = divingSchoolService.AddDivingSchools(request);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = divingSchoolId }, value: null);
            }
            return BadRequest(ModelState);
            
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDivingSchool(int id, EditDivingSchoolRequest request)
        {
            var isExisting = divingSchoolService.GetDivingSchoolById(id);
            if(isExisting == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                int editItemId = divingSchoolService.UpdateDivingSchool(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var isExisting = divingSchoolService.GetDivingSchoolById(id);
            if (isExisting == null)
            {
                return NotFound();
            }
            divingSchoolService.DeleteDivingSchool(id);
            return Ok();
        }
    }
}
