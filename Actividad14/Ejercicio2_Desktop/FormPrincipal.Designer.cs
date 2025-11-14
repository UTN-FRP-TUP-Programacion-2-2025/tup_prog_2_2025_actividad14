namespace Ejercicio2_Desktop
{
    partial class FormPrincipal
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
            cbDestino = new ComboBox();
            cbTransporte = new ComboBox();
            tbPrecio = new TextBox();
            tbCuit = new TextBox();
            tbNombre = new TextBox();
            tbTelefono = new TextBox();
            tbTarjeta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnGenerar = new Button();
            bntResumen = new Button();
            btnSalir = new Button();
            btnEjemplo = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbDestino
            // 
            cbDestino.FormattingEnabled = true;
            cbDestino.Items.AddRange(new object[] { "Buenos Aires", "Bariloche", "Rosario" });
            cbDestino.Location = new Point(162, 17);
            cbDestino.Margin = new Padding(4, 4, 4, 4);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(154, 29);
            cbDestino.TabIndex = 0;
            // 
            // cbTransporte
            // 
            cbTransporte.FormattingEnabled = true;
            cbTransporte.Items.AddRange(new object[] { "Bus", "Avion" });
            cbTransporte.Location = new Point(162, 98);
            cbTransporte.Margin = new Padding(4, 4, 4, 4);
            cbTransporte.Name = "cbTransporte";
            cbTransporte.Size = new Size(154, 29);
            cbTransporte.TabIndex = 1;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(162, 57);
            tbPrecio.Margin = new Padding(4, 4, 4, 4);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(127, 29);
            tbPrecio.TabIndex = 2;
            // 
            // tbCuit
            // 
            tbCuit.Location = new Point(147, 32);
            tbCuit.Margin = new Padding(4, 4, 4, 4);
            tbCuit.Name = "tbCuit";
            tbCuit.Size = new Size(127, 29);
            tbCuit.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(147, 73);
            tbNombre.Margin = new Padding(4, 4, 4, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(281, 29);
            tbNombre.TabIndex = 4;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(147, 113);
            tbTelefono.Margin = new Padding(4, 4, 4, 4);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(127, 29);
            tbTelefono.TabIndex = 5;
            // 
            // tbTarjeta
            // 
            tbTarjeta.Location = new Point(147, 154);
            tbTarjeta.Margin = new Padding(4, 4, 4, 4);
            tbTarjeta.Name = "tbTarjeta";
            tbTarjeta.Size = new Size(127, 29);
            tbTarjeta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 8;
            label1.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 9;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 101);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 10;
            label3.Text = "Transporte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 11;
            label4.Text = "CUIT/CUIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 12;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 118);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 13;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 158);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 14;
            label7.Text = "N° Tarjeta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCuit);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbTarjeta);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(15, 139);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(454, 192);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(347, 15);
            btnGenerar.Margin = new Padding(4, 4, 4, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(96, 60);
            btnGenerar.TabIndex = 17;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // bntResumen
            // 
            bntResumen.Location = new Point(347, 104);
            bntResumen.Margin = new Padding(4, 4, 4, 4);
            bntResumen.Name = "bntResumen";
            bntResumen.Size = new Size(96, 32);
            bntResumen.TabIndex = 18;
            bntResumen.Text = "Resumen";
            bntResumen.UseVisualStyleBackColor = true;
            bntResumen.Click += bntResumen_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(326, 339);
            btnSalir.Margin = new Padding(4, 4, 4, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 32);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEjemplo
            // 
            btnEjemplo.Location = new Point(64, 339);
            btnEjemplo.Margin = new Padding(4, 4, 4, 4);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(96, 32);
            btnEjemplo.TabIndex = 20;
            btnEjemplo.Text = "Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = true;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 380);
            Controls.Add(btnEjemplo);
            Controls.Add(btnSalir);
            Controls.Add(bntResumen);
            Controls.Add(btnGenerar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPrecio);
            Controls.Add(cbTransporte);
            Controls.Add(cbDestino);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDestino;
        private ComboBox cbTransporte;
        private TextBox tbPrecio;
        private TextBox tbCuit;
        private TextBox tbNombre;
        private TextBox tbTelefono;
        private TextBox tbTarjeta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Button btnGenerar;
        private Button bntResumen;
        private Button btnSalir;
        private Button button4;
        private Button btnEjemplo;
        private OpenFileDialog openFileDialog1;
    }
}
