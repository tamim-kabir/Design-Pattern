﻿using FactoryMethod;

ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}


Console.WriteLine();
creditCard = new MoneyBackFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
}