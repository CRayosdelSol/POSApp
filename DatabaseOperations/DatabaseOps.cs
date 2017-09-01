using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace DatabaseOperations
{
    public class DatabaseOps
    {
        /*
                public string FileName;
        */

        private SqlConnection _sqlconn;

        private string StrConn { get; }

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
            var path = filename; //Obtains the absolute path to the databse.
            var databaseName = Path.GetFileNameWithoutExtension(path); //Derived  database name.
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
                        $"EXEC sp_detach_db '{databaseName}', 'true'";
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool CheckForTableExistence(string tableName)
        {
            int check;
            using (_sqlconn = new SqlConnection(StrConn))
            {
                var checkExistence = @"IF EXISTS(SELECT*FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + "'" + tableName + "') SELECT 1 ELSE SELECT 0";
                _sqlconn.Open();
                var sqlCommand = new SqlCommand(checkExistence, _sqlconn);
                check = Convert.ToInt32(sqlCommand.ExecuteScalar());
                _sqlconn.Close();
            }

            return check != 0;
        }

        public void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string dataTypeB, string attributeC, string dataTypeC, string attributeD, string dataTypeD, string attributeE, string dataTypeE)
        {
            using (var sqlconn = new SqlConnection(StrConn))
            {
                if (CheckForTableExistence(tableName)) return;
                sqlconn.Open();
                var temp = $"CREATE TABLE {tableName}(" + $"{attributeA} {dataTypeA}," + $"{attributeB} {dataTypeB}," +
                           $"{attributeC} {dataTypeC}," + $"{attributeD} {dataTypeD}," + $"{attributeE} {dataTypeE});";

                var createTableCommand = temp;
                var sqlCommand = new SqlCommand(createTableCommand, sqlconn);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void UpdateDataset(DataSet ds, string tableName)
        {
            _sqlconn = new SqlConnection(StrConn);

            var sInsert = "INSERT INTO " + tableName + "(Barcode,Item,Price,Quantity) values(@p2,@p3,@p4,@p5)";

            var sUpdate = "UPDATE " + tableName + " SET Barcode=@p2,Item=@p3,Price=@p4,Quantity=@p5 where ID=@p1";

            var sDelete = "DELETE FROM " + tableName + " WHERE ID=@p1";

            SqlParameter[] pInsert = new SqlParameter[4];
            SqlParameter[] pUpdate = new SqlParameter[5];
            SqlParameter[] pDelete = new SqlParameter[1];

            pInsert[0] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Barcode");
            pInsert[1] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Item");
            pInsert[2] = new SqlParameter("@p4", SqlDbType.SmallMoney, 255, "Price");
            pInsert[3] = new SqlParameter("@p5", SqlDbType.VarChar, 255, "Quantity");

            pUpdate[0] = new SqlParameter("@p1", SqlDbType.Int, 1000, "ID");
            pUpdate[1] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Barcode");
            pUpdate[2] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Item");
            pUpdate[3] = new SqlParameter("@p4", SqlDbType.SmallMoney, 255, "Price");
            pUpdate[4] = new SqlParameter("@p5", SqlDbType.VarChar, 255, "Quantity");

            pDelete[0] = new SqlParameter("@p1", SqlDbType.VarChar, 255, "ID");

            var cmdInsert = new SqlCommand(sInsert, _sqlconn);
            var cmdUpdate = new SqlCommand(sUpdate, _sqlconn);
            var cmdDelete = new SqlCommand(sDelete, _sqlconn);

            cmdInsert.Parameters.AddRange(pInsert);
            cmdUpdate.Parameters.AddRange(pUpdate);
            cmdDelete.Parameters.AddRange(pDelete);

            var da = new SqlDataAdapter
            {
                InsertCommand = cmdInsert,
                UpdateCommand = cmdUpdate,
                DeleteCommand = cmdDelete
            };
            da.Update(ds, tableName);
            ds.AcceptChanges();
        }

/*
        public void DropTable(string tableName)
        {
            using (_sqlconn = new SqlConnection(StrConn))
            {
                _sqlconn.Open();
                var query = "DROP TABLE @tableName";
                var sqlComm = new SqlCommand(query, _sqlconn);
                sqlComm.Parameters.AddWithValue("@tableName", tableName);
                sqlComm.ExecuteNonQuery();
                _sqlconn.Close();
                SqlConnection.ClearAllPools();
            }
        }
*/
    }
}
