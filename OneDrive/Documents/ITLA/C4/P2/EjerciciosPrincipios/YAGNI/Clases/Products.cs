namespace YAGNI.Clases;

public class Products
{
    public int idProduct { get; set; }
    public string nameProduct { get; set; }
    public decimal priceProduct { get; set; }

    public Products(int id, string name, decimal price)
    {
        idProduct = id;
        nameProduct = name;
        priceProduct = price;
    }
}