using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Product.Abstract
{
    public abstract class ProductAbstract
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
