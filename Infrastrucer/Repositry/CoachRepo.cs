using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class CoachRepo : IBisnicity<coach>
    {
        DataContext db;
        public CoachRepo(DataContext _db)
        {
            db = _db;
        }
        public void Add(coach entity)
        {
            db.coach.Add(entity); db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public coach Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<coach> List()
        {
            return db.coach.ToList();
        }

        public void Update(int id, coach entity)
        {
            throw new NotImplementedException();
        }
    }
}
