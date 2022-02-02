using System;

namespace DiamondKataJoey {
    public class Program {
        static void Main(string[] args) {
            while (true) {
                char input = Console.ReadKey().KeyChar;

                if (!char.IsLetter(input) || char.IsLower(input)) {
                    Console.WriteLine("\nOnly uppercase letters please.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine(DiamondCreator.CreateDiamond(input));
            }
        }
    }
}
