//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeedBackSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Table
    {
        public int Id { get; set; }

        public Nullable<System.DateTime> Date { get; set; }
        public string StudentName { get; set; }
        public string Module { get; set; }

        public string Faculty { get; set; }
        [Range(1,5,ErrorMessage="rating must be 1-5")]
        public Nullable<double> ProblemSolvingRating { get; set; }
        [Range(1, 5, ErrorMessage = "rating must be 1-5")]
        public Nullable<double> PresentationSkill { get; set; }
        public string Comments { get; set; }
    }
}
