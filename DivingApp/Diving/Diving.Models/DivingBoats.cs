using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Models
{
    public class DivingBoats : IEntity
    {
        [Key]
        public int Id { get ; set ; }
        [Required (ErrorMessage = "Kapasite boş olamaz!")]
        public int Capacity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
