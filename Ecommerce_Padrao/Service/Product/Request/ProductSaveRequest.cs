using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Product.Request
{
    public class ProductSaveRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }        
    }
}
