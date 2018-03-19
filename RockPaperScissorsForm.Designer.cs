namespace RockPaperScissorsToluA
{
    partial class frmRockPaperScissors
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
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.grbPlayerOptions = new System.Windows.Forms.GroupBox();
            this.grbComputerOptions = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbPlayerOptions.SuspendLayout();
            this.grbComputerOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Location = new System.Drawing.Point(6, 19);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(51, 17);
            this.radPlayerRock.TabIndex = 0;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Location = new System.Drawing.Point(6, 65);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(64, 17);
            this.radPlayerScissors.TabIndex = 1;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Scissors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Location = new System.Drawing.Point(6, 42);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(53, 17);
            this.radPlayerPaper.TabIndex = 2;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(12, 19);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 3;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(12, 42);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
            this.radComputerPaper.TabIndex = 4;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(12, 65);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(64, 17);
            this.radComputerScissors.TabIndex = 5;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Scissors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // grbPlayerOptions
            // 
            this.grbPlayerOptions.Controls.Add(this.radPlayerRock);
            this.grbPlayerOptions.Controls.Add(this.radPlayerScissors);
            this.grbPlayerOptions.Controls.Add(this.radPlayerPaper);
            this.grbPlayerOptions.Location = new System.Drawing.Point(12, 12);
            this.grbPlayerOptions.Name = "grbPlayerOptions";
            this.grbPlayerOptions.Size = new System.Drawing.Size(200, 117);
            this.grbPlayerOptions.TabIndex = 6;
            this.grbPlayerOptions.TabStop = false;
            this.grbPlayerOptions.Text = "Player";
            // 
            // grbComputerOptions
            // 
            this.grbComputerOptions.Controls.Add(this.radComputerRock);
            this.grbComputerOptions.Controls.Add(this.radComputerPaper);
            this.grbComputerOptions.Controls.Add(this.radComputerScissors);
            this.grbComputerOptions.Location = new System.Drawing.Point(12, 179);
            this.grbComputerOptions.Name = "grbComputerOptions";
            this.grbComputerOptions.Size = new System.Drawing.Size(200, 120);
            this.grbComputerOptions.TabIndex = 7;
            this.grbComputerOptions.TabStop = false;
            this.grbComputerOptions.Text = "Computer";
            this.grbComputerOptions.Enter += new System.EventHandler(this.grbComputerOptions_Enter);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(137, 150);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputerOptions);
            this.Controls.Add(this.grbPlayerOptions);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors Game";
            this.grbPlayerOptions.ResumeLayout(false);
            this.grbPlayerOptions.PerformLayout();
            this.grbComputerOptions.ResumeLayout(false);
            this.grbComputerOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.GroupBox grbPlayerOptions;
        private System.Windows.Forms.GroupBox grbComputerOptions;
        private System.Windows.Forms.Button btnPlay;
    }
}

