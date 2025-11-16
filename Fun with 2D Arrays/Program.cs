namespace Fun_with_2D_Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's create your own custom grid and see what we can fill it with");
        Console.WriteLine("So first…");

        Console.WriteLine("\nInsert the number of rows you want:");
        int numberOfRows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInsert the number of columns you want:");
        int numberOfColumns = Convert.ToInt32(Console.ReadLine());

        string [,] gridCreatedByUser = new string[numberOfRows, numberOfColumns];
        
        Console.WriteLine("\nGood! You’ve made your own custom grid.");
        Console.WriteLine("Now, you’ll have 2 mode options");
        Console.WriteLine("\nPress 1 if you want to fill your grid with sequential numbers");
        Console.WriteLine("\nPress 2 if you want to fill your grid with alternating symbols");

        while (true)
        {
            char pressedKey = Console.ReadKey().KeyChar;
            
            string input = pressedKey.ToString();
            
            int userOption;

            bool valid = int.TryParse(input, out userOption);

            if (!valid)
            { 
                Console.WriteLine("\nYour input is not even a number! \nPlease, try again.");
                continue;
            }
    
            if (userOption != 1 && userOption != 2)
            {
                Console.WriteLine("\nInvalid input! \nPlease, press either 1 or 2."); 
            }    

            if (userOption == 1)
            {
                //Fill grid with sequential numbers
            }

            if (userOption == 2)
            {
                //Fill grid with alternating symbols   
            }
        }
    }
}