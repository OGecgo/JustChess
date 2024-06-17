using chess_teamwork.Inteface;

namespace chess_teamwork
{
    public class Player : Queue, SetNameTimePlayer
    {

        //name player
        private string player1;
        private string player2;
        //set game time
        private string gameTime;

        public void SetStartVariables()
        {
            string player1 = "";
            string player2 = "";
            string gameTime = "00:00";
            this.Play = "w";
        }

        public Player() : base()
        {
            SetStartVariables();
        }


        public string Player1   // property
        {
            get { return player1; }   // get method
            set { player1 = value; }  // set method
        }
        public string Player2   // property
        {
            get { return player2; }   // get method
            set { player2 = value; }  // set method
        }
        public string GameTime   // property
        {
            get { return gameTime; }   // get method
            set { gameTime = value; }  // set method
        }






    }
}
