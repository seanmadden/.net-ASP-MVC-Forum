using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Body { get; set; }
        public int BoardID { get; set; }
		
        public string Author { get; set; }
		public List<Post> Posts { get; set; }
		
    }
}