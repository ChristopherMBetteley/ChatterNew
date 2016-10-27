using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageTimeStamp { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
    }
}