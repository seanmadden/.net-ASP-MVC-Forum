using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Forum.Models
{
    public class Board
    {
        
        public int ID { get; set; }       
        public string Title { get; set; }
        public string Description { get; set; }
		public List<Message> Messages { get; set; }
    }



}