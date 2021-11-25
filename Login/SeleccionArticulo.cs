using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace Login
{
	public partial class SeleccionArticulo : Form
	{
		//Declaracion de variables, sirve para vincular con la ventana que las instancia.
		private Articulo articuloSeleccionado = new Articulo();

		
		
		// Constructor
		public SeleccionArticulo(string texto){InitializeComponent();
			Busquedatext.Text =texto;
		}
		
		//Propiedades, solo Get
		public Articulo ArticuloSeleccionado{
			get{return articuloSeleccionado; }
		}



		//Muestra en el cuadro las coincidencias
		void BuscarClick(object sender, EventArgs e)
		{
			Cuadro.Rows.Clear();

			MySqlConnection conectar = Conexion.ObtenerConexion();
			DataTable dt = new DataTable();
			conectar.Open();
            try
            {

                MySqlCommand comand = new MySqlCommand("BuscarArticulo", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@busqueda", Busquedatext.Text);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);


				if (dt.Rows.Count>0)
				{
					//Matriz matriz = new Matriz();
					foreach (DataRow x in dt.Rows)
					{
						int n = Cuadro.Rows.Add();
						Cuadro.Rows[n].Cells[0].Value = (string)x[11];
						Cuadro.Rows[n].Cells[1].Value = (int)x[0];
						Cuadro.Rows[n].Cells[2].Value = (string)x[1];
						Cuadro.Rows[n].Cells[3].Value = (string)x[2];
						Cuadro.Rows[n].Cells[4].Value = decimal.ToDouble((decimal)x[3]);
						Cuadro.Rows[n].Cells[5].Value = (int)x[4];
						Cuadro.Rows[n].Cells[6].Value = (int)x[5];
						Cuadro.Rows[n].Cells[7].Value = (string)x[7];
						Cuadro.Rows[n].Cells[8].Value = (string)x[8];
						Cuadro.Rows[n].Cells[9].Value = (string)x[9];
						Cuadro.Rows[n].Cells[10].Value = (string)x[10];
						Cuadro.Rows[n].Cells[11].Value = decimal.ToDouble((decimal)x[12]);

					}
			}

			else{MessageBox.Show("No se encontraron registros");}
            }

            catch (MySqlException ex){ MessageBox.Show("Error al buscar seleccion articulo" + ex.Message);}
            finally{ conectar.Close();}

        }
		
	
		
		
		// Devuelve el indice de la celda seleccionada
		int n;
		void Selecccioncelda(object sender, DataGridViewCellEventArgs e)
		{n = e.RowIndex;
			string codigo = (string)Cuadro.Rows[n].Cells[2].Value;
			try
			{
				string ruta = "//Rodrigo/imagenes/" + codigo + ".bmp";
				byte[] imageBytes = File.ReadAllBytes(ruta);
				MemoryStream buf = new MemoryStream(imageBytes);
				pictureBox1.Image = Image.FromStream(buf);
			}
			catch (Exception) { pictureBox1.Image = null; }

		}

		
		//Cierra la ventana y escribe la informacion en las propiedades
		void AceptarClick(object sender, EventArgs e){
			ArticuloSeleccionado.Cliente = Cuadro.Rows[n].Cells[0].Value.ToString();
			ArticuloSeleccionado.ID = int.Parse(Cuadro.Rows[n].Cells[1].Value.ToString());
			ArticuloSeleccionado.Codigo = Cuadro.Rows[n].Cells[2].Value.ToString();
			ArticuloSeleccionado.Descripcion = Cuadro.Rows[n].Cells[3].Value.ToString();
			ArticuloSeleccionado.PesoNominal = Double.Parse(Cuadro.Rows[n].Cells[4].Value.ToString());
			ArticuloSeleccionado.Tolerancia = int.Parse(Cuadro.Rows[n].Cells[5].Value.ToString());
			ArticuloSeleccionado.Multiplo = int.Parse(Cuadro.Rows[n].Cells[6].Value.ToString());
			ArticuloSeleccionado.Aleacion = Cuadro.Rows[n].Cells[7].Value.ToString();
			ArticuloSeleccionado.Temple = Cuadro.Rows[n].Cells[8].Value.ToString();
			ArticuloSeleccionado.Clasificacion = Cuadro.Rows[n].Cells[9].Value.ToString();
			ArticuloSeleccionado.Topologia = Cuadro.Rows[n].Cells[10].Value.ToString();
			ArticuloSeleccionado.Precio = Double.Parse(Cuadro.Rows[n].Cells[11].Value.ToString());
			this.Close();

		}

        private void articuloBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionArticulo_Load(object sender, EventArgs e)
        {
			MySqlConnection conectar = Conexion.ObtenerConexion();
			DataTable dt = new DataTable();
			conectar.Open();
			try
			{

				MySqlCommand comand = new MySqlCommand("BuscarArticulo", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@busqueda", Busquedatext.Text);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);


				if (dt.Rows.Count > 0)
				{
					Matriz matriz = new Matriz();
					foreach (DataRow x in dt.Rows)
					{
						int n = Cuadro.Rows.Add();
						Cuadro.Rows[n].Cells[0].Value = (string)x[11];
						Cuadro.Rows[n].Cells[1].Value = (int)x[0];
						Cuadro.Rows[n].Cells[2].Value = (string)x[1];
						Cuadro.Rows[n].Cells[3].Value = (string)x[2];
						Cuadro.Rows[n].Cells[4].Value = decimal.ToDouble((decimal)x[3]);
						Cuadro.Rows[n].Cells[5].Value = (int)x[4];
						Cuadro.Rows[n].Cells[6].Value = (int)x[5];
						Cuadro.Rows[n].Cells[7].Value = (string)x[7];
						Cuadro.Rows[n].Cells[8].Value = (string)x[8];
						Cuadro.Rows[n].Cells[9].Value = (string)x[9];
						Cuadro.Rows[n].Cells[10].Value = (string)x[10];
						Cuadro.Rows[n].Cells[11].Value = decimal.ToDouble((decimal)x[12]);

					}
				}

				else { MessageBox.Show("No se encontraron registros"); }
			}

			catch (MySqlException ex) { MessageBox.Show("Error al buscar seleccion articulo" + ex.Message); }
			finally { conectar.Close(); }


		}
	}
}