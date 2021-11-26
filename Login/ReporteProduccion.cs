using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace Login
{
	public partial class ReporteProduccion : Form
	{
		string usuario;
		public ReporteProduccion()
		{
			InitializeComponent();
		}

		public ReporteProduccion(string user)
		{
			usuario = user;
			InitializeComponent();
		}

		double kgAcumulados = 0;

		
		//Muestra en el cuadro las coincidencias
		void BuscarClick(object sender, EventArgs e)
		{

				kgAcumulados = 0;
			//completo el cuadro
			DataTable dt2 = Conexion.ObtenerReporteProdu(Fecha1DTP.Value, Fecha2DTP.Value);
				Cuadro.Rows.Clear();

				if (dt2 != null)
				{

					foreach (DataRow x in dt2.Rows)
					{
						int n = Cuadro.Rows.Add();
						Cuadro.Rows[n].Cells[0].Value = false;
						Cuadro.Rows[n].Cells[1].Value = ((DateTime)x[0]).ToString("dd-MM-yyyy");
						Cuadro.Rows[n].Cells[2].Value = ((decimal)x[1]).ToString();
						kgAcumulados += decimal.ToDouble((decimal)x[1]);


				}

					Acumulados.Text = kgAcumulados.ToString();

				}







		}
		
	
		
		
		// Devuelve el indice de la celda seleccionada
		int n;
		void Selecccioncelda(object sender, DataGridViewCellEventArgs e)
		{    


		}


		private void Cuadro_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;

		}
		private void Cuadro_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
			if ((bool)Cuadro.Rows[n].Cells[0].Value == true)
			{
				Cuadro.Rows[n].Cells[0].Value = false;
				Cuadro.Rows[n].DefaultCellStyle.BackColor = Color.White;
				Cuadro2.Rows.Clear();
			}
			else
			{
				try
				{
					for (int fila = 0; fila < Cuadro.Rows.Count; fila++)
					{
						Cuadro.Rows[fila].Cells[0].Value = false;
						Cuadro.Rows[fila].DefaultCellStyle.BackColor = Color.White;

					}
					Cuadro.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
					Cuadro.Rows[n].Cells[0].Value = true;
					//string seleccion = (string)Cuadro.Rows[n].Cells[1].Value;
					DateTime fecha = new DateTime(int.Parse(((string)Cuadro.Rows[n].Cells[1].Value).Substring(6, 4)), int.Parse(((string)Cuadro.Rows[n].Cells[1].Value).Substring(3, 2)), int.Parse(((string)Cuadro.Rows[n].Cells[1].Value).Substring(0, 2)));
					
					DataTable dt2 = Conexion.ObtenerReporteDiario(fecha);
					Cuadro2.Rows.Clear();

					if (dt2 != null)
					{

						foreach (DataRow x in dt2.Rows)
						{
							int n = Cuadro2.Rows.Add();
							Cuadro2.Rows[n].Cells[0].Value = (string)x[0];
							Cuadro2.Rows[n].Cells[1].Value = (string)x[1];
							Cuadro2.Rows[n].Cells[2].Value = ((decimal)x[2]).ToString();
							Cuadro2.Rows[n].Cells[3].Value = (string)x[3];

						}
					}

					}
				catch (Exception) { }
			}
		}


		private void Cancelar_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void Exportarboton_Click(object sender, EventArgs e)
        {
			Exportar.Exportar_Articulos(Cuadro);
        }



        private void ReporteProduccion_Load(object sender, EventArgs e)
        {
			Fecha1DTP.Value = DateTime.Today;
			Fecha2DTP.Value = DateTime.Today;

		}







        private void Cuadro_SelectionChanged(object sender, EventArgs e)
        {


		}

        private void Ignorar_Chek_CheckedChanged(object sender, EventArgs e)
        {
			Cuadro.Rows.Clear();
        }
    }
}