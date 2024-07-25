namespace GasPoint
{
    partial class FormMain
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
            label1 = new Label();
            cbxPosicion = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFecha = new TextBox();
            txtProducto = new TextBox();
            label5 = new Label();
            txtImporte = new TextBox();
            label6 = new Label();
            btnEnviar = new Button();
            txtTelefono = new MaskedTextBox();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            txtIdCliente = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtPuntos = new TextBox();
            groupBox2 = new GroupBox();
            txtVolumen = new TextBox();
            label9 = new Label();
            txtHoseID = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Posición";
            // 
            // cbxPosicion
            // 
            cbxPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPosicion.FormattingEnabled = true;
            cbxPosicion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            cbxPosicion.Location = new Point(16, 57);
            cbxPosicion.Name = "cbxPosicion";
            cbxPosicion.Size = new Size(63, 28);
            cbxPosicion.TabIndex = 1;
            cbxPosicion.SelectedIndexChanged += cbxPosicion_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 23);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 65);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 23);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Producto";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(152, 57);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(154, 27);
            txtFecha.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(312, 57);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 27);
            txtProducto.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 23);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Enabled = false;
            txtImporte.Location = new Point(418, 57);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(86, 27);
            txtImporte.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 22);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(294, 238);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += button1_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(16, 45);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(120, 27);
            txtTelefono.TabIndex = 10;
            txtTelefono.Leave += txtTelefono_LeaveAsync;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(198, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(289, 27);
            txtNombre.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPuntos);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 89);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(142, 46);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(50, 27);
            txtIdCliente.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 22);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 14;
            label8.Text = "Puntos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 22);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 13;
            label7.Text = "Nombre";
            // 
            // txtPuntos
            // 
            txtPuntos.Enabled = false;
            txtPuntos.Location = new Point(493, 46);
            txtPuntos.Name = "txtPuntos";
            txtPuntos.Size = new Size(103, 27);
            txtPuntos.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtVolumen);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtHoseID);
            groupBox2.Controls.Add(cbxPosicion);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtFecha);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtImporte);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(606, 116);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            // 
            // txtVolumen
            // 
            txtVolumen.Enabled = false;
            txtVolumen.Location = new Point(510, 57);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.Size = new Size(86, 27);
            txtVolumen.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 23);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 10;
            label9.Text = "Volumen";
            // 
            // txtHoseID
            // 
            txtHoseID.Location = new Point(85, 57);
            txtHoseID.Name = "txtHoseID";
            txtHoseID.Size = new Size(61, 27);
            txtHoseID.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 280);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnEnviar);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GasPoint";
            TopMost = true;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cbxPosicion;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFecha;
        private TextBox txtProducto;
        private Label label5;
        private TextBox txtImporte;
        private Label label6;
        private Button btnEnviar;
        private MaskedTextBox txtTelefono;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private TextBox txtPuntos;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private TextBox txtIdCliente;
        private TextBox txtHoseID;
        private Label label9;
        private TextBox txtVolumen;
    }
}
