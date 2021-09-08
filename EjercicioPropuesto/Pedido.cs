using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuesto
{
    public class Pedido
    {
        public string nombre;
        public double precio;
        public string Proveedor;
        public string Cliente;

        public Pedido(string nombre, double precio, string proveedor, string cliente)
        {
            this.nombre = nombre;
            this.precio = precio;
            Proveedor = proveedor;
            Cliente = cliente;
        }

    }
}