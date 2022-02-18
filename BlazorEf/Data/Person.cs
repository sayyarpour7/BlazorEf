using BlazorEf.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEf.Data
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20,ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [Display(Name ="نام")]
        public string FirstName { get; set; }
        [MaxLength(20, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
    
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        [Display(Name = "محل تولد")]
        public int? CityId { get; set; }
        [Display(Name = "تاریخ تولد")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "مبلغ اعتبار")]
        public long Price { set; get; }
        public virtual ICollection<Job> Job { get; set; }
    }
}
