using HomeApplication.API.Authorization.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HomeApplication.API.Authorization.Core.Database
{
	public class AuthorizationContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasQueryFilter(u => u.IsActive);
			modelBuilder.Entity<Role>().HasQueryFilter(u => u.IsActive);
			modelBuilder.Entity<UserRole>().HasQueryFilter(u => u.IsActive);
		}
	}
}
