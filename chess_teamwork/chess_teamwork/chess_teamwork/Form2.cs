using chess_teamwork.Inteface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace chess_teamwork
{
    public partial class FormSetTimer : Form
    {
        // the constructor which takes the form the labells and pictureBoxes of the other form
        Form form;
        Label[] labels;
        PictureBox[] pictureBoxes;
        SetNameTimePlayer player;
        Timer timer;
        public FormSetTimer(Form form, Label[] labels, SetNameTimePlayer player, Timer timer,  PictureBox[] pictureBoxes)
        {
            InitializeComponent();
            this.form = form;
            this.labels = labels;
            this.pictureBoxes = pictureBoxes;
            this.player = player;
            this.timer = timer;
        }

        // I make the sizes and positions
        private void Make_sizes_Locations()
        {
            // twoPercentWH is chosen for obvious reasons
            // the size silk distances of all objects
            int twoPercentWH = Convert.ToInt32((this.ClientSize.Width + this.ClientSize.Height) / 2 * (2 / 100.0));


            // panelUp
            //
            // I want the panelUp to be a little smaller than the width of the form
            panelUp.Size = new Size(this.ClientSize.Width - twoPercentWH * 2, this.ClientSize.Height - this.ClientSize.Height / 2 - twoPercentWH - twoPercentWH * 2);
            panelUp.Location = new Point(twoPercentWH, twoPercentWH);

            // and textBoxName are 1/3 size so they dance 2 textBoxName with labelVs and have a little space
            textBoxName1.Size = new Size(panelUp.Width / 3, 0);
            textBoxName1.Location = new Point(twoPercentWH, twoPercentWH);

            textBoxName2.Size = new Size(panelUp.Width / 3, 0);
            textBoxName2.Location = new Point(labelVs.Location.X + labelVs.Width, twoPercentWH);

            // I want the labelVs to be between the textBoxName
            labelVs.Location = new Point(textBoxName1.Width + twoPercentWH + twoPercentWH, twoPercentWH);


            // numericUpDownMin has the same sizes for appearance reasons
            numericUpDownMin.Size = new Size(panelUp.Width / 3, 0);
            // and I put it below the lable because it has heightcompared to the textBoxes as well as for the labelMin I put it on the right
            numericUpDownMin.Location = new Point(twoPercentWH, labelVs.Height + labelVs.Location.Y + twoPercentWH * 2);

            labelMin.Location = new Point(numericUpDownMin.Width + numericUpDownMin.Location.X, labelVs.Height + labelVs.Location.Y + twoPercentWH * 2);

            // panelDown
            //
            // half the size of the lath panel and the same height
            panelDown.Size = new Size(panelUp.Width / 2, this.ClientSize.Height / 2);
            // for appearance reasons I put it in the right half of the panelUp and below it
            panelDown.Location = new Point(twoPercentWH + panelUp.Width / 2, twoPercentWH * 2 + panelUp.Height);

            // the button that is in it I make it a little smaller than the same size panel "(panelDown (panelDown.Width / 11.4)"
            pictureBoxPlay.Size = new Size(Convert.ToInt32(panelDown.Width - (panelDown.Width / 11.4) * 2), Convert.ToInt32(panelDown.Height - (panelDown.Height / 9.13) * 2));
            pictureBoxPlay.Location = new Point(Convert.ToInt32(panelDown.Width / 11.4), Convert.ToInt32(panelDown.Height / 9.13));


        }
        // when the window opens I don't want to be able to use the chessboard
        private void FormSetTimer_Load(object sender, EventArgs e)
        {
            form.Enabled = false;
            // I make the sizes and positions
            Make_sizes_Locations();
        }
        // I make the sizes and positions
        private void FormSetTimer_Resize(object sender, EventArgs e)
        {
            Make_sizes_Locations();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // I put the button on a array to disable it
            PictureBox[] pictureBoxes = {pictureBoxPlay};
            //when i press the button because you don't need to press it again
            //i turn it off
            Commands.Stop_Butons(pictureBoxes);
            // display on the main form the time
            for (int i = 0; i < labels.Length - 2; i++)
            {
                // check whether it will be of the format xx:xx or not
                labels[i].Text = Queue.TimeString.changeFormat(((int)numericUpDownMin.Value),0);
            }
            player.GameTime = Queue.TimeString.changeFormat(((int)numericUpDownMin.Value), 0);

            // if nothing is given as a name, the warning that names will be (none) will be displayed
            if (textBoxName1.Text == "" || textBoxName2.Text == "")
            {
                MessageBox.Show("Play without name");
            }

            // at the end I call the form and activate the form with chess
            form.Enabled = true;

            player.Player1 = textBoxName1.Text;
            player.Player2 = textBoxName2.Text;


            this.Close();

        }
        // I don't allow the window to close if the game doesn't start.
        private void FormSetTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if the form is not called by the button then it will open again
            // because it is done by checking if I can use the form with chessboard or not
            if (!form.Enabled)
            {
                FormSetTimer copyForm = new FormSetTimer(form, labels, player, timer, pictureBoxes);
                copyForm.Size = new Size(form.Size.Width / 2, form.Size.Height / 2);
                copyForm.Show();
            }
            else
            {
                if (player.GameTime != "00:00")
                {
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("Game with no time");
                }
            }


        }
    }
}
