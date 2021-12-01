
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Login
{

	public partial class Principal : Form
	{
		private Usuario usuario { get; }
		public Principal()
		{InitializeComponent();}

		public Principal(Usuario user)
		{
			usuario = user;
			
			InitializeComponent(); }

		void AgregarToolStripMenuItemClick(object sender, EventArgs e)
		{ AgregarArticulo nuevoart = new AgregarArticulo();
			nuevoart.MdiParent = this;
			nuevoart.Show();
			
	
		}
		

		void EliminarToolStripMenuItemClick(object sender, EventArgs e)
		{
			EliminarArticulo elimart = new EliminarArticulo();
			elimart.MdiParent = this;
			elimart.Show();
	
		}
		void ModifArtClick(object sender, EventArgs e)
		{ 
			ModificarArticulo nuevoart = new ModificarArticulo();
			nuevoart.MdiParent = this;
			nuevoart.Show();
			
	
		}
		void FacturaToolStripMenuItemClick(object sender, EventArgs e)
		{
			factura fact = new factura();
			fact.MdiParent = this;
			fact.Show();
	
		}
		void PrincipalLoad(object sender, EventArgs e)	
		{


			clientesToolStripMenuItem.Visible = usuario.TablaCliente;
			archivoToolStripMenuItem.Visible = usuario.TablaArchivos;
			matricesToolStripMenuItem.Visible = usuario.TablaMatrices;
			PedidosToolStripMenuItem.Visible = usuario.TablaPedidos;
			artículosToolStripMenuItem.Visible = usuario.TablaArticulos;
			
			usuarioToolStripMenuItem.Visible = usuario.Tablausuario;
			reportesToolStripMenuItem.Visible = usuario.TablaReporte;

			if (usuario.User  == "Produccion")
            {
				

				AgregarPedidoMenu.Enabled = false;
				ModificarPedidoMenu.Enabled = false;
				AgregarArticuloMenu.Enabled = false;
				ModifArt.Enabled = false;
				EliminarArticuloMenu.Enabled = false;
				ControlBox = false;


			}


			if (usuario.User == "Gerencia")
			{

				AgregarPedidoMenu.Enabled = false;
				ModificarPedidoMenu.Enabled = false;
				AgregarArticuloMenu.Enabled = false;
				ModifArt.Enabled = false;
				EliminarArticuloMenu.Enabled = false;
				ControlBox = false;

			}


			//Haz esto en el evento Load de tu formulario MDI

			salirToolStripMenuItem.Text = "Usuario: " + usuario.User + "     Cerrar Sesión";

			MdiClient oMDI;
 
			//recorremos todos los controles hijos del formulario
			foreach (Control ctl in this.Controls)
			{
        try
        {// Intentamos castear el objeto MdiClient
           oMDI = (MdiClient)ctl;
          // Cuando sea casteado con éxito, podremos cambiar el color así
          oMDI.BackColor = Color.Navy;}
        catch (InvalidCastException){// No hacemos nada cuando el control no sea tupo MdiClient
        }}
	
		}
		
		
		void VerListadoToolStripMenuItemClick(object sender, EventArgs e)
		{ 
			ListadoArticulos listado = new ListadoArticulos("");
			listado.MdiParent = this;
			listado.Show();			
			
		}
		
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{	AgregarCliente clientenuevo = new AgregarCliente();
			clientenuevo.MdiParent = this;
			clientenuevo.Show();
			
		}
		
		void ModificarToolStripMenuItemClick(object sender, EventArgs e)
		{
			ModificarCliente modificarcli = new ModificarCliente();
			modificarcli.MdiParent = this;
			modificarcli.Show();
			
		}

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			AgregarPedido agregarpe = new AgregarPedido();
			agregarpe.MdiParent = this;
			agregarpe.Show();

		}

        private void listadoAcredoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ListadoPedidos listPed = new ListadoPedidos(usuario.User);
			listPed.MdiParent = this;
			listPed.Show();
		}

        private void listadoDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ModificarPedido modificarpedido = new ModificarPedido();
			modificarpedido.MdiParent = this;
			modificarpedido.Show();
		}

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
			AgregarMatriz agregarMat = new AgregarMatriz();
			agregarMat.MdiParent = this;
			agregarMat.Show();
		}

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			AgregarCiudad ciudad = new AgregarCiudad();
			ciudad.MdiParent = this;
			ciudad.Show();


		}

        private void detallaDeFabricaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DetalleFabricacion dt = new DetalleFabricacion();
			dt.MdiParent = this;
			dt.Show();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			IPHostEntry host;
			string localIP = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList)
			{
				if (ip.AddressFamily.ToString() == "InterNetwork")
				{
					localIP = ip.ToString();
				}
			}
			MessageBox.Show("Tú IP Local Es: " + localIP);
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
			System.Windows.Forms.Application.Exit();

		}

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
			System.Windows.Forms.Application.Exit();

		}

        private void verListadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			ListadoClientes listadoCli = new ListadoClientes("");
			listadoCli.MdiParent = this;
			listadoCli.Show();

		}

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			ModificarMatriz modmat = new ModificarMatriz();
			modmat.MdiParent = this;
			modmat.Show();
		}

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Contacto cont = new Contacto();
			cont.MdiParent = this;
			cont.Show();
        }

        private void proyecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Proyeccion proye = new Proyeccion();
			proye.MdiParent = this;
			proye.Show();

		}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void enProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
			EnProduccion produ = new EnProduccion();
			produ.MdiParent = this;
			produ.Show();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			User gestionUsuario = new User();
			gestionUsuario.MdiParent = this;
			gestionUsuario.Show();
		}

        private void reporteProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ReporteProduccion reporte = new ReporteProduccion();
			reporte.MdiParent = this;
			reporte.Show();
		}



        private void proyeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Proyeccion proye = new Proyeccion();
			proye.MdiParent = this;
			proye.Show();

		}

        private void enProducciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
			EnProduccion produ = new EnProduccion();
			produ.MdiParent = this;
			produ.Show();
		}

        private void reporteDeProducciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
			ReporteProduccion reporte = new ReporteProduccion();
			reporte.MdiParent = this;
			reporte.Show();

		}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
			Nitrurado nitrurado = new Nitrurado();
			nitrurado.MdiParent = this;
			nitrurado.Show();
        }
    }
}
