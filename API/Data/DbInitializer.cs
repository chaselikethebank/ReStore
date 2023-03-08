using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var Products = new List<Product>
            {
                new Product
{
    Name = "Luxury Signature Armchair",
    Description = "The ultimate in outdoor luxury, this armchair features high-end materials and construction for a comfortable and stylish seating experience.",
    Price = 149999,
    PictureUrl = "/images/products/luxury-armchair.png",
    Brand = "Luxury Patio",
    Type = "Outdoor Seating",
    QuantityInStock = 50
},
new Product
{
    Name = "Chaise Lounge Chair",
    Description = "Relax in style with this outdoor chaise lounge chair, designed for ultimate comfort and durability.",
    Price = 79999,
    PictureUrl = "/images/products/chaise-lounge.png",
    Brand = "Patio Paradise",
    Type = "Outdoor Seating",
    QuantityInStock = 75
},
new Product
{
    Name = "Luxury Signature Ottoman",
    Description = "Complete your outdoor seating set with this luxurious ottoman, designed to perfectly complement our Signature Armchair.",
    Price = 69999,
    PictureUrl = "/images/products/luxury-ottoman.png",
    Brand = "Luxury Patio",
    Type = "Outdoor Seating",
    QuantityInStock = 40
},
new Product
{
    Name = "Luxury Patio Table",
    Description = "Host the ultimate outdoor dinner party with this luxurious patio table, designed for both style and functionality.",
    Price = 249999,
    PictureUrl = "/images/products/luxury-table.png",
    Brand = "Luxury Patio",
    Type = "Outdoor Tables",
    QuantityInStock = 20
},
new Product
{
    Name = "Outdoor Fire Pit",
    Description = "Stay warm and cozy on chilly nights with this stylish outdoor fire pit, perfect for gathering around with friends and family.",
    Price = 89999,
    PictureUrl = "/images/products/outdoor-fire-pit.png",
    Brand = "Patio Paradise",
    Type = "Outdoor Heating",
    QuantityInStock = 30
},
new Product
{
    Name = "Outdoor Speakers",
    Description = "Bring the party outside with these high-quality outdoor speakers, designed for crisp and clear sound even in outdoor environments.",
    Price = 159999,
    PictureUrl = "/images/products/outdoor-speakers.png",
    Brand = "Audio Oasis",
    Type = "Outdoor Audio",
    QuantityInStock = 15
},
new Product
{
    Name = "Luxury Patio Sofa",
    Description = "Create the ultimate outdoor living room with this luxurious patio sofa, perfect for relaxing and entertaining in style.",
    Price = 199999,
    PictureUrl = "/images/products/luxury-sofa.png",
    Brand = "Luxury Patio",
    Type = "Outdoor Seating",
    QuantityInStock = 25
},
new Product
{
    Name = "Outdoor Hammock",
    Description = "Relax in the great outdoors with this comfortable and durable outdoor hammock, designed for ultimate relaxation.",
    Price = 129999,
    PictureUrl = "/images/products/outdoor-hammock.png",
    Brand = "Patio Paradise",
    Type = "Outdoor Seating",
    QuantityInStock = 50
},
new Product
{
    Name = "Luxury Patio Umbrella",
    Description = "Stay cool and comfortable in the shade with this stylish and durable patio umbrella, designed to perfectly complement your outdoor seating set.",
    Price = 79999,
    PictureUrl = "/images/products/luxury-umbrella.png",
    Brand = "Luxury Patio",
    Type = "Outdoor Umbrellas",
    QuantityInStock = 35
},
            };

            // context.Products.AddRange(Products)

            foreach (var product in Products)
            {
                context.Products.Add(product);
            }   

            context.SaveChanges();
        }
    }
}