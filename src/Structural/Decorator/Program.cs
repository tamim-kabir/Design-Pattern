using Decorator;
using Decorator.Pizza;

ICar bmwCar1 = new BMWCar();
//Calling the ManufactureCar method will create the BMWCar without an engine
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1 + "\n");

//Adding Diesel Engine to the bmwCar1
//Create an instance DieselCarDecorator class and 
//pass existing bmwCar1 as an argument to the Constructor which we want to decorate
DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
//Calling the ManufactureCar method on the carWithDieselEngine object will add Diesel Engine to the bmwCar1 car
carWithDieselEngine.ManufactureCar();
Console.WriteLine();

//The Process is the same for adding Petrol Engine to the existing Car
ICar bmwCar2 = new BMWCar();
PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
carWithPetrolEngine.ManufactureCar();
Console.ReadKey();

//Pizza

var pizza = new PlainPizza();
Console.WriteLine(pizza.MakePizza());

var pizzaDecorator = new ChickenPizzaDecorator(pizza);
Console.WriteLine(pizzaDecorator.MakePizza());

var masalaDecorator = new MasalaPizzaDecorator(pizza);
Console.WriteLine(masalaDecorator.MakePizza());