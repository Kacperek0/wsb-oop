using System;

namespace zad
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player = new Player();

            while (true)
            {
                Console.WriteLine("Press 1 to add a song." + "\nPress 2 to play" +
                    "\nPress 0 to exit.\n");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    Console.WriteLine("Please select genre:\n" +
                        "1. Rock\n" +
                        "2. Grunge\n" +
                        "3. Hard Rock\n" +
                        "4. Indie Rock\n" +
                        "5. Punk Rock\n" +
                        "0. Return to main menu.");
                    int selection_a = int.Parse(Console.ReadLine());
                    switch (selection_a)
                    {
                        case 1:
                            string[] rock = basic_questions();
                            player.Add(new Rock(rock[0], rock[1], rock[2]));
                            break;

                        case 2:
                            string[] grunge = basic_questions();
                            Console.WriteLine("Type drummer name:");
                            string drummer = Console.ReadLine();
                            player.Add(new GrungeRock(grunge[0], grunge[1], grunge[2], drummer));
                            break;

                        case 3:
                            string[] hard = basic_questions();
                            Console.WriteLine("Type lead guitarris name:");
                            string guitar = Console.ReadLine();
                            player.Add(new HardRock(hard[0], hard[1], hard[2], guitar));
                            break;

                        case 4:
                            string[] indie = basic_questions();
                            Console.WriteLine("Type keyboardist name:");
                            string keyboard = Console.ReadLine();
                            player.Add(new HardRock(indie[0], indie[1], indie[2], keyboard));
                            break;

                        case 5:
                            string[] punk = basic_questions();
                            Console.WriteLine("How drunk the band is? (in promiles)");
                            int drunk = int.Parse(Console.ReadLine());
                            player.Add(new PunkRock(punk[0], punk[1], punk[2], drunk));
                            break;

                        default:
                            break;
                    }
                }
                else if (selection == 2)
                {
                    foreach (Song song in player.list)
                    {
                        Console.WriteLine(song.Play());
                    }
                }
                else if (selection == 0)
                {
                    break;
                }
            }

            string[] basic_questions()
            {
                
                Console.WriteLine("Type artist name:");
                string artist = Console.ReadLine();
                Console.WriteLine("Type title");
                string title = Console.ReadLine();
                Console.WriteLine("Type basist name:");
                string basist = Console.ReadLine();

                string[] answers = { artist, title, basist };

                return answers;
            }
        }
    }
}
