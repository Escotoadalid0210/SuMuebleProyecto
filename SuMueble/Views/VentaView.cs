﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SuMueble.Controller;
using System.Windows.Forms;
using SuMueble.Models;

namespace SuMueble.Views
{
    public partial class VentaView : UserControl
    {
        //controladores
        ProductoControlador productoControlador = new ProductoControlador();
        ClienteControlador clienteControlador = new ClienteControlador();
        ColaboradorControlador colaboradorControlador = new ColaboradorControlador();
        

        //variables
        private float Total = 0;
        private List<DetallesVentas> _detallesVenta = new List<DetallesVentas>();
        private string _msg = "1. Seleccione un producto\n2. Indique la cantidad que se venderá\n3. Asegurese de No borrar el precio del producto de el cuadro de texto en la parte inferior";

        // metodos
        public VentaView()
        {
            InitializeComponent();
            
        
            dgv_productos.AutoGenerateColumns = false;
            dgv_productos.DataSource = productoControlador.GetProductos();
        }


        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes()
            {
                DNI = txt_dniCliente.Text,
                Nombre = txt_nombreCliente.Text,
                Tel = txt_clienteTelefono.Text
            };
            string msg = VentaIsAllReady();
            if (msg == string.Empty)
            {
                Ventas venta = new Ventas()
                {
                    DetallesVenta = _detallesVenta,
                    Cliente = c,
                    IDColaborador = txt_dniColaborador.Text

                };
                

            }
            else
                MessageBox.Show("Faltan los siguientes datos:\n"+msg, "Faltan datos de la venta", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell 3 = precio
            txt_precio.Text = GetCell(3);
        }

        

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            if (txt_cantidadProducto.Text != string.Empty && txt_precio.Text != string.Empty)
            {
                DetallesVentas dv = new DetallesVentas()
                {
                    IDProducto = int.Parse(GetCell(0)),
                    Cantidad = int.Parse(txt_cantidadProducto.Text),
                    PrecioVenta = int.Parse(txt_precio.Text),
                    Producto = GetCell(2)
                };

                CargarListVew(dv);
                ClearProducto();
            }
            else
                MessageBox.Show(_msg, "Faltan datos de la venta",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
           

        }
        private void CargarListVew(DetallesVentas dv)
        {
            Total += dv.SubTotal;
            l_monto.Text = string.Format("{0:C2}", Total);
            _detallesVenta.Add(dv);
            // actualizar el listview
            lb_productosVenta.DataSource = null;
            lb_productosVenta.DataSource = _detallesVenta;
            lb_productosVenta.DisplayMember = "Info";

        }
        private string GetCell(int cell = 0)
        {
            // ID, Codigo, Producto, Precio, Existencias
            // 0 ,      1,        2,      3,          4
            return dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[cell].Value.ToString();
        }

        private void ClearProducto()
        {
            txt_cantidadProducto.Text = string.Empty;
            txt_precio.Text = string.Empty;
        }

        private void txt_dniCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dniCliente.Text.Length == 13)
            {
                ClearCliente();
                Clientes cliente = clienteControlador.GetCliente(txt_dniCliente.Text);
                if (cliente == null)
                {
                    HideShowLabels(true);
                }
                else
                {
                    HideShowLabels(false);
                    txt_nombreCliente.Text = cliente.Nombre;
                    txt_clienteTelefono.Text = cliente.Tel;
                }
            }
            if (txt_dniCliente.Text.Length == 0)
                ClearCliente();
        }

        private void HideShowLabels(bool visible)
        {
            labelClienteNuevo.Visible = visible;
            labelNombre.Visible = visible;
            labelTelefono.Visible = visible;
        }
        private void ClearCliente()
        {
            txt_nombreCliente.Text = string.Empty;
            txt_clienteTelefono.Text = string.Empty;
        }

        private void txt_dniColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dniColaborador.Text.Length == 13)
            {
                Colaboradores c = colaboradorControlador.GetColaborador(txt_dniColaborador.Text);
                if (c == null)
                {
                    ShowHideColaboradorLabel();
                }
                else
                {
                    ShowHideColaboradorLabel(c.Nombre,true);

                }
            }
            if(txt_dniColaborador.Text.Length == 0)
                dniColaboradorLabelError.Visible = false;

        }

        private void ShowHideColaboradorLabel(string name="",bool flag=false)
        {
            dniColaboradorLabelError.Visible = true;
            if (flag)
            {
                dniColaboradorLabelError.Text = name;
                dniColaboradorLabelError.ForeColor = Color.FromName("Dodgerblue");


            }
            else
            {
                dniColaboradorLabelError.Text = "Escribió mal su DNI";
                dniColaboradorLabelError.ForeColor = Color.FromName("Crimson");
                
            }

        }

        private string VentaIsAllReady()
        {
            string msg = txt_dniCliente.Text.Length == 13 ? string.Empty : "* DNI del Cliente\n";
            msg += txt_nombreCliente.Text != string.Empty ? "" : "* Nombre del Cliente\n";
            msg += txt_clienteTelefono.Text != string.Empty ? "" : "* Telefono del Cliente\n";
            msg += _detallesVenta.Count > 0 ? "" : "* Agregar Productos a la Venta\n";
            msg += txt_dniColaborador.Text.Length == 13 ? "" : "* DNI del Colaborador\n";
            msg += dniColaboradorLabelError.ForeColor == Color.Crimson ? "* Agregar un DNI de Colaborador Valido": "";
            // Color.FromName("Crimson")
            return msg;

        }
    }
}
