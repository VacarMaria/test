using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsEntityFrmVs.Models
{
    public class CommentModel
    {

        public int Id { get; set; }
        public string Text { get; set; }

        public DateTime? Date { get; set; }

        public virtual EventModel Event { get; set; }
        public int EventId { get; set; }
    }
}