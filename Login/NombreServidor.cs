using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class NombreServidor : Form
    {
        public NombreServidor()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string rutaCompleta = @"NombreServidor.txt";
            string texto = ServidorTXT.Text;
            StreamWriter file = new StreamWriter(rutaCompleta, true);
            file.WriteLine(texto); 
            file.Close();
            this.Close();
        }
    }
}
