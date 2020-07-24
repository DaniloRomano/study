using System;
using System.Collections.Generic;
using System.Text;

namespace DbHelper.Repository.Database
{
    public interface IDatabaseRepository
    {
        List<T> Search<T>(string query, object parameters);

        T Get<T>(string query, object parameters);

        T Save<T>(string query, T register);
    }
}
