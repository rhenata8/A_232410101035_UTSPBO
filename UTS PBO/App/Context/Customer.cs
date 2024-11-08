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
            string query = @"
        SELECT 
            m.id,
            m.nama,
            m.email,
            m.username,
            m.password,
           FROM 
            users m
        WHERE 
                    m.id = @id;

                DataTable datausers = queryExecutor(query);
                return datausers;
            }

            public static DataTable getusersById(int id)
            {
                string query = @""
        SELECT 
            m.id,
            m.nama,
            m.email,
            m.username,
            m.password,
        FROM 
            users m
            WHERE 
                    m.id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable datausers = queryExecutor(query, parameters);
            return datausers;
        }


        public static void Addusers(Admin usersBaru)
        {
            string query = $"INSERT INTO {table} (nama, email, password) VALUES(@nama, @email, @password)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", usersBaru.nama),
                new NpgsqlParameter("@email", usersBaru.email),
                new NpgsqlParameter("@password", usersBaru.password)
            };

            commandExecutor(query, parameters);
        }
    }
}
