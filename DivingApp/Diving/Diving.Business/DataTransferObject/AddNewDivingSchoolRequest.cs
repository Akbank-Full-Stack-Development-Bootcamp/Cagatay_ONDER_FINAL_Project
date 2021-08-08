using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business.DataTransferObject
{
    public class AddNewDivingSchoolRequest
    {
        [Required(ErrorMessage ="Dalış Merkezi adı giriniz!")]
        public string Name { get; set; }
    }
}
