using Service.Product.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Service.Product
{
    public class ProductService : IProductService
    {
        List<Models.Product.Product> products = new List<Models.Product.Product>
            {
                new Models.Product.Product
                {
                    id=1,
                    name="product 1",
                    description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
                },
                new Models.Product.Product
                {
                    id=2,
                    name="product 2",
                    description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
                },
                new Models.Product.Product
                {
                    id=3,
                    name="product 3",
                    description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
                },
                new Models.Product.Product
                {
                    id=4,
                    name="product 4",
                    description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
                },
                new Models.Product.Product
                {
                    id=5,
                    name="product 5",
                    description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
                },
                new Models.Product.Product
                {
                    id=6,
                    name="product 6",
                    description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
                }
            };



        public List<Models.Product.Product> GetProducts()
        {
            return products;
        }

        public bool Save(Models.Product.Product product)
        {
            return true;
        }

        public List<Models.Product.Product> Search(Models.Product.Product product)
        {
            return products.Where(x => x.name.Contains(product.name) || x.id == product.id || x.description.Contains(product.description)).ToList();
        }
    }
}
