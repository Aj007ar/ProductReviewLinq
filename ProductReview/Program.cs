namespace ProductReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");
            Console.WriteLine("\n1.Add Values to list\nEnter Option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review 
            List<ProductReviews> productReviews = new List<ProductReviews>();
            switch (option)
            {
                case 1:
                    Products.AddingProductReview(productReviews);
                    break;

            }
        }
    }
}