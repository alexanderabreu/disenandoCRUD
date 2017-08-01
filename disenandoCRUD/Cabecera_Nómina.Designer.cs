namespace disenandoCRUD
{
    partial class Cabecera_Nómina
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtNokmbreempresa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTPFinal = new System.Windows.Forms.DateTimePicker();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdDetalleNomina = new System.Windows.Forms.TextBox();
            this.btnGuardarNomina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(17, 39);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(17, 88);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(29, 13);
            this.lblFinal.TabIndex = 4;
            this.lblFinal.Text = "Final";
            // 
            // txtNokmbreempresa
            // 
            this.txtNokmbreempresa.Location = new System.Drawing.Point(111, 22);
            this.txtNokmbreempresa.Name = "txtNokmbreempresa";
            this.txtNokmbreempresa.Size = new System.Drawing.Size(163, 20);
            this.txtNokmbreempresa.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnGuardarNomina);
            this.groupBox1.Controls.Add(this.DTPFinal);
            this.groupBox1.Controls.Add(this.DTPInicio);
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Controls.Add(this.lblFinal);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de nómina";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DTPFinal
            // 
            this.DTPFinal.Location = new System.Drawing.Point(111, 82);
            this.DTPFinal.Name = "DTPFinal";
            this.DTPFinal.Size = new System.Drawing.Size(200, 20);
            this.DTPFinal.TabIndex = 10;
            // 
            // DTPInicio
            // 
            this.DTPInicio.Location = new System.Drawing.Point(111, 33);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(200, 20);
            this.DTPInicio.TabIndex = 9;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(339, 25);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdDetalleNomina);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNokmbreempresa);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID detalle nómina";
            // 
            // txtIdDetalleNomina
            // 
            this.txtIdDetalleNomina.Location = new System.Drawing.Point(430, 22);
            this.txtIdDetalleNomina.Name = "txtIdDetalleNomina";
            this.txtIdDetalleNomina.Size = new System.Drawing.Size(136, 20);
            this.txtIdDetalleNomina.TabIndex = 8;
            // 
            // btnGuardarNomina
            // 
            this.btnGuardarNomina.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGuardarNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNomina.Location = new System.Drawing.Point(58, 199);
            this.btnGuardarNomina.Name = "btnGuardarNomina";
            this.btnGuardarNomina.Size = new System.Drawing.Size(99, 31);
            this.btnGuardarNomina.TabIndex = 11;
            this.btnGuardarNomina.Text = "Guardar";
            this.btnGuardarNomina.UseVisualStyleBackColor = false;
            this.btnGuardarNomina.Click += new System.EventHandler(this.btnGuardarNomina_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Cabecera_Nómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cabecera_Nómina";
            this.Text = "Cabecera de nómina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtNokmbreempresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPFinal;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox txtIdDetalleNomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardarNomina;
    }
}