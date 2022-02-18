using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEf.Data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [MaxLength(20, ErrorMessage = utils.AttributesErrorMessages.MaxLengthMessage)]
        [Required(ErrorMessage = utils.AttributesErrorMessages.RequiredMessage)]
        [Display(Name = "پست سازمانی")]
        public string  OrganPost { get; set; }
        [MaxLength(20, ErrorMessage = utils.AttributesErrorMessages.MaxLengthMessage)]
        [Required(ErrorMessage = utils.AttributesErrorMessages.RequiredMessage)]
        [Display(Name = "واحد سازمانی")]
        public string OrganUnit { get; set; }
  
        [Required(ErrorMessage = utils.AttributesErrorMessages.RequiredMessage)]
        [Display(Name = "تاریخ شروع به کار")]
        public DateTime StartDate { get; set; }
      
        [Display(Name = "تاریخ پایان کار")]
        public DateTime EndDate { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        [Display(Name = "شخص")]
        public int? PersonId { get; set; }

    }
}
