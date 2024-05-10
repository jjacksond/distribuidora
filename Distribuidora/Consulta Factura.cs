using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Distribuidora
{
    public partial class Consulta_Factura : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public Consulta_Factura()
        {
            InitializeComponent();
        }
        public void llenar()
        {
            tabla.Rows.Clear();
            con.Open();
            MySqlCommand COMANDO = new MySqlCommand();
            COMANDO.Connection = con;
            COMANDO.CommandText = "SELECT * FROM FACTURA";
            MySqlDataReader LECTURA = COMANDO.ExecuteReader();
            while (LECTURA.Read())
            {
                int N = tabla.Rows.Add();
                tabla.Rows[N].Cells[0].Value = LECTURA["FAC_ID"].ToString();
                tabla.Rows[N].Cells[1].Value = LECTURA["FAC_FECHAV"].ToString();
                tabla.Rows[N].Cells[2].Value = LECTURA["CLI_ID"].ToString();
                tabla.Rows[N].Cells[3].Value = LECTURA["CAJ_ID"].ToString();
                tabla.Rows[N].Cells[4].Value = LECTURA["FAC_TOTALV"].ToString();
                tabla.Rows[N].Cells[5].Value = LECTURA["FAC_ESTADO"].ToString();

            }
            con.Close();
        }
        public void buscar()
        {
            try
            {
                tabla.Rows.Clear();
                con.Open();
                MySqlCommand COMANDO = new MySqlCommand();
                COMANDO.Connection = con;
                COMANDO.CommandText = "SELECT * FROM FACTURA WHERE FAC_ID='" + txtid.Text + "'";
                COMANDO.ExecuteNonQuery();
                MySqlDataReader LECTURA = COMANDO.ExecuteReader();
                while (LECTURA.Read())
                {
                    int N = tabla.Rows.Add();
                    tabla.Rows[N].Cells[0].Value = LECTURA["FAC_ID"].ToString();
                    tabla.Rows[N].Cells[1].Value = LECTURA["FAC_FECHAV"].ToString();
                    tabla.Rows[N].Cells[2].Value = LECTURA["CLI_ID"].ToString();
                    tabla.Rows[N].Cells[3].Value = LECTURA["CAJ_ID"].ToString();
                    tabla.Rows[N].Cells[4].Value = LECTURA["FAC_TOTALV"].ToString();
                    tabla.Rows[N].Cells[5].Value = LECTURA["FAC_ESTADO"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: \n" + ex);
            }
        }

        private void Consulta_Factura_Load(object sender, EventArgs e)
        {
            llenar();          
        }

        private void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btrestaurar.Visible = false;
            btmaximizar.Visible = true;
        }

        private void btmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmaximizar.Visible = false;
            btrestaurar.Visible = true;
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                llenar();
            }
        }
    }
}
