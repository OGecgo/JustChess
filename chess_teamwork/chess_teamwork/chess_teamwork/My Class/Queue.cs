using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess_teamwork
{
    public class Queue
    {
        private string play;
        public void SetStartVariablesQueue()
        {
            this.Play = "w";
        }
        public Queue() { }



        public string Play   // property
        {
            get { return play; }   // get method
            set { play = value; }  // set method
        }


        // Sets color to white
        public void resetColorChange(PictureBox whoPlay)
        {
            whoPlay.BackColor = Color.FromArgb(204, 205, 210);
        }

        private void colorChange(PictureBox whoPlay)
        {
            if (Commands.Draw.Is_Pixel_Color_Box(whoPlay.BackColor, 204, 205,210))
            {
                whoPlay.BackColor = Color.FromArgb(105, 127, 151);
            }
            else
            {
                whoPlay.BackColor = Color.FromArgb(204, 205, 210);
            }
        }
        public void playerChange(PictureBox whoPlay)
        {
            if (play == "w")
            {
                play = "b";
                colorChange(whoPlay);
                return;
            }
            else if (play == "b")
            {
                play = "w";
                colorChange(whoPlay);
                return;
            }
            play = "-";

        }


        //if dont want change color
        public void playerChange()
        {
            if (play == "w")
            {
                play = "b";
                return;
            }
            else if (play == "b")
            {
                play = "w";
                return;
            }
            play = "-";

        }

        // the time class is used for time-related functions
        public static class TimeString
        {
            
            // Show day and time
            public static void getTime(Label day, Label time)
            {
                string currentDateTime = DateTime.Now.ToString("MM / dd / yy");
                day.Text = currentDateTime;
                currentDateTime = DateTime.Now.ToString("h: mm tt");
                time.Text = currentDateTime;

            }

            // I make the format of time
            public static string changeFormat(int min, int sec)
            {
                string time;

                if (min < 10)
                {
                    time = "0" + min.ToString() + ":";
                }
                else
                {
                    time = min.ToString() + ":";
                }

                if (sec < 10)
                {
                    time = time + "0" + sec.ToString();
                }
                else
                {
                    time = time + sec.ToString();
                }
                return time;
            }

            public static void updateTimer(Label timer)
            {
                string time = timer.Text;

                int sec = Convert.ToInt32(time[3] + "" + time[4]);
                int min = Convert.ToInt32(time[0] + "" + time[1]);
                // -1 sec
                sec--;
                if (sec < 0)
                {
                    sec = 59;
                    // -1 min
                    min--;
                    if (min < 0)
                    {
                        min = 0;
                        sec = 0;
                    }
                }
                time = changeFormat(min, sec);
                // Show time
                timer.Text = time;
            }
        }


    }
}
