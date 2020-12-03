using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetDataAccessLayer.Models;

namespace VetDataAccessLayer
{
    public class VeterinarRepository
    {
        public List<Veterinar> GetAllVeterinars()
        {
            List<Veterinar> veterinars = new List<Veterinar>();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Veterinari";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Veterinar v = new Veterinar();
                    v.Id = sqlDataReader.GetInt32(0);
                    v.FullName = sqlDataReader.GetString(1);
                    v.Specialy = sqlDataReader.GetString(2);
                    v.Years = sqlDataReader.GetInt32(3);
                    veterinars.Add(v);
                }
            }
            return veterinars;
        }

        public int InsertVeterinar(Veterinar v)
        {
            List<Veterinar> veterinars = new List<Veterinar>();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format(
                    "INSERT INTO Veterinari VALUES ('{0}','{1}',{2})"
                    , v.FullName, v.Specialy, v.Years
                    );

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

