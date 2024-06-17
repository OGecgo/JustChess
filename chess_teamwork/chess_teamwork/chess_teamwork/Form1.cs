using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static chess_teamwork.Commands;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace chess_teamwork
{
    public partial class FormChess : Form
    {

        // Setting the positions and the sizes of all visible objects in the form to the user
        private void chessBoard_positions_size()
        {
            
            // Finds how big the left gap needs to be so that the checkerboard is in the center
            int location = Math.Abs(this.ClientSize.Height - this.ClientSize.Width);
            location /= 2;

            // The chess player took the position where the gap will end so that she is in the center
            chessBoard.Location = new Point(location, 0);

            // The size of the chessboard is proportional to the height of the form
            chessBoard.Height = this.ClientSize.Height;
            chessBoard.Width = this.ClientSize.Height;

            // The size of the panelRight is proportional to the height of the form
            panelRight.Height = this.ClientSize.Height;
            panelRight.Width = this.ClientSize.Height / 4;
            

            // For the panelLeft I have not set points from the code because they are set to 0.0
            panelLeft.Height = this.ClientSize.Height;
            // The panelLeft fills the entire left side
            panelLeft.Width = location;

            //
            //Panel Left
            //

            pictureBoxPlay.Width = panelLeft.Width / 2;
            

            // The left pictureboxes are proportional to the height of the panel
            if (pictureBoxPlay.Width > panelLeft.Height / 2)
            {
                
                pictureBoxPlay.Width = panelLeft.Height / 2 ;

            }

            // Setting the Sizes of the left pictureboxes based on the height of pictureBoxPlay
            // PictureBoxPlay is placed on the bottom of the left panel
            pictureBoxPlay.Height = pictureBoxPlay.Width;
            pictureBoxPlay.Location = new Point(panelLeft.Width / 2 - pictureBoxPlay.Width / 2, panelLeft.Height - pictureBoxPlay.Height);

            //pictureBoxChaingePlayer is placed on the top of the left panel
            pictureBoxChaingePlayer.Width = pictureBoxPlay.Width;
            pictureBoxChaingePlayer.Height = pictureBoxPlay.Width;
            pictureBoxChaingePlayer.Location = new Point(panelLeft.Width / 2 - pictureBoxChaingePlayer.Width / 2 , 0);


            //
            //Panel Right
            //

            panelRight.Location = new Point(location + this.ClientSize.Height + this.ClientSize.Height / 30, 0);

            // 15 percent of the height of the panelRight
            int fifteenPercentPanelRightWidth = 15 * (panelRight.Width / 100);
            // The thickness that exists inside the panel
            int width = panelRight.Width - fifteenPercentPanelRightWidth * 2;
            // The height of all objects outside the flowLayoutPanelTimer
            int height = width / 2;
            // temporary variable
            int y;

            // I define the sizes and positions of the buttons which are essentially pictureboxes
            
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                // Set the size
                pictureBoxes[i].Size = new Size(width, height);

                // It sets the height of each picturebox (Right Buttons)
                y = fifteenPercentPanelRightWidth * (i + 1) + height * i;

                pictureBoxes[i].Location = new Point(fifteenPercentPanelRightWidth, y);
            }
            
            // Sets the location for the panel with the day/time
            flowLayoutPanelDay.Size = new Size(width, height);
            y = fifteenPercentPanelRightWidth * (4 + 1) + height * 4;
            flowLayoutPanelDay.Location = new Point(fifteenPercentPanelRightWidth, y);

            for (int i = 2; i < labelTimers.Length; i++)
            {
                // I size the labels that show the time and day in such a way that the take_label_size shows the sizes of the letters as I want
                labelTimers[i].Size = new Size(flowLayoutPanelDay.Width, flowLayoutPanelDay.Width / 4);
                Commands.Take_Label_Size(labelTimers[i]);
            }

            // Sets the location for the panel with the timer
            flowLayoutPanelTimer.Size = new Size(width, width * 2 - height);
            // I make the flowLayoutPanelTimer which I place inside the panelRight but below
            flowLayoutPanelTimer.Location = new Point(fifteenPercentPanelRightWidth, panelLeft.Height - fifteenPercentPanelRightWidth - flowLayoutPanelTimer.Height);

            for (int i = 0; i < labelTimers.Length - 2; i++)
            {
                // I size the labels that show the timers in such a way that the take_label_size shows the sizes of the letters as I want
                labelTimers[i].Size = new Size(flowLayoutPanelTimer.Width, flowLayoutPanelTimer.Width / 2);
                Commands.Take_Label_Size(labelTimers[i]);
            } 
        }


        // here I check that it gets the sizes that everything will be visible
        private static void Test_Size_Form(Form form)
        {
            // I take the panelLeft
            double min = Math.Abs(form.ClientSize.Width - form.ClientSize.Height) / 2.0;
            // then I also get the panelRight with space it has
            min = min + form.ClientSize.Height + form.ClientSize.Height / 4.0 + form.ClientSize.Height / 30.0;
            // additive and the floating space created by the form right left
            int minForm = Convert.ToInt32(min) + form.Width - form.ClientSize.Width;
            // and I set it to the smallest size it can take
            form.MinimumSize = new Size(minForm, 0);
        }


        //
        Player player;
        PawnMap pawnmap;
        DBChessInsert dbChess;

        //
        public FormChess()
        {
            pawnmap = new PawnMap();
            player = new Player();
            dbChess = new BaseChess();

            InitializeComponent();
        }




        Bitmap bitmapChessBoard;
        // It is used to move a pawn drawn on it
        Bitmap bitmapnotRealBox;
        // Array of buttons and all labels
        // These are used for resize and change location
        PictureBox[] pictureBoxes = new PictureBox[4];
        Label[] labelTimers = new Label[4];



        private void Form1_Load(object sender, EventArgs e)
        {



            // Buttons
            pictureBoxes[0] = Start;
            pictureBoxes[1] = Reset;
            pictureBoxes[2] = End;
            pictureBoxes[3] = Info;

            // Timers
            labelTimers[0] = labelTimer2;
            labelTimers[1] = labelTimer1;
            // time and day
            labelTimers[2] = labelDay;
            labelTimers[3] = labelTime;

            //start show day and time
            Queue.TimeString.getTime(labelTimers[2], labelTimers[3]);
            timerTime.Start();

            // make the sizes, points and set thisMinimumSize
            chessBoard_positions_size();
            Test_Size_Form(this);
            // this is done to fix a bug related to sizing
            // it has to do with which MinimumSize you use when you become Form1_Load
            this.MinimumSize = new Size(0,0);


            // I want notRealBox to be transparent to the chessboard
            PictureBoxNotRealBox.Parent = chessBoard;

            // notRealBox have size a box on chessboard
            // because they have 8 boxes in a row 
            PictureBoxNotRealBox.Size = new Size(chessBoard.Height / 8, chessBoard.Height / 8);
            // and I'll make it transparent for the start
            PictureBoxNotRealBox.BackColor = Color.Transparent;

            // it is done to ensure that a specific bug does not occur
            bitmapChessBoard = new Bitmap(chessBoard.Image);
            bitmapnotRealBox = new Bitmap(PictureBoxNotRealBox.Image);
            //I take their bitmaps and put them in the images pointer
            chessBoard.Image = bitmapChessBoard;
            PictureBoxNotRealBox.Image = bitmapnotRealBox;

            // start with full screen
            this.WindowState = FormWindowState.Maximized;
        }
        // update day and time
        private void timerTime_Tick(object sender, EventArgs e)
        {
            Queue.TimeString.getTime(labelTimers[2], labelTimers[3]);
            GC.Collect(); //Cleans the memory from the garbage
        }

        // Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            // When one of the timer reaches 0 the game ends
            if (labelTimers[1].Text == "00:00" || labelTimers[0].Text == "00:00")
            {
                // Stops timer,Reset player not playable,Inserts in the DB and shows message
                timer.Stop();
                player.Play = "-";
                dbChess.insertGameDB(player.Player1, player.Player2, labelTime.Text, labelDay.Text);
                MessageBox.Show("Timer is over and game saved");
            }

            // Runs Timer based on the color
            else if (player.Play == "w")
            {
                Queue.TimeString.updateTimer(labelTimers[1]);
            }else if (player.Play == "b")
            {
                Queue.TimeString.updateTimer(labelTimers[0]);
            }
            
        }

        // I make the sizes while Form1_Resize
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (pictureBoxes[0] != null)
            {
                // make the sizes, points and set thisMinimumSize
                chessBoard_positions_size();
                Test_Size_Form(this);
                // this is done to fix a bug related to sizing
                // it has to do with which MinimumSize you use when you run Form1_Resize
                this.MinimumSize = new Size(0, 0);

                // notRealBox have the size of a box on the chessboard
                // because they have 8 boxes in a row 
                PictureBoxNotRealBox.Height = PictureBoxNotRealBox.Width = chessBoard.Width / 8;
                // and in end i make it invincible
                PictureBoxNotRealBox.Visible = false;
            }
        }




        // It is for uniform movement of the box that has the pawn
        int[] oldPositionCounter = new int[2];
        // I need this if the pawn goes off the range
        int[] startPositionPutDown = new int[2];
        // Checking if the notRealBox can be moved or not
        bool mouseDownPressed = false;



        // chessBoard_MouseDown is used to allow the user to take the pawn
        private void chessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            // I check if the game has started
            if (clickStart)
            {


                // At the beginning I pass the position that would be in the real image
                int[] positions = Commands.ChessPositions.Convert_Position_Real(e.X, e.Y, chessBoard.Width, 1080);
                // then I check if the number is valid
                if (Commands.ChessPositions.Test_Positions(positions[0], positions[1], 1080))
                {
                    // i enable not realbox to use
                    PictureBoxNotRealBox.Enabled = true;
                    PictureBoxNotRealBox.Visible = true;

                    //then i take position cursore
                    int[] cursore = { e.X, e.Y };

                    // I get the starting position of the box in the real image
                    cursore = Commands.ChessPositions.Start_Positions_notRealBox(cursore[0], cursore[1], chessBoard.Width, 135, 1080);


                    int PositionPawn = PawnMap.PositionImageToPositionMap(e.X, e.Y, 1080, 8, chessBoard.Width);

                    // I paint it on the box I'm going to move
                    // and clean the box I got the pawn from
                    if (bitmapnotRealBox != null) bitmapnotRealBox.Dispose();
                    
                    bitmapnotRealBox = Commands.Draw.Take_Pawn_On_Box(pawnmap.WBPawn[PositionPawn]);
                    PictureBoxNotRealBox.Image = bitmapnotRealBox;
                    Commands.Draw.Clean_Box(bitmapChessBoard, cursore[0], cursore[1], 135);

                    // I take the notRealBox and hold it from the position I stepped on
                    // converting the original position of the box on the image to the original position of the box on the pictureBox
                    cursore = Commands.ChessPositions.Convert_Position_Fake(cursore[0], cursore[1], chessBoard.Width, chessBoard.Height, 1080);
                    PictureBoxNotRealBox.Location = new Point(cursore[0], cursore[1]);


                    // allow the notRealBox to be moved
                    if (bitmapnotRealBox != null) mouseDownPressed = true;

                    // I set the mouse position as initial for startPositionPutDown and oldPositionCounter
                    startPositionPutDown[0] = e.X;
                    startPositionPutDown[1] = e.Y;

                    oldPositionCounter[0] = e.X;
                    oldPositionCounter[1] = e.Y;

                }
            }
        }

        // here I move the notRealBox that the pawn is on
        private void chessBoard_MouseMove(object sender, MouseEventArgs e)
        {
            // do you allow transit or not?
            if (mouseDownPressed)
            {
                // I see how far the cursor has moved and to where
                int[] newposition = { e.X - oldPositionCounter[0], e.Y - oldPositionCounter[1] };

                // moving the notRealBox to the point where the cursor was moved
                PictureBoxNotRealBox.Location = new Point(PictureBoxNotRealBox.Location.X + newposition[0], PictureBoxNotRealBox.Location.Y + newposition[1]);
                // and I see in the old place the place where the ark is now
                oldPositionCounter[0] = e.X;
                oldPositionCounter[1] = e.Y;
            }

        }

        // here use chessBoard_MouseUp to select where the pawn will be drawn
        private void chessBoard_MouseUp(object sender, MouseEventArgs e)
        {
            // I check if the game has started and check whether or not you are allowed to move the pawn (Empty block)
            if (clickStart && mouseDownPressed)
            {


                int oldPositionPawn = PawnMap.PositionImageToPositionMap(startPositionPutDown[0], startPositionPutDown[1], 1080, 8, chessBoard.Width);
                int newPositionPawn = PawnMap.PositionImageToPositionMap(e.X, e.Y, 1080, 8, chessBoard.Width);



                // I convert the mouse position to the position in the image
                // to check if it is out of bounds
                int[] positions = Commands.ChessPositions.Convert_Position_Real(e.X, e.Y, chessBoard.Width, 1080);
                // if it is within the bounds then it will be drawn over the selected square
                if (Commands.ChessPositions.Test_Positions(positions[0], positions[1], 1080) && !pawnmap.testColorPawns(oldPositionPawn, newPositionPawn) && pawnmap.testColorPawns(oldPositionPawn, player.Play))
                {

                    pawnmap.positionChange(oldPositionPawn, newPositionPawn);

                    player.playerChange(pictureBoxPlay);


                    // I get the starting position of the box in the real image
                    positions = Commands.ChessPositions.Start_Positions_notRealBox(e.X, e.Y, chessBoard.Width, 135, 1080);
                    // draw on the box
                    Commands.Draw.draw_Chess_Box(bitmapChessBoard, bitmapnotRealBox, positions[0], positions[1]);
                    chessBoard.Image = bitmapChessBoard;


                }
                //  if it is out, the pawn should be redrawn
                //  in the original position we experimented with when we did it chessBoard_MouseDown
                else
                {
                    // I get the starting position of the box in the real image
                    positions = Commands.ChessPositions.Start_Positions_notRealBox(startPositionPutDown[0], startPositionPutDown[1], chessBoard.Width, 135, 1080);
                    // draw on the box
                    Commands.Draw.draw_Chess_Box(bitmapChessBoard, bitmapnotRealBox, positions[0], positions[1]);
                    chessBoard.Image = bitmapChessBoard;
                }
                //and disable takeSquare 
                PictureBoxNotRealBox.Enabled = false;
                PictureBoxNotRealBox.Visible = false;
                mouseDownPressed = false;


            }
        }


        // pictureBoxes - BUTTONS
        //
        // the game has not started
        bool clickStart = false;
        // use this button to start the game and set a time with names
        private void Start_Click(object sender, EventArgs e)
        {

            // until the commands are completed the buttons will not work
            Commands.Stop_Butons(pictureBoxes);



            // Take map and reset players turn

            if (clickStart)
            {
                pawnmap.RestartMap();
            }
            player.SetStartVariablesQueue();
            player.resetColorChange(pictureBoxPlay);
            //


            // the sizes that the form takes are 1/2 of the main one
            // and
            // until the form that sets the time and name is called
            // the checkerboard does not work
            FormSetTimer form = new FormSetTimer(this, labelTimers, player, timer, pictureBoxes);
            form.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);
            form.Show();

            //import foto with figures
            bitmapChessBoard.Dispose();
            bitmapChessBoard = Properties.Resources.ChessBoardWithFigure;
            chessBoard.Image = bitmapChessBoard;

            // the game has begun
            clickStart = true;

            Commands.Start_Buttons(pictureBoxes);
            

        }

        // restart the game
        private void Reset_Click(object sender, EventArgs e)
        {
            // until the commands are completed the buttons will not work
            Commands.Stop_Butons(pictureBoxes);
            // has the game started??
            if (clickStart)
            {

                timer.Stop();
                labelTimers[0].Text = player.GameTime;
                labelTimers[1].Text = player.GameTime;

                if (player.GameTime != "00:00")
                {
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Game with no time");
                }




                // Resets the map and the Player's turn
                pawnmap.RestartMap();
                player.SetStartVariablesQueue();
                player.resetColorChange(pictureBoxPlay);
                //


                // delete the chessboard bitmap to put the chessboard as it was originally
                // with pawns
                bitmapChessBoard.Dispose();
                bitmapChessBoard = Properties.Resources.ChessBoardWithFigure;
                chessBoard.Image = bitmapChessBoard;
            }

            Commands.Start_Buttons(pictureBoxes);
        }
        private void End_Click(object sender, EventArgs e)
        {
            // until the commands are completed the buttons will not work
            Commands.Stop_Butons(pictureBoxes);
            // has the game started??
            if (clickStart)
            {

                // Stops timer and saves data in the db


                timer.Stop();
                dbChess.insertGameDB(player.Player1, player.Player2, labelTime.Text, labelDay.Text);

                //Resets map and Player's turn and shows message

                pawnmap.RestartMap();
                player.SetStartVariables();
                MessageBox.Show("Game is over and saved");

                // Shows the game time

                labelTimers[0].Text = player.GameTime;
                labelTimers[1].Text = player.GameTime;

                // delete the bitmap of the chessboard to put the chessboard as it was in the first place
                // without the pawns
                bitmapChessBoard.Dispose();
                bitmapChessBoard = Properties.Resources.chessBoard;
                chessBoard.Image = bitmapChessBoard;

                // the game is over
                clickStart = false;
            }
            Commands.Start_Buttons(pictureBoxes);
        }
        // display the database with all games
        private void Info_Click(object sender, EventArgs e)
        {
            // until the commands are completed the buttons will not work
            Commands.Stop_Butons(pictureBoxes);

            FormInfoData form = new FormInfoData();
            // the sizes that the form takes are 1/2 of the main one
            form.Size = new Size(this.Width / 2, this.Height / 2);
            form.Show();

            Commands.Start_Buttons(pictureBoxes);
        }

        // Change players turn by pressing ctrl or by pressing the top left button (pictureBoxPlay)
        private void pictureBoxDontPlay_Click(object sender, EventArgs e)
        {
            player.playerChange(pictureBoxPlay);
        }

        private void FormChess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                player.playerChange(pictureBoxPlay);
            }
        }
    }
}
