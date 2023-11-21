using Jongerkansrijkers.Components.Data;
using Jongerkansrijkers.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jongerkansrijkers.Services
{
	public class ActiviteitService(IDbContextFactory<JongerenDbContext> dbContextFactory)
	{
		private IDbContextFactory<JongerenDbContext> _dbContextFactory = dbContextFactory;


        public void AddActiviteit(Activiteit Activiteit)
        {
            using (var contex = _dbContextFactory.CreateDbContext())
            {
                contex.Activiteiten.Add(Activiteit);
                contex.SaveChanges();
            }
        }

       

        public Activiteit GetActiviteitById(int id)
        {
            using (var contex = _dbContextFactory.CreateDbContext())
            {
                var Activiteit = contex.Activiteiten.SingleOrDefault(x => x.Id == id);
                return Activiteit ?? throw new Exception("Activiteit Does not Exits ");
            }
        }


        public void UpdateActiviteitById(Activiteit Activiteit )
        {

            if (Activiteit == null)
            {
                throw new Exception("Activiteit Does not Exits");
            }
       
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(Activiteit);
                context.SaveChanges();
            }
        }

        public List<Activiteit> GetallActiviteit()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var Activiteits = context.Activiteiten.ToList();
                return Activiteits;
            }

        }

        public void RemoveActiviteitById(int id)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var Activiteit = GetActiviteitById(id);
                context.Activiteiten.Remove(Activiteit);
                context.SaveChanges();
            }

        }




    }
}
