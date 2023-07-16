using HomeApplication.API.Authorization.Core.Database;
using HomeApplication.API.Authorization.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Repositories
{
	public class AuthRepository : IAuthRepository
	{
		private readonly AuthorizationContext dbContext;
		public AuthRepository(AuthorizationContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<bool> AddUser(User user)
		{
			if( dbContext.Users.Where(u => u.Username == user.Username).Any() )
			{
				return false;
			}
			else
			{
				user.Password = Convert.ToBase64String( Encoding.ASCII.GetBytes( user.Password ) );
				await dbContext.Users.AddAsync(user);
				return true;
			}
		}

		public async Task DeleteUser(string username)
		{
			var user = await dbContext.Users.Where(u => u.Username == username).FirstOrDefaultAsync();
			if( user != null )
			{
				dbContext.Users.Remove( user );
			}
		}

		public async Task<User> GetUser(string username, string password)
		{
			var user = await dbContext.Users.AsQueryable()
				.Where(u => u.Username == username && u.Password == Convert.ToBase64String(Encoding.ASCII.GetBytes( password ) ) )
				.FirstOrDefaultAsync();

			if( user != null )
			{
				return user;
			}
			else
			{
				return null;
			}
		}

		public Task UpdateUser(User user)
		{
			throw new System.NotImplementedException();
		}
	}
}
