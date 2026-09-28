namespace pr6
{
    public partial class Form1 : Form
    {
        // ---------- Поля игры ----------
        private int playerX = 100, playerY = 100;
        private int targetX, targetY;
        private int score = 0;
        private int timeLeft = 30;
        private Random rnd = new Random();
        private const int PlayerSize = 30;
        private const int TargetSize = 40;

        public Form1()
        {
            InitializeComponent();

            // Начальная позиция цели
            // Math.Max(1, ...) защищает от отрицательной границы, если форма
            // окажется меньше размера цели
            targetX = rnd.Next(0, Math.Max(1, this.ClientSize.Width - TargetSize));
            targetY = rnd.Next(0, Math.Max(1, this.ClientSize.Height - TargetSize));

            // Запуск таймеров
            timerGame.Start();
            timerSecond.Start();
        }

        // ---------- Игровой цикл (20 кадров в секунду) ----------
        private void timerGame_Tick(object sender, EventArgs e)
        {
            // Проверка столкновения
            Rectangle playerRect = new Rectangle(playerX, playerY, PlayerSize, PlayerSize);
            Rectangle targetRect = new Rectangle(targetX, targetY, TargetSize, TargetSize);

            if (playerRect.IntersectsWith(targetRect))
            {
                score++;
                labelScore.Text = "Счёт: " + score;

                // Новая позиция цели
                targetX = rnd.Next(0, Math.Max(1, this.ClientSize.Width - TargetSize));
                targetY = rnd.Next(0, Math.Max(1, this.ClientSize.Height - TargetSize));
            }

            // Перерисовать форму
            this.Invalidate();
        }

        // ---------- Обратный отсчёт времени ----------
        private void timerSecond_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTime.Text = "Время: " + timeLeft;

            if (timeLeft <= 0)
            {
                timerGame.Stop();
                timerSecond.Stop();
                MessageBox.Show("Игра окончена! Ваш счёт: " + score, "Результат");
                this.Close();
            }
        }

        // ---------- Управление игроком ----------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 10;
            switch (e.KeyCode)
            {
                case Keys.Left: playerX -= step; break;
                case Keys.Right: playerX += step; break;
                case Keys.Up: playerY -= step; break;
                case Keys.Down: playerY += step; break;
            }

            // Ограничение по границам формы
            playerX = Math.Max(0, Math.Min(this.ClientSize.Width - PlayerSize, playerX));
            playerY = Math.Max(0, Math.Min(this.ClientSize.Height - PlayerSize, playerY));
        }

        // ---------- Отрисовка ----------
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Игрок — синий квадрат
            g.FillRectangle(Brushes.Blue, playerX, playerY, PlayerSize, PlayerSize);

            // Цель — красный квадрат
            g.FillRectangle(Brushes.Red, targetX, targetY, TargetSize, TargetSize);
        }

    }
}
