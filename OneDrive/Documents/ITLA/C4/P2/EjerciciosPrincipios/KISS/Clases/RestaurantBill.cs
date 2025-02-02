namespace KISS.Clases;
public class RestaurantBill
{ public decimal CalculateTotal(decimal[] prices, decimal tipPercentage = 10)
        {
            decimal subtotal = prices.Sum();
            decimal tipAmount = subtotal * (tipPercentage / 100);
            return subtotal + tipAmount;
        }
}