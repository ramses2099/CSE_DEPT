using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CSE_DEPT.Entities;
using CSE_DEPT.Utils;

namespace CSE_DEPT.Services
{
    class LogInService : IRepository
    {
        /// <summary>
        ///  metodo para validar usuario
        /// </summary>
        /// <param name="logIn">Objecto de la clase LogIn</param>
        /// <returns>True or False</returns>
        public bool ValidaLogIn(LogIn logIn)
        {
            bool rs = false;

            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {

                if (oConnection.State != ConnectionState.Open)
                {
                    oConnection.Open();
                }

                SqlParameter sqlParamUser_name = new SqlParameter("@user_name", logIn.User_name);
                SqlParameter sqlParamPass_word = new SqlParameter("@pass_word", logIn.Pass_word);

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT [user_name],pass_word FROM [dbo].[LogIn] ");
                sql.AppendLine("WHERE [user_name] = @user_name AND pass_word = @pass_word");

                using (SqlCommand oCommand = new SqlCommand())
                {

                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = sql.ToString();
                    oCommand.Connection = oConnection;
                    oCommand.Parameters.Add(sqlParamUser_name);
                    oCommand.Parameters.Add(sqlParamPass_word);

                    using (SqlDataReader oDataReader = oCommand.ExecuteReader())
                    {

                        if (oDataReader.HasRows)
                        {

                            while (oDataReader.Read())
                            {

                                if (oDataReader["user_name"] != DBNull.Value)
                                {
                                    rs = true;
                                }

                                if (oDataReader["user_name"] != DBNull.Value)
                                {
                                    rs = true;
                                }
                            }
                        }
                        else {
                            rs = false;                             
                        }

                    }

                }
            }

            return rs;
        }

        public void CrateObject(object obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteObject(object obj)
        {
            throw new NotImplementedException();
        }

        public List<object> GetObject()
        {
            throw new NotImplementedException();
        }

        public void UpdateObject(object obj)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~LogInService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

       
        #endregion

    }
}
