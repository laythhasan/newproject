// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IApplictionUser.cs" >
//  Hamza Nayef 
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BisnicityApp.InterFaces
{
    public interface IApplictionUser<T>
    {
        #region Methods
        #region Methdos :: LstGetAllUsers
        Task<IQueryable<T>> LstGetAllUsers();
        #endregion
        #region Method :: UpdateUser
        Task UpdateUser(T Object);
        #endregion
        #region Method ::FindUser
        T FindUser(string UserrID);
        #endregion
        #region Methods ::GetQueryFromBind
        IQueryable<T> GetQueryFromBind(string Command);
        #endregion
        #endregion
    }
}
