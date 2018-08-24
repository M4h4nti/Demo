using System;

namespace ClassAndObject
{
    public class Glass
    {
        public int LiquidLevel = 200;
        public void Drink(int ml)
        {
            LiquidLevel -= ml;
        }
        public void Refill()
        {
            LiquidLevel = 200;
        }
    }

    public class RefillMyGlass
    {
        public static void Main()
        {
            /* Create object and read commands here */
            var glass = new Glass();
            var mlToDrink = 0;
            var command = Console.ReadLine();

            while (command != "stop")
            {
                if (command.Contains("drink"))
                {
                   // command = "drink";
                    string[] words = command.Split(' ');
                    command = "drink";
                    mlToDrink = int.Parse(words[1]);
                }
                //glass.LiquidLevel == glass.LiquidLevel < 100 ? glass.Refill() : glass.LiquidLevel;
                
                switch (command)
                {
                    case "drink":
                        glass.Drink(mlToDrink);
                        if (glass.LiquidLevel < 100)
                        {
                            glass.Refill();
                        }
                        break;
                    case "print":
                        Console.WriteLine("This glass contains "+ glass.LiquidLevel +" of liquid. ");
                        //Console.WriteLine
                        break;
                    default:
                        Console.WriteLine("Enter command.");
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
