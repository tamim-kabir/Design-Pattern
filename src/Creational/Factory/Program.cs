
using Factory;

var cardDetails = CreditCardFactory.GetCreditCard("Titanium");

Console.WriteLine("CardType : " + cardDetails?.GetCardType());
Console.WriteLine("CreditLimit : " + cardDetails?.GetCreditLimit());
Console.WriteLine("AnnualCharge :" + cardDetails?.GetAnnualCharge());
