namespace YAGNI.Clases;

public class ProductService
{
    private List<Products> _products = new List<Products>();
    private int _id = 0;
    public void AddProduct(string name, decimal price)
    {
        Products productCreated = new Products(_id, name, price);
        _products.Add(productCreated);
        Console.WriteLine($"Product: {name}, Price: {price}, ID: {_id}");
        _id++;
    }

    public void DeleteProduct(int idToDelete)
    {
        Products? productsDeleted = _products.Find(pD => pD.idProduct == idToDelete);
        if (productsDeleted != null)
        {
            _products.Remove(productsDeleted);
            Console.WriteLine($"Product: {idToDelete} deleted");
        }
        else
        {
            Console.WriteLine($"Product: {idToDelete} not found");
        }
        
    }
}