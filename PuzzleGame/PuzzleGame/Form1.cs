namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] PuzzlePosition = new string[3, 3]
        {
                {"00","01","02"},
                {"10","11","12"},
                {"20","21","black"}
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRestart.Location = new Point(475, 5);
            btnRestart.Hide();
        }

        public void MakeRandomPosition()
        {
            Random rnd = new Random();

            for (int i = 0; i < PuzzlePosition.GetLength(0); i++)
            {
                for (int j = 0; j < PuzzlePosition.GetLength(1); j++)
                {
                    int randoomRow = rnd.Next(0, PuzzlePosition.GetLength(0));
                    int randoomColumn = rnd.Next(0, PuzzlePosition.GetLength(1));

                    string temp = PuzzlePosition[i, j];

                    PuzzlePosition[i, j] = PuzzlePosition[randoomRow, randoomColumn];
                    PuzzlePosition[randoomRow, randoomColumn] = temp;
                }
            }
        }
        private void FixPieces()
        {
            int locationX = 0;
            int locationY = -150;
            int locationRepait = 0;

            foreach (var item in PuzzlePosition)
            {
                if (locationRepait % 3 == 0)
                {
                    locationY += 150;
                    locationX = 0;
                }
                Button btn = (Button)this.Controls[$"btn{item}"];
                if (btn != null)
                {
                    btn.Location = new Point(locationX, locationY);
                }

                locationX += 150;
                locationRepait++;
            }
        }

        int PosX;
        int PosY;

        public void MakeMove()
        {

            for (int i = 0; i < PuzzlePosition.GetLength(0); i++)
            {
                for (int j = 0; j < PuzzlePosition.GetLength(1); j++)
                {
                    if (PuzzlePosition[i, j] == "black")
                    {
                        PosX = i;
                        PosY = j;

                        if (PosX - 1 == 0 || PosX - 1 == 1)
                        {
                            string ButtonName = PuzzlePosition[PosX - 1, PosY];
                            Button ActiveButton = (Button)this.Controls[$"btn{ButtonName}"];
                            ActiveButton.Click += ActiveButton_Click;
                        }
                        if (PosX + 1 == 1 || PosX + 1 == 2)
                        {
                            string ButtonName = PuzzlePosition[PosX + 1, PosY];
                            Button ActiveButton = (Button)this.Controls[$"btn{ButtonName}"];
                            ActiveButton.Click += ActiveButton_Click;
                        }
                        if (PosY - 1 == 0 || PosY - 1 == 1)
                        {
                            string ButtonName = PuzzlePosition[PosX, PosY - 1];
                            Button ActiveButton = (Button)this.Controls[$"btn{ButtonName}"];
                            ActiveButton.Click += ActiveButton_Click;
                        }
                        if (PosY + 1 == 1 || PosY + 1 == 2)
                        {
                            string ButtonName = PuzzlePosition[PosX, PosY + 1];
                            Button ActiveButton = (Button)this.Controls[$"btn{ButtonName}"];
                            ActiveButton.Click += ActiveButton_Click;
                        }
                    }
                }
            }
        }

        private void ActiveButton_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            int BlackPositionX = PosX;
            int BlackPositionY = PosY;

            string SwapButtonPosition = btn.Name.Substring(3, 2);

            for (int i = 0; i < PuzzlePosition.GetLength(0); i++)
            {
                for (int j = 0; j < PuzzlePosition.GetLength(1); j++)
                {
                    if (PuzzlePosition[i, j] == SwapButtonPosition)
                    {
                        string temp = PuzzlePosition[i, j];

                        PuzzlePosition[i, j] = PuzzlePosition[BlackPositionX, BlackPositionY];
                        PuzzlePosition[BlackPositionX, BlackPositionY] = temp;
                        break;

                    }
                }
            }
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    Button buttonReset = item as Button;
                    buttonReset.Click -= ActiveButton_Click;
                }
            }

            FixPieces();
            MakeMove();

            if (CheckWin())
            {
                string GameoverTime = "";

                if (seconds <= 9)
                {
                    GameoverTime = $"{minute}:0{seconds}";
                }
                else
                {
                    GameoverTime = $"{minute}:{seconds}";
                }

                timer1.Stop();
                MessageBox.Show($"Congratulations! You won in {GameoverTime}");
                btnStart.Show();
                btnRestart.Hide();
            }

        }
        public bool CheckWin()
        {
            string[,] WinPuzzlePosition = new string[3, 3]
            {
                {"00","01","02"},
                {"10","11","12"},
                {"20","21","black"}
            };

            for (int i = 0; i < PuzzlePosition.GetLength(0); i++)
            {
                for (int j = 0; j < PuzzlePosition.GetLength(1); j++)
                {
                    if (WinPuzzlePosition[i, j] != PuzzlePosition[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        int seconds = 0;
        int minute = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;
            if (seconds == 60)
            {
                minute++;
                seconds = 0;
            }
            if (seconds <= 9)
            {
                lblTime.Text = $"{minute}:0{seconds}";
            }
            else
            {
                lblTime.Text = $"{minute}:{seconds}";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnRestart.Show();
            lblTime.Text = $"0:00";
            seconds = 0;
            minute = 0;
            btnStart.Hide();
            timer1.Start();
            MakeRandomPosition();
            FixPieces();
            MakeMove();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStart.Show();
            btnStart.PerformClick();
        }
    }
}

