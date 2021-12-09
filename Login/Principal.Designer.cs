
namespace Login
{
	partial class Principal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AgregarArticuloMenu;
		private System.Windows.Forms.ToolStripMenuItem EliminarArticuloMenu;
		private System.Windows.Forms.ToolStripMenuItem ModifArt;
		private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem PedidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AgregarPedidoMenu;
		private System.Windows.Forms.ToolStripMenuItem ModificarPedidoMenu;
		private System.Windows.Forms.ToolStripMenuItem ListadoPedidoMenu;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarArticuloMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifArt = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarPedidoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarPedidoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadoPedidoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.detallaDeFabricaciónMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.matricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.PedidosToolStripMenuItem,
            this.matricesToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadesToolStripMenuItem,
            this.puestosDeTrabajoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Image = global::Login.Properties.Resources.ubicacion;
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            resources.ApplyResources(this.ciudadesToolStripMenuItem, "ciudadesToolStripMenuItem");
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarArticuloMenu,
            this.EliminarArticuloMenu,
            this.ModifArt,
            this.verListadoToolStripMenuItem});
            this.artículosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            resources.ApplyResources(this.artículosToolStripMenuItem, "artículosToolStripMenuItem");
            // 
            // AgregarArticuloMenu
            // 
            this.AgregarArticuloMenu.Image = global::Login.Properties.Resources.agregar;
            this.AgregarArticuloMenu.Name = "AgregarArticuloMenu";
            resources.ApplyResources(this.AgregarArticuloMenu, "AgregarArticuloMenu");
            this.AgregarArticuloMenu.Click += new System.EventHandler(this.AgregarToolStripMenuItemClick);
            // 
            // EliminarArticuloMenu
            // 
            this.EliminarArticuloMenu.Image = global::Login.Properties.Resources.borrar;
            this.EliminarArticuloMenu.Name = "EliminarArticuloMenu";
            resources.ApplyResources(this.EliminarArticuloMenu, "EliminarArticuloMenu");
            this.EliminarArticuloMenu.Click += new System.EventHandler(this.EliminarToolStripMenuItemClick);
            // 
            // ModifArt
            // 
            this.ModifArt.Image = global::Login.Properties.Resources.modificar;
            this.ModifArt.Name = "ModifArt";
            resources.ApplyResources(this.ModifArt, "ModifArt");
            this.ModifArt.Click += new System.EventHandler(this.ModifArtClick);
            // 
            // verListadoToolStripMenuItem
            // 
            this.verListadoToolStripMenuItem.Image = global::Login.Properties.Resources.listado;
            this.verListadoToolStripMenuItem.Name = "verListadoToolStripMenuItem";
            resources.ApplyResources(this.verListadoToolStripMenuItem, "verListadoToolStripMenuItem");
            this.verListadoToolStripMenuItem.Click += new System.EventHandler(this.VerListadoToolStripMenuItemClick);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem,
            this.verListadoToolStripMenuItem1});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Image = global::Login.Properties.Resources.agregar;
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            resources.ApplyResources(this.agregarToolStripMenuItem1, "agregarToolStripMenuItem1");
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.AgregarToolStripMenuItem1Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::Login.Properties.Resources.modificar;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            resources.ApplyResources(this.modificarToolStripMenuItem, "modificarToolStripMenuItem");
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItemClick);
            // 
            // verListadoToolStripMenuItem1
            // 
            this.verListadoToolStripMenuItem1.Image = global::Login.Properties.Resources.listado;
            this.verListadoToolStripMenuItem1.Name = "verListadoToolStripMenuItem1";
            resources.ApplyResources(this.verListadoToolStripMenuItem1, "verListadoToolStripMenuItem1");
            this.verListadoToolStripMenuItem1.Click += new System.EventHandler(this.verListadoToolStripMenuItem1_Click);
            // 
            // PedidosToolStripMenuItem
            // 
            this.PedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarPedidoMenu,
            this.ModificarPedidoMenu,
            this.ListadoPedidoMenu,
            this.detallaDeFabricaciónMenu});
            this.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem";
            resources.ApplyResources(this.PedidosToolStripMenuItem, "PedidosToolStripMenuItem");
            // 
            // AgregarPedidoMenu
            // 
            this.AgregarPedidoMenu.Image = global::Login.Properties.Resources.agregar;
            this.AgregarPedidoMenu.MergeIndex = 1;
            this.AgregarPedidoMenu.Name = "AgregarPedidoMenu";
            resources.ApplyResources(this.AgregarPedidoMenu, "AgregarPedidoMenu");
            this.AgregarPedidoMenu.Click += new System.EventHandler(this.PedidoToolStripMenuItem_Click);
            // 
            // ModificarPedidoMenu
            // 
            this.ModificarPedidoMenu.Image = global::Login.Properties.Resources.modificar;
            this.ModificarPedidoMenu.Name = "ModificarPedidoMenu";
            resources.ApplyResources(this.ModificarPedidoMenu, "ModificarPedidoMenu");
            this.ModificarPedidoMenu.Click += new System.EventHandler(this.listadoDeudoresToolStripMenuItem_Click);
            // 
            // ListadoPedidoMenu
            // 
            this.ListadoPedidoMenu.Image = global::Login.Properties.Resources.listado;
            this.ListadoPedidoMenu.Name = "ListadoPedidoMenu";
            resources.ApplyResources(this.ListadoPedidoMenu, "ListadoPedidoMenu");
            this.ListadoPedidoMenu.Click += new System.EventHandler(this.listadoAcredoresToolStripMenuItem_Click);
            // 
            // detallaDeFabricaciónMenu
            // 
            this.detallaDeFabricaciónMenu.Image = global::Login.Properties.Resources.lupa;
            this.detallaDeFabricaciónMenu.Name = "detallaDeFabricaciónMenu";
            resources.ApplyResources(this.detallaDeFabricaciónMenu, "detallaDeFabricaciónMenu");
            this.detallaDeFabricaciónMenu.Click += new System.EventHandler(this.detallaDeFabricaciónToolStripMenuItem_Click);
            // 
            // matricesToolStripMenuItem
            // 
            this.matricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.modificarToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.matricesToolStripMenuItem.Name = "matricesToolStripMenuItem";
            resources.ApplyResources(this.matricesToolStripMenuItem, "matricesToolStripMenuItem");
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Image = global::Login.Properties.Resources.agregar;
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            resources.ApplyResources(this.agregarToolStripMenuItem2, "agregarToolStripMenuItem2");
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Image = global::Login.Properties.Resources.modificar;
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            resources.ApplyResources(this.modificarToolStripMenuItem1, "modificarToolStripMenuItem1");
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Login.Properties.Resources.nitrogeno;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salirToolStripMenuItem.Image = global::Login.Properties.Resources.stop;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyeccionToolStripMenuItem,
            this.enProducciónToolStripMenuItem,
            this.reporteDeProducciónToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            // 
            // proyeccionToolStripMenuItem
            // 
            this.proyeccionToolStripMenuItem.Image = global::Login.Properties.Resources.reloj_calendario;
            this.proyeccionToolStripMenuItem.Name = "proyeccionToolStripMenuItem";
            resources.ApplyResources(this.proyeccionToolStripMenuItem, "proyeccionToolStripMenuItem");
            this.proyeccionToolStripMenuItem.Click += new System.EventHandler(this.proyeccionToolStripMenuItem_Click);
            // 
            // enProducciónToolStripMenuItem
            // 
            this.enProducciónToolStripMenuItem.Image = global::Login.Properties.Resources.listado;
            this.enProducciónToolStripMenuItem.Name = "enProducciónToolStripMenuItem";
            resources.ApplyResources(this.enProducciónToolStripMenuItem, "enProducciónToolStripMenuItem");
            this.enProducciónToolStripMenuItem.Click += new System.EventHandler(this.enProducciónToolStripMenuItem_Click_1);
            // 
            // reporteDeProducciónToolStripMenuItem
            // 
            this.reporteDeProducciónToolStripMenuItem.Image = global::Login.Properties.Resources.reporte;
            this.reporteDeProducciónToolStripMenuItem.Name = "reporteDeProducciónToolStripMenuItem";
            resources.ApplyResources(this.reporteDeProducciónToolStripMenuItem, "reporteDeProducciónToolStripMenuItem");
            this.reporteDeProducciónToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProducciónToolStripMenuItem_Click_1);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            resources.ApplyResources(this.usuarioToolStripMenuItem, "usuarioToolStripMenuItem");
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // puestosDeTrabajoToolStripMenuItem
            // 
            this.puestosDeTrabajoToolStripMenuItem.Name = "puestosDeTrabajoToolStripMenuItem";
            resources.ApplyResources(this.puestosDeTrabajoToolStripMenuItem, "puestosDeTrabajoToolStripMenuItem");
            this.puestosDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.puestosDeTrabajoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::Login.Properties.Resources.FONDO_3;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripMenuItem matricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallaDeFabricaciónMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem puestosDeTrabajoToolStripMenuItem;
    }
}
