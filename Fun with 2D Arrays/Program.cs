namespace Fun_with_2D_Arrays;

class Program
{
    static void Main(string[] args)
    {
        //Some constants for MODE ONE
        const int MODE_ONE = 1;
        const int INITIAL_VALUE = 0;

        //Some constants for MODE TWO
        const int MODE_TWO = 2;
        const string ALTERNATING_SYMBOL_ONE = "x";
        const string ALTERNATING_SYMBOL_TWO = "o";

        Console.WriteLine("Let's create your own custom grid and see what we can fill it with");
        Console.WriteLine("So first…");

        Console.WriteLine("\nInsert the number of rows you want:");
        int numberOfRows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInsert the number of columns you want:");
        int numberOfColumns = Convert.ToInt32(Console.ReadLine());

        string[,] gridCreatedByUser = new string[numberOfRows, numberOfColumns];

        Console.WriteLine("\nGood! You’ve made your own custom grid.");
        Console.WriteLine("Now, you’ll have 2 mode options");
        Console.WriteLine("\nPress 1 if you want to fill your grid with sequential numbers");
        Console.WriteLine("\nPress 2 if you want to fill your grid with alternating symbols");

        while (true)
        {
            char pressedKey = Console.ReadKey(true).KeyChar;
            string input = pressedKey.ToString();

            int userOption;

            bool valid = int.TryParse(input, out userOption);

            if (!valid)
            {
                Console.WriteLine("\nYour input is not even a number! \nPlease, try again.");
                continue;
            }

            if (userOption != MODE_ONE && userOption != MODE_TWO)
            {
                Console.WriteLine("\nInvalid input! \nPlease, press either 1 or 2.");
                continue;
            }

            if (userOption == MODE_ONE)
            {
                int counter = INITIAL_VALUE;

                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        gridCreatedByUser[row, column] = counter.ToString();
                        counter++;
                    }
                }

                Console.WriteLine();

                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        Console.Write(gridCreatedByUser[row, column]);
                    }

                    Console.WriteLine();
                }
            }

            if (userOption == MODE_TWO)
            {
                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        if ((row + column) % 2 == 0)
                        {
                            gridCreatedByUser[row, column] = ALTERNATING_SYMBOL_ONE;
                        }
                        else
                        {
                            gridCreatedByUser[row, column] = ALTERNATING_SYMBOL_TWO;
                        }
                    }
                }

                Console.WriteLine();

                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        Console.Write(gridCreatedByUser[row, column]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}