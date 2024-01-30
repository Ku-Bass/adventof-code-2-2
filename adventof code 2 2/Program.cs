public class Program
{
    private static void main(String[] args)
    {
        string input = "Game 1: 12 blue; 2 green, 13 blue, 19 red; 13 red, 3 green, 14 blue\r\nGame 2: 12 blue, 1 red, 1 green; 1 red, 12 blue, 3 green; 5 green, 1 red, 9 blue; 1 red, 7 blue, 4 green\r\nGame 3: 1 red; 12 blue, 15 red; 1 green, 10 red, 2 blue; 1 green, 3 red, 9 blue\r\nGame 4: 6 blue, 5 green; 2 blue, 6 green, 6 red; 11 blue, 5 red; 6 green, 11 red, 7 blue; 4 green, 10 red; 1 green, 7 red, 13 blue\r\nGame 5: 10 green, 1 red, 2 blue; 3 red, 4 green, 4 blue; 5 green, 5 red\r\nGame 6: 1 green, 6 blue, 14 red; 9 blue, 5 red; 14 red, 12 blue\r\nGame 7: 1 green, 9 red, 8 blue; 9 blue, 1 green, 6 red; 1 green, 15 blue, 19 red\r\nGame 8: 9 red, 7 green, 2 blue; 6 red, 17 green; 18 red, 16 green, 2 blue; 10 red, 14 green\r\nGame 9: 1 blue, 11 red, 9 green; 8 red, 1 blue, 9 green; 4 blue, 16 red, 9 green; 8 green, 3 blue, 6 red; 8 green, 11 red, 3 blue; 11 red, 2 blue\r\nGame 10: 8 green, 14 blue; 1 red, 6 blue, 9 green; 6 blue, 4 green, 1 red; 16 green, 9 blue\r\nGame 11: 6 green, 11 blue, 1 red; 10 green, 1 red; 7 blue, 2 green, 1 red\r\nGame 12: 3 green, 5 blue, 2 red; 14 blue, 16 green, 4 red; 8 green, 14 blue, 4 red\r\nGame 13: 5 red, 12 blue, 2 green; 2 green, 1 red, 9 blue; 1 red, 2 blue, 3 green; 3 green, 3 red, 7 blue; 2 red, 13 blue; 1 red, 10 blue, 2 green\r\nGame 14: 5 blue, 1 red, 2 green; 8 blue, 1 green, 1 red; 1 blue, 2 green\r\nGame 15: 14 blue, 9 green, 1 red; 2 red, 15 blue, 12 green; 1 blue, 2 green, 1 red; 1 red, 16 green, 15 blue; 1 red, 12 green, 8 blue; 1 red, 17 blue\r\nGame 16: 7 red, 1 green, 18 blue; 7 blue, 5 green, 17 red; 14 blue, 8 red, 6 green\r\nGame 17: 4 green, 5 blue; 5 green, 1 red, 7 blue; 3 green, 6 blue, 4 red; 2 green, 5 blue; 9 green, 6 red, 6 blue\r\nGame 18: 8 red, 6 blue; 4 blue, 19 red; 4 blue, 9 red; 9 blue, 10 red; 2 green, 9 blue, 13 red; 3 blue, 7 red\r\nGame 19: 8 green, 2 red, 17 blue; 11 blue, 4 red, 5 green; 8 blue, 8 green, 10 red; 9 green, 4 blue, 2 red; 4 green, 10 red, 6 blue\r\nGame 20: 9 green, 3 blue, 1 red; 5 blue, 16 green, 3 red; 3 green, 3 red; 2 blue, 1 red, 5 green\r\nGame 21: 7 green, 1 red, 10 blue; 7 green, 5 blue, 7 red; 7 green, 9 blue\r\nGame 22: 5 red, 2 blue, 9 green; 6 red, 11 green; 6 green, 6 red\r\nGame 23: 14 red, 2 blue, 9 green; 9 green, 1 blue, 4 red; 9 red, 1 green, 1 blue; 6 green; 3 blue, 1 green, 9 red; 1 blue, 2 red\r\nGame 24: 3 red, 7 green, 6 blue; 1 green, 5 blue; 6 blue, 1 red, 2 green; 5 red, 1 blue, 4 green; 6 red, 2 blue, 11 green; 2 green, 2 red, 1 blue\r\nGame 25: 5 green, 1 red, 3 blue; 3 blue, 6 green, 3 red; 3 red, 4 green, 1 blue; 6 green, 1 blue, 9 red; 2 blue, 2 red, 1 green\r\nGame 26: 3 green, 4 red, 12 blue; 2 red, 1 green, 15 blue; 7 red, 16 green, 4 blue; 11 blue, 11 green, 3 red; 8 green, 15 blue, 10 red\r\nGame 27: 9 red; 10 red, 2 blue; 3 red; 8 red, 1 green, 2 blue; 1 red, 2 blue; 1 blue, 4 red\r\nGame 28: 5 blue, 8 red, 5 green; 10 blue, 4 red, 5 green; 8 red, 14 blue, 10 green; 10 blue, 4 red, 1 green; 5 red, 17 green, 4 blue\r\nGame 29: 16 green, 11 red, 5 blue; 11 red, 14 blue, 13 green; 13 blue, 8 green; 3 red, 18 green, 15 blue\r\nGame 30: 2 red, 4 blue, 8 green; 6 green, 2 red, 2 blue; 6 green, 6 blue, 2 red\r\nGame 31: 2 red, 1 blue, 16 green; 10 green, 1 blue, 7 red; 1 blue, 14 green, 7 red; 2 blue, 1 green, 1 red; 6 red, 13 green; 2 blue, 6 red, 10 green\r\nGame 32: 4 green, 4 blue; 1 green, 5 red; 6 green, 1 red; 3 green, 5 red, 2 blue; 4 red, 1 blue, 4 green; 6 green, 2 blue, 6 red\r\nGame 33: 5 blue, 2 red, 1 green; 5 blue; 1 blue, 1 green, 10 red; 8 red, 3 blue, 1 green\r\nGame 34: 15 blue, 7 green; 12 green, 17 blue; 10 blue, 11 green; 1 red, 5 blue, 9 green; 2 red, 10 blue, 11 green\r\nGame 35: 2 red, 6 blue; 2 red, 5 blue, 4 green; 2 red, 8 green, 10 blue\r\nGame 36: 4 red, 9 green, 3 blue; 4 red, 6 green; 6 red; 11 red, 4 green\r\nGame 37: 3 blue, 12 green, 14 red; 3 red, 5 green, 7 blue; 2 blue, 2 green, 16 red\r\nGame 38: 17 blue, 16 red, 8 green; 4 green, 17 blue, 4 red; 8 red, 7 blue, 6 green; 2 blue, 9 green, 17 red; 10 blue, 8 green, 11 red\r\nGame 39: 10 blue, 1 red, 4 green; 4 green, 4 red, 6 blue; 11 blue\r\nGame 40: 5 green, 17 blue; 11 blue, 4 green, 7 red; 2 green, 6 red, 13 blue; 7 blue, 12 green, 16 red; 15 red, 3 green, 8 blue; 12 green, 3 blue, 12 red\r\nGame 41: 13 blue, 3 red, 1 green; 2 green, 10 red; 1 blue, 5 red, 3 green; 5 green, 16 blue; 9 blue, 2 green; 14 blue, 4 green, 5 red\r\nGame 42: 2 blue, 15 green, 3 red; 3 red, 17 green; 6 red, 1 blue, 8 green\r\nGame 43: 8 green, 9 red, 3 blue; 1 blue, 13 red; 5 red, 1 blue, 6 green; 2 red, 2 blue; 17 red, 2 blue, 6 green\r\nGame 44: 10 red, 3 blue; 10 blue, 5 green; 4 red, 4 blue, 1 green; 16 blue, 6 red, 7 green; 3 green, 12 blue\r\nGame 45: 12 blue, 2 red; 2 blue, 3 red, 2 green; 8 blue, 3 green; 4 green, 8 blue, 5 red; 3 red, 2 blue, 1 green; 1 red, 2 blue, 7 green\r\nGame 46: 1 blue, 11 red, 6 green; 2 blue, 11 red, 6 green; 8 red, 5 green\r\nGame 47: 2 blue, 9 red; 1 green, 5 blue; 10 red, 2 blue, 2 green; 10 red, 3 green, 3 blue; 3 red, 6 blue, 2 green; 1 red, 1 green, 5 blue\r\nGame 48: 1 red, 7 green; 1 blue, 10 green, 5 red; 4 red, 8 green; 10 red, 10 green; 2 red, 16 green; 11 red, 14 green, 1 blue\r\nGame 49: 1 red, 1 blue, 5 green; 6 green, 5 red; 3 blue, 4 red, 3 green; 3 red, 5 green, 2 blue; 3 blue, 3 red\r\nGame 50: 17 red, 1 green, 7 blue; 4 blue, 1 red, 5 green; 10 red, 13 blue; 17 red\r\nGame 51: 2 red, 1 green; 1 green, 10 blue, 2 red; 5 red, 1 green, 7 blue; 7 blue, 1 red; 9 blue, 5 red, 2 green\r\nGame 52: 8 green, 1 blue; 14 green, 1 red; 10 green, 1 red\r\nGame 53: 17 green, 6 blue; 17 blue, 9 green; 1 red, 12 blue\r\nGame 54: 4 blue, 7 red, 9 green; 7 red, 2 green; 14 green, 10 red, 3 blue; 9 green, 6 blue, 5 red; 2 blue, 3 green, 11 red\r\nGame 55: 11 green, 4 red; 14 green; 3 red, 3 green; 3 green, 4 red, 1 blue; 15 green, 6 red, 2 blue; 4 red, 3 blue, 15 green\r\nGame 56: 8 blue, 5 red, 9 green; 11 green, 5 blue, 6 red; 1 green, 1 blue, 7 red; 7 green, 4 red, 1 blue; 9 blue, 5 red, 1 green; 5 red, 2 blue\r\nGame 57: 11 green, 19 blue, 5 red; 15 green, 5 red, 18 blue; 16 green, 5 red, 10 blue; 19 blue, 3 red; 9 green, 8 blue\r\nGame 58: 4 blue, 12 green; 11 green, 4 blue; 6 blue, 6 green; 1 red, 2 green; 11 green, 3 blue; 13 blue, 6 green\r\nGame 59: 10 blue, 1 red; 1 green, 4 blue; 4 blue\r\nGame 60: 7 red, 2 green, 6 blue; 1 green, 13 red, 12 blue; 9 blue, 9 green, 8 red\r\nGame 61: 7 green, 3 red, 2 blue; 1 red, 1 blue; 5 green, 3 blue; 4 blue, 1 red, 4 green\r\nGame 62: 1 green, 8 blue, 6 red; 7 blue, 3 red, 12 green; 2 blue, 7 red, 6 green\r\nGame 63: 3 red, 2 green; 3 green, 4 blue, 9 red; 3 blue, 3 green, 16 red; 4 red, 1 blue\r\nGame 64: 10 red, 2 green, 15 blue; 4 red, 14 green; 6 red, 14 green, 2 blue\r\nGame 65: 11 red, 14 green, 5 blue; 7 blue, 14 green, 15 red; 1 blue, 14 green; 4 green, 4 blue, 7 red\r\nGame 66: 6 blue, 9 green, 6 red; 6 blue, 2 red, 4 green; 3 blue; 8 blue, 5 green, 8 red; 17 blue, 11 green; 12 green, 11 blue, 4 red\r\nGame 67: 8 red, 4 blue, 6 green; 4 blue, 8 red, 2 green; 1 green, 6 red, 2 blue; 10 red, 1 green, 2 blue; 1 blue, 5 red; 2 red, 1 green, 2 blue\r\nGame 68: 10 green, 9 red, 13 blue; 2 blue, 2 green, 4 red; 11 red, 13 blue; 4 green, 2 red, 8 blue\r\nGame 69: 16 red; 12 red, 1 green, 4 blue; 1 green, 14 red, 9 blue; 12 blue, 2 green, 13 red; 14 red, 2 green, 10 blue; 11 blue\r\nGame 70: 1 red, 19 green; 4 blue, 6 green; 12 green, 2 red\r\nGame 71: 9 green, 2 blue, 3 red; 5 red; 1 red, 1 blue, 5 green\r\nGame 72: 1 green, 19 red; 12 red, 1 green, 1 blue; 16 red, 6 blue; 14 red, 7 blue; 11 blue, 1 green, 13 red; 16 blue, 4 red\r\nGame 73: 1 green, 1 red, 2 blue; 8 green, 2 red, 4 blue; 7 blue, 7 green, 7 red\r\nGame 74: 1 blue, 1 green; 1 red; 1 red, 5 blue, 4 green; 2 blue, 1 red; 1 blue\r\nGame 75: 8 green, 1 red; 3 blue, 1 red, 5 green; 12 green\r\nGame 76: 8 green, 6 red, 2 blue; 7 red, 1 blue; 2 blue, 9 green, 1 red; 8 red, 13 green; 12 green, 2 red; 7 green, 5 red\r\nGame 77: 3 blue, 1 green, 10 red; 13 red; 1 blue, 13 red, 1 green\r\nGame 78: 2 red, 3 green, 14 blue; 3 red, 16 blue, 6 green; 3 blue, 3 red, 9 green; 4 blue, 11 green; 6 green, 2 blue; 2 red, 10 green, 11 blue\r\nGame 79: 5 green, 10 blue, 2 red; 16 green, 15 blue, 1 red; 1 red, 11 green; 1 red, 11 blue, 16 green; 7 blue, 18 green\r\nGame 80: 9 blue, 10 green; 13 green, 9 blue; 1 red, 5 green, 5 blue; 13 green, 5 blue, 1 red\r\nGame 81: 9 green, 15 red, 11 blue; 11 blue, 9 red, 5 green; 2 green, 11 blue, 19 red; 14 green, 15 red, 5 blue\r\nGame 82: 4 green, 6 red, 13 blue; 5 blue, 5 red, 4 green; 2 green, 7 blue\r\nGame 83: 12 blue, 8 red; 6 red, 1 blue, 1 green; 7 red, 1 green, 1 blue; 6 red, 1 green, 9 blue; 10 blue, 3 red; 1 red, 5 blue\r\nGame 84: 9 blue, 13 red; 8 blue, 1 green; 9 blue, 1 green; 3 blue, 5 red, 1 green\r\nGame 85: 14 green, 5 blue, 8 red; 1 blue, 5 green, 1 red; 10 red, 7 blue, 17 green; 3 blue, 6 green; 6 red, 5 blue, 4 green; 5 blue, 4 green, 6 red\r\nGame 86: 14 red; 20 red, 3 blue; 1 green, 12 blue, 15 red; 16 red, 13 blue; 13 red, 12 blue; 2 blue, 20 red\r\nGame 87: 2 blue, 2 red, 10 green; 8 green, 9 red, 1 blue; 11 red, 1 green, 4 blue; 13 red, 1 blue; 11 green, 16 red, 3 blue\r\nGame 88: 5 green, 4 red, 1 blue; 3 blue, 8 red, 10 green; 11 green, 7 red, 4 blue; 11 green, 5 blue, 4 red; 9 red, 9 green; 4 blue, 6 green, 9 red\r\nGame 89: 2 blue, 2 red, 5 green; 2 red, 2 blue, 3 green; 2 red, 1 blue, 7 green; 6 green, 1 red, 2 blue\r\nGame 90: 4 green, 1 blue, 5 red; 2 blue, 2 red, 10 green; 2 green, 8 red, 1 blue; 10 green, 5 red; 2 red, 3 green, 2 blue\r\nGame 91: 16 blue, 5 red, 15 green; 4 green, 7 red, 3 blue; 4 red, 8 green, 12 blue; 4 green, 8 red, 17 blue\r\nGame 92: 13 red, 2 blue, 12 green; 19 green, 7 red; 17 green, 2 blue, 3 red; 6 blue, 11 red, 10 green; 6 red, 15 green, 3 blue; 6 blue, 20 green, 11 red\r\nGame 93: 2 blue, 3 green; 1 blue, 4 red; 1 red\r\nGame 94: 3 red, 5 green, 6 blue; 7 blue, 5 green, 6 red; 9 blue, 1 green, 2 red; 4 blue, 1 green, 4 red\r\nGame 95: 8 green, 9 red, 2 blue; 7 green, 7 red; 2 green, 4 blue, 6 red; 6 blue, 2 red, 2 green\r\nGame 96: 11 blue, 4 red; 1 green, 3 red, 14 blue; 2 green, 3 red, 8 blue; 7 red, 1 green, 3 blue; 8 blue, 6 red, 2 green; 9 blue, 3 red, 3 green\r\nGame 97: 5 green, 13 red, 7 blue; 2 blue, 12 red, 6 green; 10 blue, 11 red, 3 green; 4 green, 11 blue, 15 red; 8 green, 16 blue, 1 red; 15 blue, 4 red, 5 green\r\nGame 98: 3 blue, 1 red; 4 blue; 2 green, 1 blue; 2 green, 1 red, 5 blue\r\nGame 99: 4 green, 3 blue, 9 red; 6 blue, 5 red, 3 green; 2 green, 4 blue, 7 red; 8 red, 4 blue; 2 green, 15 red; 4 red, 5 blue, 3 green\r\nGame 100: 8 red, 4 blue, 4 green; 10 blue, 3 red, 4 green; 10 green, 4 red; 18 red, 9 blue, 2 green; 12 red, 4 green, 2 blue";
        string[] games = input.Split("\r\n");
        //only 12 red cubes, 13 green cubes, and 14 blue cubes.
        int answer = 0;
        foreach (string game in games)
        {
            answer += ComputeGame(game);
        }
        Console.WriteLine(answer);


        static int ComputeGame(string game)
        {
            int answer = 0;
            bool isOk = true;
            string[] components = game.Split(':');
            components[0] = components[0].Replace("Game ", "");
            int gameIndex = Convert.ToInt32(components[0]);
            Console.WriteLine(gameIndex);
            Console.WriteLine("____");
            string[] rounds = components[1].Split(";");
            int minBlue = 0;
            int minRed = 0;
            int minGreen = 0;
            foreach (string round in rounds)
            {
                string[] colors = round.Split(",");
                foreach (string color in colors)
                {
                    string[] colorAndNumber = color.Split(" ");
                    int count = Convert.ToInt32(colorAndNumber[1]);
                    string colorOfCube = colorAndNumber[2];
                    Console.WriteLine(colorOfCube);
                    if (colorOfCube == "blue")
                    {
                        if (count > minBlue)
                        {
                            minBlue = count;

                        }

                    }
                    if (colorOfCube == "red")
                    {
                        if (count > minRed)
                        {
                            minRed = count;

                        }

                    }
                    if (colorOfCube == "green")
                    {
                        if (count > minGreen)
                        {
                            minGreen = count;

                        }

                    }
                }
            }

            answer = minBlue * minGreen * minRed;
            return answer;
        }

    }

}