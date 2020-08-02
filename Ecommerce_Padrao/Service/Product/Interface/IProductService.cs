using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Product.Interface
{
    public interface IProductService
    {
        List<Models.Product.Product> GetProducts();

        bool Save(Models.Product.Product product);

        List<Models.Product.Product> Search(Models.Product.Product product);
        
    }
}
