using StateDesignPattern.Context;

public class Program
{
    public static void Main()
    {
        Order order = new Order();

        order.ProcessOrder(); // Output: Order is being processed.
        order.CancelOrder(); // Output: Order is canceled.

        order.ProcessOrder(); // Output: Order is being processed.
        order.ProcessOrder(); // Output: Order is already being processed.
    }
}