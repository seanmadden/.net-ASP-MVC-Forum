using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Forum.Models
{

	public class ForumDB : DbContext
	{
		public DbSet<Board> Boards { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<User> Users { get; set; }
	}
}