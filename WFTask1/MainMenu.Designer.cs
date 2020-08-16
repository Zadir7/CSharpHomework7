namespace WFTask1
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonPlayDouble = new System.Windows.Forms.Button();
            this.buttonPlayGuessing = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.48F);
            this.labelWelcome.Location = new System.Drawing.Point(61, 23);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(158, 15);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Добро пожаловать в дз 7!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlayDouble
            // 
            this.buttonPlayDouble.Location = new System.Drawing.Point(64, 69);
            this.buttonPlayDouble.Name = "buttonPlayDouble";
            this.buttonPlayDouble.Size = new System.Drawing.Size(155, 23);
            this.buttonPlayDouble.TabIndex = 1;
            this.buttonPlayDouble.Text = "Играть в удвоитель";
            this.buttonPlayDouble.UseVisualStyleBackColor = true;
            this.buttonPlayDouble.Click += new System.EventHandler(this.buttonPlayDouble_Click);
            // 
            // buttonPlayGuessing
            // 
            this.buttonPlayGuessing.Location = new System.Drawing.Point(64, 107);
            this.buttonPlayGuessing.Name = "buttonPlayGuessing";
            this.buttonPlayGuessing.Size = new System.Drawing.Size(155, 23);
            this.buttonPlayGuessing.TabIndex = 2;
            this.buttonPlayGuessing.Text = "Играть в угадайку";
            this.buttonPlayGuessing.UseVisualStyleBackColor = true;
            this.buttonPlayGuessing.Click += new System.EventHandler(this.buttonPlayGuessing_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(64, 226);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(155, 23);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Выйти";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonPlayGuessing);
            this.Controls.Add(this.buttonPlayDouble);
            this.Controls.Add(this.labelWelcome);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonPlayDouble;
        private System.Windows.Forms.Button buttonPlayGuessing;
        private System.Windows.Forms.Button buttonQuit;
    }
}

