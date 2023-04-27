using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQprogram
{
    public class Mangement
    {
        public void topRecords(List<ProductModel> products)
        {
            var RecordData = (from Product in products
                             orderby Product.Rating descending
                             select Product).Take(3);
            foreach (var record in RecordData)
            {
                Console.WriteLine(record.ProductId+" "+record.UserId+" "+record.Rating+" "+record.IsLike);
            }
        }
        public void SelectedRecords(List<ProductModel> productsModel)
        {
            var RecordData = from Product in productsModel
                             where (Product.ProductId == 1 && Product.Rating >3)||
                             (Product.ProductId == 4 && Product.Rating>3 )||
                             (Product.ProductId == 9 && Product.Rating > 3)
                             select Product;
            foreach (var record in RecordData)
            {
                Console.WriteLine(record.ProductId + " " + record.UserId + " " + record.Rating + " " + record.IsLike);
            }
        }
        public void RetriewCountofRecords(List<ProductModel> products)
        {
            var RecordData = products.GroupBy(x => x.ProductId).Select(x => new { productId = x.Key, count = x.Count() });
            foreach (var record in RecordData)
            {
                Console.WriteLine(record.productId + " " + record.count);
            }
        }
        public void RetriewIdandReview(List<ProductModel> products)
        {
            var RecordData = from product in products
                             select
                             new { productid = product.ProductId, review = product.Review };
            foreach (var record in RecordData)
            {
                Console.WriteLine(record.productid+ " " + record.review);
            }
        }
    }
}
