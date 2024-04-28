namespace Decorator.Pizza;

internal class MasalaPizzaDecorator(IPizza pizza) : PizzaDecorator(pizza)
{
    public override string MakePizza()
    {
        return base.MakePizza() + ", Masala Added";
    }
}
