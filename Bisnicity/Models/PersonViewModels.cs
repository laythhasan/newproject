using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bisnicity.Models
{
    public class PersonViewModels
    {
        [Required]
        [StringLength(265)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [StringLength(265)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }   
        
        [Required]
        public int PersonID { get; set; }
        public string PersonImagePath { get; set; }
        public string LinkedInLink { get; set; }
        public string pdfbath { get; set; }

        public string Age { get; set; }

        public string GPA { get; set; }
        [Required]
        public string Major { get; set; }
        public string Address { get; set; }

    }
}
