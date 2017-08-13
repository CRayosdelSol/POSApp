using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO; 
namespace DatabaseOperations
{
    public class DatabaseOps
    {

        string strConn;
        public string fileName;

        SqlConnection sqlconn;

        public string StrConn
        {
            get { return strConn; }
            set { strConn = value; }
        }

        public DatabaseOps(string connString)
        {
            StrConn = connString;
        }


        /// <summary>
        /// Creates a databese with the specified filename
        /// </summary>
        /// <param name="filename">Complete filename and path of the DB</param>
        public void CreateDatabase(string filename)
        {
            string path = filename; //Obtains the absolute path to the databse.
            string databaseName = Path.GetFileNameWithoutExtension(path); //Derived  database name.
            using (var connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=master; Integrated Security=true;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        string.Format("CREATE DATABASE [{0}] ON PRIMARY (NAME=[{0}], FILENAME='{1}')", databaseName, path);
                    command.ExecuteNonQuery();

                    command.CommandText =
                        string.Format("EXEC sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool checkForTableExistence(string tableName)
        {
            int check = 0;
            using (sqlconn = new SqlConnection(StrConn))
            {
                string checkExistence = @"IF EXISTS(SELECT*FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + "'" + tableName + "') SELECT 1 ELSE SELECT 0";
                sqlconn.Open();
                SqlCommand sqlCommand = new SqlCommand(checkExistence, sqlconn);
                check = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlconn.Close();
            }

            if(check == 0)
            {
                return false;
            }

            return true;
        }

        public void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string dataTypeB, string attributeC, string dataTypeC, string attributeD, string dataTypeD, string attributeE, string dataTypeE)
        {
            using (sqlconn = new SqlConnection(StrConn))
            {
                if (!checkForTableExistence(tableName))
                {
                    string temp = string.Format(
                        "CREATE TABLE {0}(" +
                        "{1} {2}," +
                        "{3} {4}," +
                        "{5} {6}," +
                        "{7} {8}," +
                        "{9} {10});",
                        tableName, attributeA, dataTypeA, attributeB, dataTypeB,attributeC,dataTypeC,attributeD,dataTypeD,attributeE,dataTypeE);

                    string createTableCommand = temp;
                    SqlCommand sqlCommand = new SqlCommand(createTableCommand, sqlconn);
                    sqlconn.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDataset(DataSet ds, string tableName)
        {
            sqlconn = new SqlConnection(StrConn);

            string sInsert, sUpdate, sDelete;

            sInsert = "INSERT INTO " + tableName + "(Barcode,Item,Price,Quantity) values(@p2,@p3,@p4,@p5)";

            sUpdate = "UPDATE " + tableName + "SET Barcode=@p2,Item=@p3,Price=@p4,Quantity=@p5 where ID=@p1";

            sDelete = "DELETE FROM " + tableName + " WHERE ID=@p1";

            SqlParameter[] pInsert = new SqlParameter[4];
            SqlParameter[] pUpdate = new SqlParameter[5];
            SqlParameter[] pDelete = new SqlParameter[1];

            pInsert[0] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Barcode");
            pInsert[1] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Item");
            pInsert[2] = new SqlParameter("@p4", SqlDbType.VarChar, 255, "Price");
            pInsert[3] = new SqlParameter("@p5", SqlDbType.VarChar, 255, "Quantity");

            pUpdate[0] = new SqlParameter("@p1", SqlDbType.Int, 1000, "ID");
            pUpdate[1] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Barcode");
            pUpdate[2] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Item");
            pUpdate[3] = new SqlParameter("@p4", SqlDbType.VarChar, 255, "Price");
            pUpdate[4] = new SqlParameter("@p5", SqlDbType.VarChar, 255, "Quantity");

            pDelete[0] = new SqlParameter("@p1", SqlDbType.VarChar, 255, "ID");

            var cmdInsert = new SqlCommand(sInsert, sqlconn);
            var cmdUpdate = new SqlCommand(sUpdate, sqlconn);
            var cmdDelete = new SqlCommand(sDelete, sqlconn);

            cmdInsert.Parameters.AddRange(pInsert);
            cmdUpdate.Parameters.AddRange(pUpdate);
            cmdDelete.Parameters.AddRange(pDelete);

            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmdInsert;
            da.UpdateCommand = cmdUpdate;
            da.DeleteCommand = cmdDelete;
            da.Update(ds, tableName);
            ds.AcceptChanges();
        }

        public void dropTable(string tableName)
        {
            using (sqlconn = new SqlConnection(strConn))
            {
                string query = "DROP TABLE @tableName";
                SqlCommand sqlComm = new SqlCommand(query, sqlconn);
                sqlComm.Parameters.AddWithValue("@tableName", tableName);
                sqlComm.ExecuteNonQuery();
            }
        }
    }
}
