using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDListaSimple
{
    class Inventario
    {
        Producto inicio;
        Producto tem;
        public Inventario()
        {
            inicio = null;
        }
        public void Insertar(Producto pNuevo)
        {
            if (inicio == null)
            {
                inicio = pNuevo;
            }
            else
            {
                pNuevo = inicio;
                while (tem.siguiente == null)
                {

                    tem = tem.siguiente;
                    tem.siguiente = pNuevo;
                }
            }

        }

        public string Datos()
        {
            String datos = "";
            Producto t = inicio;
            while (t != null)
            {
                datos += t.ToString();
                t = t.siguiente;
            }
            return datos;
        }


        public void Eliminar(int codigoProducto)
        {
            tem = inicio;
            if (tem.CodigoProducto == codigoProducto)
            {
                inicio = tem.siguiente;
            }
            else
            {
                while (tem.siguiente != null)
                {
                    if (tem.siguiente.CodigoProducto == codigoProducto)
                    {
                        if (tem.siguiente.siguiente == null)
                        {
                            tem.siguiente = null;
                        }
                        else
                        {
                            tem.siguiente = tem.siguiente.siguiente;
                        }
                    }
                    if (tem.siguiente != null)
                    {
                        tem = tem.siguiente;
                    }
                }
            }
        }

        public Producto Buscar(int codigo)
        {
            tem = inicio;
            Producto producto = null;
            while (tem != null)
            {
                if (tem.CodigoProducto == codigo)
                {
                    producto = tem;
                }
                tem = tem.siguiente;
            }
            return producto;
        }

    }
}
