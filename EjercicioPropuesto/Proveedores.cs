using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuesto
{
    public class Proveedores
    {
        private string category;
        private string name;

        public Proveedores(string _name,string _category)
        {
            this.name = _name;
            this.category = _category;
        }
        public string getName()
        {
            return this.name;
        }
        public string getCategory()
        {
            return this.category;
        }
        

        public static List<Proveedores> generarProveedores(string category)
        {
            List<Proveedores> lista = new List<Proveedores>();
            if(category == "Informatica")
            {
                lista.Add(new Proveedores("HP",category));
                lista.Add(new Proveedores("Lenovo", category));
                lista.Add(new Proveedores("Asus", category));
                lista.Add(new Proveedores("Toshiba", category));
                return lista;
            }
            if (category == "Comestibles")
            {
                lista.Add(new Proveedores("Alicorp", category));
                lista.Add(new Proveedores("Nestle", category));
                lista.Add(new Proveedores("Andina Peru", category));
                lista.Add(new Proveedores("Gloria", category));
                return lista;
            }
            if (category == "Papeleria")
            {
                lista.Add(new Proveedores("Artesco", category));
                lista.Add(new Proveedores("Faber-Castell", category));
                lista.Add(new Proveedores("Standford", category));
                return lista;
            }
            if (category == "Electrodomesticos")
            {
                lista.Add(new Proveedores("LG", category));
                lista.Add(new Proveedores("Samsung", category));
                lista.Add(new Proveedores("JVC", category));
                lista.Add(new Proveedores("TLC", category));
                return lista;
            }

            return null;
        }
    }
}