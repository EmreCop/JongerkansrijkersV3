using Jongerkansrijkers.Components.Data;
using Jongerkansrijkers.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jongerkansrijkers.Services
{
	public class InstituutService(IDbContextFactory<JongerenDbContext> dbContextFactory)
	{
		private IDbContextFactory<JongerenDbContext> _dbContextFactory = dbContextFactory;


        public void AddInstutuut(Instutuut Instutuut)
        {
            using (var contex = _dbContextFactory.CreateDbContext())
            {
                contex.Instutuuts.Add(Instutuut);
                contex.SaveChanges();
            }
        }

       

        public Instutuut GetInstutuutById(int id)
        {
            using (var contex = _dbContextFactory.CreateDbContext())
            {
                var Instutuut = contex.Instutuuts.SingleOrDefault(x => x.Id == id);
                return Instutuut ?? throw new Exception("Instutuut Does not Exits ");
            }
        }


        public void UpdateInstutuutById(Instutuut instutuut )
        {

            if (instutuut == null)
            {
                throw new Exception("Instutuut Does not Exits");
            }
       
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(instutuut);
                context.SaveChanges();
            }
        }

        public List<Instutuut> GetallInstutuut()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var Instutuuts = context.Instutuuts.ToList();
                return Instutuuts;
            }

        }

        public void RemoveInstutuutById(int id)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var Instutuut = GetInstutuutById(id);
                context.Instutuuts.Remove(Instutuut);
                context.SaveChanges();
            }

        }




    }
}
