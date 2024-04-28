namespace FactoryMethod;

internal class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        return new Titanium();
    }
}
