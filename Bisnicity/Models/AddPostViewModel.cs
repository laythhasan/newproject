using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bisnicity.Models
{
    public class AddPostViewModel
    {
        [Required]
        public string detailspost { get; set; }
        [Required]
        public IFormFile postimage { get; set; }
        [Required]
        public string Tittelpost { get; set; }
    }
}
