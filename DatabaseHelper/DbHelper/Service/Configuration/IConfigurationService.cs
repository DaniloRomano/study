using System;
using System.Collections.Generic;
using System.Text;

namespace DbHelper.Service
{
    public interface IConfigurationService
    {
        string GetConnectionString(string ConnectionString);
    }
}
