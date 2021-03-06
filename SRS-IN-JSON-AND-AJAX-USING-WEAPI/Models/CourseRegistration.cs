//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRS_IN_JSON_AND_AJAX_USING_WEAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text.RegularExpressions;
    public partial class CourseRegistration
    {
        public int CourseRegistrationId { get; set; }
        [Required]
        [ForeignKey("Course")]
        public Nullable<int> CourseId { get; set; }
        [Required]
        [ForeignKey("Student")]
        public Nullable<int> StudentId { get; set; }
        //[RegularExpression("(^[1-3])$", ErrorMessage = "range can between 1 to 3")]
        public Nullable<System.DateTime> RegistrationTime { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
