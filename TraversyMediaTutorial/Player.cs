//Namespace
namespace TraversyMediaTutorial
{
    class Player
    {
        public bool Computer = false;
        public bool Lost = false;

        private int balance = 10000;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private int currbet;

        public int Currbet
        {
            get { return currbet; }
            set { currbet = value; }
        }
        private int guess;
        public int Guess
        {
            get { return guess; }
            set { guess = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Statistics
        {
            get { return  Name + " has a balance of " + balance.ToString(); }
        }


        public string InfoString
        {
            get { return "\n\n"+Name + " bets " + Currbet.ToString() + " and thinks " + Guess.ToString() + " will win!!!"; }
        }
    }
}
