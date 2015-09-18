namespace Guessing_Game
{
    partial class GuessingGame
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
            this.Welcome = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.Guess = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(12, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(309, 13);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to McBuilds Studios Random Number Guessing Game";
            this.Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(97, 145);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(110, 20);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // Guess
            // 
            this.Guess.AutoSize = true;
            this.Guess.Location = new System.Drawing.Point(94, 101);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(113, 13);
            this.Guess.TabIndex = 2;
            this.Guess.Text = "Enter your guess here!";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(97, 207);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Welcome);
            this.Name = "GuessingGame";
            this.Text = "McBuilds Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label Guess;
        private System.Windows.Forms.Button submit;
    }
}

