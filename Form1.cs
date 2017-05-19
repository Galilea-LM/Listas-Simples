using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDListaSimple
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            inventario = new Inventario();
        }
        Inventario inventario;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt16(txtCodigo.Text);
            string nombre = txtNombre.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            Producto producto = new Producto(codigo,nombre,costo,cantidad);
            inventario.Insertar(producto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt16(txtCodigo.Text);
            if (inventario.Buscar(codigo) != null)
            {
                txtInventario.Text = inventario.Buscar(codigo).NombreProducto;
            }
            else
            {
                txtInventario.Clear();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            inventario.Eliminar(codigo);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtInventario.Text = inventario.Datos();
        }
    }
}
