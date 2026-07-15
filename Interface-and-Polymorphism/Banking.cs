public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Processing credit card with the amount of {amount}");
    }
}

public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        System.Console.WriteLine($"Processing paypal payment with the amount of {amount}");
    }
}

public class PaymentService
{
    private readonly IPaymentProcessor _processor;

    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _processor.ProcessPayment(amount);
    }
}
