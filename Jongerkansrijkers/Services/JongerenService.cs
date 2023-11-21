using Jongerkansrijkers.Components.Data;
using Jongerkansrijkers.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jongerkansrijkers.Services
{
	public class JongerenService(IDbContextFactory<JongerenDbContext> dbContextFactory)
	{
		private IDbContextFactory<JongerenDbContext> _dbContextFactory = dbContextFactory;


        public void AddJongeren(Jongeren Jongeren)
        {
            using (var contex = _dbContextFactory.CreateDbContext())
            {
                contex.Jongeren.Add(Jongeren);
                contex.SaveChanges();
            }
        }

       

        public Jongeren GetJongerenById(int id)
        {
            using (var contex = _dbContextFactory.CreateDbContext())
            {
                var Jongeren = contex.Jongeren.SingleOrDefault(x => x.Id == id);
                return Jongeren ?? throw new Exception("Jongeren Does not Exits ");
            }
        }


        public void UpdateJongeren(Jongeren Jongeren )
        {

            if (Jongeren == null)
            {
                throw new Exception("Jongeren Does not Exits");
            }
       
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(Jongeren);
                context.SaveChanges();
            }
        }

        public List<Jongeren> GetallJongeren()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var Jongerens = context.Jongeren.ToList();
                return Jongerens;
            }

        }

        public void RemoveJongerenById(int id)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var Jongeren = GetJongerenById(id);
                context.Jongeren.Remove(Jongeren);
                context.SaveChanges();
            }

        }




    }
}
