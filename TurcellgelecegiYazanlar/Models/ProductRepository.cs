namespace TurcellgelecegiYazanlar.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new () { Id = 1, Name = "Kalem1", price = 100, Stock = 100 },
            new () { Id = 2, Name = "Kalem2", price = 200, Stock = 200 },
            new () { Id = 3, Name = "Kalem3", price = 300, Stock = 300 }
        };

        public List<Product> GetAll() => _products;

        public void Add(Product newProduct) => _products.Add(newProduct);
        
        public void Remove(int id)
        {
            var hasProducts = _products.FirstOrDefault(x => x.Id == id);
            if(hasProducts == null)
            {
                throw new Exception($"Bu id({id})bulunmamaktadır.");
            }
            _products.Remove(hasProducts);
        }

        public void Update(Product updateProduct)
        {
            var hasProducts = _products.FirstOrDefault(x => x.Id == updateProduct.Id);
            if (hasProducts == null)
            {
                throw new Exception($"Bu id({updateProduct.Id}) bulunmamaktadır.");
            }
            hasProducts.Name = updateProduct.Name;
            hasProducts.price = updateProduct.price;
            hasProducts.Stock = updateProduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateProduct.Id);
            _products[index] = updateProduct;
        }

    }
}
