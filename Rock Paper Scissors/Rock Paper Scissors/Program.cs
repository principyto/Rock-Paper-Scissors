class Program
{
    static void Main(string[] args)
    {
        int player;
        int AI;
        int rounds = 5;
        int score = 0;
        string answer;
        Random random = new Random();


        while(rounds >= 0)
        {
            Console.WriteLine("Pick one: r: Rock p: Paper s: Scissors");
            answer = Console.ReadLine();

            switch(answer)
            {
                case "r":
                    player = 0;
                    break;
                case "p":
                    player = 1;
                    break;
                case "s":
                    player = 2;
                    break;
                default:
                    break;
            }
            AI = random.Next(0,3);

            if(AI == 0)
            {
                Console.WriteLine("AI picked Rock");
                switch (answer)
                {
                    case "r":
                        Console.WriteLine("Tie");
                        rounds--;
                        break;
                    case "p":
                        Console.WriteLine("Player wins");
                        rounds--;
                        score++;
                        break;
                    case "s":
                        Console.WriteLine("AI wins");
                        rounds--;

                        break;
                    default:
                        return;
                }
            }
            if (AI == 1)
            {
                Console.WriteLine("AI picked Paper");
                switch (answer)
                {
                    case "r":
                        Console.WriteLine("AI wins");
                        rounds--;
                        break;
                    case "p":
                        Console.WriteLine("Tie");
                        rounds--;
                        break;
                    case "s":
                        Console.WriteLine("Player wins");
                        rounds--;
                        score++;
                        break;
                    default:
                        return;
                }
            }
            if (AI == 2)
            {
                Console.WriteLine("AI picked Scissors");
                switch (answer)
                {
                    case "r":
                        Console.WriteLine("Player wins");
                        rounds--;
                        score++;
                        break;
                    case "p":
                        Console.WriteLine("AI wins");
                        rounds--;
                        break;
                    case "s":
                        Console.WriteLine("Tie");
                        rounds--;
                        break;
                    default:
                        return;
                }
            }
        }
        Console.WriteLine("your score was: " + score);
        Console.ReadLine();
    }
}