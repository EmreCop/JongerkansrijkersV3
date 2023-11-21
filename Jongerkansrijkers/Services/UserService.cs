using Jongerkansrijkers.Components.Data;
using Jongerkansrijkers.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jongerkansrijkers.Services
{
	public class UserService(IDbContextFactory<JongerenDbContext> dbContextFactory)
	{
		private IDbContextFactory<JongerenDbContext> _dbContextFactory = dbContextFactory;


		public void AddUser(User user)
		{
			using (var contex = _dbContextFactory.CreateDbContext())
			{
				contex.Users.Add(user);
				contex.SaveChanges();
			}
		}

		public User GetUserByName(string name)
		{
			using (var contex = _dbContextFactory.CreateDbContext())
			{
				var user = contex.Users.SingleOrDefault(x => x.Name == name);
				return user;
			}

		}

		public User GetUserById(int id)
		{
			using (var contex = _dbContextFactory.CreateDbContext())
			{
				var user = contex.Users.SingleOrDefault(x => x.Id == id);
				return user ?? throw new Exception("User Does not Exits ");
			}
		}




		public void UpdateUser(User user)
		{
			if (user == null)
			{
				throw new Exception("User Does not Exits");
			}

			using (var context = _dbContextFactory.CreateDbContext())
			{
				context.Update(user);
				context.SaveChanges();
			}
		}

		public List<User> GetallUser()
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var users = context.Users.ToList();
				return users;
			}

		}

		public void RemoveUserById(int id)
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var user = GetUserById(id);
				context.Users.Remove(user);
				context.SaveChanges();

			}

		}
	}
}
