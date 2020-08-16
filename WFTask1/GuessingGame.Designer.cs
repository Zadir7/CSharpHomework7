namespace WFTask1
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.labelGameRules = new System.Windows.Forms.Label();
            this.labelGameStatus = new System.Windows.Forms.Label();
            this.textUserNumber = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(103, 173);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(103, 226);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToMainMenu.TabIndex = 1;
            this.buttonBackToMainMenu.Text = "Main Menu";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // labelGameRules
            // 
            this.labelGameRules.AutoSize = true;
            this.labelGameRules.Location = new System.Drawing.Point(41, 29);
            this.labelGameRules.Name = "labelGameRules";
            this.labelGameRules.Size = new System.Drawing.Size(207, 13);
            this.labelGameRules.TabIndex = 2;
            this.labelGameRules.Text = "Я загадал число от 1 до 100! Угадайте!";
            // 
            // labelGameStatus
            // 
            this.labelGameStatus.AutoSize = true;
            this.labelGameStatus.Location = new System.Drawing.Point(66, 80);
            this.labelGameStatus.Name = "labelGameStatus";
            this.labelGameStatus.Size = new System.Drawing.Size(182, 13);
            this.labelGameStatus.TabIndex = 3;
            this.labelGameStatus.Text = "Нажмите \"New Game\" для начала!";
            // 
            // textUserNumber
            // 
            this.textUserNumber.Location = new System.Drawing.Point(92, 109);
            this.textUserNumber.MaxLength = 10;
            this.textUserNumber.Name = "textUserNumber";
            this.textUserNumber.Size = new System.Drawing.Size(100, 20);
            this.textUserNumber.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(197, 106);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 25);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Отправить";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textUserNumber);
            this.Controls.Add(this.labelGameStatus);
            this.Controls.Add(this.labelGameRules);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "GuessingGame";
            this.Text = "GuessingGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Label labelGameRules;
        private System.Windows.Forms.Label labelGameStatus;
        private System.Windows.Forms.TextBox textUserNumber;
        private System.Windows.Forms.Button buttonSubmit;
    }
}