using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace Login
{
	public partial class ListadoArticulos : Form
	{
		//Declaracion de variables, sirve para vincular con la ventana que las instancia.
		private Articulo articuloSeleccionado = new Articulo();

		
		
		// Constructor
		public ListadoArticulos(string texto){InitializeComponent();
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

			else{MessageBox.Show("No se encontraron registros");}
            }

            catch (MySqlException ex){ MessageBox.Show("Error al buscar seleccion articulo" + ex.Message);}
            finally{ conectar.Close();}

        }
		
	
		
		
		// Devuelve el indice de la celda seleccionada
		int n;
		void Selecccioncelda(object sender, DataGridViewCellEventArgs e)
		{
			
			n = e.RowIndex;

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
			
			this.Close();

		}

        private void articuloBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
			MySqlConnection conectar = Conexion.ObtenerConexion();
			DataTable dt = new DataTable();
			conectar.Open();
			try
			{

				MySqlCommand comand = new MySqlCommand("BuscarArticulo", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@busqueda", "");
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

        private void VerTodos_Click(object sender, EventArgs e)
        {
			Cuadro.Rows.Clear();
			MySqlConnection conectar = Conexion.ObtenerConexion();
			DataTable dt = new DataTable();
			conectar.Open();
			try
			{

				MySqlCommand comand = new MySqlCommand("BuscarArticulo", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@busqueda", "");
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

        private void ExportarBTN_Click(object sender, EventArgs e)
        {
			Exportar.Exportar_Articulos(Cuadro);
		}
    }
}