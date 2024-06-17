using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_teamwork
{
    public partial class FormInfoData : Form
    {

        DBChessExport data;

        
        public FormInfoData()
        {
            data = new BaseChess();
            InitializeComponent();
            data.exportGameDB(richTextBoxLeft, richTextBoxRight); // Exports data.
            data = null;
            GC.Collect();
        }
        // I make the sizes and positions
        private void Make_Panels()
        {
            // twoPercentWH is chosen for obvious reasons
            // the size silk distances of all objects
            int twoPercentWH = Convert.ToInt32((this.ClientSize.Width + this.ClientSize.Height) / 2 * (2 / 100.0));
            
            //panelLeft
            //
            // I'm making two equal panels that have a twoPercentWH distance from all the sides
            panelLeft.Size = new Size(this.ClientSize.Width / 2 - twoPercentWH * 2 + twoPercentWH / 2, this.ClientSize.Height - twoPercentWH * 2);
            panelLeft.Location = new Point(twoPercentWH, twoPercentWH);
            
            //I make the labels according to the function so that the font has the right sizes
            labelPlayers.Size = new Size(panelLeft.Width / 5, panelLeft.Width / 10);
            Commands.Take_Label_Size(labelPlayers);
            labelPlayers.Location = new Point(0, twoPercentWH);

            //I am making a richBox that will show the games
            //its sizes are such that it has a distance of twoPercentageWH from every object
            //and panel without taking into account the left side 
            richTextBoxLeft.Size = new Size(panelLeft.Width - labelPlayers.Width - twoPercentWH * 2, panelLeft.Height - twoPercentWH * 2);
            richTextBoxLeft.Location = new Point(labelPlayers.Width + twoPercentWH, twoPercentWH);
            richTextBoxLeft.Font = new Font(labelPlayers.Font, labelPlayers.Font.Style);

            //panelRight
            //
            // I'm making two equal panels that have a twoPercentWH distance from all the sides
            panelRight.Size = new Size(this.ClientSize.Width / 2 - twoPercentWH * 2 + twoPercentWH / 2, this.ClientSize.Height - twoPercentWH * 2);
            panelRight.Location = new Point(twoPercentWH * 2 + panelLeft.Width, twoPercentWH);

            //I make the labels according to the function so that the font has the right sizes
            labelTime.Size = new Size(panelRight.Width / 5, panelRight.Width / 10);
            Commands.Take_Label_Size(labelTime);
            labelTime.Location = new Point(0, twoPercentWH);

            labelDay.Size = new Size(panelRight.Width / 5, panelRight.Width / 10);
            Commands.Take_Label_Size(labelDay);
            labelDay.Location = new Point(0, labelTime.Height + twoPercentWH);

            //I am making a richBox that will show the time and day
            //its sizes are such that it has a distance of twoPercentageWH from every object
            //and panel without taking into account the left side
            richTextBoxRight.Size = new Size(panelRight.Width - labelTime.Width - twoPercentWH * 2, panelRight.Height - twoPercentWH * 2);
            richTextBoxRight.Location = new Point(labelTime.Width + twoPercentWH , twoPercentWH);
            richTextBoxRight.Font = new Font(labelTime.Font, labelTime.Font.Style);
        }
        // I make the sizes and positions
        private void FormInfoData_Load(object sender, EventArgs e)
        {
            Make_Panels();
        }

        private void FormInfoData_Resize(object sender, EventArgs e)
        {
            Make_Panels();
        }
    }
}
