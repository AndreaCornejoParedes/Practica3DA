using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuesto
{
    public class ClientePedido
    {
        private string Nombre;
        private string codigo;

        public ClientePedido(string nombre, string codigo)
        {
            Nombre = nombre;
            this.codigo = codigo;
        }
        public string getNombre()
        {
            return this.Nombre;
        }
        public string getCodigo()
        {
            return this.codigo;
        }
        public static List<ClientePedido> generarClientes()
        {
            List<ClientePedido> c = new List<ClientePedido>();
            c.Add(new ClientePedido("Alexander Acuna Ramirez", "2019500011"));
            c.Add(new ClientePedido("Andrea Cornejo Paredes", "2000100011"));
            c.Add(new ClientePedido("Aremi Paja Medina", "2000400011"));
            c.Add(new ClientePedido("Sara Cruz Torres","2018400023"));
            return c;
        }
    }
}