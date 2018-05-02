using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APItwo.Models
{
    public class Field
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeField { get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
    }
}