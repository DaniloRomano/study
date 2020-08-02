using Service.Product.Request;
using Service.Product.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transformer.Product
{
    public interface ITransformerProduct
    {
        IEnumerable<ProductListResponse> ParseListProductToResponse(IEnumerable<Models.Product.Product> products);

        ProductListResponse ParseProductToResponse(Models.Product.Product product);

        #region SaveMethod
        Models.Product.Product ParseSaveRequestToProduct(ProductSaveRequest saveRequest);
        #endregion

        #region SearchMethod
        Models.Product.Product ParseSearchRequestToProduct(ProductSearchRequest searchRequest);

        List<ProductSearchResponse> ParseProductToSearchList(List<Models.Product.Product> products);

        ProductSearchResponse ParseProductToSearchResponse(Models.Product.Product product);
        #endregion
    }
}
