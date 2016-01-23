namespace RockPaperScissorsGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerGameBoard = new System.Windows.Forms.SplitContainer();
            this.panelComputerScore = new System.Windows.Forms.Panel();
            this.labelComputerScore = new System.Windows.Forms.Label();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.panelUserScore = new System.Windows.Forms.Panel();
            this.labelUserScore = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.labelMe = new System.Windows.Forms.Label();
            this.labelYou = new System.Windows.Forms.Label();
            this.pictureBoxComputerChoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserChoice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGameBoard)).BeginInit();
            this.splitContainerGameBoard.Panel1.SuspendLayout();
            this.splitContainerGameBoard.Panel2.SuspendLayout();
            this.splitContainerGameBoard.SuspendLayout();
            this.panelComputerScore.SuspendLayout();
            this.panelUserScore.SuspendLayout();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerGameBoard
            // 
            this.splitContainerGameBoard.BackColor = System.Drawing.Color.Purple;
            this.splitContainerGameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGameBoard.ForeColor = System.Drawing.Color.White;
            this.splitContainerGameBoard.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGameBoard.Name = "splitContainerGameBoard";
            // 
            // splitContainerGameBoard.Panel1
            // 
            this.splitContainerGameBoard.Panel1.Controls.Add(this.pictureBoxComputerChoice);
            this.splitContainerGameBoard.Panel1.Controls.Add(this.panelComputerScore);
            // 
            // splitContainerGameBoard.Panel2
            // 
            this.splitContainerGameBoard.Panel2.Controls.Add(this.radioButtonScissors);
            this.splitContainerGameBoard.Panel2.Controls.Add(this.radioButtonPaper);
            this.splitContainerGameBoard.Panel2.Controls.Add(this.radioButtonRock);
            this.splitContainerGameBoard.Panel2.Controls.Add(this.pictureBoxUserChoice);
            this.splitContainerGameBoard.Panel2.Controls.Add(this.panelUserScore);
            this.splitContainerGameBoard.Size = new System.Drawing.Size(1103, 469);
            this.splitContainerGameBoard.SplitterDistance = 561;
            this.splitContainerGameBoard.TabIndex = 0;
            // 
            // panelComputerScore
            // 
            this.panelComputerScore.Controls.Add(this.labelMe);
            this.panelComputerScore.Controls.Add(this.labelComputerScore);
            this.panelComputerScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComputerScore.Location = new System.Drawing.Point(0, 0);
            this.panelComputerScore.Name = "panelComputerScore";
            this.panelComputerScore.Size = new System.Drawing.Size(561, 40);
            this.panelComputerScore.TabIndex = 0;
            // 
            // labelComputerScore
            // 
            this.labelComputerScore.AutoSize = true;
            this.labelComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerScore.Location = new System.Drawing.Point(12, 12);
            this.labelComputerScore.Name = "labelComputerScore";
            this.labelComputerScore.Size = new System.Drawing.Size(17, 17);
            this.labelComputerScore.TabIndex = 0;
            this.labelComputerScore.Text = "0";
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonScissors.Location = new System.Drawing.Point(407, 287);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(95, 23);
            this.radioButtonScissors.TabIndex = 5;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "SCISSORS";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            this.radioButtonScissors.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPaper.Location = new System.Drawing.Point(407, 230);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(73, 23);
            this.radioButtonPaper.TabIndex = 4;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "PAPER";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            this.radioButtonPaper.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRock.Location = new System.Drawing.Point(407, 173);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(68, 23);
            this.radioButtonRock.TabIndex = 3;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "ROCK";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            this.radioButtonRock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panelUserScore
            // 
            this.panelUserScore.Controls.Add(this.labelYou);
            this.panelUserScore.Controls.Add(this.labelUserScore);
            this.panelUserScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserScore.Location = new System.Drawing.Point(0, 0);
            this.panelUserScore.Name = "panelUserScore";
            this.panelUserScore.Size = new System.Drawing.Size(538, 40);
            this.panelUserScore.TabIndex = 0;
            // 
            // labelUserScore
            // 
            this.labelUserScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserScore.AutoSize = true;
            this.labelUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserScore.Location = new System.Drawing.Point(509, 12);
            this.labelUserScore.Name = "labelUserScore";
            this.labelUserScore.Size = new System.Drawing.Size(17, 17);
            this.labelUserScore.TabIndex = 1;
            this.labelUserScore.Text = "0";
            // 
            // panelResults
            // 
            this.panelResults.BackColor = System.Drawing.Color.Purple;
            this.panelResults.Controls.Add(this.buttonShoot);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResults.Location = new System.Drawing.Point(0, 469);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(1103, 74);
            this.panelResults.TabIndex = 2;
            // 
            // buttonShoot
            // 
            this.buttonShoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonShoot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoot.ForeColor = System.Drawing.Color.White;
            this.buttonShoot.Location = new System.Drawing.Point(324, 18);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(437, 44);
            this.buttonShoot.TabIndex = 0;
            this.buttonShoot.Text = "SHOOT";
            this.buttonShoot.UseVisualStyleBackColor = false;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // labelMe
            // 
            this.labelMe.AutoSize = true;
            this.labelMe.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMe.Location = new System.Drawing.Point(48, 11);
            this.labelMe.Name = "labelMe";
            this.labelMe.Size = new System.Drawing.Size(85, 19);
            this.labelMe.TabIndex = 1;
            this.labelMe.Text = "COMPUTER";
            // 
            // labelYou
            // 
            this.labelYou.AutoSize = true;
            this.labelYou.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYou.Location = new System.Drawing.Point(446, 11);
            this.labelYou.Name = "labelYou";
            this.labelYou.Size = new System.Drawing.Size(39, 19);
            this.labelYou.TabIndex = 2;
            this.labelYou.Text = "YOU";
            // 
            // pictureBoxComputerChoice
            // 
            this.pictureBoxComputerChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxComputerChoice.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxComputerChoice.InitialImage")));
            this.pictureBoxComputerChoice.Location = new System.Drawing.Point(155, 78);
            this.pictureBoxComputerChoice.Name = "pictureBoxComputerChoice";
            this.pictureBoxComputerChoice.Size = new System.Drawing.Size(329, 375);
            this.pictureBoxComputerChoice.TabIndex = 1;
            this.pictureBoxComputerChoice.TabStop = false;
            // 
            // pictureBoxUserChoice
            // 
            this.pictureBoxUserChoice.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserChoice.InitialImage")));
            this.pictureBoxUserChoice.Location = new System.Drawing.Point(38, 78);
            this.pictureBoxUserChoice.Name = "pictureBoxUserChoice";
            this.pictureBoxUserChoice.Size = new System.Drawing.Size(318, 375);
            this.pictureBoxUserChoice.TabIndex = 2;
            this.pictureBoxUserChoice.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 543);
            this.Controls.Add(this.splitContainerGameBoard);
            this.Controls.Add(this.panelResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 520);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.splitContainerGameBoard.Panel1.ResumeLayout(false);
            this.splitContainerGameBoard.Panel2.ResumeLayout(false);
            this.splitContainerGameBoard.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGameBoard)).EndInit();
            this.splitContainerGameBoard.ResumeLayout(false);
            this.panelComputerScore.ResumeLayout(false);
            this.panelComputerScore.PerformLayout();
            this.panelUserScore.ResumeLayout(false);
            this.panelUserScore.PerformLayout();
            this.panelResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGameBoard;
        private System.Windows.Forms.PictureBox pictureBoxComputerChoice;
        private System.Windows.Forms.Panel panelComputerScore;
        private System.Windows.Forms.Label labelComputerScore;
        private System.Windows.Forms.RadioButton radioButtonScissors;
        private System.Windows.Forms.RadioButton radioButtonPaper;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.PictureBox pictureBoxUserChoice;
        private System.Windows.Forms.Panel panelUserScore;
        private System.Windows.Forms.Label labelUserScore;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Label labelMe;
        private System.Windows.Forms.Label labelYou;
    }
}

