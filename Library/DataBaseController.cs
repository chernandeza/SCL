using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library
{
    public class DataBaseController
    {

        #region Class Attributes

        private SqlConnectionStringBuilder ConnectionStr;
        private SqlConnection DBConnection;
        private SqlCommand SQLcmdSP;
        

        #endregion

        #region Class Methods

        /// <summary>
        /// Base class constructor. Initializes the connection to the DB with the specific parameters.            
        /// </summary>
        public DataBaseController()
        {
            ConnectionStr = new SqlConnectionStringBuilder();
            ConnectionStr.DataSource = "HERNANDEZAC\\SQLEXPRESS";            
            //ConnectionStr.DataSource = ".\\SQLEXPRESS";
            ConnectionStr.InitialCatalog = "830TestDB";
            ConnectionStr.UserID = "dbtest";
            ConnectionStr.Password = "P@ssw0rd";
            DBConnection = new SqlConnection(ConnectionStr.ConnectionString);
        }

        /// <summary>
        /// Agrega datos a la BD a través de un procedimiento almacenado
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>True si la inserción fue exitosa</returns>
        public bool AddNewMessage(Message msg)
        {
            try
            {
                DBConnection.Open();
                SQLcmdSP = new SqlCommand("sp_StoreMessage", DBConnection);
                SQLcmdSP.CommandType = CommandType.StoredProcedure;
                SQLcmdSP.Parameters.Add(new SqlParameter("@content", SqlDbType.NVarChar, 200));
                SQLcmdSP.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar, 50));
                SQLcmdSP.Parameters[0].Value = msg.Content;
                SQLcmdSP.Parameters[1].Value = msg.Importance.ToString();
                int i = SQLcmdSP.ExecuteNonQuery();                
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                SQLcmdSP.Dispose();
                DBConnection.Close();
            }
        }


        /*
        * Garbage Collection Dispose Methods implemented as Programming Best Practices.
        */
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                DBConnection.Close();
                SQLcmdSP.Dispose();
            }
            // free native resources
        }

        /// <summary>
        /// Disposes the DBConnector object
        /// </summary>  
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
