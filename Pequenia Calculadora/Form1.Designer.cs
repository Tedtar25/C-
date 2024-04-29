namespace Pequenia_Calculadora
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
            barraResultados = new TextBox();
            nudOp1 = new NumericUpDown();
            nupOperando2 = new NumericUpDown();
            botonSuma = new Button();
            botonResta = new Button();
            botonMultiplicar = new Button();
            botonDividir = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudOp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupOperando2).BeginInit();
            SuspendLayout();
            // 
            // barraResultados
            // 
            barraResultados.Location = new Point(63, 222);
            barraResultados.Name = "barraResultados";
            barraResultados.ReadOnly = true;
            barraResultados.Size = new Size(527, 27);
            barraResultados.TabIndex = 0;
            // 
            // nudOp1
            // 
            nudOp1.Location = new Point(63, 61);
            nudOp1.Name = "nudOp1";
            nudOp1.Size = new Size(214, 27);
            nudOp1.TabIndex = 1;
            // 
            // nupOperando2
            // 
            nupOperando2.Location = new Point(332, 61);
            nupOperando2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupOperando2.Name = "nupOperando2";
            nupOperando2.Size = new Size(258, 27);
            nupOperando2.TabIndex = 2;
            nupOperando2.ValueChanged += nupOperando2_ValueChanged;
            // 
            // botonSuma
            // 
            botonSuma.Location = new Point(63, 140);
            botonSuma.Name = "botonSuma";
            botonSuma.Size = new Size(94, 29);
            botonSuma.TabIndex = 3;
            botonSuma.Text = "Suma";
            botonSuma.UseVisualStyleBackColor = true;
            botonSuma.Click += botonSuma_Click;
            // 
            // botonResta
            // 
            botonResta.Location = new Point(204, 140);
            botonResta.Name = "botonResta";
            botonResta.Size = new Size(94, 29);
            botonResta.TabIndex = 4;
            botonResta.Text = "Resta";
            botonResta.UseVisualStyleBackColor = true;
            botonResta.Click += botonResta_Click;
            // 
            // botonMultiplicar
            // 
            botonMultiplicar.Location = new Point(354, 140);
            botonMultiplicar.Name = "botonMultiplicar";
            botonMultiplicar.Size = new Size(94, 29);
            botonMultiplicar.TabIndex = 5;
            botonMultiplicar.Text = "Multiplicar";
            botonMultiplicar.UseVisualStyleBackColor = true;
            botonMultiplicar.Click += botonMultiplicar_Click;
            // 
            // botonDividir
            // 
            botonDividir.Location = new Point(496, 140);
            botonDividir.Name = "botonDividir";
            botonDividir.Size = new Size(94, 29);
            botonDividir.TabIndex = 6;
            botonDividir.Text = "Dividir";
            botonDividir.UseVisualStyleBackColor = true;
            botonDividir.Click += botonDividir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 22);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 7;
            label1.Text = "Operando 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 22);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 8;
            label2.Text = "Operando 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonDividir);
            Controls.Add(botonMultiplicar);
            Controls.Add(botonResta);
            Controls.Add(botonSuma);
            Controls.Add(nupOperando2);
            Controls.Add(nudOp1);
            Controls.Add(barraResultados);
            Name = "Form1";
            Text = "Ejercicio 1";
            ((System.ComponentModel.ISupportInitialize)nudOp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupOperando2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox barraResultados;
        private NumericUpDown nudOp1;
        private NumericUpDown nupOperando2;
        private Button botonSuma;
        private Button botonResta;
        private Button botonMultiplicar;
        private Button botonDividir;
        private Label label1;
        private Label label2;
    }
}
