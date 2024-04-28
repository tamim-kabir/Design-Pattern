namespace Decorator.Pizza;

internal abstract class PizzaDecorator : IPizza
{
    public IPizza pizza;
    protected PizzaDecorator(IPizza pizza)
    {
        this.pizza = pizza;
    }
    public virtual string MakePizza()
    {
        return pizza.MakePizza();
    }
}
