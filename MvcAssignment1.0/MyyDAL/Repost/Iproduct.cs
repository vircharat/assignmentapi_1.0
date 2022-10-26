using MyyEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyyDAL.Repost
{
    public interface Iproduct
    {
        void AddProduct(Product product);

        void RemoveProduct(int productId);

        void EditProduct(Product product);

        Product GetProductById(int productId);

        IEnumerable<Product> GetProducts();
    }
}
