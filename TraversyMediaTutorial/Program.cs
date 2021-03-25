using System;
using System.Collections.Generic;
using TraversyMediaTutorial;


//Namespace
namespace Sprinterz
{
    //main class
    class Program
    {
        private static Random _random = new Random();
        public static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            ConsoleColor retColor=  (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
            if (retColor == ConsoleColor.Black)
            {
                retColor = ConsoleColor.Cyan;
            }
            return retColor;
        }

        public static int Max(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static void AddSponsor(List<Sprinter> Sprinters, string name,int id)
        {
            foreach (Sprinter s in Sprinters)
            {
                if(s.Index == id)
                {
                    s.Sponsors.Add(name);
                }
            }
        }
        //entry point method
        public static void PrintWDelay(List<string> list, int delay)
        {
            foreach(string line in list)
            {
                System.Threading.Thread.Sleep(delay);
                Console.WriteLine(line);

            }
            
        }

        public static int GetRandom (int min, int max)
        {
            var rand = new Random();

            int randNum = rand.Next(min, max);

            return randNum;


        }


        public static int getInt (string message, string errormessage)
        {
            string input;
            input = Console.ReadLine();
            int numPlay;
            while (!int.TryParse(input, out numPlay))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errormessage);
                Console.ResetColor();
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            return numPlay;
        }

