using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDb.Models
{
    public class DeptMetadata
    {   
        // validation for id != null
        [Required(ErrorMessage ="Id is compulsory!")]
        [Display(Name = "Dept, Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name should not be blank!")]
        [Display(Name = "Department, Name")]
        public string Name { get; set; }

        [StringLength(maximumLength:25, ErrorMessage ="Maximum length is 25 characters")]
        [Display(Name = "City")]
        public string Location { get; set; }

    }

    [MetadataType(typeof(DeptMetadata))]
    public partial class Dept { }
}
