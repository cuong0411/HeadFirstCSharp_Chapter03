namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            Guy player = new() { Name = "The player", Cash = 100 };
            double odds = 0.75;

            Console.WriteLine("Welcome to the casino. The odds are " + odds);

            while (player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.Write("How much money to bet: ");
                string? howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int amount))
                {
                    if (amount > player.Cash)
                    {
                        Console.WriteLine("The amount you bet is greater than your cash");
                    }
                    else
                    {
                        int pot = player.GiveCash(amount);
                        pot *= 2;

                        if (random.NextDouble() > odds)
                        {
                            Console.WriteLine("You won");
                            player.RecieveCash(pot);
                        }
                        else
                        {
                            Console.WriteLine("You lose");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }
    }
}