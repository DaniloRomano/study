using Repository.Interface;
using System;

namespace Repository.Class.Product.Database
{
    public class ProductDatabase : IRepository
    {
        public T Get<T>(int id)
        {
            throw new NotImplementedException();
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
