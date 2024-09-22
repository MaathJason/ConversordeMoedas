namespace ConversordeMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor, valormoeda, euro, dolar, iene, libra;

            euro = 6.16;
            dolar = 5.52;
            iene = 0.048;
            libra = 7.20;

            valor = double.Parse(textBox1.Text);
            string moeda = comboBox1.SelectedItem.ToString();

            if (moeda == "Euro")
            {
                valormoeda = valor * euro;
            }
            else if (moeda == "Dolar")
            {
                valormoeda = valor * dolar;
            }
            else if (moeda == "Libra")
            {
                valormoeda = valor * libra;
            }
            else if (moeda == "Iene")
            {
                valormoeda = valor * iene;
            }
            else
            {
                MessageBox.Show("Moeda inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox3.Text = valormoeda.ToString("N2");
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
