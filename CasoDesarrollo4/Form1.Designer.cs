namespace CasoDesarrollo4
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
            label10 = new Label();
            lvFacturas = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtFechaFact = new TextBox();
            txtMontoFact = new TextBox();
            txtNumFact = new TextBox();
            textBox1 = new TextBox();
            lblFecha = new Label();
            Fecha = new Label();
            lblComision = new Label();
            lblTotalSub = new Label();
            lblTotalFact = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(672, 109);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 43;
            label10.Text = "label10";
            // 
            // lvFacturas
            // 
            lvFacturas.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvFacturas.FullRowSelect = true;
            lvFacturas.GridLines = true;
            lvFacturas.Location = new Point(105, 244);
            lvFacturas.Name = "lvFacturas";
            lvFacturas.Size = new Size(720, 169);
            lvFacturas.TabIndex = 42;
            lvFacturas.UseCompatibleStateImageBehavior = false;
            lvFacturas.View = View.Details;
            lvFacturas.SelectedIndexChanged += lvFacturas_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "";
            columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "NUM FACTURA";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "FECHA DE FACTURACION";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "MONTO FACTURADO";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 250;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(672, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 44);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(559, 194);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 44);
            btnRegistrar.TabIndex = 40;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtFechaFact
            // 
            txtFechaFact.Location = new Point(541, 145);
            txtFechaFact.Name = "txtFechaFact";
            txtFechaFact.Size = new Size(125, 27);
            txtFechaFact.TabIndex = 39;
            // 
            // txtMontoFact
            // 
            txtMontoFact.Location = new Point(219, 187);
            txtMontoFact.Name = "txtMontoFact";
            txtMontoFact.Size = new Size(216, 27);
            txtMontoFact.TabIndex = 38;
            // 
            // txtNumFact
            // 
            txtNumFact.Location = new Point(219, 145);
            txtNumFact.Name = "txtNumFact";
            txtNumFact.Size = new Size(216, 27);
            txtNumFact.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 36;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(694, 109);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 20);
            lblFecha.TabIndex = 35;
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(619, 109);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(47, 20);
            Fecha.TabIndex = 34;
            Fecha.Text = "Fecha";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(662, 520);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(0, 20);
            lblComision.TabIndex = 33;
            // 
            // lblTotalSub
            // 
            lblTotalSub.AutoSize = true;
            lblTotalSub.Location = new Point(422, 520);
            lblTotalSub.Name = "lblTotalSub";
            lblTotalSub.Size = new Size(0, 20);
            lblTotalSub.TabIndex = 32;
            // 
            // lblTotalFact
            // 
            lblTotalFact.AutoSize = true;
            lblTotalFact.Location = new Point(193, 520);
            lblTotalFact.Name = "lblTotalFact";
            lblTotalFact.Size = new Size(0, 20);
            lblTotalFact.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(441, 148);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 30;
            label9.Text = "FECHA FACT.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(619, 485);
            label8.Name = "label8";
            label8.Size = new Size(158, 20);
            label8.TabIndex = 29;
            label8.Text = "COMISION ASIGNADA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 485);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 28;
            label7.Text = "TOTAL SUBTOTAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 485);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 27;
            label6.Text = "TOTAL FACTURAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 430);
            label5.Name = "label5";
            label5.Size = new Size(471, 20);
            label5.TabIndex = 26;
            label5.Text = "MONTO ASIGNADOS AL VENDEDOR POR EL REGISTRO DE FACTURAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 194);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 25;
            label4.Text = "MONTO FACT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 152);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 24;
            label3.Text = "N° FACTURA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 23;
            label2.Text = "VENDEDOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 40);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 22;
            label1.Text = "CONTROL DE FACTURAS DE VENDEDORES ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 581);
            Controls.Add(label10);
            Controls.Add(lvFacturas);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtFechaFact);
            Controls.Add(txtMontoFact);
            Controls.Add(txtNumFact);
            Controls.Add(textBox1);
            Controls.Add(lblFecha);
            Controls.Add(Fecha);
            Controls.Add(lblComision);
            Controls.Add(lblTotalSub);
            Controls.Add(lblTotalFact);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private ListView lvFacturas;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtFechaFact;
        private TextBox txtMontoFact;
        private TextBox txtNumFact;
        private TextBox textBox1;
        private Label lblFecha;
        private Label Fecha;
        private Label lblComision;
        private Label lblTotalSub;
        private Label lblTotalFact;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
