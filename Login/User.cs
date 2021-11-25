using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Login
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

            try
            {
                Cuadro.Rows.Clear();
                DataTable dt = Conexion.ObtenerUsuarios();
                foreach (DataRow x in dt.Rows)
                    {
                        int n = Cuadro.Rows.Add();
                        Cuadro.Rows[n].Cells[0].Value = false;
                        Cuadro.Rows[n].Cells[1].Value = (int)x[0];
                        Cuadro.Rows[n].Cells[2].Value = (string)x[1];
                        Cuadro.Rows[n].Cells[3].Value = (string)x[2];
                        Cuadro.Rows[n].Cells[4].Value = intToBool((int)x[3]);
                        Cuadro.Rows[n].Cells[5].Value = intToBool((int)x[4]);
                        Cuadro.Rows[n].Cells[6].Value = intToBool((int)x[5]);
                        Cuadro.Rows[n].Cells[7].Value = intToBool((int)x[6]);
                        Cuadro.Rows[n].Cells[8].Value = intToBool((int)x[7]);
                        Cuadro.Rows[n].Cells[9].Value = intToBool((int)x[8]);

            }


        }
            catch (Exception ex) { MessageBox.Show("Error al buscar " + ex.Message,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error); }
}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void cuil2TBX_TextChanged(object sender, EventArgs e)
        {


        }



        private void telefonoTBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void CelularTBX_TextChanged(object sender, EventArgs e)
        {


        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private static int boolToInt(bool booleano)
        {
            if (booleano == true) { return 1; }
            else return 0;
        }

        private static bool intToBool(int entero)
        {
            if (entero == 1) { return true; }
            else return false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (UsuarioTBX.Text!="" && ContraseñaTBX.Text!="")
            {
                try
                {
                    Conexion.AgregarUsuario(UsuarioTBX.Text,ContraseñaTBX.Text,boolToInt(ClienteCKB.Checked),boolToInt(ArchivosCKB.Checked), boolToInt(ArticulosCKB.Checked), boolToInt(PedidosCKB.Checked), boolToInt(MatricesCKB.Checked), boolToInt(UsuarioCKB.Checked));
                    Limpiar();
                    User_Load(sender, e);
                }
                catch (Exception) { MessageBox.Show("No se pudo agregar el Usuaruo, revise los datos y reintente","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Revise los campos ingresados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Limpiar()
        {
            UsuarioTBX.Text = "";
            ContraseñaTBX.Text = "";
            ClienteCKB.Checked = false;
            ArchivosCKB.Checked = false;
            ArticulosCKB.Checked = false;
            PedidosCKB.Checked = false;
            MatricesCKB.Checked = false;
            UsuarioCKB.Checked = false;

        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            if (UsuarioTBX.Text!="" && ContraseñaTBX.Text!="")
            {
                try
                {
                    bool check = false;
                    for (int fila = 0; fila < Cuadro.Rows.Count; fila++)
                    {
                        if ((bool)Cuadro.Rows[fila].Cells[0].Value == true)
                        {
                            check = true; break;
                        }
                    }

                    if (check == true)
                    {
                        Conexion.ModificarUsuario((int)Cuadro.Rows[n].Cells[1].Value, UsuarioTBX.Text, ContraseñaTBX.Text,boolToInt(ClienteCKB.Checked), boolToInt(ArchivosCKB.Checked), boolToInt(ArticulosCKB.Checked), boolToInt(PedidosCKB.Checked), boolToInt(MatricesCKB.Checked), boolToInt(UsuarioCKB.Checked));
                        Limpiar();
                        User_Load(sender, e);
                    }


                    else { AutoClosingMessageBox.Show("No hay ningun registro seleccionado","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning,1600); }
                }
                catch (Exception) { AutoClosingMessageBox.Show("No se pudo modificar el usuario, revise los datos y reintente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning, 1600); }
            }
            else { AutoClosingMessageBox.Show("Revise los campos ingresados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning, 1600); }
        }

    

        private void TipoContratoCBX_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        int n;
        private void Cuadro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                n = e.RowIndex;
                if ((bool)Cuadro.Rows[n].Cells[0].Value == true)
                {
                    Cuadro.Rows[n].Cells[0].Value = false;
                    Limpiar();
                    User_Load(sender, e);
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
                        Cuadro.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                        Cuadro.Rows[n].Cells[0].Value = true;
                        UsuarioTBX.Text = (string)Cuadro.Rows[n].Cells[2].Value;
                        ContraseñaTBX.Text = (string)Cuadro.Rows[n].Cells[3].Value;
                        ClienteCKB.Checked = (bool)Cuadro.Rows[n].Cells[4].Value;
                        ArchivosCKB.Checked = (bool)Cuadro.Rows[n].Cells[5].Value;
                        ArticulosCKB.Checked = (bool)Cuadro.Rows[n].Cells[6].Value;
                        PedidosCKB.Checked = (bool)Cuadro.Rows[n].Cells[7].Value;
                        MatricesCKB.Checked = (bool)Cuadro.Rows[n].Cells[8].Value;
                        UsuarioCKB.Checked = (bool)Cuadro.Rows[n].Cells[9].Value;
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception) { }
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                for (int fila = 0; fila < Cuadro.Rows.Count; fila++)
                {
                    if ((bool)Cuadro.Rows[fila].Cells[0].Value == true)
                    {
                        check = true; break;
                    }
                }

                if (check == true)
                {
                    Conexion.EliminarUsuario((int)Cuadro.Rows[n].Cells[1].Value);
                    Limpiar();
                    User_Load(sender, e);
                }


                else { AutoClosingMessageBox.Show("No hay ningun registro seleccionado","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning,1600); }
            }
            catch (Exception) { AutoClosingMessageBox.Show("No se pudo eliminar el Usuario, revise los datos y reintente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning, 1600); }
        }




        private void TipoContratoCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
