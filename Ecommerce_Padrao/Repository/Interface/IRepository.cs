using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository
    {
        string RepositoryType();

        T Get<T>(int id);

        T Save<T>(T objeto);

        T Search<T>(T parameters);
    }
}
