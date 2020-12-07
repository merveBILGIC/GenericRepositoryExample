using System;
using System.Collections.Generic;
using System.Text;
using GenericRepositoryExample.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GenericRepositoryExample.Data.Configs
{
	class AuthorConfig: IEntityTypeConfiguration<UsersAuthor>
	{
        public AuthorConfig()
        { }

		

        public void Configure(EntityTypeBuilder<UsersAuthor> builder)
        {
                builder
                    .HasKey(a => a.Id);

                builder
                    .Property(m => m.Id)
                    .UseIdentityColumn();

                builder
                    .Property(m => m.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                builder
                    .ToTable("users");
        }
        
    }
}
