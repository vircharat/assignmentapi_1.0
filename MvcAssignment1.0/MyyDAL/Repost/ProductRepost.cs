using Microsoft.EntityFrameworkCore;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyyDAL.Repost
{
    public class ProductRepost : Iproduct
    {

        DBContext _dbContext;
        public ProductRepost(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void AddProduct(Product Product)
        {

            _dbContext.product_tbl.Add(Product);
            _dbContext.SaveChanges();
        }



        public void EditProduct(Product Product)
        {
            _dbContext.Entry(Product).State = EntityState.Modified;

            _dbContext.SaveChanges();

        }

        public Product GetProductById(int productId)
        {
            return _dbContext.product_tbl.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.product_tbl.ToList();
        }

        public void RemoveProduct(int productId)
        {
            var Producte = _dbContext.product_tbl.Find(productId);
            _dbContext.product_tbl.Remove(Producte);
            _dbContext.SaveChanges();
        }
    }
}
