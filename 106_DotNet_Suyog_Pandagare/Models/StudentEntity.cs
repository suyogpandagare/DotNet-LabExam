using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("studentfeedback")]
    public class StudentEntity
    {
      
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime Date { get; set; } 
       
        public string Module { get; set; }
        public string Faculty { get; set; }
        public int Pbskills { get; set; }

        public int Prskills { get; set; }
        
    }
}