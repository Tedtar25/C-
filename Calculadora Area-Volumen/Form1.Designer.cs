namespace Calculadora_Area_Volumen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rbCubo = new RadioButton();
            rbPrisma = new RadioButton();
            nudLargo = new NumericUpDown();
            nudAlto = new NumericUpDown();
            nudAncho = new NumericUpDown();
            textoLargo = new Label();
            textoAlto = new Label();
            textoAncho = new Label();
            cbArea = new CheckBox();
            cbVolumen = new CheckBox();
            botonCalcular = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudLargo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAlto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAncho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rbCubo
            // 
            rbCubo.AutoSize = true;
            rbCubo.Location = new Point(12, 12);
            rbCubo.Name = "rbCubo";
            rbCubo.Size = new Size(65, 24);
            rbCubo.TabIndex = 0;
            rbCubo.TabStop = true;
            rbCubo.Text = "Cubo";
            rbCubo.UseVisualStyleBackColor = true;
            rbCubo.CheckedChanged += rbCubo_CheckedChanged;
            // 
            // rbPrisma
            // 
            rbPrisma.AutoSize = true;
            rbPrisma.Location = new Point(160, 12);
            rbPrisma.Name = "rbPrisma";
            rbPrisma.Size = new Size(74, 24);
            rbPrisma.TabIndex = 1;
            rbPrisma.TabStop = true;
            rbPrisma.Text = "Prisma";
            rbPrisma.UseVisualStyleBackColor = true;
            rbPrisma.CheckedChanged += rbPrisma_CheckedChanged;
            // 
            // nudLargo
            // 
            nudLargo.Location = new Point(127, 69);
            nudLargo.Name = "nudLargo";
            nudLargo.Size = new Size(150, 27);
            nudLargo.TabIndex = 2;
            nudLargo.ValueChanged += nudLargo_ValueChanged;
            // 
            // nudAlto
            // 
            nudAlto.Location = new Point(127, 125);
            nudAlto.Name = "nudAlto";
            nudAlto.Size = new Size(150, 27);
            nudAlto.TabIndex = 3;
            // 
            // nudAncho
            // 
            nudAncho.Location = new Point(127, 190);
            nudAncho.Name = "nudAncho";
            nudAncho.Size = new Size(150, 27);
            nudAncho.TabIndex = 4;
            // 
            // textoLargo
            // 
            textoLargo.AutoSize = true;
            textoLargo.Location = new Point(12, 69);
            textoLargo.Name = "textoLargo";
            textoLargo.Size = new Size(50, 20);
            textoLargo.TabIndex = 5;
            textoLargo.Text = "Largo:";
            // 
            // textoAlto
            // 
            textoAlto.AutoSize = true;
            textoAlto.Location = new Point(12, 132);
            textoAlto.Name = "textoAlto";
            textoAlto.Size = new Size(40, 20);
            textoAlto.TabIndex = 6;
            textoAlto.Text = "Alto:";
            // 
            // textoAncho
            // 
            textoAncho.AutoSize = true;
            textoAncho.Location = new Point(12, 197);
            textoAncho.Name = "textoAncho";
            textoAncho.Size = new Size(54, 20);
            textoAncho.TabIndex = 7;
            textoAncho.Text = "Ancho:";
            // 
            // cbArea
            // 
            cbArea.AutoSize = true;
            cbArea.Location = new Point(28, 252);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(62, 24);
            cbArea.TabIndex = 8;
            cbArea.Text = "Area";
            cbArea.UseVisualStyleBackColor = true;
            cbArea.CheckedChanged += cbArea_CheckedChanged;
            // 
            // cbVolumen
            // 
            cbVolumen.AutoSize = true;
            cbVolumen.Location = new Point(160, 252);
            cbVolumen.Name = "cbVolumen";
            cbVolumen.Size = new Size(89, 24);
            cbVolumen.TabIndex = 9;
            cbVolumen.Text = "Volumen";
            cbVolumen.UseVisualStyleBackColor = true;
            cbVolumen.CheckedChanged += cbVolumen_CheckedChanged;
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(81, 320);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(94, 29);
            botonCalcular.TabIndex = 10;
            botonCalcular.Text = "Calcular";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(463, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(botonCalcular);
            Controls.Add(cbVolumen);
            Controls.Add(cbArea);
            Controls.Add(textoAncho);
            Controls.Add(textoAlto);
            Controls.Add(textoLargo);
            Controls.Add(nudAncho);
            Controls.Add(nudAlto);
            Controls.Add(nudLargo);
            Controls.Add(rbPrisma);
            Controls.Add(rbCubo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudLargo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAlto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAncho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbCubo;
        private RadioButton rbPrisma;
        private NumericUpDown nudLargo;
        private NumericUpDown nudAlto;
        private NumericUpDown nudAncho;
        private Label textoLargo;
        private Label textoAlto;
        private Label textoAncho;
        private CheckBox cbArea;
        private CheckBox cbVolumen;
        private Button botonCalcular;
        private PictureBox pictureBox1;
    }
}
