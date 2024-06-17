namespace chess_teamwork
{
    partial class FormInfoData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoData));
            this.richTextBoxLeft = new System.Windows.Forms.RichTextBox();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelDay = new System.Windows.Forms.Label();
            this.richTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLeft
            // 
            this.richTextBoxLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.richTextBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBoxLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(82)))));
            this.richTextBoxLeft.Location = new System.Drawing.Point(66, 6);
            this.richTextBoxLeft.Name = "richTextBoxLeft";
            this.richTextBoxLeft.ReadOnly = true;
            this.richTextBoxLeft.Size = new System.Drawing.Size(232, 487);
            this.richTextBoxLeft.TabIndex = 0;
            this.richTextBoxLeft.Text = "";
            // 
            // labelPlayers
            // 
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.labelPlayers.Location = new System.Drawing.Point(3, 9);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(66, 33);
            this.labelPlayers.TabIndex = 2;
            this.labelPlayers.Text = "Players::";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.panelLeft.Controls.Add(this.richTextBoxLeft);
            this.panelLeft.Controls.Add(this.labelPlayers);
            this.panelLeft.Location = new System.Drawing.Point(12, 12);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(305, 506);
            this.panelLeft.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(87)))), ((int)(((byte)(56)))));
            this.panelRight.Controls.Add(this.labelDay);
            this.panelRight.Controls.Add(this.richTextBoxRight);
            this.panelRight.Controls.Add(this.labelTime);
            this.panelRight.Location = new System.Drawing.Point(347, 12);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(331, 506);
            this.panelRight.TabIndex = 4;
            // 
            // labelDay
            // 
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.labelDay.Location = new System.Drawing.Point(3, 54);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(66, 45);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Day::";
            // 
            // richTextBoxRight
            // 
            this.richTextBoxRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.richTextBoxRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBoxRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(127)))), ((int)(((byte)(82)))));
            this.richTextBoxRight.Location = new System.Drawing.Point(75, 6);
            this.richTextBoxRight.Name = "richTextBoxRight";
            this.richTextBoxRight.ReadOnly = true;
            this.richTextBoxRight.Size = new System.Drawing.Size(243, 487);
            this.richTextBoxRight.TabIndex = 0;
            this.richTextBoxRight.Text = "";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(31)))));
            this.labelTime.Location = new System.Drawing.Point(3, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(66, 45);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time::";
            // 
            // FormInfoData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(745, 530);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoData";
            this.Text = "InfoData";
            this.Load += new System.EventHandler(this.FormInfoData_Load);
            this.Resize += new System.EventHandler(this.FormInfoData_Resize);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLeft;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.RichTextBox richTextBoxRight;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDay;
    }
}