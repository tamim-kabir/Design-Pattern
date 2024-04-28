namespace FactoryMethod;

internal class PlatinumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        return new Platinum();
    }
}
