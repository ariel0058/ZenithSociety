using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithSociety.Models
{
    public class Activity
    {
        [Key]
        public int activityId { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Create Time")]
        public DateTime createActivity { get; set; }

        public List<Event> events { get; set; }
    }
}
