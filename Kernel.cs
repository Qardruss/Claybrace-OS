using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace ClaybraceOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Claybrace OS: Be Nice, Be Well.");
            Console.WriteLine("Started Claybracket shell: Use 'help' for help");
        }

        protected override void Run()
        {
            while (true)
            {
                Console.Write("Claybracket >>  ");
                var input = Console.ReadLine();
                parseCommand(input);
            }

        }
        public void parseCommand(string command)
        {
            switch (command)
            {
                case "cat":
                    Console.WriteLine("Cat: Return back the text you typed\n");
                    Console.WriteLine("Cat > Enter any text > ");
                    Console.WriteLine(Console.ReadLine());
                    break;
                case "truth-machine":
                    Console.WriteLine("Truth machine: If the input is a 0, return 0, else if it is 1, output 1 2500 times");
                    Console.WriteLine("Truth machine > 1 or 0 > ");
                    var input = Console.ReadLine();
                    if (input == "0")
                    {
                        Console.WriteLine("0");
                    }
                    else if (input == "1")
                    {
                        for (int i = 0; i < 2500; i++)
                        {
                            Console.WriteLine("1");
                        }
                    }
                    break;
                case "calc":
                    Console.WriteLine("Calculator: Is a calculator...");
                    Console.WriteLine("Calc > Number 1 > ");
                    var num1 = Console.ReadLine();
                    Console.WriteLine("\nCalc  >Number 2 > ");
                    var num2 = Console.ReadLine();
                    Console.WriteLine("Calc Operation> +, -, *, /, or % > ");
                    var op = Console.ReadLine();
                    switch (op)
                    {
                        case "+":
                            int num11 = Pi(num1);
                            int num21 = Pi(num2);
                            Console.WriteLine("Result: " + (num11 + num21));
                            break;
                        case "-":
                            var result = Pi(num1) - Pi(num2);
                            Console.WriteLine("Result: " + result);
                            break;
                        case "*":
                            var _result = Pi(num1) * Pi(num2);
                            Console.WriteLine("Result: " + _result);
                            break;
                        case "/":
                            var __result = Pi(num1) / Pi(num2);
                            Console.WriteLine("Result: " + __result);
                            break;
                        case "%":
                            var ___result = Pi(num1) % Pi(num2);
                            Console.WriteLine("Result: " + ___result);
                            break;
                    }
                    break;
                case "shutdown":
                    Sys.Power.Shutdown();
                    break;
                case "reboot":
                    Sys.Power.Reboot();
                    break;
                case "help":
                    Console.WriteLine("Commands:\ncat : Return the text you inputted to it\ntruth-machine : Truth machine program, input 0 = output 0, input 1 = 25000 1's\ncalc : Simple calulator\nshutdown : Shut the OS down\nreboot: Reboot/Restart the OS");
                    break;
                case "hobbit":
                    Console.WriteLine(@"Far over the misty mountains cold
To dungeons deep and caverns old
We must away ere break of day
To seek the pale enchanted gold.

The dwarves of yore made mighty spells,
While hammers fell like ringing bells
In places deep, where dark things sleep,
In hollow halls beneath the fells.

For ancient king and elvish lord
There many a gleaming golden hoard
They shaped and wrought, and light they caught
To hide in gems on hilt of sword.

On silver necklaces they strung
The flowering stars, on crowns they hung
The dragon-fire, in twisted wire
They meshed the light of moon and sun.");
                    break;
            }
        }
        public int Pi(string item)
        {
            try
            {
                return (int)int.Parse(item);
            }
            catch (Exception e)
            {
                Exception ee = e;
                return 0;
            }
        }
    }
}