        static void Main(string[] args)
        {

            List<string> Sprinterz = new List<string>();
            Sprinterz.Add(@"                _____            _       _                ");
            Sprinterz.Add(@"               /  ___|          (_)     | |               ");
            Sprinterz.Add(@"               \ `--. _ __  _ __ _ _ __ | |_ ___ _ __ ____");
            Sprinterz.Add(@"                `--. \ '_ \| '__| | '_ \| __/ _ \ '__|_  /");
            Sprinterz.Add(@"               /\__/ / |_) | |  | | | | | ||  __/ |   / / ");
            Sprinterz.Add(@"               \____/| .__/|_|  |_|_| |_|\__\___|_|  /___|");
            Sprinterz.Add(@"                     | |                                  ");
            Sprinterz.Add(@"                     |_|                                  ");




            List<string> OnMarks = new List<string>();
            OnMarks.Add(@"                ____         __     __                __  __            _        ");
            OnMarks.Add(@"               / __ \        \ \   / /               |  \/  |          | |       ");
            OnMarks.Add(@"              | |  | |_ __    \ \_/ /__  _   _ _ __  | \  / | __ _ _ __| | _____ ");
            OnMarks.Add(@"              | |  | | '_ \    \   / _ \| | | | '__| | |\/| |/ _` | '__| |/ / __|");
            OnMarks.Add(@"              | |__| | | | |    | | (_) | |_| | |    | |  | | (_| | |  |   <\__ \");
            OnMarks.Add(@"               \____/|_| |_|    |_|\___/ \__,_|_|    |_|  |_|\__,_|_|  |_|\_\___/");

            List<string> GetReady = new List<string>();

            GetReady.Add(@"                _____      _     _____                _       ");
            GetReady.Add(@"               / ____|    | |   |  __ \              | |      ");
            GetReady.Add(@"              | |  __  ___| |_  | |__) |___  __ _  __| |_   _ ");
            GetReady.Add(@"              | | |_ |/ _ \ __| |  _  // _ \/ _` |/ _` | | | |");
            GetReady.Add(@"              | |__| |  __/ |_  | | \ \  __/ (_| | (_| | |_| |");
            GetReady.Add(@"               \_____|\___|\__| |_|  \_\___|\__,_|\__,_|\__, |");
            GetReady.Add(@"                                                         __/ |");
            GetReady.Add(@"                                                        |___/ ");


            List<string> Set = new List<string>();
            Set.Add(@"        _____ ______ _______    _ ");
            Set.Add(@"       / ____|  ____|__   __|  | |");
            Set.Add(@"      | (___ | |__     | |     | |");
            Set.Add(@"       \___ \|  __|    | |     | |");
            Set.Add(@"       ____) | |____   | |     |_|");
            Set.Add(@"      |_____/|______|  |_|     (_)");


            List<string> Dots = new List<string>();
            Dots.Add("        .....");
            Dots.Add("          .....");
            Dots.Add("        .....");
            Dots.Add("          .....");
            Dots.Add("        .....");




            List<string> Go = new List<string>();
            Go.Add(@"                   _____  ____     _   _   _ ");
            Go.Add(@"                  / ____|/ __ \   | | | | | |");
            Go.Add(@"                 | |  __| |  | |  | | | | | |");
            Go.Add(@"                 | | |_ | |  | |  | | | | | |");
            Go.Add(@"                 | |__| | |__| |  |_| |_| |_|");
            Go.Add(@"                  \_____|\____/   (_) (_) (_)");


            Console.ForegroundColor = GetRandomConsoleColor();
            PrintWDelay(Sprinterz, 100);
            Console.ResetColor();
            
            string appVersion = "1.0.0";
            string appAuthor = "Diego Castro";
            /*
             
            Colors:

            Red
            Green
            Yellow
            White
            Cyan
            Blue
            DarkRed
            DarkYellow
             
             */

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Version {0} by {1}", appVersion, appAuthor);
            Console.ForegroundColor = ConsoleColor.White;
            //or
            Console.ResetColor();
            Console.WriteLine("Enter the number of human players: (0-5) ");
            int numPlay = getInt("Enter the number of human players: (1-5) ", "Number of players must be an int");
            while (numPlay > 5 || numPlay < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Players must be between 0-5");
                Console.ResetColor();
                numPlay = getInt("Enter the number of players: (0-5) ", "Number of players must be an int");
            }
            List<Player> Players = new List<Player>();
            if (numPlay == 0)
            {
                Player computer = new Player();
                computer.Computer = true;
                computer.Name = "Computer 1";
                Players.Add(computer);
            }
           
            for (int i =1; i < numPlay+1; i++)
            {
                Console.WriteLine("Enter the name of player "+i.ToString());
                Player p = new Player();
                p.Name = Console.ReadLine();
                Players.Add(p);
            }

  
           
           
            Console.WriteLine("Play against computer (y/n)");
            string read = Console.ReadLine();
            while (read != "y" && read != "n")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter y or n");
                Console.ResetColor();
                Console.WriteLine("Play against computer (y/n)");
                read = Console.ReadLine();

            }
  
            if(read == "y")
            {
                Console.WriteLine("Enter the number of computer players: (1-5) ");
                int numCPUPlay = getInt("Enter the number of computer players: (1-5) ", "Number of computer players must be an int");
                while (numCPUPlay > 5 || numCPUPlay < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Computer Players must be between 1-5");
                    Console.ResetColor();
                    numCPUPlay = getInt("Enter the number of coputers players: (1-5) ", "Number of  computer players must be an int");
                }


                for (int i = 1;i< numCPUPlay; i++){

                    Player computer = new Player();
                    computer.Computer = true;
                    computer.Name = "Computer "+i.ToString();
                    Players.Add(computer);

                }

                //Play w/ a computer
                
            }


            if(Players.Count < 2)
            {
                Player computer = new Player();
                computer.Computer = true;
                computer.Name = "Computer 2";
                Players.Add(computer);
            }

            bool KeepOnPlaying = true;

            List<Sprinter> SprintersList = new List<Sprinter>();

            for (int i =1; i < 9; i++)
            {
                Sprinter sprinter = new Sprinter();
                sprinter.Index = i;
                sprinter.color = GetRandomConsoleColor();
                SprintersList.Add(sprinter);

            }


            //Actual game goes here
            while (KeepOnPlaying)
            {
                
                //Get guesses from players
                foreach (Player p in Players)
                {
                    if (p.Lost == false)
                    {
                        if (p.Computer == false)
                        {
                            Console.WriteLine("Hello " + p.Name + " please enter the number of the sprinter you think is going to win the race! (1-8) ");
                            int guess = getInt("Please enter the number of the sprinter you think is going to win the race!", "Sprinter number must be an int! (1-8)");
                           

                            while (guess > 8 || guess < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Guess must be between 1-8");
                                Console.ResetColor();
                                guess = getInt("Please enter the number of the sprinter you think is goint to win the race!", "Sprinter number must be an int! (1-8)");
                            }
                            p.Guess = guess;



                            Console.WriteLine("Place your bet " + p.Name );

                            int bet = getInt("Please place your bet.", "Bet must be an integer! (min bet 1000) ");

                            while (bet < 1000)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Bet must be > 1000!!!");
                                Console.ResetColor();
                                bet = getInt("Please place your bet.", "Bet must be an integer! (min bet 1000) ");
                               
                            }

                            if (bet > p.Balance)
                            {
                                bet = p.Balance;
                            }
                            p.Currbet = bet;


                        }
                        else
                        {

                            int guess = _random.Next(1, 9);
                            if (p.Balance > 10000)
                            {
                                int bet = _random.Next(5, 10);
                                bet = bet * 1000;
                                if (bet > p.Balance)
                                {
                                    bet = p.Balance;
                                }
                                p.Guess = guess;
                                p.Currbet = bet;
                            }
                            else
                            {
                                int bet = _random.Next(1, 5);
                                bet = bet * 1000;
                                if (bet > p.Balance)
                                {
                                    bet = p.Balance;
                                }
                                p.Guess = guess;
                                p.Currbet = bet;
                            }
                        }
                    }
                    
                }

                foreach(Player p in Players)
                {
                    if (p.Lost == false)
                    { 
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(p.InfoString);
                        Console.ResetColor();
                        AddSponsor(SprintersList, p.Name, p.Guess);
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                PrintWDelay(GetReady, 450);
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintWDelay(Set, 350);
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                PrintWDelay(Go, 100);
                Console.WriteLine("\n\n");
                Console.ResetColor();




                //Have the sprinters race
                bool race_over = false;
                int winner = 0;
                while (race_over == false)
                {
                    //Console.WriteLine("\n\n\n\n\n\n\n");
                    Console.WriteLine("          _________________________________________________________");
                    Console.WriteLine("        |                                                         |");
                    //System.Threading.Thread.Sleep(200);
                    foreach (Sprinter s in SprintersList)
                    {

                        int advance = GetRandom(1, 9);
            

                        if (s.Index == advance)
                        {
                            s.Position++;
                        }

                        if (s.Position > 50)
                        {
                            race_over = true;
                            winner = s.Index;
                        }
                       // Console.WriteLine("  _________________________________________________________");
                        Console.ForegroundColor = s.color;
                        Console.WriteLine("        |"+s.Index+"     " + s.Race+s.SponsorsStr);
                        Console.ResetColor();
                       // Console.WriteLine("  _________________________________________________________");
                        //
                    }
                    Console.WriteLine("        |                                                         |");
                    Console.WriteLine("          _________________________________________________________");
       
                }

                Console.WriteLine("Winner is "+ winner.ToString());

                foreach(Sprinter s in SprintersList)
                {
                    s.Position = 0;
                    s.Sponsors.Clear();
                }


                //If you win you get *2 money, else you lose whatever you bet

                foreach (Player p in Players)
                {
                    if (p.Lost == false)
                    {
                        if (p.Guess == winner)
                        {
                            p.Balance += (p.Currbet * 5);
                        }
                        else
                        {
                            p.Balance -= p.Currbet;
                        }
                        if (p.Balance <= 0)
                        {
                            p.Lost = true;
                            Console.WriteLine("       " + p.Name + " went bankrupt :( ");
                        }
                    }

                }


                int bankrupt = 0;
                foreach (Player p in Players)
                {
                    if (p.Lost == false)
                    {

                        Console.WriteLine(p.Statistics);
                        
                            bankrupt++;
                       
                    }

                }
                if (bankrupt < 2)
                {
                    KeepOnPlaying = false;
                }
               
            }

            string won = "";
            foreach(Player p in Players)
            {
                if(p.Lost == false)
                {
                    won = p.Name;
                }
            }

            Console.WriteLine("            Winner is ....\n");
            PrintWDelay(Dots, 500);
            Console.WriteLine("              "+won+"!!!!!!!!!!!!!");
            Console.WriteLine("Thanks for playing \n");
            PrintWDelay(Sprinterz, 100);
            Console.WriteLine("Made by Diego Castro - 2021");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();







        }
    }
}
