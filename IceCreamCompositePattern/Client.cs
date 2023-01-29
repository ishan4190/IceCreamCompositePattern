using BusinessLayer.Classes;
using BusinessLayer.Interfaces;

public class Client
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Composite Ice Cream");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        //Ice cream toppings
        //Hot Fudge.
        //Sprinkles.
        //Caramel.
        //Oreos.
        bool isNotDoneAddingToppings = true;
        var product = new CompositeIngredients();
        while (isNotDoneAddingToppings)
        {
            Console.WriteLine();
            Console.WriteLine("\n \n Please pick from the list of toppings: \n 1. Vanilla IceCream \n 2. Choclate IceCream \n 3. Hot Fudge \n 4. Sprinkles \n 5.Exit \n ");
            int componentCode = Convert.ToInt32(Console.ReadLine());
            if (componentCode == 5) break;
            product.AddNewIngredient(CreateIngredientFactory(componentCode));
            Console.Clear();
        }

        Console.WriteLine("Final Recipe");
        Console.WriteLine("---------------");
        Console.WriteLine(product.AddIngredients());


    }

    public static IIngredients CreateIngredientFactory(int code)
    {
        switch (code)
        {
            case 1: return new VanillaIceCream();
            case 2: return new ChoclateIceCream();
            case 3: return new HotFudge();
            case 4: return new Sprinkles();
            default: return new VanillaIceCream();
        }
    }
}