namespace FactoryMethod;

internal class MoneyBackFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        return new MoneyBack();
    }
}
