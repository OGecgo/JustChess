namespace chess_teamwork
{
    partial class FormSetTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetTimer));
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.labelMin = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.panelUp = new System.Windows.Forms.Panel();
            this.labelVs = new System.Windows.Forms.Label();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.numericUpDownMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericUpDownMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(82)))));
            this.numericUpDownMin.Location = new System.Drawing.Point(13, 61);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(133, 29);
            this.numericUpDownMin.TabIndex = 2;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.labelMin.Location = new System.Drawing.Point(152, 61);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(57, 31);
            this.labelMin.TabIndex = 3;
            this.labelMin.Text = "Min";
            // 
            // panelDown
            // 
            this.panelDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.panelDown.Controls.Add(this.pictureBoxPlay);
            this.panelDown.Location = new System.Drawing.Point(171, 137);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(162, 92);
            this.panelDown.TabIndex = 4;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlay.Image = global::chess_teamwork.Properties.Resources.Play;
            this.pictureBoxPlay.Location = new System.Drawing.Point(13, 16);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(133, 63);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 1;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelUp
            // 
            this.panelUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUp.AutoScroll = true;
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.panelUp.Controls.Add(this.labelVs);
            this.panelUp.Controls.Add(this.numericUpDownMin);
            this.panelUp.Controls.Add(this.labelMin);
            this.panelUp.Controls.Add(this.textBoxName2);
            this.panelUp.Controls.Add(this.textBoxName1);
            this.panelUp.Location = new System.Drawing.Point(12, 12);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(321, 105);
            this.panelUp.TabIndex = 5;
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.BackColor = System.Drawing.Color.Transparent;
            this.labelVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelVs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.labelVs.Location = new System.Drawing.Point(130, 13);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(46, 31);
            this.labelVs.TabIndex = 4;
            this.labelVs.Text = "Vs";
            // 
            // textBoxName2
            // 
            this.textBoxName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.textBoxName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(82)))));
            this.textBoxName2.Location = new System.Drawing.Point(201, 13);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 31);
            this.textBoxName2.TabIndex = 1;
            // 
            // textBoxName1
            // 
            this.textBoxName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.textBoxName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(82)))));
            this.textBoxName1.Location = new System.Drawing.Point(13, 13);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(100, 31);
            this.textBoxName1.TabIndex = 0;
            // 
            // FormSetTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panelDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSetTimer";
            this.Text = "SetTimer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSetTimer_FormClosed);
            this.Load += new System.EventHandler(this.FormSetTimer_Load);
            this.Resize += new System.EventHandler(this.FormSetTimer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxName1;
    }
}