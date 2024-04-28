namespace Decorator.Pizza;
internal class ChickenPizzaDecorator(IPizza pizza) : PizzaDecorator(pizza)
{
    public override string MakePizza()
    {
        return pizza.MakePizza() + ", Chicken Added";
    }
}
