namespace disenandoCRUD
{
    partial class Crear_detalleDeNómina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarNomina = new System.Windows.Forms.Button();
            this.txtIdEmpelado = new System.Windows.Forms.TextBox();
            this.txtDescuentoISR = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtDetallenomina = new System.Windows.Forms.TextBox();
            this.TXTtOTALdESCUENTO = new System.Windows.Forms.TextBox();
            this.TXTsALARIOnETO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOTROS = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.lblIdEmpelado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescuentoISR = new System.Windows.Forms.Label();
            this.lblDescuentoSS = new System.Windows.Forms.Label();
            this.lblDescuentoOTROS = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.lblDetalleNomina = new System.Windows.Forms.Label();
            this.btnEliminarNomina = new System.Windows.Forms.Button();
            this.btbConsultarNomina = new System.Windows.Forms.Button();
            this.DTGVDetalleNomina = new System.Windows.Forms.DataGridView();
            this.ID_DetalleNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentoSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescuentosOTROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDetalleNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarNomina
            // 
            this.btnGuardarNomina.Location = new System.Drawing.Point(12, 361);
            this.btnGuardarNomina.Name = "btnGuardarNomina";
            this.btnGuardarNomina.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarNomina.TabIndex = 0;
            this.btnGuardarNomina.Text = "Guardar";
            this.btnGuardarNomina.UseVisualStyleBackColor = true;
            this.btnGuardarNomina.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdEmpelado
            // 
            this.txtIdEmpelado.Location = new System.Drawing.Point(124, 72);
            this.txtIdEmpelado.Name = "txtIdEmpelado";
            this.txtIdEmpelado.Size = new System.Drawing.Size(164, 20);
            this.txtIdEmpelado.TabIndex = 1;
            // 
            // txtDescuentoISR
            // 
            this.txtDescuentoISR.Location = new System.Drawing.Point(124, 146);
            this.txtDescuentoISR.Name = "txtDescuentoISR";
            this.txtDescuentoISR.ReadOnly = true;
            this.txtDescuentoISR.Size = new System.Drawing.Size(36, 20);
            this.txtDescuentoISR.TabIndex = 2;
            this.txtDescuentoISR.Text = "0.12";
            this.txtDescuentoISR.TextChanged += new System.EventHandler(this.txtDescuentoISR_TextChanged);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(124, 108);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(164, 20);
            this.txtSalarioBruto.TabIndex = 3;
            // 
            // txtDetallenomina
            // 
            this.txtDetallenomina.Location = new System.Drawing.Point(124, 39);
            this.txtDetallenomina.Name = "txtDetallenomina";
            this.txtDetallenomina.Size = new System.Drawing.Size(164, 20);
            this.txtDetallenomina.TabIndex = 4;
            // 
            // TXTtOTALdESCUENTO
            // 
            this.TXTtOTALdESCUENTO.Location = new System.Drawing.Point(124, 256);
            this.TXTtOTALdESCUENTO.Name = "TXTtOTALdESCUENTO";
            this.TXTtOTALdESCUENTO.Size = new System.Drawing.Size(164, 20);
            this.TXTtOTALdESCUENTO.TabIndex = 5;
            // 
            // TXTsALARIOnETO
            // 
            this.TXTsALARIOnETO.Location = new System.Drawing.Point(124, 288);
            this.TXTsALARIOnETO.Name = "TXTsALARIOnETO";
            this.TXTsALARIOnETO.Size = new System.Drawing.Size(164, 20);
            this.TXTsALARIOnETO.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOTROS);
            this.groupBox1.Controls.Add(this.txtSS);
            this.groupBox1.Controls.Add(this.txtISR);
            this.groupBox1.Controls.Add(this.lblSalarioBruto);
            this.groupBox1.Controls.Add(this.lblSalarioNeto);
            this.groupBox1.Controls.Add(this.lblIdEmpelado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblDescuentoISR);
            this.groupBox1.Controls.Add(this.lblDescuentoSS);
            this.groupBox1.Controls.Add(this.lblDescuentoOTROS);
            this.groupBox1.Controls.Add(this.lblTotalDescuento);
            this.groupBox1.Controls.Add(this.lblDetalleNomina);
            this.groupBox1.Controls.Add(this.TXTtOTALdESCUENTO);
            this.groupBox1.Controls.Add(this.TXTsALARIOnETO);
            this.groupBox1.Controls.Add(this.txtIdEmpelado);
            this.groupBox1.Controls.Add(this.txtDescuentoISR);
            this.groupBox1.Controls.Add(this.txtSalarioBruto);
            this.groupBox1.Controls.Add(this.txtDetallenomina);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 349);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Nómina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(36, 20);
            this.textBox5.TabIndex = 28;
            this.textBox5.Text = "0.03";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(36, 20);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "0.04";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // txtOTROS
            // 
            this.txtOTROS.Location = new System.Drawing.Point(213, 221);
            this.txtOTROS.Name = "txtOTROS";
            this.txtOTROS.Size = new System.Drawing.Size(75, 20);
            this.txtOTROS.TabIndex = 22;
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(213, 183);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(75, 20);
            this.txtSS.TabIndex = 20;
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(213, 146);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(75, 20);
            this.txtISR.TabIndex = 18;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(10, 115);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 17;
            this.lblSalarioBruto.Text = "Salario Bruto";
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Location = new System.Drawing.Point(12, 295);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(65, 13);
            this.lblSalarioNeto.TabIndex = 16;
            this.lblSalarioNeto.Text = "Salario Neto";
            // 
            // lblIdEmpelado
            // 
            this.lblIdEmpelado.AutoSize = true;
            this.lblIdEmpelado.Location = new System.Drawing.Point(10, 79);
            this.lblIdEmpelado.Name = "lblIdEmpelado";
            this.lblIdEmpelado.Size = new System.Drawing.Size(66, 13);
            this.lblIdEmpelado.TabIndex = 15;
            this.lblIdEmpelado.Text = "Id Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // lblDescuentoISR
            // 
            this.lblDescuentoISR.AutoSize = true;
            this.lblDescuentoISR.Location = new System.Drawing.Point(10, 153);
            this.lblDescuentoISR.Name = "lblDescuentoISR";
            this.lblDescuentoISR.Size = new System.Drawing.Size(80, 13);
            this.lblDescuentoISR.TabIndex = 13;
            this.lblDescuentoISR.Text = "Descuento ISR";
            // 
            // lblDescuentoSS
            // 
            this.lblDescuentoSS.AutoSize = true;
            this.lblDescuentoSS.Location = new System.Drawing.Point(10, 190);
            this.lblDescuentoSS.Name = "lblDescuentoSS";
            this.lblDescuentoSS.Size = new System.Drawing.Size(76, 13);
            this.lblDescuentoSS.TabIndex = 12;
            this.lblDescuentoSS.Text = "Descuento SS";
            // 
            // lblDescuentoOTROS
            // 
            this.lblDescuentoOTROS.AutoSize = true;
            this.lblDescuentoOTROS.Location = new System.Drawing.Point(9, 228);
            this.lblDescuentoOTROS.Name = "lblDescuentoOTROS";
            this.lblDescuentoOTROS.Size = new System.Drawing.Size(100, 13);
            this.lblDescuentoOTROS.TabIndex = 11;
            this.lblDescuentoOTROS.Text = "Descuento OTROS";
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.Location = new System.Drawing.Point(10, 263);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(86, 13);
            this.lblTotalDescuento.TabIndex = 10;
            this.lblTotalDescuento.Text = "Total Descuento";
            // 
            // lblDetalleNomina
            // 
            this.lblDetalleNomina.AutoSize = true;
            this.lblDetalleNomina.Location = new System.Drawing.Point(10, 42);
            this.lblDetalleNomina.Name = "lblDetalleNomina";
            this.lblDetalleNomina.Size = new System.Drawing.Size(106, 13);
            this.lblDetalleNomina.TabIndex = 9;
            this.lblDetalleNomina.Text = "Id Detalle de Nómina";
            // 
            // btnEliminarNomina
            // 
            this.btnEliminarNomina.Location = new System.Drawing.Point(97, 361);
            this.btnEliminarNomina.Name = "btnEliminarNomina";
            this.btnEliminarNomina.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNomina.TabIndex = 10;
            this.btnEliminarNomina.Text = "Eliminar";
            this.btnEliminarNomina.UseVisualStyleBackColor = true;
            this.btnEliminarNomina.Click += new System.EventHandler(this.btnEliminarNomina_Click);
            // 
            // btbConsultarNomina
            // 
            this.btbConsultarNomina.Location = new System.Drawing.Point(183, 361);
            this.btbConsultarNomina.Name = "btbConsultarNomina";
            this.btbConsultarNomina.Size = new System.Drawing.Size(75, 23);
            this.btbConsultarNomina.TabIndex = 11;
            this.btbConsultarNomina.Text = "Consultar";
            this.btbConsultarNomina.UseVisualStyleBackColor = true;
            // 
            // DTGVDetalleNomina
            // 
            this.DTGVDetalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVDetalleNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DetalleNomina,
            this.ID_Empleado,
            this.DescuentoISR,
            this.DescuentoSS,
            this.DescuentosOTROS,
            this.TotalDescuento,
            this.SalarioNeto});
            this.DTGVDetalleNomina.Location = new System.Drawing.Point(319, 13);
            this.DTGVDetalleNomina.Name = "DTGVDetalleNomina";
            this.DTGVDetalleNomina.Size = new System.Drawing.Size(778, 371);
            this.DTGVDetalleNomina.TabIndex = 12;
            this.DTGVDetalleNomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVDetalleNomina_CellContentClick);
            // 
            // ID_DetalleNomina
            // 
            this.ID_DetalleNomina.HeaderText = "ID_DetalleNomina";
            this.ID_DetalleNomina.Name = "ID_DetalleNomina";
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.HeaderText = "ID_Empleado";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Width = 80;
            // 
            // DescuentoISR
            // 
            this.DescuentoISR.HeaderText = "DescuentoISR";
            this.DescuentoISR.Name = "DescuentoISR";
            this.DescuentoISR.Width = 90;
            // 
            // DescuentoSS
            // 
            this.DescuentoSS.HeaderText = "DescuentoSS";
            this.DescuentoSS.Name = "DescuentoSS";
            this.DescuentoSS.Width = 90;
            // 
            // DescuentosOTROS
            // 
            this.DescuentosOTROS.HeaderText = "DescuentosOTROS";
            this.DescuentosOTROS.Name = "DescuentosOTROS";
            this.DescuentosOTROS.Width = 110;
            // 
            // TotalDescuento
            // 
            this.TotalDescuento.HeaderText = "TotalDescuento";
            this.TotalDescuento.Name = "TotalDescuento";
            // 
            // SalarioNeto
            // 
            this.SalarioNeto.HeaderText = "SalarioNeto";
            this.SalarioNeto.Name = "SalarioNeto";
            // 
            // Crear_detalleDeNómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 459);
            this.Controls.Add(this.DTGVDetalleNomina);
            this.Controls.Add(this.btbConsultarNomina);
            this.Controls.Add(this.btnEliminarNomina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarNomina);
            this.Name = "Crear_detalleDeNómina";
            this.Text = "Crear_detalleDeNómina";
            this.Load += new System.EventHandler(this.Crear_detalleDeNómina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDetalleNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarNomina;
        private System.Windows.Forms.TextBox txtIdEmpelado;
        private System.Windows.Forms.TextBox txtDescuentoISR;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtDetallenomina;
        private System.Windows.Forms.TextBox TXTtOTALdESCUENTO;
        private System.Windows.Forms.TextBox TXTsALARIOnETO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.Label lblIdEmpelado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDescuentoISR;
        private System.Windows.Forms.Label lblDescuentoSS;
        private System.Windows.Forms.Label lblDescuentoOTROS;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.Label lblDetalleNomina;
        private System.Windows.Forms.Button btnEliminarNomina;
        private System.Windows.Forms.Button btbConsultarNomina;
        private System.Windows.Forms.DataGridView DTGVDetalleNomina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOTROS;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DetalleNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoISR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentosOTROS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioNeto;
    }
}