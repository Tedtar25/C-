namespace Calculadora_Area_Volumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbCubo_CheckedChanged(object sender, EventArgs e)
        {
            textoAlto.Visible = false;
            textoAncho.Visible = false;
            nudAlto.Visible = false;
            nudAncho.Visible = false;
        }

        private void nudLargo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbPrisma_CheckedChanged(object sender, EventArgs e)
        {
            textoAlto.Visible = true;
            textoAncho.Visible = true;
            nudAlto.Visible = true;
            nudAncho.Visible = true;
        }

        private void cbArea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbVolumen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            if (cbArea.Checked || cbVolumen.Checked)
            {
                decimal largo = nudLargo.Value;
                decimal alto = nudAlto.Visible ? nudAlto.Value : 0;
                decimal ancho = nudAncho.Visible ? nudAncho.Value : 0;

                if (rbCubo.Checked)
                {
                    if (cbArea.Checked)
                    {
                        decimal area = 6 * (largo * largo);
                        MessageBox.Show($"El área del cubo es: {area}");
                    }

                    if (cbVolumen.Checked)
                    {
                        decimal volumen = largo * largo * largo;
                        MessageBox.Show($"El volumen del cubo es: {volumen}");
                    }
                }
                else if (rbPrisma.Checked)
                {
                    if (cbArea.Checked)
                    {
                        decimal area = 2 * (largo * ancho + largo * alto + ancho * alto);
                        MessageBox.Show($"El área del prisma es: {area}");
                    }

                    if (cbVolumen.Checked)
                    {
                        decimal volumen = largo * alto * ancho;
                        MessageBox.Show($"El volumen del prisma es: {volumen}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una opción (Área o Volumen).");
            }
        }

    }
}
