#region Using
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

#endregion


namespace DataManager
{
    public class DbManager : IDisposable
    {
        #region Global Variable
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlTransaction transaction;
        DataTable dt;
        DataSet ds;
        #endregion

        #region Constructor
        public DbManager(string connStr)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            adp = new System.Data.SqlClient.SqlDataAdapter();
            adp.SelectCommand = cmd;
        }
        #endregion

        #region Property
        public SqlCommand DataCommand
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlDataAdapter SqlDataAdapter
        {
            get { return adp; }
            set { adp = value; }
        }
        #endregion

        #region Connection Functions

        public enum ConnType
        {
            webConfigFile,
            connectionStringText
        }

        public string GetConnectionString()
        {
            return conn.ConnectionString;
        }

        /// <summary>
        /// Open SQL Connection
        /// </summary>
        /// <returns>If open connection return true, else return false</returns>
        public bool ConnOpen()
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// Close SQL Connection
        /// </summary>
        /// <returns>If close connection return true, else return false</returns>
        public bool ConnClose()
        {
            try
            {
                if (ConnOpen()) conn.Close();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Set the connection
        /// </summary>
        /// <param name="connectionType">Connection type</param>
        /// <param name="connectionStringOrName">Connection string or Web.config connectionstring name</param>
        public void SetConnectionString(string connectionStringOrName)
        {
            //try
            //{
            //    conn = new SqlConnection();
            //    conn.ConnectionString = connectionStringOrName;
            //    ConnOpen();
            //    cmd = new SqlCommand();
            //    cmd.CommandTimeout = 600;
            //    cmd.Connection = conn;
            //    da.SelectCommand = cmd;
            //}
            //catch (Exception ex)
            //{
            //    conn = new SqlConnection();
            //    conn.ConnectionString = connectionStringOrName;
            //    ConnOpen();
            //    cmd = new SqlCommand();
            //    cmd.CommandTimeout = 600;
            //    cmd.Connection = conn;
            //    da.SelectCommand = cmd;
            //}
            //ConnOpen();
        }

        public bool BeginTransaction()
        {
            try { transaction = conn.BeginTransaction(); return true; }
            catch (Exception ex) { AddError(ex.Source, ex.Message, GetWebSite(), "BeginTransaction"); return false; }
        }

        /// <summary>
        /// Test SQL connection and get the table names.
        /// This function return List<string>
        /// </summary>
        /// <returns>string text</returns>
        // SqlDataReader dr;
        public List<string> TestDatabase()
        {
            List<string> result = new List<string>();

            if (ConnOpen())
            {
                SqlDataReader dr = GetDataReader("SELECT name FROM sys.Tables");
                while (dr.Read()) result.Add(dr["name"].ToString());
                ConnClose();
            }
            return result;
        }
        #endregion

        #region Functions
        #region Get

        public SqlDataReader GetDataReader(string sqlCode)
        {
            return GetDataReader(sqlCode, CommandType.Text);
        }

        public SqlDataReader GetDataReader(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            SqlDataReader dr = null;
            try
            {
                cmd.CommandType = commandType;
                cmd.CommandText = sqlCode;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                if (dr != null)
                {
                    dr.Close();
                    dr.Dispose();
                }
                AddError(ex.Source, ex.Message, GetWebSite(), sqlCode);
                return GetDataReader(sqlCode);
            }
        }

        public DataTable GetDataTable(string sqlCode)
        {
            return GetDataTable(sqlCode, CommandType.Text);
        }
        public DataTable GetDataTable(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            dt = new DataTable();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlCode;
            try
            {
                adp.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            ConnClose();
            return dt;
        }
        public static string getdatacell(string sqlselect)
        {
            try
            {
                //return true;
                return getdatacell(sqlselect);
            }
            catch (Exception hata)
            {
                //MessageBox.Show("Tekrar Deneyin\n" + hata.Message, firma.programAdi);
                return null;
            }
        }
        public DataSet GetDataSet(string sqlCode)
        {
            return GetDataSet(sqlCode, CommandType.Text);
        }
        public DataSet GetDataSet(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            ds = new DataSet();
            cmd.CommandText = sqlCode;
            cmd.CommandType = commandType;
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                ds.Tables.Add(dt);
            }
            catch (Exception ex)
            {
                AddError(ex.Source, ex.Message, GetWebSite(), sqlCode);
            }
            ConnClose();
            return ds;
        }
        public DataSet GetDataSet(string sqlCode, CommandType commandType, DataSet dataSet, string tableName)
        {
            ConnOpen();
            ds = new DataSet();
            cmd.CommandText = sqlCode;
            cmd.CommandType = commandType;
            try
            {
                adp.Fill(dataSet, tableName);
            }
            catch (Exception ex)
            {
                AddError(ex.Source, ex.Message, GetWebSite(), sqlCode);
            }
            ConnClose();
            return dataSet;
        }

        public DataRow GetDataRow(string sqlCode)
        {
            return GetDataRow(sqlCode, CommandType.Text);
        }
        public DataRow GetDataRow(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            DataRow dRow;
            if (GetDataTable(sqlCode, commandType).Rows.Count > 0) dRow = GetDataTable(sqlCode, commandType).Rows[0];
            else dRow = GetDataTable(sqlCode, commandType).NewRow();

            ConnClose();
            return dRow;
        }

        public object GetExecuteScalar(string sqlCode)
        {
            return GetExecuteScalar(sqlCode, CommandType.Text);
        }
        public object GetExecuteScalar(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            object objValue;
            cmd.CommandType = commandType;
            cmd.CommandText = sqlCode;
            try
            {
                if (!sqlCode.Contains("@")) cmd.Parameters.Clear();
                objValue = DataCommand.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                AddError(ex.Source, ex.Message, GetWebSite(), sqlCode);
                objValue = null;
            }
            ConnClose();
            return objValue;
        }
        #endregion


        public bool CommitTransaction()
        {
            if (transaction == null) return false;
            try { transaction.Commit(); return true; }
            catch (Exception ex) { return false; }
        }
        public int RunCommand(string sqlCode)
        {
            return RunCommand(sqlCode, CommandType.Text);
        }
        public int RunCommand(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            int identityID = -1;
            try
            {
                cmd.CommandText = sqlCode;
                cmd.CommandType = commandType;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();
                if (!sqlCode.ToLower().StartsWith("update") &&
                    !sqlCode.StartsWith("insert into InventoryWeb") &&
                    !sqlCode.ToLower().StartsWith("delete from") &&
                    !sqlCode.StartsWith("Insert Into ItineraryStop") &&
                    !sqlCode.StartsWith("Insert Into VehicleTourPerson"))
                    identityID = Convert.ToInt32(GetExecuteScalar("select @@IDENTITY"));
            }
            catch (Exception ex)
            {
                if (transaction != null) transaction.Rollback();

                AddError(ex.Source, ex.Message, GetWebSite(), sqlCode);

                ConnClose();
                return 0;
            }
            ConnClose();
            return identityID;
        }

        private string GetWebSite()
        {
            string sql = "select top 1 webSite from CompanyInfo";
            return GetExecuteScalar(sql).ToString();
        }

        /// <summary>
        /// Return login user ID
        /// </summary>
        public int LoginUserID { get; set; }
        /// <summary>
        /// Return true or false
        /// </summary>
        /// <param name="dbTableName">Database table name</param>
        /// <param name="dbUserIDName">Database ID name</param>
        /// <param name="dbUserName">Database user name</param>
        /// <param name="dbUserPassword">Database user password</param>
        /// <param name="userName">Enter user name</param>
        /// <param name="userPassword">Enter user password</param>
        /// <returns></returns>
        public bool LoginUser(string dbTableName, string dbUserIDName, string dbUserName, string dbUserPassword, string userName, string userPassword)
        {
            string sqlCode = "select " + dbUserIDName + " from " + dbTableName
                           + " where " + dbUserName + "=@Name and "
                           + dbUserPassword + " =@Password";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@dbUserName", SqlDbType.NVarChar).Value = userName;
            cmd.Parameters.Add("@dbUserPassword", SqlDbType.NVarChar).Value = userPassword;

            SqlDataReader drLoginUser = GetDataReader(sqlCode);
            if (drLoginUser.Read())
            {
                LoginUserID = int.Parse(drLoginUser[dbUserIDName].ToString());
                drLoginUser.Close();
                return true;
            }
            else return false;
        }

        public string GetDataCell(string procedureName, SqlParameter[] paramList)
        {
            string result = "";
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conn;
                    command.CommandText = procedureName;
                    //transaction.Commit();
                    if (paramList != null) command.Parameters.AddRange(paramList);
                    result = command.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    if (transaction != null) transaction.Rollback();

                    AddError(ex.Source, ex.Message, GetWebSite(), procedureName);

                    ConnClose();
                    return "-1";
                }
                finally
                {
                    command.Dispose();
                }
            }
            return result;
        }

