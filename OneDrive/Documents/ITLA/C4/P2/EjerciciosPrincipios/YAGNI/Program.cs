using YAGNI.Clases;

namespace YAGNI 
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            decimal price; 
            int opcion;
            ProductService productoCreado = new ProductService();
            do
            {
                opcion = ValidarInt(@"Seleccione una opción:   
                              1. Agregar producto 
                              2. Eliminar producto
                              3. Salir");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del producto:");
                        string name = Console.ReadLine()!;
                        if (!string.IsNullOrEmpty(name))
                        {
                            do
                            {
                                Console.WriteLine("Ingrese el precio: ");
                            } while (!decimal.TryParse(Console.ReadLine(), out price) || price < 1);

                            
                            productoCreado.AddProduct(name, price);
                        }
                        else
                        {
                            Console.WriteLine("El nombre no puede estar vacio");
                        }

                        break;
                    case 2:
                        int idToDelete = ValidarInt("Ingrese el id del producto: ");
                       
                        productoCreado.DeleteProduct(idToDelete);
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Esta opcion no está disponible");
                        break;
                }
            } while (opcion != 3);
        }
        static int ValidarInt(string mensaje)
        {
            int numero;
            do
            {
                Console.WriteLine(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out numero));
            return numero;
        }
    }
}