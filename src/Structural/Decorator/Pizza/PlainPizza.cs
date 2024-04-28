namespace Decorator.Pizza;
internal class PlainPizza : IPizza
{
    public string MakePizza()
    {
        return "Plain Pizza";
    }
}
