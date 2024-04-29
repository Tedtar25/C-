namespace Clase_220424
{
    public partial class Form1 : Form
    {
        // Variable para gestionar los componentes del formulario
        private System.ComponentModel.IContainer components = null;

        // Método para liberar los recursos utilizados por el formulario
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Método generado automáticamente que inicializa los componentes del formulario
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Cubo y Prisma Calculator";

            // RadioButton para seleccionar Cubo
            this.rbCubo = new System.Windows.Forms.RadioButton();
            this.rbCubo.Text = "Cubo";
            this.rbCubo.Location = new System.Drawing.Point(50, 20);
            this.rbCubo.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.rbCubo);

            // RadioButton para seleccionar Prisma
            this.rbPrisma = new System.Windows.Forms.RadioButton();
            this.rbPrisma.Text = "Prisma";
            this.rbPrisma.Location = new System.Drawing.Point(150, 20);
            this.rbPrisma.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.rbPrisma);

            // Label para mostrar "Lado:"
            this.lblLado = new System.Windows.Forms.Label();
            this.lblLado.Text = "Lado:";
            this.lblLado.Location = new System.Drawing.Point(50, 50);
            this.lblLado.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.lblLado);

            // TextBox para introducir el valor del lado
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtLado.Location = new System.Drawing.Point(150, 50);
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.txtLado);

            // Label para mostrar "Altura:"
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Location = new System.Drawing.Point(50, 80);
            this.lblAltura.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.lblAltura);

            // TextBox para introducir el valor de la altura
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtAltura.Location = new System.Drawing.Point(150, 80);
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.txtAltura);

            // Label para mostrar "Ancho:"
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAncho.Text = "Ancho:";
            this.lblAncho.Location = new System.Drawing.Point(50, 110);
            this.lblAncho.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.lblAncho);

            // TextBox para introducir el valor del ancho
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAncho.Location = new System.Drawing.Point(150, 110);
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.txtAncho);

            // CheckBox para calcular el área
            this.checkBoxArea = new System.Windows.Forms.CheckBox();
            this.checkBoxArea.Text = "Calcular Área";
            this.checkBoxArea.Location = new System.Drawing.Point(50, 140);
            this.checkBoxArea.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(this.checkBoxArea);

            // CheckBox para calcular el volumen
            this.checkBoxVolumen = new System.Windows.Forms.CheckBox();
            this.checkBoxVolumen.Text = "Calcular Volumen";
            this.checkBoxVolumen.Location = new System.Drawing.Point(200, 140);
            this.checkBoxVolumen.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(this.checkBoxVolumen);

            // Botón para realizar los cálculos
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCalcular.Location = new System.Drawing.Point(50, 180);
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.Text = "Calcular";
            this.Controls.Add(this.btnCalcular);

            // Label para mostrar el resultado del área
            this.lblArea = new System.Windows.Forms.Label();
            this.lblArea.Text = "";
            this.lblArea.Location = new System.Drawing.Point(50, 230);
            this.lblArea.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.lblArea);

            // Label para mostrar el resultado del volumen
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblVolumen.Text = "";
            this.lblVolumen.Location = new System.Drawing.Point(50, 260);
            this.lblVolumen.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.lblVolumen);

            // PictureBox para mostrar la imagen
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1.Image = Image.FromFile("Homero.jpg"); // Ruta de la imagen
            this.pictureBox1.Location = new System.Drawing.Point(500, 50);
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.pictureBox1);
        }

        // Declaración de variables para los componentes del formulario
        private System.Windows.Forms.RadioButton rbCubo;
        private System.Windows.Forms.RadioButton rbPrisma;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox checkBoxArea;
        private System.Windows.Forms.CheckBox checkBoxVolumen;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}
