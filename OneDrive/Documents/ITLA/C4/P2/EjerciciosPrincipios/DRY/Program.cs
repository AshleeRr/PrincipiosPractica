using DRY.Clases;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payroll pay = new Payroll();
            Console.WriteLine("DRY");
            int tipoEmpleado = ValidarInt("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo) ");
            decimal baseSalary = 0;
            switch (tipoEmpleado)
            {
                case 1:
                    baseSalary = ValidarDecimal("Ingrese el salario base: ");
                    baseSalary = pay.CalculateSalary(baseSalary);
                    Console.WriteLine("Salario final: " + baseSalary);
                    break;
                case 2:
                    int hoursWorked = ValidarInt("Ingrese las horas trabajadas: ");
                    decimal hourlyRate = ValidarDecimal("Ingrese la tasa por hora: ");
                    baseSalary = hourlyRate * hoursWorked;
                    baseSalary = pay.CalculateSalary(baseSalary);
                    Console.WriteLine("Salario final: " + baseSalary);
                    break;
                default: Console.WriteLine("Opcion Invalida"); break;
            }
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
        static decimal ValidarDecimal(string mensaje)
        {
            decimal numeroDec;
            do
            {
                Console.WriteLine(mensaje);
            } while (!decimal.TryParse(Console.ReadLine(), out numeroDec));
            return numeroDec;
        }
    }
}