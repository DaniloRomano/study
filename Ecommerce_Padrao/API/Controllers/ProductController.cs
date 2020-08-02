using Default.Return;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Product.Interface;
using Service.Product.Request;
using Service.Product.Response;
using System.Collections.Generic;
using Transformer.Product;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Authorize(Roles = "atendente")]
        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(DefaultReturn<IEnumerable<ProductListResponse>>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Get(
            [FromServices] ITransformerProduct _transformer,
            [FromServices] IProductService _productService
            )
        {
            try
            {
                DefaultReturn<IEnumerable<ProductListResponse>> response = new DefaultReturn<IEnumerable<ProductListResponse>>();
                response.dataReturn = _transformer.ParseListProductToResponse(_productService.GetProducts());
                return StatusCode(200, response);
            }
            catch (System.Exception)
            {
                throw new System.Exception("Erro");
            }
        }

        [Authorize(Roles = "atendente")]
        [HttpPost]
        [Route("save")]
        [ProducesResponseType(typeof(DefaultReturn<bool>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Save(
            [FromServices] ITransformerProduct _transformer,
            [FromServices] IProductService _product,
            [FromBody] ProductSaveRequest request
            )
        {
            try
            {
                DefaultReturn<bool> response = new DefaultReturn<bool>();
                response.dataReturn = _product.Save(_transformer.ParseSaveRequestToProduct(request));
                return StatusCode(200, response);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [Authorize(Roles = "atendente")]
        [HttpPost]
        [Route("search")]
        [ProducesResponseType(typeof(DefaultReturn<List<ProductSearchResponse>>), 200)]
        [ProducesResponseType(typeof(DefaultReturn<object>), 400)]
        public IActionResult Search(
            [FromServices] ITransformerProduct _transformer,
            [FromServices] IProductService _product,
            [FromBody] ProductSearchRequest search
            )
        {
            try
            {
                DefaultReturn<List<ProductSearchResponse>> response = new DefaultReturn<List<ProductSearchResponse>>();
                response.dataReturn = _transformer.ParseProductToSearchList(_product.Search(_transformer.ParseSearchRequestToProduct(search)));

                return StatusCode(200, response);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}