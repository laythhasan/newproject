using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System.Collections.Generic;
using System.Linq;
namespace Infrastrucer.Repositry
{
    public class InfoDBRepo : IBisnicity<Info>
    {
      private readonly  DataContext db;
        public InfoDBRepo(DataContext _db)
        {
            db = _db;
        }
        #region Mehod :: Add
        /// <summary>
        ///  This Mehod For Create Obejct
        /// </summary>
        /// <param name="entity"></param>
        public void Add(Info entity)
        {
            //try
            //{

            //}
            //catch (DbEntityValidationException ex)
            //{
            //    throw ex;
            //}
            db.Info.Add(entity);
            db.SaveChanges();
        }
        #endregion
        public void Delete(int id)
        {
            var info = Find(id);
            db.Info.Remove(info);
            db.SaveChanges();
        }
        public Info Find(int id)
        {
            var info = db.Info.SingleOrDefault(a => a.InfoID == id);
            if(info !=null)
            {
                return info;
            }
            return null;
        }
        public IList<Info> List()
        {
            return db.Info.ToList();
        }
        public void Update(int id, Info Model)
        {
            db.Update<Info>(Model);
            db.SaveChanges();
        }
    }
    
}
