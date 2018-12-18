using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FNATestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            Game game = null;
            while (!validInput)
            {
                Console.Write("Choose a game to load:\n  1. 2D Demo\n  2. 3D Demo\nSelection: ");
                var input = Console.ReadLine();
                bool parsed = uint.TryParse(input, out uint result);
                if (parsed && result > 0)
                {
                    switch (result)
                    {
                        case 1:
                            game = new FNATestGame2D();
                            validInput = true;
                            break;
                    }
                }
            }

            game.Run();
        }
    }
}
