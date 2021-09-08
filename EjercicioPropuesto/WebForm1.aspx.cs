using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Lista de pedidos 
        private static List<Pedido> pedidos = new List<Pedido>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarClientes();
                this.resetProveedores();
            }
            this.mostrarPedidos();
        }

        //Funcion para cargar los proveedores dependiendo de la categoria
        protected void onSelectCategory(object sender, EventArgs e)
        {
            this.cargarProveedores();
            this.mostrarPedidos();
        }
        private void cargarProveedores()
        {
            if (Categoria.SelectedValue != "0")
            {
                Proveedor.Items.Clear();
                Proveedor.Enabled = true;
                List<Proveedores> provs = Proveedores.generarProveedores(Categoria.SelectedValue);
                Proveedor.Items.Add(new ListItem("Seleccione el proveedor", "0"));
                provs.ForEach((p) =>
                {
                    Proveedor.Items.Add(new ListItem(p.getName(),p.getName()));
                });
  
            }
        }
        //Agregar datos a la lista de pedidos
        protected void saveData(object sender, EventArgs e)
        {
            
            Pedido pedido;
            if((pedido = this.validarCampos()) != null)
            {
                WebForm1.pedidos.Add(pedido);
            }
            Response.Write(WebForm1.pedidos.Count());
            this.resetCampos();
            //Refrescar la pagina
            Response.Redirect(Request.RawUrl);
        }
        private void resetProveedores()
        {
            Proveedor.Items.Clear();
            Proveedor.Items.Add(new ListItem("Seleccione Proveedor", "0"));
            Proveedor.CssClass = "formInput";
            Proveedor.Enabled = false;
        }

        private Pedido validarCampos()
        {
            Double precio;
            if(name.Text == "")
            {
                return null;
            }
            else
            {
                if (Double.TryParse(price.Text,out precio) == false)
                {
                    return null;
                }
                else
                {
                    if(Categoria.SelectedValue != "0" && Proveedor.SelectedValue != "0" && Cliente.SelectedValue != "0")
                    {
                        Pedido p = new Pedido(name.Text, precio, Proveedor.SelectedValue, Cliente.SelectedValue);
                        return p;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        } 
        private void cargarClientes()
        {
            Cliente.Items.Clear();
            List<ClientePedido> p = ClientePedido.generarClientes();
            Cliente.Items.Add(new ListItem("Selecciona un cliente", "0"));
            p.ForEach((a)=> {
                Cliente.Items.Add(new ListItem(a.getNombre() , a.getCodigo()));
            });

        }
        private void resetCampos()
        {
            name.Text = "";
            price.Text = "";
            Categoria.SelectedIndex = 0;
            Proveedor.SelectedIndex = 0;
            Cliente.SelectedIndex = 0;
            Proveedor.Enabled = false;
        }
        //Funcion para crear elementos html dentro del panel1
        private void mostrarPedidos()
        {
            
            Panel1.Controls.Clear();
            WebForm1.pedidos.ForEach((x)=> {
                Panel1.Controls.Add(new LiteralControl("<div class='pedido'>"));
                Panel1.Controls.Add(new LiteralControl("<div class='element'>"));
                Panel1.Controls.Add(new LiteralControl(x.nombre));
                Panel1.Controls.Add(new LiteralControl("</div>"));

                Panel1.Controls.Add(new LiteralControl("<div class='element'>"));
                Panel1.Controls.Add(new LiteralControl(x.precio.ToString()));
                Panel1.Controls.Add(new LiteralControl("</div>"));

                Panel1.Controls.Add(new LiteralControl("<div class='element'>"));
                Panel1.Controls.Add(new LiteralControl(x.Proveedor));
                Panel1.Controls.Add(new LiteralControl("</div>"));

                Panel1.Controls.Add(new LiteralControl("</div>"));
            });

        }
    }
}