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
            button1 = new Button();
            txtTelefono = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 87);
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
            cbxPosicion.Location = new Point(158, 87);
            cbxPosicion.Name = "cbxPosicion";
            cbxPosicion.Size = new Size(71, 28);
            cbxPosicion.TabIndex = 1;
            cbxPosicion.SelectedIndexChanged += cbxPosicion_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 137);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 137);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 185);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Producto";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(158, 137);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(154, 27);
            txtFecha.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(158, 182);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(154, 27);
            txtProducto.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 229);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Enabled = false;
            txtImporte.Location = new Point(158, 229);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(154, 27);
            txtImporte.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 27);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 9;
            label6.Text = "Telefono";
            // 
            // button1
            // 
            button1.Location = new Point(157, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(158, 27);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 27);
            txtTelefono.TabIndex = 10;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 341);
            Controls.Add(txtTelefono);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtImporte);
            Controls.Add(label5);
            Controls.Add(txtProducto);
            Controls.Add(txtFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxPosicion);
            Controls.Add(label1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GasPoint";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private MaskedTextBox txtTelefono;
    }
}
