using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class mood
    {
        [Key]
        public int numero { get; set; }
        public string mensaje { get; set; }
    }
}