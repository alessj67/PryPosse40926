namespace PryPosse40926
{
    partial class FrmListado
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotalDeu = new System.Windows.Forms.Label();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotalD = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPromD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalDeu
            // 
            this.lblTotalDeu.AutoSize = true;
            this.lblTotalDeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeu.Location = new System.Drawing.Point(187, 292);
            this.lblTotalDeu.Name = "lblTotalDeu";
            this.lblTotalDeu.Size = new System.Drawing.Size(89, 15);
            this.lblTotalDeu.TabIndex = 0;
            this.lblTotalDeu.Text = "Total de deuda";
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.Location = new System.Drawing.Point(185, 332);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(120, 15);
            this.lblCantClientes.TabIndex = 1;
            this.lblCantClientes.Text = "Cantidad de Clientes";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(187, 383);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(118, 15);
            this.lblPromDeuda.TabIndex = 2;
            this.lblPromDeuda.Text = "Promedio de Deuda";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGrilla.Location = new System.Drawing.Point(30, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(444, 232);
            this.dgvGrilla.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Límite de Crédito ";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // gbConsulta
            // 
            this.gbConsulta.BackColor = System.Drawing.Color.RosyBrown;
            this.gbConsulta.Controls.Add(this.lblPromD);
            this.gbConsulta.Controls.Add(this.lblCant);
            this.gbConsulta.Controls.Add(this.lblTotalD);
            this.gbConsulta.Controls.Add(this.btnListar);
            this.gbConsulta.Controls.Add(this.dgvGrilla);
            this.gbConsulta.Controls.Add(this.lblPromDeuda);
            this.gbConsulta.Controls.Add(this.lblCantClientes);
            this.gbConsulta.Controls.Add(this.lblTotalDeu);
            this.gbConsulta.Location = new System.Drawing.Point(21, 22);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(498, 469);
            this.gbConsulta.TabIndex = 0;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de datos";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(271, 426);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(189, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotalD
            // 
            this.lblTotalD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalD.Location = new System.Drawing.Point(323, 294);
            this.lblTotalD.Name = "lblTotalD";
            this.lblTotalD.Size = new System.Drawing.Size(116, 13);
            this.lblTotalD.TabIndex = 8;
            // 
            // lblCant
            // 
            this.lblCant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCant.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.lblCant.Location = new System.Drawing.Point(323, 332);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(116, 15);
            this.lblCant.TabIndex = 9;
            // 
            // lblPromD
            // 
            this.lblPromD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromD.Location = new System.Drawing.Point(323, 383);
            this.lblPromD.Name = "lblPromD";
            this.lblPromD.Size = new System.Drawing.Size(116, 15);
            this.lblPromD.TabIndex = 10;
            // 
            // FrmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(548, 523);
            this.Controls.Add(this.gbConsulta);
            this.Name = "FrmListado";
            this.Text = "FrmListado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTotalDeu;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblPromD;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblTotalD;
    }
}