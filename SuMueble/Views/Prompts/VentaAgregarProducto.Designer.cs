﻿
namespace SuMueble.Views.Prompts
{
    partial class VentaAgregarProducto
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
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(701, 509);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 37);
            this.btn_agregarProducto.TabIndex = 36;
            this.btn_agregarProducto.Text = "Agregar a la Venta";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precio.Location = new System.Drawing.Point(388, 62);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.PlaceholderText = "Precio Sugerido...";
            this.txt_precio.Size = new System.Drawing.Size(223, 34);
            this.txt_precio.TabIndex = 35;
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cantidadProducto.Location = new System.Drawing.Point(668, 62);
            this.txt_cantidadProducto.MaxLength = 100;
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.PlaceholderText = "Cantidad...";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidadProducto.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(385, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "Precio Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(665, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cantidad Producto";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.producto,
            this.precio,
            this.existencias});
            this.dgv_productos.Location = new System.Drawing.Point(36, 126);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(857, 365);
            this.dgv_productos.TabIndex = 31;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 300;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "Precio";
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // existencias
            // 
            this.existencias.DataPropertyName = "Existencias";
            this.existencias.HeaderText = "Existencias";
            this.existencias.MinimumWidth = 6;
            this.existencias.Name = "existencias";
            this.existencias.ReadOnly = true;
            this.existencias.Width = 125;
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarProducto.Location = new System.Drawing.Point(36, 62);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Nombre o Codigo de Producto...";
            this.txt_buscarProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_buscarProducto.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 37;
            this.label7.Text = "Buscar Producto";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(36, 509);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(191, 37);
            this.btn_cancelar.TabIndex = 36;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // VentaAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(932, 593);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VentaAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentaAgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelar;
    }
}