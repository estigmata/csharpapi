using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APItwo.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Field> Fields { get; set; }
    }
}