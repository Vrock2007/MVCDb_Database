using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDb.Models
{
    public class DeptMetadata
    {
        [Display(Name = "Dept, Id")]
        public int Id { get; set; }

        [Display(Name = "Department, Name")]
        public string Name { get; set; }

        [Display(Name = "City")]
        public string Location { get; set; }

    }
    [MetadataType(typeof(DeptMetadata))]
    public partial class Dept { }
}
