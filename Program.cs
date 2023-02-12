
/*
 * Flip a coin the number of times entered by the user and print total heads and tails
 */

namespace CoinFlipper
{
    class Program
    {
        enum CoinSides
        {
            Heads,
            Tails
        }
        
        static void Main(string[] args)
        {
            // Create random number object
            var rand = new Random();
            // Valid input flag
            bool validInput = false;

            // Introduce the program and get the number
            do
            {
                Console.WriteLine("Flip a coin!");
                Console.WriteLine("Enter the number of coin flips you would like: ");
                string input = Console.ReadLine();
                // Check the input was a number
                if (int.TryParse(input, out int value))
                {
                    // Value is safe to use here
                    validInput = true;
                    // Track the values
                    int heads = 0;
                    int tails = 0;
                        
                    int i = 0;
                    while (i < value)
                    {
                        int flip = rand.Next(2);
                        if (flip == (int)CoinSides.Heads)
                        {
                            heads++;
                        }
                        else
                        {
                            tails++;
                        }
                        i++;
                    }
                    Console.WriteLine("Heads flipped: " + heads);
                    Console.WriteLine("Tails flipped: " + tails);
                }
            } while (!validInput);
        }
    }
}