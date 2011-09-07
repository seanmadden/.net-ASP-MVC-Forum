using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;

namespace Forum.Models
{
	public class User
	{
		[Display(Name = "User Name")]
		[Required]
		public string UserName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public int id { get; set; }

		[Display(Name = "Is administrator?")]
		public bool admin { get; set;}

	}
}