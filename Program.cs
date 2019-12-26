using System;

namespace TheOrderOfThings
{
    class Program
    {
        static void Main(string[] Args)
        {
            double number;
            string opinion, size, age, shape, color, origin, material, purpose;
            string noun;

            number = 5.0;
            opinion = "AWESOME";
            size = "teensy-weensy";
            age = "new";
            shape = "oblong";
            color = "BRIGHT yellow";
            origin = "AlphaCentaurian";
            material = "platinum";
            purpose = "good";

            noun = "dragons";

                // Using the + with strings, doesn't add it concatenates! (sticks them together)
                Console.WriteLine(number + opinion + size + age + shape + color
                        + origin + material + purpose + noun);
        }
    }
}