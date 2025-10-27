using System.Security.Cryptography;

namespace 猜數字遊戲
{
    public partial class Form1 : Form
    {
        string answer = "";
        public Form1()
        {
           
            InitializeComponent();
        }
        private void StartNewGame()
        {
            Random rnd = new Random();
            answer = "";

            var ans = rnd.Next(1, 10000);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartNewGame();
        } 

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private string CheckGuess(string guess)
        {
            int A = 0; // 數字和位置都對
            int B = 0; // 數字對但位置錯

            // 逐一比較4位數字
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == ans[i])
                {
                    A++; // 相同位置數字相同 → A
                }
                else if (ans.Contains(guess[i]))
                {
                    B++; // 答案中有這個數字但位置不同 → B
                }
            }

            // 回傳結果文字，例如 "1A2B"
            return $"{A}A{B}B";
        }
    }
}
