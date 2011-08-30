using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public int MessageID { get; set; }

		public Post()
		{
		}


		public Post(int id)
		{
			MessageID = id;
		}

    }
}