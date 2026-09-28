namespace pr6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Interval = 50;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerSecond
            // 
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 21);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Счёт: 0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(470, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(92, 21);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Время: 30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поймай квадрат";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTime;
    }
}
