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
    class LogInService : IRepository<LogIn>, IDisposable
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

                                if (oDataReader["pass_word"] != DBNull.Value)
                                {
                                    rs = true;
                                }
                            }
                        }
                        else
                        {
                            rs = false;
                        }

                    }

                }
            }

            return rs;
        }

        /// <summary>
        ///  metodo para validar usuario
        /// </summary>
        /// <param name="logIn">Objecto de la clase LogIn</param>
        /// <returns>True or False</returns>
        public bool ValidaLogIn2(LogIn logIn)
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

                    using (SqlDataAdapter oDataAdapter = new SqlDataAdapter(oCommand))
                    {

                        DataTable dt = new DataTable();
                        oDataAdapter.Fill(dt);

                        if (dt.Rows.Count > 1)
                        {
                            rs = true;
                        }

                    }

                }
            }

            return rs;
        }

        public void CrateObject(LogIn logIn)
        {
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {

                if (oConnection.State != ConnectionState.Open)
                {
                    oConnection.Open();
                }

                SqlParameter sqlParamLogin_id = new SqlParameter("@login_id", logIn.Login_id);
                SqlParameter sqlParamPass_word = new SqlParameter("@pass_word", logIn.Pass_word);
                SqlParameter sqlParamUser_name = new SqlParameter("@user_name", logIn.User_name);
                SqlParameter sqlParamFaculty_id = new SqlParameter("@faculty_id", logIn.Faculty_id);
                SqlParameter sqlParamstudent_id = new SqlParameter("@student_id", logIn.Student_id);


                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO [dbo].[LogIn]([login_id],[user_name],[pass_word],[faculty_id],[student_id]) ");
                sql.AppendLine("VALUES(@login_id, @user_name, @pass_word, @faculty_id, @student_id) ");

                using (SqlCommand oCommand = new SqlCommand())
                {

                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = sql.ToString();
                    oCommand.Connection = oConnection;

                    oCommand.Parameters.Add(sqlParamLogin_id);
                    oCommand.Parameters.Add(sqlParamUser_name);
                    oCommand.Parameters.Add(sqlParamPass_word);
                    oCommand.Parameters.Add(sqlParamFaculty_id);
                    oCommand.Parameters.Add(sqlParamstudent_id);

                    oCommand.ExecuteNonQuery();


                }
            }


        }

        public void DeleteObject(LogIn logIn)
        {
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {

                if (oConnection.State != ConnectionState.Open)
                {
                    oConnection.Open();
                }

                SqlParameter sqlParamLogin_id = new SqlParameter("@login_id", logIn.Login_id);


                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE FROM [dbo].[LogIn] WHERE [login_id] = @login_id");

                using (SqlCommand oCommand = new SqlCommand())
                {

                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = sql.ToString();
                    oCommand.Connection = oConnection;
                    oCommand.Parameters.Add(sqlParamLogin_id);

                    oCommand.ExecuteNonQuery();


                }
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<LogIn> GetObject()
        {
            throw new NotImplementedException();
        }

        public void UpdateObject(LogIn logIn)
        {
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {

                if (oConnection.State != ConnectionState.Open)
                {
                    oConnection.Open();
                }

                SqlParameter sqlParamLogin_id = new SqlParameter("@login_id", logIn.Login_id);
                SqlParameter sqlParamPass_word = new SqlParameter("@pass_word", logIn.Pass_word);
                SqlParameter sqlParamUser_name = new SqlParameter("@user_name", logIn.User_name);
                SqlParameter sqlParamFaculty_id = new SqlParameter("@faculty_id", logIn.Faculty_id);
                SqlParameter sqlParamstudent_id = new SqlParameter("@faculty_id", logIn.Faculty_id);


                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE [dbo].[LogIn] SET");
                sql.AppendLine("[user_name] = @user_name ");
                sql.AppendLine(",[pass_word] = @pass_word ");
                sql.AppendLine(",[faculty_id] = @faculty_id ");
                sql.AppendLine(",[student_id] = @student_id ");
                sql.AppendLine("WHERE[login_id] = @login_id");
                
                using (SqlCommand oCommand = new SqlCommand())
                {

                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = sql.ToString();
                    oCommand.Connection = oConnection;

                    oCommand.Parameters.Add(sqlParamLogin_id);
                    oCommand.Parameters.Add(sqlParamUser_name);
                    oCommand.Parameters.Add(sqlParamPass_word);
                    oCommand.Parameters.Add(sqlParamFaculty_id);
                    oCommand.Parameters.Add(sqlParamstudent_id);

                    oCommand.ExecuteNonQuery();


                }
            }
        }

        public LogIn GetLogInById(String login_id)
        {
           
            LogIn logIn = null;

            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {


                if (oConnection.State != ConnectionState.Open)
                {
                    oConnection.Open();
                }

                SqlParameter sqlParamLogin_id = new SqlParameter("@login_id", login_id);
              
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT[login_id],[user_name],[pass_word],[faculty_id],[student_id] ");
                sql.AppendLine("FROM[dbo].[LogIn] WHERE[login_id] = @login_id ");

                using (SqlCommand oCommand = new SqlCommand())
                {

                    oCommand.CommandType = CommandType.Text;
                    oCommand.CommandText = sql.ToString();
                    oCommand.Connection = oConnection;
                    oCommand.Parameters.Add(sqlParamLogin_id);
                    using (SqlDataReader oDataReader = oCommand.ExecuteReader())
                    {

                        if (oDataReader.HasRows)
                        {
                            logIn = new LogIn();

                            while (oDataReader.Read())
                            {

                                if (oDataReader["login_id"] != DBNull.Value)
                                {
                                    logIn.Login_id = oDataReader["[login_id]"].ToString();
                                }

                                if (oDataReader["user_name"] != DBNull.Value)
                                {
                                    logIn.User_name = oDataReader["user_name"].ToString();
                                }

                                if (oDataReader["pass_word"] != DBNull.Value)
                                {
                                    logIn.Pass_word = oDataReader["pass_word"].ToString();
                                }

                                if (oDataReader["faculty_id"] != DBNull.Value)
                                {
                                    logIn.Faculty_id = oDataReader["faculty_id"].ToString();
                                }

                                if (oDataReader["student_id"] != DBNull.Value)
                                {
                                    logIn.Student_id = oDataReader["student_id"].ToString();
                                }
                            }
                        }
                       
                    }
                    
                }
            }

            return logIn;
        }
        

    }
}
