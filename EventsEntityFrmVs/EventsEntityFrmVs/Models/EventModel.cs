using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsEntityFrmVs.Models
{
    public class EventModel
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }

        public virtual List<CommentModel> Comments { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual List<ApplicationUser> ApplicationUsers { get; set; }


    }
}