namespace Pequenia_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            decimal x = this.nudOp1.Value;
            decimal y = this.nupOperando2.Value;

            decimal total = x + y;
            this.barraResultados.Text = total.ToString();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            decimal x = this.nudOp1.Value;
            decimal y = this.nupOperando2.Value;

            decimal total = x - y;
            this.barraResultados.Text = total.ToString();
        }

        private void botonMultiplicar_Click(object sender, EventArgs e)
        {
            decimal x = this.nudOp1.Value;
            decimal y = this.nupOperando2.Value;

            decimal total = x * y;
            this.barraResultados.Text = total.ToString();
        }

        private void botonDividir_Click(object sender, EventArgs e)
        {
            decimal x = this.nudOp1.Value;
            decimal y = this.nupOperando2.Value;

            if (y == 0)
            {
                MessageBox.Show("Syntax Error");
            }
            else
            {
                decimal total = x / y;
                this.barraResultados.Text = total.ToString();
            }
        }

        private void nupOperando2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
