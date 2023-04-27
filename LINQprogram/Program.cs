namespace LINQprogram
{
    public class Program
    {
       public static void Main(string[] args)
        {
            List<ProductModel> products = new List<ProductModel>()
            { new ProductModel {ProductId = 1,UserId = 10 ,Rating = 4,IsLike = true,Review = "Good"},
              new ProductModel {ProductId = 2,UserId = 20 ,Rating = 4.5,IsLike = true,Review = "Good"},
              new ProductModel {ProductId = 3,UserId = 30 ,Rating = 2,IsLike = false,Review = "Bad"},
              new ProductModel {ProductId = 3,UserId = 40 ,Rating = 5.5,IsLike = true,Review = "Good"},
              new ProductModel {ProductId = 5,UserId = 50 ,Rating = 2.2,IsLike = false,Review = "Bad"},
              new ProductModel {ProductId = 5,UserId = 60 ,Rating = 6.6,IsLike = true,Review = "Good"},
              new ProductModel {ProductId = 7,UserId = 70 ,Rating = 6.7,IsLike = true,Review = "Good"},
              new ProductModel {ProductId = 7,UserId = 80 ,Rating = 9.2,IsLike = true, Review = "Good"},
              new ProductModel {ProductId = 7,UserId = 90 ,Rating = 2.3,IsLike = false,Review = "Bad"}
            };
            Mangement Mangement = new Mangement();
            // Mangement.topRecords(products);
            //Mangement.SelectedRecords(products);
            // Mangement.RetriewCountofRecords(products);
            Mangement.RetriewIdandReview(products);
        }  

    }
}