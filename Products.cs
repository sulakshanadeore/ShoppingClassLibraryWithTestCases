namespace ShoppingClassLibrary
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int Price { get; set; }


        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Products other = (Products)obj;
            return ProductID == other.ProductID && ProductName == other.ProductName && Price == other.Price;
        }
      

    }
}
