using HomeApplication.API.Authorization.Models.Entities;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace HomeApplication.API.Authorization.Repositories
{
	public interface IAuthRepository
	{
		public Task<User> GetUser(string username, string password);
		public Task<bool> AddUser(User user);
		public Task UpdateUser(User user);
		public Task DeleteUser(string username);

	}
}
