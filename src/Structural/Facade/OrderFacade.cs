namespace Facade;

internal class OrderFacade
{
    public void PlaceOrder()
    {
        Console.WriteLine("Place Order Started");
        //Get the Product Details
        Product product = new Product();
        product.GetProductDetails();
        //Make the Payment
        Payment payment = new Payment();
        payment.MakePayment();
        //Send the Invoice
        Invoice invoice = new Invoice();
        invoice.SendInvoice();
        Console.WriteLine("Order Placed Successfully");
    }
}
