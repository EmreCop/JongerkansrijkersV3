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


		public void UpdateUserByName(string name, string email)
		{

			var user = GetUserByName(name);
			if (user == null)
			{
				throw new Exception("User Does not Exits");
			}
			user.Email = email;
			using (var  context = _dbContextFactory.CreateDbContext()) 
			{
				context.Update(user);
				context.SaveChanges();
			}



		}


	}
}
