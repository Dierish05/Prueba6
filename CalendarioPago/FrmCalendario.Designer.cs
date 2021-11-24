namespace CalendarioPago
{
    partial class FrmCalendario
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
            this.dgvVerCuotas = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerCuotas
            // 
            this.dgvVerCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCuotas.Location = new System.Drawing.Point(73, 62);
            this.dgvVerCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVerCuotas.Name = "dgvVerCuotas";
            this.dgvVerCuotas.RowHeadersWidth = 51;
            this.dgvVerCuotas.Size = new System.Drawing.Size(843, 401);
            this.dgvVerCuotas.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(807, 485);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(109, 41);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Location = new System.Drawing.Point(155, 15);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(136, 24);
            this.cmbBusqueda.TabIndex = 2;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(327, 15);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(205, 24);
            this.cmbEstado.TabIndex = 0;
            this.cmbEstado.Visible = false;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // cmbTipos
            // 
            this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(325, 15);
            this.cmbTipos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(207, 24);
            this.cmbTipos.TabIndex = 0;
            this.cmbTipos.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(679, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvVerCuotas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCalendario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerCuotas;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Button btnDelete;
    }
}

