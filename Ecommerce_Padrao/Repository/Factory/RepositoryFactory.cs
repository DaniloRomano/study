using Enum.Repository;
using Repository.Class.Product.Database;
using Repository.Class.Product.ElasticSearch;
using Repository.Interface;

namespace Repository.Factory
{
    public class RepositoryFactory
    {
        public IRepository GetRepository(EnumRepository repository, EnumRepositoryType type)
        {
            IRepository obj = null;
            switch (repository)
            {
                case EnumRepository.product:
                    switch (type)
                    {
                        case EnumRepositoryType.Database:
                            obj = new ProductDatabase();
                            break;
                        case EnumRepositoryType.ElasticSearch:
                            obj = new ProductElasticSearch();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            return obj;
        }
    }
}
