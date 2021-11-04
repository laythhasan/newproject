// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplictionUser.cs" >
//  Hamza Nayef 
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using BisnicityApp.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
namespace Infrastrucer.Repositry
{
    public class ApplictionUser<T> : IApplictionUser<T> where T : class, new()
    {
        #region Members
        protected DataContext oDataContext;
        #endregion
        #region Props
        public string DataBaseContext
        {
            get
            {
                return this.oDataContext.Database.GetDbConnection().Database;
            }
        }
        #endregion
        #region Ctor
        public ApplictionUser(DataContext dataContext)
        {
            this.oDataContext = dataContext;
        }
        #endregion
        #region Methods
        #region Methods :: FindUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserrID"></param>
        /// <returns></returns>
        public T FindUser(string UserrID)
        {
            return this.oDataContext.Set<T>().Find(UserrID);
        }
        #endregion
        #region Methdos:: LstGetAllUsers
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IQueryable<T>> LstGetAllUsers()
        {
            return this.oDataContext.Set<T>();
        }
        #endregion
        #region Methods :: UpdateUser
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        public async Task UpdateUser(T Object)
        {
            this.oDataContext.Set<T>().Update(Object);
        }
        #endregion
        #region Method :: GetQueryFromBind
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Command"></param>
        /// <param name="oDataReader"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetQueryFromBind(string Command)
        {
            var command = oDataContext.Database.GetDbConnection().CreateCommand();
            command.CommandText = Command;
            command.CommandType = CommandType.Text;
            oDataContext.Database.OpenConnection();
            List<T> list = new List<T>();
            var result = command.ExecuteReader();
            T obj = default(T);
            while (result.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(result[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, result[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            oDataContext.Database.CloseConnection();
            return list.AsQueryable();
        }
        #endregion
        #endregion
    }
}
