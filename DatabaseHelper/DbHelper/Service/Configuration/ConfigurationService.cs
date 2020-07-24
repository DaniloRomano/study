using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DbHelper.Service
{
    public class ConfigurationService : IConfigurationService
    {
        ConfigurationBuilder builder = new ConfigurationBuilder();
        public ConfigurationService()
        {
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(),"AppConfig.json"),false);
        }

        public string GetConnectionString(string ConnectionString)
        {
            IConfigurationRoot root = builder.Build();
            return root.GetSection("ConnectionString").GetSection(ConnectionString).Value;
        }
    }
}
