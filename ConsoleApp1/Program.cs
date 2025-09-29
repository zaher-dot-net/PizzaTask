namespace ConsoleApp1;

using Common;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your favorite food (Pizza, Burger, Salad): ");
        string input = Console.ReadLine();
        
        // Try to parse user input into nullable enum
        if (Enum.TryParse<Food>(input, true, out var chosenFood))
        {
            Console.WriteLine($"You chose: {chosenFood}");
        }
        else
        {
            Console.WriteLine("That food is not on the menu!");
        }
    }
}