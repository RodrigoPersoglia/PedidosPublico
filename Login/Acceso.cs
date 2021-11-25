
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
	
		}


		void EntrarClick(object sender, EventArgs e)
        {
			try
			{


				MySqlConnection conectar = Conexion.ObtenerConexion();
				conectar.Open();
				DataTable dt = new DataTable();
				try
				{
					MySqlCommand comand = new MySqlCommand("ObtenerUsuario", conectar);
					comand.CommandType = CommandType.StoredProcedure;
					comand.Parameters.AddWithValue("@parametro1", Usuario.Text);
					MySqlDataAdapter adp = new MySqlDataAdapter(comand);
					adp.Fill(dt);
					if (dt.Rows.Count == 1)
					{

						bool prueba = false;
						foreach (DataRow x in dt.Rows)
						{
							if (Usuario.Text != (string)x[1])
							{
								MessageBox.Show("El usuario ingresado no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								if (Contraseña.Text == (string)x[2]) { prueba = true; }


								if (prueba)
								{
									Usuario usuarioNuevo = new Usuario();
									foreach (DataRow y in dt.Rows)
									{
										usuarioNuevo.User = (string)x[1];
										if ((int)y[3] == 0) { usuarioNuevo.TablaCliente = false; }
										else { usuarioNuevo.TablaCliente = true; }

										if ((int)y[4] == 0) { usuarioNuevo.TablaArchivos = false; }
										else { usuarioNuevo.TablaArchivos = true; }

										if ((int)y[5] == 0) { usuarioNuevo.TablaArticulos = false; }
										else { usuarioNuevo.TablaArticulos = true; }

										if ((int)y[6] == 0) { usuarioNuevo.TablaPedidos = false; }
										else { usuarioNuevo.TablaPedidos = true; }

										if ((int)y[7] == 0) { usuarioNuevo.TablaMatrices = false; }
										else { usuarioNuevo.TablaMatrices = true; }

										if ((int)y[8] == 0) { usuarioNuevo.Tablausuario = false; }
										else { usuarioNuevo.Tablausuario = true; }

									}

									Principal vnappal = new Principal(usuarioNuevo);
									vnappal.Show();
									this.Hide();
								}
								else { MessageBox.Show("Contraseña Incorrecta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
							}
						}

					}



					else { MessageBox.Show("El usuario ingresado no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				}

				catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
				catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }

				finally { conectar.Close(); }
			}

            catch (Exception)
			{ 
				AutoClosingMessageBox.Show("No se encuentra el servidor","Error",MessageBoxButtons.OK,MessageBoxIcon.Error,1200);
				NombreServidor nameServer = new NombreServidor();
				nameServer.Show();
			}
		}
	}
}
