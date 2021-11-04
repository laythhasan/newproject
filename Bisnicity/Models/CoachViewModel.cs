using BisnicityApp.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bisnicity.Models
{
    public class CoachViewModel
    {
        public string Address { get; set; }
        [Required]
        public IFormFile Fcertificte { get; set; }
        [Required]
        public string Expireance { get; set; }
        public string Type { get; set; }
        public int Flag { get; set; }
        public int levelID { get; set; }
        public List<Educationlevel> Educationlevels { get; set; }
        public List<Univircity> univircitys { get; set; }
        public int uniID { get; set; }

    }
}
