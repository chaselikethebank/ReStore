namespace API.Entities
{
    public class Product
    // represents a colum in the products table in the DB 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long Price { get; set; }

        public string  PictureUrl { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; }

        public int QuantityInStock { get; set; }
                
        public string Make { get; set; }

        public string Difficulty { get; set; }  

        public string Notes { get; set; }



    }
}