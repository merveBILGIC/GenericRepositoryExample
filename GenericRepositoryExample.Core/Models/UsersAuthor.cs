using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExample.Core.Models
{
  public class UsersAuthor:IdentityUser
  {
		public UsersAuthor()
		{
				
		}
		public int Id { get; set; }
		public string Name { get; set; }
  }
}
