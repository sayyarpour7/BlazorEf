using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEf.Data
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string CityTitle { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

    }
}
