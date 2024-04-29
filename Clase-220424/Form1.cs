namespace Clase_220424
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalcular.Click += new EventHandler(botonCalcularClick);
            rbCubo.Click += new EventHandler(cuboSeleccionado);
            rbPrisma.Click += new EventHandler(prismaSeleccionado);
        }

        protected void botonCalcularClick(object sender, EventArgs e)
        {
            int lado = int.Parse(txtLado.Text);
            int altura = 0, ancho = 0;
            if (rbPrisma.Checked)
            {
                altura = int.Parse(txtAltura.Text);
                ancho = int.Parse(txtAncho.Text);
            }

            decimal area = 0, volumen = 0;

            if (checkBoxArea.Checked)
            {
                if (rbCubo.Checked)
                {
                    area = 6 * Math.Pow(lado, 2);
                }
                else if (rbPrisma.Checked)
                {
                    area = 2 * (lado * altura + lado * ancho + altura * ancho);
                }
                lblArea.Text = "El área es: " + area.ToString();
            }
            else
            {
                lblArea.Text = "";
            }

            if (checkBoxVolumen.Checked)
            {
                if (rbCubo.Checked)
                {
                    volumen = Math.Pow(lado, 3);
                }
                else if (rbPrisma.Checked)
                {
                    volumen = lado * altura * ancho;
                }
                lblVolumen.Text = "El volumen es: " + volumen.ToString();
            }
            else
            {
                lblVolumen.Text = "";
            }
        }

        protected void cuboSeleccionado(object sender, EventArgs e)
        {
            lblAltura.Visible = false;
            txtAltura.Visible = false;
            lblAncho.Visible = false;
            txtAncho.Visible = false;
            checkBoxArea.Visible = true;
            checkBoxVolumen.Visible = true;
            pictureBox1.Image = Image.FromFile("Cubazo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected void prismaSeleccionado(object sender, EventArgs e)
        {
            lblAltura.Visible = true;
            txtAltura.Visible = true;
            lblAncho.Visible = true;
            txtAncho.Visible = true;
            checkBoxArea.Visible = true;
            checkBoxVolumen.Visible = true;
            pictureBox1.Image = Image.FromFile("Prismazo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
