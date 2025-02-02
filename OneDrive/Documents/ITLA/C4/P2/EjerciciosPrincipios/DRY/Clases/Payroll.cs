namespace DRY.Clases;

public class Payroll
{
    private const decimal TAX_AMOUNT = 0.18m;
    private const decimal BONUS_AMOUNT = 0.05m;
    
    public decimal CalculateSalary(decimal baseSalary)
    {
        decimal tax = baseSalary * TAX_AMOUNT;
        decimal bonus = baseSalary * BONUS_AMOUNT;
        return baseSalary - tax + bonus;
    }

}