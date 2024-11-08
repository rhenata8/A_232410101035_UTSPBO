using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Core;

namespace UTS_PBO.App.Context
{
    internal class Customer : Database
    {
        private static string table = "users";

        public static DataTable All()
        {
            string query = $"SELECT id, nama, email, username, password FROM {table};";
            return queryExecutor(query);
        }

        public static DataTable GetUserById(int id)
        {
            string query = $"SELECT id, nama, email, username, password FROM {table} WHERE id = @id;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            return queryExecutor(query, parameters);
        }

        public static void AddUser(Customer newUser)
        {
            string query = $"INSERT INTO {table} (nama, email, password) VALUES(@nama, @email, @password);";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", newUser.nama),
                new NpgsqlParameter("@email", newUser.email),
                new NpgsqlParameter("@password", newUser.password)
            };

            commandExecutor(query, parameters);
        }
    }
}
