using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GenericRepositoryExample.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryExample.Data.Repositories
{
	class AuthorDbContext:IdentityDbContext<UsersAuthor>
	{
		public AuthorDbContext(DbContextOptions<AuthorDbContext> options) : base(options)
		{

		}
	}
}
