﻿namespace Proyecto_Hospital
{
    partial class Mostrar_Reposicion_Stock
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
            this.dtgReposicion = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pacto_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbCodigoPacto = new System.Windows.Forms.CheckBox();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.cmbCodigoPacto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReposicion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReposicion
            // 
            this.dtgReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReposicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.codigo_stock,
            this.descripcion,
            this.unidad_medida,
            this.pacto_stocks,
            this.frecuencia,
            this.Existencia,
            this.entregado,
            this.pendiente,
            this.costo_unitario,
            this.costo_total});
            this.dtgReposicion.Location = new System.Drawing.Point(12, 28);
            this.dtgReposicion.Name = "dtgReposicion";
            this.dtgReposicion.Size = new System.Drawing.Size(1127, 351);
            this.dtgReposicion.TabIndex = 71;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // codigo_stock
            // 
            this.codigo_stock.DataPropertyName = "codigo_stock";
            this.codigo_stock.HeaderText = "Codigo";
            this.codigo_stock.Name = "codigo_stock";
            this.codigo_stock.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 300;
            // 
            // unidad_medida
            // 
            this.unidad_medida.DataPropertyName = "unidad_medida";
            this.unidad_medida.FillWeight = 70F;
            this.unidad_medida.HeaderText = "Unidad de Medida";
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unidad_medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unidad_medida.Width = 70;
            // 
            // pacto_stocks
            // 
            this.pacto_stocks.DataPropertyName = "pacto_stocks";
            this.pacto_stocks.FillWeight = 70F;
            this.pacto_stocks.HeaderText = "Pacto de Stock";
            this.pacto_stocks.Name = "pacto_stocks";
            this.pacto_stocks.Width = 70;
            // 
            // frecuencia
            // 
            this.frecuencia.DataPropertyName = "frecuencia";
            this.frecuencia.FillWeight = 70F;
            this.frecuencia.HeaderText = "Frecuencia";
            this.frecuencia.Name = "frecuencia";
            this.frecuencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.frecuencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.frecuencia.Width = 70;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // entregado
            // 
            this.entregado.HeaderText = "Entregado";
            this.entregado.Name = "entregado";
            // 
            // pendiente
            // 
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            // 
            // costo_unitario
            // 
            this.costo_unitario.DataPropertyName = "costo_unitario";
            this.costo_unitario.FillWeight = 50F;
            this.costo_unitario.HeaderText = "Costo Unitario";
            this.costo_unitario.Name = "costo_unitario";
            this.costo_unitario.Width = 70;
            // 
            // costo_total
            // 
            this.costo_total.DataPropertyName = "costo_total";
            this.costo_total.FillWeight = 50F;
            this.costo_total.HeaderText = "Costo Total";
            this.costo_total.Name = "costo_total";
            this.costo_total.Width = 60;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(373, 433);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 81;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbCodigoPacto
            // 
            this.cbCodigoPacto.AutoSize = true;
            this.cbCodigoPacto.Location = new System.Drawing.Point(337, 436);
            this.cbCodigoPacto.Name = "cbCodigoPacto";
            this.cbCodigoPacto.Size = new System.Drawing.Size(15, 14);
            this.cbCodigoPacto.TabIndex = 79;
            this.cbCodigoPacto.UseVisualStyleBackColor = true;
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Location = new System.Drawing.Point(145, 435);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(15, 14);
            this.cbFecha.TabIndex = 78;
            this.cbFecha.UseVisualStyleBackColor = true;
            // 
            // cmbCodigoPacto
            // 
            this.cmbCodigoPacto.FormattingEnabled = true;
            this.cmbCodigoPacto.Location = new System.Drawing.Point(210, 435);
            this.cmbCodigoPacto.Name = "cmbCodigoPacto";
            this.cmbCodigoPacto.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigoPacto.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Codigo de Pacto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Fecha:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "dd/mm/yyyy";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(35, 436);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(104, 20);
            this.dtpfecha.TabIndex = 72;
            this.dtpfecha.Value = new System.DateTime(2017, 5, 30, 21, 8, 46, 0);
            // 
            // Mostrar_Reposicion_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 488);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbCodigoPacto);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.cmbCodigoPacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.dtgReposicion);
            this.Name = "Mostrar_Reposicion_Stock";
            this.Text = "Mostrar_Reposicion_Stock";
            this.Load += new System.EventHandler(this.Mostrar_Reposicion_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReposicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgReposicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbCodigoPacto;
        private System.Windows.Forms.CheckBox cbFecha;
        private System.Windows.Forms.ComboBox cmbCodigoPacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacto_stocks;
        private System.Windows.Forms.DataGridViewComboBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
    }
}