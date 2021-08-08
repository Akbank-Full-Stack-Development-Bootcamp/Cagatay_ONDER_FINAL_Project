using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Models
{
    public class DivingSchools : IEntity
    {
        [Key]
        public int Id { get ; set; }
        [Required(ErrorMessage ="Ad alanı boş geçilemez")]
        public string  Name { get; set; }
        [Required(ErrorMessage = "Adres boş olamaz!")]
        public string Address { get; set; }
        [ForeignKey("Head Instructor")]
        public int InstructorId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual HeadInstructor HeadInstructor { get; set; }


    }
}
