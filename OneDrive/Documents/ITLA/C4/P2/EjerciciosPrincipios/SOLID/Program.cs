using SOLID.Clases;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID");
            MessagesService messages = new MessagesService();
            int option;
            string message;
            do
            {
                Console.WriteLine(@"Seleccione el tipo de notificación:
                                1. Email
                                2. SMS");
            } while (!int.TryParse(Console.ReadLine(), out option));
            switch (option)
            {
                case 1:
                    Console.Write("Ingrese el email: ");
                    string email = Console.ReadLine()!;
                    Console.Write($"Ingrese el mensaje para {email}: ");
                    message = Console.ReadLine()!;
                    if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message)) {
                        Console.WriteLine("Email o mensaje inválido. Intente otra vez.");
                       
                    }else {
                         messages.SendEmail(email, message);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de sms");
                    string phoneNumber = Console.ReadLine()!;
                    Console.Write($"Ingrese el mensaje para {phoneNumber}: ");
                    message = Console.ReadLine()!;
                    if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(message)) {
                        Console.WriteLine("Numero o mensaje inválido. Intente otra vez.");
                    }else {
                        messages.SendEmail(phoneNumber, message);
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.WriteLine("Notificacion registrada en logs");
        }
    }
}