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
						Cuadro.Rows[n].Cells[0].Value = true;
						Cuadro.Rows[n].Cells[1].Value = ((DateTime)x[0]).ToString("dd-MM-yyyy");
						Cuadro.Rows[n].Cells[2].Value = ((decimal)x[1]).ToString();
					Cuadro.Rows[n].Cells[3].Value = "Ver Detalle";
					kgAcumulados += decimal.ToDouble((decimal)x[1]);


				}

					Acumulados.Text = kgAcumulados.ToString();

				}







		}
		
	
		
		
		// Devuelve el indice de la celda seleccionada
		int n;
		void Selecccioncelda(object sender, DataGridViewCellEventArgs e)
		{    //n = e.RowIndex;
			//string numeroPedido = Cuadro.Rows[n].Cells[1].Value.ToString();
			//MessageBox.Show(n.ToString());
		}

		private void Cuadro_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;

		}
		private void Cuadro_CellClick(object sender, DataGridViewCellEventArgs e)
		{

        }


		private void Cancelar_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void Exportarboton_Click(object sender, EventArgs e)
        {
			Exportar.Exportar2(Cuadro);

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