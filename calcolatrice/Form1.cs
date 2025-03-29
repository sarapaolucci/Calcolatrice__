namespace calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string num = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            num += "1";
            label.Text = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num += "2";
            label.Text = num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num += "3";
            label.Text = num;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num += "4";
            label.Text = num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num += "5";
            label.Text = num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num += "6";
            label.Text = num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num += "7";
            label.Text = num;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num += "8";
            label.Text = num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num += "9";
            label.Text = num;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num += "0";
            label.Text = num;
        }

        private void pulisci_Click(object sender, EventArgs e)
        {
            label.Text = "";
            num = "";
        }

        private void buttonpiu_Click(object sender, EventArgs e)
        {
            num += "+";
            label.Text = num;
        }

        private void buttonmeno_Click(object sender, EventArgs e)
        {
            num += "-";
            label.Text = num;
        }

        private void buttonper_Click(object sender, EventArgs e)
        {
            num += "*";
            label.Text = num;
        }

        private void buttondiviso_Click(object sender, EventArgs e)
        {
            num += "/";
            label.Text = num;
        }

        private void buttonris_Click(object sender, EventArgs e)
        {
            //FAI FUNZIONE CHE TI ESTRAE IL NUM E POI SUB STRING
            string cifre = "1234567890";
            int indice = 0;
            string n = "";
            bool r = true;
            while(r == true)
            {
                for(int i = 0; i < cifre.Length; i++)
                {
                    for(int j = 0; j < num.Length; j++)
                    {
                        if (num[j] == cifre[i])
                        {
                            n += num;
                        }
                        else
                        {
                            j = num.Length;
                            i = cifre.Length;
                            r = false;
                        }
                    }
                }
            }
        }
    }
}