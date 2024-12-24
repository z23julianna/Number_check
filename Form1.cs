namespace Угадайка
{
    public partial class Form1 : Form
    {
        int guessNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            guessNumber = random.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userinput = userinpuTextBox.Text;
            userinpuTextBox.Clear();
            userinpuTextBox.Focus();
            var parsed = int.TryParse(userinput, out var UserNumber);
            if (!parsed)
            {
                verdictLAbel.Text = $"введите число";
                return;
            }

            if (!(UserNumber >=1 && UserNumber <=100))
            {
                verdictLAbel.Text = $"введите число от 1 до 100";
                return;
            }


            if (UserNumber == guessNumber)
            {
                MessageBox.Show("поздравляю.угадали число!");
            }
            else
            {
                if (guessNumber > UserNumber)
                {
                    verdictLAbel.Text = $"Мое число больше {UserNumber}";
                }
                else
                {
                    verdictLAbel.Text = $"Мое число меньше {UserNumber}";
                }
            }
            userinpuTextBox.Clear();
            userinpuTextBox.Focus();
        }
    }
}


