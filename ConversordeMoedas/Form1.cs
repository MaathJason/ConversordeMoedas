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
            double valor, valoreal, euro, dolar;

            euro = 6.16;
            dolar = 5.52;
            string moeda = textBox2.Text;
            valor = double.Parse(textBox1.Text);

            if (moeda.ToLower() == "euro")
            {
                valoreal = valor * euro;
                textBox3.Text = valoreal.ToString("C");
            } else if(moeda.ToLower() == "dolar")
            {
                valoreal = valor * dolar;
                textBox3.Text = valoreal.ToString("C");
            }
            else
            {
                MessageBox.Show("Moeda invalida, insira Euro ou Dolar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = string.Empty;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
        

        }
    }
}
