using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Database
    {
        SqlConnection _connection;
        private string _connectionString;
        public Database(string _connectionString)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void AddData(AddressDetails details)
        {
            string sqlQuery = $"Insert into addressbook values({details.Name}, )";
            SqlCommand cmd = new SqlCommand(sqlQuery, _connection);
            cmd.ExecuteNonQuery();

        }
        public void EditData(AddressDetails details)
        {
            string sqlQuery = $"update addressbook set mobilenumber={details.MobileNum} where username={details.Name}";
            SqlCommand cmd = new SqlCommand(sqlQuery, _connection);
            cmd.ExecuteNonQuery();
        }
        public void DeleteData(AddressDetails details)
        {
            string sqlQuery = $"delete from addressbook where username={details.Name}";
            SqlCommand cmd = new SqlCommand(sqlQuery, _connection);
            cmd.ExecuteNonQuery();
        }
    }
}
