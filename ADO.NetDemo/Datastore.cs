using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace ADO.NetDemo
{
    public class Datastore
    {
        readonly string connectionString = "Server=.;Database=TheBulbDB;Trusted_Connection=True;";

        public List<DotnetFellow> FetchDataById(string Id)
        {
            List<DotnetFellow> fellows = new();

            using SqlConnection connection = new(connectionString);

            string query = "select * from DotnetFellows where Id = '"+Id+"'";

            SqlCommand command = new(query, connection);

            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                fellows.Add(new DotnetFellow
                {
                    Id = reader["Id"].ToString(),
                    Firstname = reader["Firstname"].ToString(),
                    Middlename = reader["Middlename"].ToString(),
                    Lastname = reader["Lastname"].ToString(),
                    GenderId = (int)reader["GenderId"],
                    StateId = (int)reader["StateId"],
                    HasGraduated = reader["HasGraduated"].ToString() == "1"
                });
            }

            connection.Close();

            return fellows;
        }

        public bool AddFellow(DotnetFellow newFellow)
        {
            using SqlConnection conn = new(connectionString);

            string sql = $"INSERT into DotnetFellows VALUES ( '{newFellow.Id}', '{newFellow.Firstname}', '{newFellow.Middlename}', '{newFellow.Lastname}', {newFellow.GenderId}, {newFellow.StateId}, {(newFellow.HasGraduated ? 0 : 1)})";

            using SqlCommand com = new(sql, conn);

            conn.Open();

            int affectedRows = 0;
            try
            {
                affectedRows = com.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return affectedRows > 0;
        }
    }
}

/*
 * ADO - ActiveX Data Object
 * 
 * OLEDB
 * ORACLEDB
 * SQL
 * ODBC
 */
