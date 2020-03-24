using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InvaxTechnology.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string ModelNumber { get; set; }
        [Required]
        public string ProductType { get; set; }

        public string Dimension { get; set; }

        public string Image { get; set; }

        public string Descriptions { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
