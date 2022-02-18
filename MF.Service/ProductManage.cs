using System;
using System.Collections.Generic;
using System.Text;
using MF.Domain;
namespace MF.Service
{
    public delegate IList<Product> FindDelege(IList<Product> l, string lettre);
 public   class ProductManage
    {
        IList<Product> products;
        public FindDelege FindProduct { get; set; }
        public ProductManage(IList<Product>list)
        {
            products = list;
        }
        public IList<Product>FindProductMethode(FindDelege f,string chaine)
        {
            return f(products, chaine);
        }
    }
}
