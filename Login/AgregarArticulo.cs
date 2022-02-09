using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace Login
{
	public partial class AgregarArticulo : Form
	{
		public AgregarArticulo() {InitializeComponent();}

		// Carga los Combobox iniciales desde la base de datos
		void AgregarArticuloLoad(object sender, EventArgs e)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();

			// COMBOBOX ALEACION
			MySqlDataReader reader;
			string consulta = "Select ID,descripcion From Aleacion a order by a.descripcion";
			conectar.Open();

			try{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				DataRow newRow = dt.NewRow();
				newRow["descripcion"] = "Seleccione";
				dt.Rows.InsertAt(newRow, 0);
				AleacionComboBox.DataSource = dt;
				AleacionComboBox.DisplayMember = "descripcion";
				AleacionComboBox.ValueMember = "ID";

			}
			catch (MySqlException ex){MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);}

			// COMBOBOX TEMPLE
			string consulta2 = "Select ID,descripcion From Temple t order by t.descripcion";
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta2, conectar);
				reader = comand.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				DataRow newRow = dt.NewRow();
				newRow["descripcion"] = "Seleccione";
				dt.Rows.InsertAt(newRow, 0);
				TempleComboBox.DataSource = dt;
				TempleComboBox.DisplayMember = "descripcion";
				TempleComboBox.ValueMember = "ID";
			}
			catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); }

			// COMBOBOX CLASIFICACION
			string consulta3 = "Select ID,descripcion From Clasificacion c order by c.descripcion ";
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta3, conectar);
				reader = comand.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				DataRow newRow = dt.NewRow();
				newRow["descripcion"] = "Seleccione";
				dt.Rows.InsertAt(newRow, 0);
				ClasificacionComboBox.DataSource = dt;
				ClasificacionComboBox.DisplayMember = "descripcion";
				ClasificacionComboBox.ValueMember = "ID";
			}
			catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); }

			// COMBOBOX TOPOLOGIA
			string consulta4 = "Select ID,descripcion From Topologia t order by t.descripcion";
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta4, conectar);
				reader = comand.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				DataRow newRow = dt.NewRow();
				newRow["descripcion"] = "Seleccione";
				dt.Rows.InsertAt(newRow, 0);
				TopologiaComboBox.DataSource = dt;
				TopologiaComboBox.DisplayMember = "descripcion";
				TopologiaComboBox.ValueMember = "ID";
			}
			catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); }

			// COMBOBOX CLIENTE
			string consulta5 = "Select ID,Alias From Cliente c order by c.Alias";
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta5, conectar);
				reader = comand.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				DataRow newRow = dt.NewRow();
				newRow["Alias"] = "Seleccione";
				dt.Rows.InsertAt(newRow, 0);
				ClienteComboBox.DataSource = dt;
				ClienteComboBox.DisplayMember = "Alias";
				ClienteComboBox.ValueMember = "ID";
			}
			catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); }

			// COMBOBOX PRENSA
			string consulta6 = "Select ID,descripcion From Puesto p order by p.descripcion";
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta6, conectar);
				reader = comand.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				DataRow newRow = dt.NewRow();
				newRow["descripcion"] = "Seleccione";
				dt.Rows.InsertAt(newRow, 0);
				PrensaCBX.DataSource = dt;
				PrensaCBX.DisplayMember = "descripcion";
				PrensaCBX.ValueMember = "ID";
			}
			catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); } // Cerramos la conexion a la base de datos
		}




		void CancelarClick(object sender, EventArgs e)
		{this.Close();
		}
		
		
		
		void CrearClick(object sender, EventArgs e)
		{
            try
            {
                String _codigo = Codigotxt.Text;
				String _descripcion = DescripcionTxt.Text;
				double _pesoNominal = double.Parse(PesoNominalTxt.Text);
				int _tolerancia = int.Parse(ToleranciaTxt.Text);
				int _multiplos = int.Parse(MultiplosTxt.Text);
				int _aleacionID = (int)AleacionComboBox.SelectedValue;
				int _templeID = (int)TempleComboBox.SelectedValue;
				int _clasificacionID = (int)ClasificacionComboBox.SelectedValue;
				int _topologiaID = (int)TopologiaComboBox.SelectedValue;
				int _clienteID = (int)ClienteComboBox.SelectedValue;
				int _prensaID = (int)PrensaCBX.SelectedValue;

				if (Conexion.ExisteArticulo(_codigo)) { MessageBox.Show("el codigo ingresado ya existe. Ingrese otro."); }
				else
				{

					if ( _descripcion != "" && _tolerancia > 0 && _tolerancia < 50 && _multiplos < 6000 && AleacionComboBox.Text != "Seleccione" && TempleComboBox.Text != "Seleccione" && ClasificacionComboBox.Text != "Seleccione" && TopologiaComboBox.Text != "Seleccione" && PrensaCBX.Text != "Seleccione" && ClienteComboBox.Text != "Seleccione")
					{

						//revisar aca
						string sql = "INSERT INTO articulo (codigo,descripcion,pesoNominal, tolerancia,Aleacion_ID,Temple_ID,Clasificacion_ID,Topologia_ID,Cliente_ID,Puesto_ID,Ubicacion) VALUES ('" + _codigo + "', '" + _descripcion + "','" + _pesoNominal + "','" + _tolerancia + "','" + _aleacionID + "','" + _templeID + "','" + _clasificacionID + "','" + _topologiaID + "','" + _clienteID + "','" + _prensaID + "' , '" + UbicacionTXT.Text + "')";

						MySqlConnection conexionBD = Conexion.ObtenerConexion();
						conexionBD.Open();
                        try
                        {
                            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
							comando.ExecuteNonQuery();
							MessageBox.Show("Registro guardado");
							//limpiar();
							Codigotxt.Text = "";
							DescripcionTxt.Text = "";
							PesoNominalTxt.Value = 0;
							ToleranciaTxt.Value = 0;
							MultiplosTxt.Value = 0;
							AleacionComboBox.Text = "Seleccione";
							TempleComboBox.Text = "Seleccione";
							ClasificacionComboBox.Text = "Seleccione";
							TopologiaComboBox.Text = "Seleccione";
							ClienteComboBox.Text = "Seleccione";
							PrensaCBX.Text = "Seleccione";
							pictureBox1.ImageLocation = null;
							UbicacionTXT.Text = "";

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al guardar: " + ex.Message);
                        }
                        finally
                        {
                            conexionBD.Close();
                        }
                    }
					else
					{
						MessageBox.Show("Debe completar todos los campos");
					}
				}
        }
			catch (FormatException fex)
			{
				MessageBox.Show("Datos incorrectos: " + fex.Message);
			}


}
		
			



	  }
}