        public bool LoginUser(string dbTableName, string dbUserIDName, string[] dbColums, string[] dbColumsValue)
        {
            if (dbColums.Length == dbColumsValue.Length)
            {
                string strWhereSentence = "";
                for (int i = 0; i < dbColums.Length; i++)
                {
                    strWhereSentence += " " + dbColums[i].ToString() + "=@" + dbColums[i].ToString() + " and ";
                }
                strWhereSentence = strWhereSentence.Substring(0, strWhereSentence.Length - 5);

                string sqlCode = "select * from " + dbTableName
                               + " where " + strWhereSentence;
                cmd.Parameters.Clear();

                for (int i = 0; i < dbColums.Length; i++)
                {
                    cmd.Parameters.Add("@" + dbColums[i], SqlDbType.NVarChar).Value = dbColumsValue[i].ToString();
                }

                SqlDataReader drLoginUser = GetDataReader(sqlCode);
                if (drLoginUser.Read())
                {
                    if (!string.IsNullOrEmpty(drLoginUser[dbUserIDName].ToString()))
                        LoginUserID = int.Parse(drLoginUser[dbUserIDName].ToString());
                    drLoginUser.Close();
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public bool IsThereRow(string sqlCode)
        {
            ConnOpen();
            bool state = GetDataTable(sqlCode).Rows.Count > 0;
            ConnClose();
            return state;
        }

        public int AddError(string exceptionName, string message, string webSite, string sqlCode)
        {
            string connStr = @"Server = 176.53.32.51;
                               Database = dbElmarERPTasks;
                               user id=userElmarERPTasks;
                               Password=passElmarERPTasks23";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string sql = @"Insert Into Errors(Exception, Message, WebSite, Sql, Environment)
                           Values (@Exception, @Message, @WebSite, @Sql, @Environment)";
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Exception", SqlDbType.VarChar).Value = exceptionName;
            cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = message;
            cmd.Parameters.Add("@WebSite", SqlDbType.VarChar).Value = webSite;
            cmd.Parameters.Add("@Sql", SqlDbType.VarChar).Value = sqlCode;
            cmd.Parameters.Add("@Environment", SqlDbType.VarChar).Value = "Ticari Program";
            int turn = cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return turn;
        }
        #endregion

        public void Dispose()
        {
            ConnClose();
            if (conn != null) conn.Dispose();
            if (cmd != null) cmd.Dispose();
            if (adp != null) adp.Dispose();
            if (dt != null) dt.Dispose();
            if (ds != null) ds.Dispose();
            if (transaction != null) transaction.Dispose();
        }
    }
}
