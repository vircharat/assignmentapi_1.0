using Microsoft.EntityFrameworkCore;
using MyyDAL.Repost;
using MyyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyyBLL.services
{
    public class ProductService
    {
        Iproduct _iproduct;
        
        public static int code1 = 0;

      
       
        public static int code3 = 10000000;
        private static Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    
        public ProductService(Iproduct iProduct)
        {
            _iproduct = iProduct;
        }

        public void AddProduct(Product product)
        {

            if (product.channelId == 1)
            {
                product.productCode = codegenerator1(product.productYear);

            }
            else if (product.channelId == 2)
            {

                product.productCode = codegenerator2(product.productId);
            }
            else if (product.channelId == 3)
            {
                product.productCode =codegenerator3();
            }
            _iproduct.AddProduct(product);
        }

        public string codegenerator1(int productYear)
        {
            
           
            int a = (productYear*1000) + (++code1);
           
            

            return a.ToString();
        }

        public string codegenerator2(int productId)
        {
            string code;
           
            code = AlphanumericGenerator(6);


            return code;
        }

        public string codegenerator3()
        {
           

            int a = code3++;

           

            return a.ToString();
            
        }
      
        private string AlphanumericGenerator(int length)
        {
            var result = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }
        
        public void EditProduct(Product Product)
        {
            _iproduct.EditProduct(Product);
        }

        public void RemoveProduct(int productId)
        {
            _iproduct.RemoveProduct(productId);
        }

        public Product GetProductbyId(int productId)
        {
            return _iproduct.GetProductById(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _iproduct.GetProducts();
        }
    }
}
