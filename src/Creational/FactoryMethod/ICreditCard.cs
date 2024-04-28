namespace FactoryMethod;

internal interface ICreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}
