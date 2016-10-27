using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserFirstName { get; set; }
        public string UserCity { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}