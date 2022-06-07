namespace JoeAndBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new() { Cash = 100, Name = "Bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string? howMuch = Console.ReadLine();

                if (howMuch == "") return;
                
                if (int.TryParse(howMuch, out int result))
                {
                    Console.WriteLine("Who should give cash: ");
                    string? whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int amount = joe.GiveCash(result);
                        bob.RecieveCash(amount);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int amount = bob.GiveCash(result);
                        joe.RecieveCash(amount);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit)");
                }
            }
        }
    }
}