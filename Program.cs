using System;
using SharpDX.Direct3D9;

namespace TheOrderOfThings
{
    class Program
    {
        static Main(string)[] Args)
        {
            
            double number;
            string opinion, size, age, shape, color, origin, material, purpose;
            string noun;

            double = 5.0;
            opinion = "AWESOME";
            size = "teensy-weensy";
            age = "new";
            shape = "oblong";
            color = "Bright yellow";
            origin = "AlphaCentaurian";
            Material = "platinum";
            purpose = "good";

            noun = "dragons";


            // Using the + with strings, doesn't add it concatenates! (sticks them together)
            Console.WriteLine(number + opinion + size  + age + shape + color
                    + origin + material + purpose + noun);
        }
    }
}
