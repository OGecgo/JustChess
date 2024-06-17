namespace chess_teamwork
{
    partial class FormChess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChess));
            this.panelRight = new System.Windows.Forms.Panel();
            this.flowLayoutPanelDay = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.flowLayoutPanelTimer = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTimer2 = new System.Windows.Forms.Label();
            this.labelTimer1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.PictureBox();
            this.End = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxChaingePlayer = new System.Windows.Forms.PictureBox();
            this.PictureBoxNotRealBox = new System.Windows.Forms.PictureBox();
            this.chessBoard = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelRight.SuspendLayout();
            this.flowLayoutPanelDay.SuspendLayout();
            this.flowLayoutPanelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChaingePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNotRealBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.panelRight.Controls.Add(this.flowLayoutPanelDay);
            this.panelRight.Controls.Add(this.flowLayoutPanelTimer);
            this.panelRight.Controls.Add(this.Info);
            this.panelRight.Controls.Add(this.End);
            this.panelRight.Controls.Add(this.Reset);
            this.panelRight.Controls.Add(this.Start);
            this.panelRight.Location = new System.Drawing.Point(542, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(103, 421);
            this.panelRight.TabIndex = 2;
            // 
            // flowLayoutPanelDay
            // 
            this.flowLayoutPanelDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.flowLayoutPanelDay.Controls.Add(this.labelTime);
            this.flowLayoutPanelDay.Controls.Add(this.labelDay);
            this.flowLayoutPanelDay.Location = new System.Drawing.Point(10, 231);
            this.flowLayoutPanelDay.Name = "flowLayoutPanelDay";
            this.flowLayoutPanelDay.Size = new System.Drawing.Size(82, 55);
            this.flowLayoutPanelDay.TabIndex = 9;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.labelTime.Location = new System.Drawing.Point(3, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(77, 29);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDay
            // 
            this.labelDay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.labelDay.Location = new System.Drawing.Point(3, 29);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(77, 26);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "00.00.00";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanelTimer
            // 
            this.flowLayoutPanelTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.flowLayoutPanelTimer.Controls.Add(this.labelTimer2);
            this.flowLayoutPanelTimer.Controls.Add(this.labelTimer1);
            this.flowLayoutPanelTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanelTimer.Location = new System.Drawing.Point(10, 292);
            this.flowLayoutPanelTimer.Name = "flowLayoutPanelTimer";
            this.flowLayoutPanelTimer.Size = new System.Drawing.Size(80, 122);
            this.flowLayoutPanelTimer.TabIndex = 8;
            // 
            // labelTimer2
            // 
            this.labelTimer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTimer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.labelTimer2.Location = new System.Drawing.Point(3, 0);
            this.labelTimer2.Name = "labelTimer2";
            this.labelTimer2.Size = new System.Drawing.Size(79, 55);
            this.labelTimer2.TabIndex = 0;
            this.labelTimer2.Text = "00:00";
            this.labelTimer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelTimer1
            // 
            this.labelTimer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTimer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.labelTimer1.Location = new System.Drawing.Point(3, 55);
            this.labelTimer1.Name = "labelTimer1";
            this.labelTimer1.Size = new System.Drawing.Size(77, 68);
            this.labelTimer1.TabIndex = 1;
            this.labelTimer1.Text = "00:00";
            this.labelTimer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Info
            // 
            this.Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Image = ((System.Drawing.Image)(resources.GetObject("Info.Image")));
            this.Info.Location = new System.Drawing.Point(10, 174);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(80, 51);
            this.Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info.TabIndex = 3;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // End
            // 
            this.End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End.Image = global::chess_teamwork.Properties.Resources.End;
            this.End.Location = new System.Drawing.Point(10, 117);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(80, 51);
            this.End.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.End.TabIndex = 2;
            this.End.TabStop = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Image = global::chess_teamwork.Properties.Resources.Reset;
            this.Reset.Location = new System.Drawing.Point(10, 60);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(80, 51);
            this.Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Reset.TabIndex = 1;
            this.Reset.TabStop = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Image = global::chess_teamwork.Properties.Resources.Start;
            this.Start.Location = new System.Drawing.Point(10, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 51);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.panelLeft.Controls.Add(this.pictureBoxPlay);
            this.panelLeft.Controls.Add(this.pictureBoxChaingePlayer);
            this.panelLeft.Location = new System.Drawing.Point(2, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(87, 414);
            this.panelLeft.TabIndex = 8;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxPlay.Location = new System.Drawing.Point(10, 347);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(65, 62);
            this.pictureBoxPlay.TabIndex = 1;
            this.pictureBoxPlay.TabStop = false;
            // 
            // pictureBoxChaingePlayer
            // 
            this.pictureBoxChaingePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(41)))), ((int)(((byte)(27)))));
            this.pictureBoxChaingePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxChaingePlayer.Location = new System.Drawing.Point(10, 3);
            this.pictureBoxChaingePlayer.Name = "pictureBoxChaingePlayer";
            this.pictureBoxChaingePlayer.Size = new System.Drawing.Size(65, 62);
            this.pictureBoxChaingePlayer.TabIndex = 0;
            this.pictureBoxChaingePlayer.TabStop = false;
            this.pictureBoxChaingePlayer.Click += new System.EventHandler(this.pictureBoxDontPlay_Click);
            // 
            // PictureBoxNotRealBox
            // 
            this.PictureBoxNotRealBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxNotRealBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxNotRealBox.Enabled = false;
            this.PictureBoxNotRealBox.Image = global::chess_teamwork.Properties.Resources.wKing;
            this.PictureBoxNotRealBox.Location = new System.Drawing.Point(108, 0);
            this.PictureBoxNotRealBox.Name = "PictureBoxNotRealBox";
            this.PictureBoxNotRealBox.Size = new System.Drawing.Size(51, 53);
            this.PictureBoxNotRealBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxNotRealBox.TabIndex = 1;
            this.PictureBoxNotRealBox.TabStop = false;
            this.PictureBoxNotRealBox.Visible = false;
            // 
            // chessBoard
            // 
            this.chessBoard.Image = global::chess_teamwork.Properties.Resources.chessBoard;
            this.chessBoard.Location = new System.Drawing.Point(95, 0);
            this.chessBoard.Name = "chessBoard";
            this.chessBoard.Size = new System.Drawing.Size(441, 414);
            this.chessBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chessBoard.TabIndex = 0;
            this.chessBoard.TabStop = false;
            this.chessBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chessBoard_MouseDown);
            this.chessBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chessBoard_MouseMove);
            this.chessBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chessBoard_MouseUp);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(650, 422);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.PictureBoxNotRealBox);
            this.Controls.Add(this.chessBoard);
            this.Controls.Add(this.panelRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormChess_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelRight.ResumeLayout(false);
            this.flowLayoutPanelDay.ResumeLayout(false);
            this.flowLayoutPanelTimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChaingePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNotRealBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chessBoard;
        private System.Windows.Forms.PictureBox PictureBoxNotRealBox;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.PictureBox Info;
        private System.Windows.Forms.PictureBox End;
        private System.Windows.Forms.PictureBox Reset;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTimer;
        private System.Windows.Forms.Label labelTimer2;
        private System.Windows.Forms.Label labelTimer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDay;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxChaingePlayer;
    }
}

