using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace Login
{
	/// <summary>
	/// Description of Conexion.
	/// </summary>
	public class Conexion
	{

		
		public static MySqlConnection ObtenerConexion()
		{
			string servidor = "xxx"; 
			try
            {
				StreamReader sr = new StreamReader("NombreServidor.txt");
				servidor = sr.ReadLine();
				sr.Close();
			}
			catch (Exception) { }
			MySqlConnection Conexion = new MySqlConnection("Server="+servidor+";database=pedidos;Uid=cualquierUsuario;pwd=;");
			
			return Conexion;
		}

		

		public static Cliente ObtenerCliente(string busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
            try
            {
                MySqlCommand comand = new MySqlCommand("ObtenerCliente", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", busqueda);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					Cliente cliente = new Cliente();
					foreach (DataRow x in dt.Rows)
					{
						cliente.ID = (int)x[0];
					cliente.Numero = (int)x[1];
					cliente.Alias = (string)x[2];
					
					if (x[3] != null)
					{
						try { cliente.RazonSocial = (string)x[3];}
						catch (Exception) { }
					}

					if (x[4] != null)
					{
						try { cliente.Cuit = (int)x[4]; }
						catch (Exception) { }
					}

					if (x[5] != null)
					{
						try { cliente.Telefono1 = (string)x[5]; }
						catch (Exception) { }
					}

					if (x[6] != null)
					{
						try { cliente.Telefono2 = (string)x[6]; }
						catch (Exception) { }
					}


					cliente.IDDireccion = (int)x[7];
					cliente.Direccion = (string)x[8];
					cliente.Ciudad = (string)x[9];
					cliente.Provincia = (string)x[10];
					cliente.CP = (string)x[11];

					cliente.IDDireccion2 = (int)x[12];
					cliente.Direccion2 = (string)x[13];
					cliente.Ciudad2 = (string)x[14];
					cliente.Provincia2 = (string)x[15];
					cliente.CP2 = (string)x[16];

					cliente.IVA = (string)x[17];
					cliente.TIPODOC = (string)x[18];



				}
					return cliente;
				}
				else { 
					VentanaSeleccion2 selec = new VentanaSeleccion2(busqueda);
					DialogResult resultado = selec.ShowDialog();
					return selec.ClienteSeleccionado; }

        }
            catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
            finally { conectar.Close(); }
        }





        public static bool ExisteArticulo(string busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			MySqlDataReader reader;
			// Hago la consulta a la base de datos
			string consulta = "SELECT a.codigo FROM articulo a";
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						if (busqueda == reader.GetString(0)) { return true; }

					}
				}
				return false;
			}
					
			catch (MySqlException ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return false; }
			finally {conectar.Close(); }

		}

		public static Pedido ObtenerPedido(string busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("consultaPedidos", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@parametro1", busqueda);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if(dt.Rows.Count == 1)
				{
					Pedido pedido = new Pedido();
					foreach (DataRow x in dt.Rows)
					{
						pedido.ID = (int)x[0];
						pedido.Numero = (int)x[1];
						pedido.Fecha = (DateTime)x[2];
                    try { pedido.KgEstimados = (double)x[3]; }
					catch (Exception) { pedido.KgEstimados = 0; }
						pedido.OrdenCompra = (string)x[4];
						pedido.Observaciones = (string)x[5];
						pedido.Cliente = (string)x[6];
						pedido.Articulo = (string)x[7];
						pedido.Unidad = (string)x[8];
						pedido.Terminacion = (string)x[9];
						pedido.Estado = (string)x[10];
						pedido.Prioridad = (string)x[11];
						pedido.Aleacion = (string)x[12];
						pedido.Temple = (string)x[13];
						pedido.Codigo_Articulo = x[17].ToString();
						pedido.Matriz = (int)x[18];
					}
					return pedido;
				}
				else{ MessageBox.Show("El numero ingresado no corresponde a un pedido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null;}

			}
			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }

		}

		public static DataTable ObtenerDetallepedido(string busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("consultaPedidoDetalle", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@parametro1", busqueda);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count>0)
				{
					
					return dt;
				}
				else { MessageBox.Show("El numero de pedido ingresado no tiene detalle"); return null; }

			}
			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }

		}

		public static void EliminarDetalle(string ID_Pedido)
        {
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("eliminardetalle", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@parametro1", ID_Pedido);
				comand.ExecuteNonQuery();

			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}

		public static void ModificarPedido(int ID_Pedido,int numero,string fecha,double kgEstimados, string oc,string observaciones,int cliente,int articulo,int unidad, int terminacion, int prioridad,int aleacion,int temple)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("eliminardetalle", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", ID_Pedido);
				comand.Parameters.AddWithValue("@p2", numero);
				comand.Parameters.AddWithValue("@p3", fecha);
				comand.Parameters.AddWithValue("@p4", kgEstimados);
				comand.Parameters.AddWithValue("@p5", oc);
				comand.Parameters.AddWithValue("@p6", observaciones);
				comand.Parameters.AddWithValue("@p7", cliente);
				comand.Parameters.AddWithValue("@p8", articulo);
				comand.Parameters.AddWithValue("@p9", unidad);
				comand.Parameters.AddWithValue("@p10", terminacion);
				comand.Parameters.AddWithValue("@p11", prioridad);
				comand.Parameters.AddWithValue("@p12", aleacion);
				comand.Parameters.AddWithValue("@p13", temple);
				comand.ExecuteNonQuery();
				MessageBox.Show("Pedido modificado");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}



		public static DataTable VerMatriz(string busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("verMatriz", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@parametro1", busqueda);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count >0)
				{
					return dt;
				}
				else { MessageBox.Show("El Artículo ingresado no tiene matrices asociadas disponibles","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Warning); return null; }

			}
			catch (Exception ex) { MessageBox.Show("Error al buscar matriz " + ex.Message); return null; }
			finally { conectar.Close(); }
		}


		public static Matriz ObtenerMatriz(int busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
            try
            {
                MySqlCommand comand = new MySqlCommand("ObtenerMatriz", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@parametro1", busqueda);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					Matriz matriz = new Matriz();
					foreach (DataRow x in dt.Rows)
					{

                        matriz.ID = (int)x[0];
                        matriz.Leyenda = (string)x[1];
                        matriz.Ejemplar = (int)x[2];
                        matriz.Salidas = (int)x[3];
                        matriz.Peso = decimal.ToDouble((decimal)x[4]);
                        matriz.Codigo = (string)x[5];
                        matriz.Estado = (string)x[6];
						matriz.Propietario = (int)x[7];
						matriz.KgAcumulados = (int)x[8];
						matriz.KgAcumulados2 = (int)x[9];
						matriz.Controlada = (bool)x[10];

					}
					return matriz;
				}
				else { MessageBox.Show("El numero ingresado no corresponde a un pedido"); return null; }

        }
            catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
            finally { conectar.Close(); }

        }

		public static string VerEstado(string busqueda)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("verEstado", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", busqueda);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					string estado = "";
					foreach (DataRow x in dt.Rows)
					{

						//matriz.ID = (int)x[0];
						estado = (string)x[1];

					}
					return estado;
				}
				else { MessageBox.Show("El numero ingresado no corresponde a un pedido"); return null; }

			}
			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }

		}


		public static void ModificarEstado(string numPedido,int EstadoID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("modificarEstado", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", numPedido);
				comand.Parameters.AddWithValue("@p2", EstadoID);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Estado del pedido Modificado","Pedido",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}

		public static void ModificarEstado(string numPedido, int EstadoID, bool notificar)
		{
            if (notificar)
			{
				MySqlConnection conectar = Conexion.ObtenerConexion();
				conectar.Open();
				try
				{
					MySqlCommand comand = new MySqlCommand("modificarEstado", conectar);
					comand.CommandType = CommandType.StoredProcedure;
					comand.Parameters.AddWithValue("@p1", numPedido);
					comand.Parameters.AddWithValue("@p2", EstadoID);
					comand.ExecuteNonQuery();
					AutoClosingMessageBox.Show("Estado del pedido Modificado", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 1600);
				}
				catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
				finally { conectar.Close(); }

            }
            else
            {
				MySqlConnection conectar = Conexion.ObtenerConexion();
				conectar.Open();
				try
				{
					MySqlCommand comand = new MySqlCommand("modificarEstado", conectar);
					comand.CommandType = CommandType.StoredProcedure;
					comand.Parameters.AddWithValue("@p1", numPedido);
					comand.Parameters.AddWithValue("@p2", EstadoID);
					comand.ExecuteNonQuery();
					
				}
				catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
				finally { conectar.Close(); }

			}

		}


		public static void AgregarMatriz(int ejemplar,int salidas, double pesoActual,int Articulo_ID,int Cliente_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("AgregarMatriz", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", ejemplar);
				comand.Parameters.AddWithValue("@p2", salidas);
				comand.Parameters.AddWithValue("@p3", pesoActual);
				comand.Parameters.AddWithValue("@p4", Articulo_ID);
				comand.Parameters.AddWithValue("@p5", Cliente_ID);
				

				comand.ExecuteNonQuery();
				MessageBox.Show("Matriz Agregada");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}



		public static void EliminarLocalidad(string localidad)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("eliminarLocalidad", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", localidad);
				comand.ExecuteNonQuery();
				MessageBox.Show("Localidad Eliminada");

			}
			catch (MySqlException) { MessageBox.Show("No se puede eliminar una Localidad que registre actividad"); }
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}




		public static void CrearCliente(string dirFisc,int provFisc,string CodPosFis,string dirEnt, int provEnt, string CodPosEnt,int numero,string Alias,string RazonSocial,long cuit,string tel1,string tel2,int tipoDoc,int IVA)
		{
			int dirF = 0;
			int dirE = 0;
			DataTable dt = new DataTable();
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("guardarDireccion", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", dirFisc);
				comand.Parameters.AddWithValue("@p2", provFisc);
				comand.Parameters.AddWithValue("@p3", CodPosFis);
				comand.ExecuteNonQuery();

				MySqlCommand comand2 = new MySqlCommand("guardarDireccion", conectar);
				comand2.CommandType = CommandType.StoredProcedure;
				comand2.Parameters.AddWithValue("@p1", dirEnt);
				comand2.Parameters.AddWithValue("@p2", provEnt);
				comand2.Parameters.AddWithValue("@p3", CodPosEnt);
				comand2.ExecuteNonQuery();


				MySqlCommand comand3 = new MySqlCommand("UltimasDirecciones", conectar);
				comand3.CommandType = CommandType.StoredProcedure;
				MySqlDataAdapter adp = new MySqlDataAdapter(comand3);
				adp.Fill(dt);
				if (dt.Rows.Count == 2)
				{
					int contador = 0;
					foreach (DataRow x in dt.Rows)
					{

						if (contador == 0)
						{
							dirE = (int)x[0];
						}
						else { dirF = (int)x[0]; }
						contador++;
					}
				}


				MySqlCommand comand4 = new MySqlCommand("CrearCliente", conectar);
                comand4.CommandType = CommandType.StoredProcedure;
				comand4.Parameters.AddWithValue("@p1", numero);
				comand4.Parameters.AddWithValue("@p2", Alias);
				comand4.Parameters.AddWithValue("@p3", RazonSocial);
				comand4.Parameters.AddWithValue("@p4", cuit);
				comand4.Parameters.AddWithValue("@p5", tel1);
				comand4.Parameters.AddWithValue("@p6", tel2);
				comand4.Parameters.AddWithValue("@p7", dirF);
				comand4.Parameters.AddWithValue("@p8", dirE);
				comand4.Parameters.AddWithValue("@p9", tipoDoc);
				comand4.Parameters.AddWithValue("@p10", IVA);
				comand4.ExecuteNonQuery();

                    MessageBox.Show("Cliente Creado correctamente");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}




		public static void AgregarDetallePedido(DateTime fecha, string horaInicio, string horaFin, double kgs, int tiras, string largoPerfil, double pesoMetro, string colada, string observaciones, int largoTocho, int cantidadTochos, int matriz_ID, int puesto_ID, int pedido_ID, int turno_ID, int Aleacion_ID,  int Kg, int diamTocho, double kgPrensa)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
            try
            {
                MySqlCommand comand = new MySqlCommand("AgregarDetalleFabricacion", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@fecha", fecha);
				comand.Parameters.AddWithValue("@horaInicio", horaInicio);
				comand.Parameters.AddWithValue("@horaFin", horaFin);
				comand.Parameters.AddWithValue("@kgs", kgs);
				comand.Parameters.AddWithValue("@tiras", tiras);
				comand.Parameters.AddWithValue("@largoPerfil", largoPerfil);
				comand.Parameters.AddWithValue("@pesoMetro", pesoMetro);
				comand.Parameters.AddWithValue("@colada", colada);
				comand.Parameters.AddWithValue("@observaciones", observaciones);
				comand.Parameters.AddWithValue("@largoTocho", largoTocho);
				comand.Parameters.AddWithValue("@cantidadTochos", cantidadTochos);
				comand.Parameters.AddWithValue("@matriz_ID", matriz_ID);
				comand.Parameters.AddWithValue("@prensa", puesto_ID);
				comand.Parameters.AddWithValue("@pedido_ID", pedido_ID);
				comand.Parameters.AddWithValue("@turno_ID", turno_ID);
				comand.Parameters.AddWithValue("@Aleacion_ID", Aleacion_ID);
				comand.Parameters.AddWithValue("@kg_acumulados", Kg);
				comand.Parameters.AddWithValue("@p18", diamTocho);
				comand.Parameters.AddWithValue("@p19", kgPrensa);
				comand.ExecuteNonQuery();
				MessageBox.Show("Detalle de fabricación guardado");
        }
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }

		}

		public static DataTable VerDetalleFabricacion(int numero)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand(" VerDetalleFabricacion", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", numero);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					return dt;
				}
				else { MessageBox.Show("No tiene detalle de fabricacion"); return null; }

			}
			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void ModificarCliente(int clienteID,int numero, string alias, string razonSocial, int cuit, string tel1, string tel2, int tipoDoc, int iva, string calleNumero, int LocalidadID, string codigoPostal,string  calleNumero2, int localidadID2, string codigoPostal2)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("ModificarCliente", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", clienteID);
				comand.Parameters.AddWithValue("@p1", numero);
				comand.Parameters.AddWithValue("@p2", alias);
				comand.Parameters.AddWithValue("@p3", razonSocial);
				comand.Parameters.AddWithValue("@p4", cuit);
				comand.Parameters.AddWithValue("@p5", tel1);
				comand.Parameters.AddWithValue("@p6", tel2);
				comand.Parameters.AddWithValue("@p7", tipoDoc);
				comand.Parameters.AddWithValue("@p8", iva);

				comand.Parameters.AddWithValue("@p9", calleNumero);
				comand.Parameters.AddWithValue("@p10", LocalidadID);
				comand.Parameters.AddWithValue("@p11", codigoPostal);

				comand.Parameters.AddWithValue("@p12", calleNumero2);
				comand.Parameters.AddWithValue("@p13", localidadID2);
				comand.Parameters.AddWithValue("@p14", codigoPostal2);

				comand.ExecuteNonQuery();
				MessageBox.Show("Cliente modificado");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}




		public static Articulo ObtenerArticulo(string buscar, Form formulario)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
            try
            {
                MySqlCommand comand = new MySqlCommand("BuscarArticulo", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@busqueda", buscar);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					Articulo articulo = new Articulo();
					foreach (DataRow x in dt.Rows)
					{
						
						articulo.ID = (int)x[0];
						articulo.Codigo = (string)x[1];
						articulo.Descripcion = (string)x[2];
						articulo.PesoNominal = decimal.ToDouble((decimal)x[3]);
						articulo.Tolerancia = (int)x[4];
						articulo.Multiplo = (int)x[5];

						articulo.Aleacion = (string)x[7];
						articulo.Temple = (string)x[8];
						articulo.Clasificacion = (string)x[9];
						articulo.Topologia = (string)x[10];
						articulo.Cliente = (string)x[11];
						articulo.Precio = decimal.ToDouble((decimal)x[12]);
						articulo.Prensa = (int)x[13];
						articulo.Ubicacion = (string)x[14];



					}
					return articulo;
				}
				else {
					SeleccionArticulo selec = new SeleccionArticulo(buscar);
					selec.ShowDialog();
					selec.Dispose();
					return selec.ArticuloSeleccionado;
				}

        }
			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }


		}



		public static void ModificarMatriz(int ID, int salidas, double peso, int cliente, int estado , int  kgAcumulados, int kgAcumulados2, bool controlada)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("ModificarMatriz", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", ID);
				comand.Parameters.AddWithValue("@p2", salidas);
				comand.Parameters.AddWithValue("@p3", peso);
				comand.Parameters.AddWithValue("@p4", cliente);
				comand.Parameters.AddWithValue("@p5", estado);
				comand.Parameters.AddWithValue("@p6", kgAcumulados);
				comand.Parameters.AddWithValue("@p7", kgAcumulados2);
				comand.Parameters.AddWithValue("@p8", controlada);
				comand.ExecuteNonQuery();
				MessageBox.Show("Matriz modificada");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }
		}



		public static DataTable ObtenerProyeccion (DateTime fecha, int prensa_ID)
        {
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("proyeccion", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fecha);
				comand.Parameters.AddWithValue("@p2", prensa_ID);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en el intervalo seleccionado"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}


		public static DataTable ObtenerProyeccion2(DateTime fecha, int prensa_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("proyeccion2", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fecha);
				comand.Parameters.AddWithValue("@p2", prensa_ID);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en el intervalo seleccionado"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static DataTable ObtenerProyeccion3(DateTime fecha, int prensa_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("proyeccion3", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fecha);
				comand.Parameters.AddWithValue("@p2", prensa_ID);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en el intervalo seleccionado"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static DataTable ObtenerProyeccion4(DateTime fecha, int prensa_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("proyeccion4", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fecha);
				comand.Parameters.AddWithValue("@p2", prensa_ID);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en el intervalo seleccionado"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}


		public static void ModificarDetallePedido(int idDetalle,DateTime fecha, string horaInicio, string horaFin, double kgs, int tiras, string largoPerfil, double pesoMetro, string colada, string observaciones, int largoTocho, int cantidadTochos, int matriz_ID, int puesto_ID, int turno_ID, int Aleacion_ID,double kgs_Anteriores,int diamTocho, double kgPrensa, int pedido_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("ModificarDetalleFabricacion", conectar);
				comand.CommandType = CommandType.StoredProcedure;

				comand.Parameters.AddWithValue("@p0", idDetalle);
				comand.Parameters.AddWithValue("@p1", pesoMetro);
				comand.Parameters.AddWithValue("@p2", fecha);
				comand.Parameters.AddWithValue("@p3", horaInicio);
				comand.Parameters.AddWithValue("@p4", horaFin);
				comand.Parameters.AddWithValue("@p5", puesto_ID);
				comand.Parameters.AddWithValue("@p6", turno_ID);
				comand.Parameters.AddWithValue("@p7", Aleacion_ID);
				comand.Parameters.AddWithValue("@p8", colada);
				comand.Parameters.AddWithValue("@p9", largoTocho);
				comand.Parameters.AddWithValue("@p10", cantidadTochos);
				comand.Parameters.AddWithValue("@p11", kgs);
				comand.Parameters.AddWithValue("@p12", tiras);
				comand.Parameters.AddWithValue("@p13", largoPerfil);
				comand.Parameters.AddWithValue("@p14", observaciones);
				comand.Parameters.AddWithValue("@p15", matriz_ID);
				comand.Parameters.AddWithValue("@p16", kgs_Anteriores);
				comand.Parameters.AddWithValue("@p18", diamTocho);
				comand.Parameters.AddWithValue("@p19", kgPrensa);
				comand.Parameters.AddWithValue("@p20", pedido_ID);
				comand.ExecuteNonQuery();
				MessageBox.Show("Detalle de fabricación modificado");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }

		}


		public static void EliminarDetallePedido(int idDetalle, int matriz_ID, double kgs_Anteriores)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("EliminarDetalleFabricacion", conectar);
				comand.CommandType = CommandType.StoredProcedure;

				comand.Parameters.AddWithValue("@p0", idDetalle);
				comand.Parameters.AddWithValue("@p2", matriz_ID);
				comand.Parameters.AddWithValue("@p1", kgs_Anteriores);

				comand.ExecuteNonQuery();
				MessageBox.Show("Detalle de fabricación eliminado");
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
			finally { conectar.Close(); }

		}

		public static DataTable EnProduccion()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("EnProduccion", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				//comand.Parameters.AddWithValue("@p1", fecha);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en el intervalo seleccionado"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}


		public static void AgregarUsuario(string usuario, string contraseña , int cliente, int archivos, int articulos, int pedidos , int matrices, int usuarios, int reportes, int altaArticulo, int BajaArticulo, int ModificaArticulo, int AltaCliente, int modificaCliente, int altaPedido, int ModificaPedido, int detallePedido, int altaMatriz, int modificaMatriz, int nitrurado)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
            try
            {
                MySqlCommand comand = new MySqlCommand("AgregarUsuario", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", usuario);
				comand.Parameters.AddWithValue("@p2", contraseña);
				comand.Parameters.AddWithValue("@p3", cliente);
				comand.Parameters.AddWithValue("@p4", archivos);
				comand.Parameters.AddWithValue("@p5", articulos);
				comand.Parameters.AddWithValue("@p6", pedidos);
				comand.Parameters.AddWithValue("@p7", matrices);
				comand.Parameters.AddWithValue("@p8", usuarios);
				comand.Parameters.AddWithValue("@p9", reportes);

				comand.Parameters.AddWithValue("@p10", altaArticulo);
				comand.Parameters.AddWithValue("@p11", BajaArticulo);
				comand.Parameters.AddWithValue("@p12", ModificaArticulo);
				comand.Parameters.AddWithValue("@p13", AltaCliente);
				comand.Parameters.AddWithValue("@p14", modificaCliente);
				comand.Parameters.AddWithValue("@p15", altaPedido);
				comand.Parameters.AddWithValue("@p16", ModificaPedido);
				comand.Parameters.AddWithValue("@p17", detallePedido);
				comand.Parameters.AddWithValue("@p18", altaMatriz);
				comand.Parameters.AddWithValue("@p19", modificaMatriz);
				comand.Parameters.AddWithValue("@p20", nitrurado);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Usuario Creado Correctamente","Usuario",MessageBoxButtons.OK,MessageBoxIcon.Information,1600);
            }
            catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conectar.Close(); }
        }



		public static DataTable ObtenerUsuarios()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("verUsuarios", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				return dt;
			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}



		public static void ModificarUsuario(int id,string usuario, string contraseña, int cliente, int archivos, int articulos, int pedidos, int matrices, int usuarios, int reportes, int altaArticulo, int BajaArticulo, int ModificaArticulo, int AltaCliente, int modificaCliente, int altaPedido, int ModificaPedido, int detallePedido, int altaMatriz, int modificaMatriz, int nitrurado)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("ModificarUsuario", conectar);
				comand.CommandType = CommandType.StoredProcedure;

				comand.Parameters.AddWithValue("@p0", id);
				comand.Parameters.AddWithValue("@p1", usuario);
				comand.Parameters.AddWithValue("@p2", contraseña);
				comand.Parameters.AddWithValue("@p3", cliente);
				comand.Parameters.AddWithValue("@p4", archivos);
				comand.Parameters.AddWithValue("@p5", articulos);
				comand.Parameters.AddWithValue("@p6", pedidos);
				comand.Parameters.AddWithValue("@p7", matrices);
				comand.Parameters.AddWithValue("@p8", usuarios);
				comand.Parameters.AddWithValue("@p9", reportes);

				comand.Parameters.AddWithValue("@p10", altaArticulo);
				comand.Parameters.AddWithValue("@p11", BajaArticulo);
				comand.Parameters.AddWithValue("@p12", ModificaArticulo);
				comand.Parameters.AddWithValue("@p13", AltaCliente);
				comand.Parameters.AddWithValue("@p14", modificaCliente);
				comand.Parameters.AddWithValue("@p15", altaPedido);
				comand.Parameters.AddWithValue("@p16", ModificaPedido);
				comand.Parameters.AddWithValue("@p17", detallePedido);
				comand.Parameters.AddWithValue("@p18", altaMatriz);
				comand.Parameters.AddWithValue("@p19", modificaMatriz);
				comand.Parameters.AddWithValue("@p20", nitrurado);

				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Usuario Modificado","Usuario",MessageBoxButtons.OK,MessageBoxIcon.Information,1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void EliminarUsuario(int ID)
		{
			MySqlConnection conectar = ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("EliminarUsuario", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", ID);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Usuario Eliminado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }

		}


		public static DataTable ObtenerReporteProdu( DateTime fechaIN , DateTime fechaFin)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("ObtenerKGrango", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fechaIN);
				comand.Parameters.AddWithValue("@p2", fechaFin);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en el intervalo seleccionado"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static DataTable ObtenerReporteDiario(DateTime fecha)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("ObtenerKgDia", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fecha);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en la fecha seleccionada"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}



		public static void AgregarNitrurado(DateTime fecha, int matriz_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("AgregarNitrurado", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", fecha);
				comand.Parameters.AddWithValue("@p2", matriz_ID);

				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Nitrurado cargado correctamente", "Nitrurado", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static DataTable VerLocalidad(int provincia_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("verLocalidad", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", provincia_ID);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros en la provincia seleccionada"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static DataTable VerProvincias()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM provincia";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);
				
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}


		public static void AgregarLocalidad(string localidad, int Provincia_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("AgregarLocalidad", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", localidad);
				comand.Parameters.AddWithValue("@p2", Provincia_ID);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Localidad creada correctamente", "Localidad", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}

		public static void ModificarLocalidad(int id,string localidad, int Provincia_ID)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("ModificarLocalidad", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", id);
				comand.Parameters.AddWithValue("@p1", localidad);
				comand.Parameters.AddWithValue("@p2", Provincia_ID);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Localidad modificada correctamente", "Localidad", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void EliminarLocalidad(int ID)
		{
			MySqlConnection conectar = ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("EliminarLocalidad", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", ID);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Localidad Eliminada", "Localidad", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }

		}


		public static DataTable VerPuesto()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM puesto p order by p.descripcion";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);

				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void AgregarPuesto(string puesto, string maquinista,string encargado)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("AgregarPuesto", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p1", puesto);
				comand.Parameters.AddWithValue("@p2", maquinista);
				comand.Parameters.AddWithValue("@p3", encargado);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Puesto creado correctamente", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void ModificarPuesto(int id, string puesto, string maquinista, string encargado)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("ModificarPuesto", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", id);
				comand.Parameters.AddWithValue("@p1", puesto);
				comand.Parameters.AddWithValue("@p2", maquinista);
				comand.Parameters.AddWithValue("@p3", encargado);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Puesto modificado correctamente", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void EliminarPuesto(int ID)
		{
			MySqlConnection conectar = ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand("EliminarPuesto", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", ID);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Puesto Eliminado", "Puesto", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }

		}


		public static DataTable GetClasificacion()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM clasificacion c order by c.descripcion";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);

				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void AddClasificacion(string descripcion, string precio)
		{
			string consulta = "insert into clasificacion (descripcion,precio) values ('" + descripcion + "', '" + precio + "')";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Clasificación creada correctamente", "Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void SetClasificacion(int id, string descripcion, string precio)
		{
			string consulta = "update clasificacion c set descripcion = '"+descripcion+ "', precio = '" + precio + "' where c.id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Clasificación modificada correctamente", "Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}

		public static void DeleteClasificacion(int id)
		{
			string consulta = "delete from clasificacion where id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Clasificación eliminada correctamente", "Clasificación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}



		public static DataTable GetPrioridad()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM prioridad p order by p.descripcion";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);

				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void AddPrioridad(string descripcion, string plazo)
		{
			string consulta = "insert into prioridad (descripcion,plazo) values ('" + descripcion + "', '" + plazo + "')";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Prioridad creada correctamente", "Prioridad", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void SetPrioridad(int id, string descripcion, string plazo)
		{
			string consulta = "update prioridad p set descripcion = '" + descripcion + "', plazo = '" + plazo + "' where p.id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Prioridad modificada correctamente", "Prioridad", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}

		public static void DeletePrioridad(int id)
		{
			string consulta = "delete from Prioridad where id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Prioridad eliminada correctamente", "Prioridad", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static DataTable GetAleacion()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM aleacion a order by a.descripcion";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);

				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void AddAleacion(string descripcion)
		{
			string consulta = "insert into aleacion (descripcion) values ('" + descripcion + "')";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Aleación creada correctamente", "Aleación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void SetAleacion(int id, string descripcion)
		{
			string consulta = "update aleacion a set descripcion = '" + descripcion + "' where a.id = " + id.ToString();
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Aleación modificada correctamente", "Aleación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}

		public static void DeleteAleacion(int id)
		{
			string consulta = "delete from Aleacion where id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Aleación eliminada correctamente", "Aleación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static DataTable GetTemple()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM temple a order by a.descripcion";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);

				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void AddTemple(string descripcion)
		{
			string consulta = "insert into temple (descripcion) values ('" + descripcion + "')";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Temple creado correctamente", "Temple", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void SetTemple(int id, string descripcion)
		{
			string consulta = "update temple a set descripcion = '" + descripcion + "' where a.id = " + id.ToString();
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Temple modificado correctamente", "Temple", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}

		public static void DeleteTemple(int id)
		{
			string consulta = "delete from temple where id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Temple eliminado correctamente", "Temple", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static DataTable GetTerminacion()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			MySqlDataReader reader;
			string consulta = "SELECT * FROM terminacion a order by a.descripcion";
			try
			{

				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				reader = comand.ExecuteReader();
				dt.Load(reader);

				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}

		public static void AddTerminacion(string descripcion)
		{
			string consulta = "insert into terminacion (descripcion) values ('" + descripcion + "')";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Terminación creada correctamente", "Terminación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}


		public static void SetTerminacion(int id, string descripcion)
		{
			string consulta = "update terminacion a set descripcion = '" + descripcion + "' where a.id = " + id.ToString();
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Terminación modificada correctamente", "Terminación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}

		public static void DeleteTerminacion(int id)
		{
			string consulta = "delete from terminacion where id = '" + id.ToString() + "'";
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			try
			{
				MySqlCommand comand = new MySqlCommand(consulta, conectar);
				comand.ExecuteNonQuery();
				AutoClosingMessageBox.Show("Terminación eliminada correctamente", "Terminación", MessageBoxButtons.OK, MessageBoxIcon.Information, 1600);
			}
			catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { conectar.Close(); }
		}



		public static DataTable ReporteNitrurado(int umbral1,int umbral2, int umbral3)
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("ReporteNitrurado", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				comand.Parameters.AddWithValue("@p0", umbral1);
				comand.Parameters.AddWithValue("@p1", umbral2);
				comand.Parameters.AddWithValue("@p2", umbral3);
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros según los parametros ingresados"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}



		public static DataTable ReporteMatricesPesadas()
		{
			MySqlConnection conectar = Conexion.ObtenerConexion();
			conectar.Open();
			DataTable dt = new DataTable();
			try
			{
				MySqlCommand comand = new MySqlCommand("VerMatricesPesadas", conectar);
				comand.CommandType = CommandType.StoredProcedure;
				MySqlDataAdapter adp = new MySqlDataAdapter(comand);
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					return dt;
				}
				else { MessageBox.Show("No hay registros"); return null; }

			}

			catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
			finally { conectar.Close(); }
		}
	}


}