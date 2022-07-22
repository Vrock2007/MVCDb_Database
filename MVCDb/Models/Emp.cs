using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

#nullable disable

namespace MVCDb.Models
{
    public partial class Emp
    {
        [Display(Name = "Emp. Code")]
        public int Id { get; set; }

        [Display(Name = "Emp Name")]
        [Required(ErrorMessage ="Blank name not allowed")]
        public string Name { get; set; }

        [Range(10000,90000,ErrorMessage ="Salary between 10k and 90k")]
        public int? Salary { get; set; }
        public int? Deptid { get; set; }

        [Display(Name="Dirthdate")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0,yyyy-mm-dd}")]
        public DateTime? Dob { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual Dept Dept { get; set; }
    }
}
