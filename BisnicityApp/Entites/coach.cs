using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnicityApp.Entites
{
   public class coach
    {
        [Key]
        public int coachID { get; set; }
        public string Address { get; set; }
        [Required]
        public string certificte { get; set; }
        [Required]
        public string Expireance { get; set; }
        public string  Type { get; set; }
        public virtual Educationlevel Educationlevel { get; set; }

        [ForeignKey("EducationlevelID")]
        public int? EducationlevelID { get; set; }
        public virtual Univircity Univircity { get; set; }

        [ForeignKey("UnivircityID")]
        public int? UnivircityID { get; set; }
        public int Flag { get; set; } = 0;
        [ForeignKey("UserId")]
        public string UserId { get; set; }

    }
}
