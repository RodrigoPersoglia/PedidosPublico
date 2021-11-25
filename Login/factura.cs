
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Login
{
	/// <summary>
	/// Description of factura.
	/// </summary>
	public partial class factura : Form
	{
		//variables
		private int num_fila;
		private double varsubtotal = 0;
		private double variva;
		private double vartotal;




		//Constructor
		public factura()
		{ InitializeComponent(); }


		void agregarClick(object sender, EventArgs e)
		{
			if (txtCodigo.Text != "" && txtDescripcion.Text != "" && cant.Text != "0" && PrecioUd.Text != "0,00") {
				//Adicionamos un nuevo renglon
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = txtCodigo.Text;
				dataGridView1.Rows[n].Cells[1].Value = txtDescripcion.Text;
				dataGridView1.Rows[n].Cells[2].Value = cant.Text;
				dataGridView1.Rows[n].Cells[3].Value = "Ud.";
				dataGridView1.Rows[n].Cells[4].Value = "$ " + PrecioUd.Text;
				dataGridView1.Rows[n].Cells[5].Value = "0,00%";
				double var1, var2;
				var1 = double.Parse(cant.Text);
				var2 = double.Parse(PrecioUd.Text);
				varsubtotal = varsubtotal + var1 * var2;
				variva = varsubtotal * 0.21;
				vartotal = varsubtotal + variva;
				dataGridView1.Rows[n].Cells[6].Value = "$ " + (var1 * var2).ToString();
				totales.Rows[0].Cells[0].Value = "$ " + (varsubtotal).ToString();
				totales.Rows[0].Cells[1].Value = "$ " + (variva).ToString();
				totales.Rows[0].Cells[3].Value = "$ " + (vartotal).ToString();

			}
			else { MessageBox.Show("Revise los campos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
		}

	
		
		//Devuelve el numero de fila seleccionada.(Creado en los "eventos")
		void seleccioncelda(object sender, DataGridViewCellEventArgs e){ 
			num_fila = e.RowIndex;}
		
		
		void QuitarClick(object sender, EventArgs e)
		{try{
			if(num_fila>-1){
					double restar=double.Parse(((string)dataGridView1.Rows[num_fila].Cells[6].Value).Replace("$ ",""));
					varsubtotal-=restar;
					variva = varsubtotal*0.21;
					vartotal = varsubtotal+variva;
					totales.Rows[0].Cells[0].Value = "$ "+(varsubtotal).ToString();
					totales.Rows[0].Cells[1].Value = "$ "+(variva).ToString();
					totales.Rows[0].Cells[3].Value = "$ "+(vartotal).ToString();
					dataGridView1.Rows.RemoveAt(num_fila);}}
			
			catch (Exception){MessageBox.Show("Acción Invalida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);}
	
		}



		void BuscarClick(object sender, EventArgs e)
		{
			Articulo articulo =  Conexion.ObtenerArticulo(txtCodigo.Text,this);
			txtCodigo.Text = articulo.Codigo;
			txtDescripcion.Text = articulo.Descripcion;
			PrecioUd.Value =  Convert.ToDecimal (articulo.Precio);

		}


		void FacturarClick(object sender, EventArgs e)
			{

			}

			void SalirClick(object sender, EventArgs e)
			{ this.Close(); }



			void LimpiarClick(object sender, EventArgs e)
			{
				dataGridView1.Rows.Clear(); varsubtotal = 0; variva = 0; vartotal = 0;
				totales.Rows[0].Cells[0].Value = "$ " + (varsubtotal).ToString();
				totales.Rows[0].Cells[1].Value = "$ " + (variva).ToString();
				totales.Rows[0].Cells[3].Value = "$ " + (vartotal).ToString();
			}

			//void TextChanged(object sender, EventArgs e)
			//{
			//	string[] lista;
			//	try
			//	{
			//		if (int.Parse(numcli.Text) > 0)
			//		{
			//			lista = Asignar_cliente(numcli.Text);
			//		}
			//		else
			//		{
			//			lista = Asignar_cliente("0");
			//		}
			//		Cliente.Text = lista[0];
			//		//Empresa.Text=lista[2];
			//		Direccion.Text = lista[2];
			//		//DirEntrega.Text=lista[4];
			//		Telefono.Text = lista[4];
			//		Ivabox.Text = lista[5];
			//		//Documento.Text=lista[6];
			//		Cuit.Text = lista[7];
			//		numcli.Text = lista[8];
			//	}
			//	catch (Exception)
			//	{
			//		if (numcli.Text == "") { Cliente.Text = ""; Direccion.Text = ""; Telefono.Text = ""; Ivabox.Text = ""; Cuit.Text = ""; numcli.Text = ""; }
			//		else
			//		{
			//			lista = Asignar_cliente("0");

			//			Cliente.Text = lista[0];
			//			//Empresa.Text=lista[2];
			//			Direccion.Text = lista[2];
			//			//DirEntrega.Text=lista[4];
			//			Telefono.Text = lista[4];
			//			Ivabox.Text = lista[5];
			//			//Documento.Text=lista[6];
			//			Cuit.Text = lista[7];
			//			numcli.Text = lista[8];
			//		}
			//	}

			//}



		//**** METODO ****//
		//Retorna una lista con la informacion del articulo seleccionado o vacia si no hay seleccion.
		//string[] Asignar_cliente(string numcliente)
		//{ }
				


			
	
	}
}
