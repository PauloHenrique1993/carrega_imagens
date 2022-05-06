namespace Calculadora
{
    public partial class Form1 : Form
    {
        double total;
        double ultimonumero;
        string operador;

        private void Limpar()
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtresult.Text = "1";
        }
    }
}