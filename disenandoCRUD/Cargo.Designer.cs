namespace disenandoCRUD
{
    partial class Cargo
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
            this.DTGVcargo = new System.Windows.Forms.DataGridView();
            this.id_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombrecargo = new System.Windows.Forms.TextBox();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVcargo)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVcargo
            // 
            this.DTGVcargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVcargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cargo,
            this.nombre_cargo});
            this.DTGVcargo.Location = new System.Drawing.Point(10, 98);
            this.DTGVcargo.Name = "DTGVcargo";
            this.DTGVcargo.Size = new System.Drawing.Size(341, 339);
            this.DTGVcargo.TabIndex = 1;
            // 
            // id_cargo
            // 
            this.id_cargo.HeaderText = "id_cargo";
            this.id_cargo.Name = "id_cargo";
            // 
            // nombre_cargo
            // 
            this.nombre_cargo.HeaderText = "nombre_cargo";
            this.nombre_cargo.Name = "nombre_cargo";
            this.nombre_cargo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombre_cargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre_cargo.Width = 200;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrar.Location = new System.Drawing.Point(217, 66);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Buscar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizar.Location = new System.Drawing.Point(217, 18);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(65, 29);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Location = new System.Drawing.Point(291, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 31);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCrear.Location = new System.Drawing.Point(145, 18);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(66, 29);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNombrecargo
            // 
            this.txtNombrecargo.Location = new System.Drawing.Point(12, 72);
            this.txtNombrecargo.Name = "txtNombrecargo";
            this.txtNombrecargo.Size = new System.Drawing.Size(155, 20);
            this.txtNombrecargo.TabIndex = 8;
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.Location = new System.Drawing.Point(12, 26);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Size = new System.Drawing.Size(100, 20);
            this.txtIdCargo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id del cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del cargo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(291, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(60, 20);
            this.txtBuscar.TabIndex = 12;
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 439);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCargo);
            this.Controls.Add(this.txtNombrecargo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.DTGVcargo);
            this.Name = "Cargo";
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.Cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVcargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVcargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cargo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombrecargo;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}