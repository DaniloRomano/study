using Dapper;
using Microsoft.Extensions.Configuration;
using Repository.Interface;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Repository.Class.Product.Database
{
    public class ProductDatabase : IRepository
    {
        ConfigurationBuilder config = new ConfigurationBuilder();

        public ProductDatabase()
        {
            config.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), false);
        }

        public string GetConnectionString()
        {
            IConfigurationRoot root = config.Build();
            return root.GetSection("ConnectionStrings").GetSection("mysqlConnection").Value;
        }

        public T Get<T>(int id)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                StringBuilder query = new StringBuilder();
                query.Append("SELECT intId,strName FROM person WHERE intId=@id");

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@id", id);

                return connection.QueryFirstOrDefault<T>(query.ToString(), parameters);
            }
        }

        public string RepositoryType()
        {
            throw new NotImplementedException();
        }

        public T Save<T>(T objeto)
        {
            throw new NotImplementedException();
        }

        public T Search<T>(T parameters)
        {
            throw new NotImplementedException();
        }
    }
}
