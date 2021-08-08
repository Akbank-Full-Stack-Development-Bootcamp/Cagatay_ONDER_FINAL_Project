using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Models
{
    public class HeadInstructor : IEntity
    {
        [Key]
        public int Id { get ; set ; }
        [Required(ErrorMessage = "İsim boş olamaz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bröve boş olamaz!")]
        public string License { get; set; }
        public string Description { get; set; }
        [ForeignKey("Diving Boats")]
        public int DivingBoatsId { get; set; }
        //NAV PROP
        public virtual DivingBoats DivingBoats { get; set; }
    }
}
