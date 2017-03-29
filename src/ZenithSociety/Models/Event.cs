using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithSociety.Models
{
    public class Event
    {
        [Key]
        public int eventId { get; set; }

        //saved as "dd-MM-yyyy hh:mm:ss"
        [Display(Name = "From")]
        public DateTime eventFrom { get; set; }

        [Display(Name = "To")]
        public DateTime eventTo { get; set; }

        public string Username { get; set; }

        [Display(Name = "Created")]
        public DateTime createEvent { get; set; }

        [Display(Name = "Active")]
        public bool isActive { get; set; }

        public int activityId { get; set; }

        [ForeignKey("activityId")]
        public Activity Activity { get; set; }

    }
}
