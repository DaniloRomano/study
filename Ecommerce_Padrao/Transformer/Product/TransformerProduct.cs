using Service.Product.Request;
using Service.Product.Response;
using System.Collections.Generic;

namespace Transformer.Product
{
    public class TransformerProduct : ITransformerProduct
    {
        public IEnumerable<ProductListResponse> ParseListProductToResponse(IEnumerable<Models.Product.Product> products)
        {
            List<ProductListResponse> productListResponses = new List<ProductListResponse>();

            foreach (Models.Product.Product product in products)
            {
                productListResponses.Add(ParseProductToResponse(product));
            }

            return productListResponses;
        }

        public ProductListResponse ParseProductToResponse(Models.Product.Product product)
        {
            return new ProductListResponse
            {
                name = product.name,
                description = product.description
            };
        }

        #region Save Method
        public Models.Product.Product ParseSaveRequestToProduct(ProductSaveRequest saveRequest)
        {
            return new Models.Product.Product
            {
                id = 0,
                description = saveRequest.description,
                name = saveRequest.name
            };
        }
        #endregion

        #region Search Method
        public Models.Product.Product ParseSearchRequestToProduct(ProductSearchRequest searchRequest)
        {
            return new Models.Product.Product
            {
                id = searchRequest.id,
                name = searchRequest.name,
                description = searchRequest.description
            };
        }

        public List<ProductSearchResponse> ParseProductToSearchList(List<Models.Product.Product> products)
        {
            List<ProductSearchResponse> responses = new List<ProductSearchResponse>();

            foreach (Models.Product.Product product in products)
            {
                responses.Add(ParseProductToSearchResponse(product));
            }

            return responses;
        }

        public ProductSearchResponse ParseProductToSearchResponse(Models.Product.Product product)
        {
            return new ProductSearchResponse
            {
                description = product.description,
                name = product.name
            };
        }
        #endregion
    }
}
