
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
		{
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is AgregarArticulo)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				AgregarArticulo nuevoart = new AgregarArticulo();
				nuevoart.MdiParent = this;
				nuevoart.Show();
			}
			contador = 0;


			
	
		}
		

		void EliminarToolStripMenuItemClick(object sender, EventArgs e)
		{
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is EliminarArticulo)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				EliminarArticulo elimart = new EliminarArticulo();
				elimart.MdiParent = this;
				elimart.Show();
			}
			contador = 0;


	
		}
		void ModifArtClick(object sender, EventArgs e)
		{
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ModificarArticulo)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				ModificarArticulo nuevoart = new ModificarArticulo();
				nuevoart.MdiParent = this;
				nuevoart.Show();
			}
			contador = 0;

			
	
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
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ListadoArticulos)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
			ListadoArticulos listado = new ListadoArticulos("");
			listado.MdiParent = this;
			listado.Show();		
			}
			contador = 0;
			
		}
		
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is AgregarCliente)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				AgregarCliente clientenuevo = new AgregarCliente();
				clientenuevo.MdiParent = this;
				clientenuevo.Show();
			}
			contador = 0;
		}
		
		void ModificarToolStripMenuItemClick(object sender, EventArgs e)
		{
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ModificarCliente)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				ModificarCliente modificarcli = new ModificarCliente();
				modificarcli.MdiParent = this;
				modificarcli.Show();
			}
			contador = 0;
		}

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is AgregarPedido)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				AgregarPedido agregarpe = new AgregarPedido();
				agregarpe.MdiParent = this;
				agregarpe.Show();
			}
			contador = 0;
		}

        private void listadoAcredoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ListadoPedidos)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				ListadoPedidos listPed = new ListadoPedidos(usuario.User);
				listPed.MdiParent = this;
				listPed.Show();
			}
			contador = 0;
		}

        private void listadoDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ModificarPedido)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				ModificarPedido modificarpedido = new ModificarPedido();
				modificarpedido.MdiParent = this;
				modificarpedido.Show();
			}
			contador = 0;
		}

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is AgregarMatriz)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				AgregarMatriz agregarMat = new AgregarMatriz();
				agregarMat.MdiParent = this;
				agregarMat.Show();
			}
			contador = 0;
		}

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is AgregarCiudad)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				AgregarCiudad ciudad = new AgregarCiudad();
				ciudad.MdiParent = this;
				ciudad.Show();
			}
			contador = 0;
		}

        private void detallaDeFabricaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is DetalleFabricacion)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				DetalleFabricacion dt = new DetalleFabricacion();
				dt.MdiParent = this;
				dt.Show();
			}
			contador = 0;
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
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ListadoClientes)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				ListadoClientes listadoCli = new ListadoClientes("");
				listadoCli.MdiParent = this;
				listadoCli.Show();
			}
			contador = 0;


		}

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ModificarMatriz)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				ModificarMatriz modmat = new ModificarMatriz();
				modmat.MdiParent = this;
				modmat.Show();
			}
			contador = 0;
		}

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is Contacto)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				Contacto cont = new Contacto();
				cont.MdiParent = this;
				cont.Show();
			}
			contador = 0;
        }

  //      private void proyecciónToolStripMenuItem_Click(object sender, EventArgs e)
  //      {

		//}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        //private void enProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is User)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				User gestionUsuario = new User();
				gestionUsuario.MdiParent = this;
				gestionUsuario.Show();
			}
			contador = 0;
		}

        //private void reporteProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ReporteProduccion reporte = new ReporteProduccion();
        //    reporte.MdiParent = this;
        //    reporte.Show();
        //}



        private void proyeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {//ok
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is Proyeccion)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				Proyeccion proye = new Proyeccion();
				proye.MdiParent = this;
				proye.Show();
			}
			contador = 0;

		}

        private void enProducciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {//ok
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is EnProduccion)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				EnProduccion produ = new EnProduccion();
				produ.MdiParent = this;
				produ.Show();
			}
			contador = 0;
		}

        private void reporteDeProducciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is ReporteProduccion)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
            {
				ReporteProduccion reporte = new ReporteProduccion();
				reporte.MdiParent = this;
				reporte.Show();
			}
			contador = 0;
		}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
			int contador = 0;
			foreach (Form f in Application.OpenForms)
			{
				if (f is Nitrurado)
				{
					f.Show();
					if (f.WindowState == FormWindowState.Minimized)
						f.WindowState = FormWindowState.Normal;
					f.BringToFront();
					contador++;
					return;
				}

			}
			if (contador == 0)
			{
				Nitrurado nitrurado = new Nitrurado();
				nitrurado.MdiParent = this;
				nitrurado.Show();
			}
			contador = 0;
        }
    }
}
