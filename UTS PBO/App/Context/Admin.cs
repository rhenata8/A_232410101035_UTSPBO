using Npgsql;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO.App.Core;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using UTS_PBO.App.Models;

namespace UTS_PBO.App.Context
{
    using System.Data;
using Npgsql;
using UTS_PBO.App.Core;

namespace UTS_PBO.App.Context
{
    internal class Admin : Database
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

        public static void AddUser(Admin newUser)
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

    }





  
