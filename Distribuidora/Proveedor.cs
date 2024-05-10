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
    public partial class Proveedor : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public Proveedor()
        {
            InitializeComponent();
        }
        public void inicio()
        {
            txtidp.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            mdtelefono.Text = "";
            btmodificar.Text = "Modificar";
            btcancelar.Visible = false;
            txtidp.Focus();
        }
        public void privilegios()
        {
            if (usuario.dato == "DBA")
            {
                btingresar.Enabled = true;
                btconsultar.Enabled = true;
                btmodificar.Enabled = true;
                bteliminar.Enabled = true;
            }
            else if (usuario.dato == "CAJERO")
            {
                btingresar.Enabled = true;
                btconsultar.Enabled = false;
                btmodificar.Enabled = true;
                bteliminar.Enabled = false;
            }
        }
        public void llenartabla()
        {
            tabla.Rows.Clear();
            con.Open();
            MySqlCommand COMANDO = new MySqlCommand();
            COMANDO.Connection = con;
            COMANDO.CommandText = "SELECT * FROM PROVEEDOR";
            MySqlDataReader LECTURA = COMANDO.ExecuteReader();
            while (LECTURA.Read())
            {
                int N = tabla.Rows.Add();
                tabla.Rows[N].Cells[0].Value = LECTURA["PROV_ID"].ToString();
                tabla.Rows[N].Cells[1].Value = LECTURA["PROV_NOM"].ToString().ToUpper();
                tabla.Rows[N].Cells[2].Value = LECTURA["PROV_DIR"].ToString().ToUpper();
                tabla.Rows[N].Cells[3].Value = LECTURA["PROV_TEL"].ToString();
            }
            con.Close();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            if (btmodificar.Text == "Modificando...")
            {
                try
                {
                    con.Open();
                    MySqlCommand COMANDO = new MySqlCommand();
                    COMANDO.Connection = con;
                    COMANDO.CommandText = "UPDATE PROVEEDOR SET PROV_NOM='" + txtnombre.Text + "',PROV_DIR='" + txtdireccion.Text + "',PROV_TEL='" + mdtelefono.Text + "' WHERE PROV_ID ='" + txtidp.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtidp.Text + " > fue actualizado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: \n" + ex);
                }
                llenartabla();
                inicio();
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand COMANDO = new MySqlCommand();
                    COMANDO.Connection = con;
                    COMANDO.CommandText = "INSERT INTO PROVEEDOR(PROV_ID,PROV_NOM,PROV_DIR,PROV_TEL) VALUES('" + txtidp.Text + "','" + txtnombre.Text + "','" + txtdireccion.Text + "','" + mdtelefono.Text + "')";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtidp.Text +"> fue guardado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: \n" + ex);
                }
                llenartabla();
                inicio();
            }
            inicio();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            llenartabla();
            privilegios();
            inicio();
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                tabla.Rows.Clear();
                con.Open();
                MySqlCommand COMANDO = new MySqlCommand();
                COMANDO.Connection = con;
                COMANDO.CommandText = "SELECT * FROM PROVEEDOR WHERE PROV_ID='" + txtidp.Text + "'";
                COMANDO.ExecuteNonQuery();
                MySqlDataReader LECTURA = COMANDO.ExecuteReader();
                while (LECTURA.Read())
                {
                    int N = tabla.Rows.Add();
                    tabla.Rows[N].Cells[0].Value = LECTURA["PROV_ID"].ToString();
                    tabla.Rows[N].Cells[1].Value = LECTURA["PROV_NOM"].ToString().ToUpper();
                    tabla.Rows[N].Cells[2].Value = LECTURA["PROV_DIR"].ToString().ToUpper();
                    tabla.Rows[N].Cells[3].Value = LECTURA["PROV_TEL"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: \n" + ex);
            }
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            btmodificar.Text = "Modificando...";
            txtidp.Text = this.tabla.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = this.tabla.CurrentRow.Cells[1].Value.ToString().ToLower();
            txtdireccion.Text = this.tabla.CurrentRow.Cells[2].Value.ToString().ToLower();
            mdtelefono.Text = this.tabla.CurrentRow.Cells[3].Value.ToString();
            txtnombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtdireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtdireccion.Text);
            btcancelar.Visible = true;
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand COMANDO = new MySqlCommand();
                    COMANDO.Connection = con;
                    COMANDO.CommandText = "DELETE FROM PROVEEDOR WHERE PROV_ID='" + txtidp.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtidp.Text + " > fue eliminado exitosamente!", "Dato borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    llenartabla();
                    inicio();
                }
                else
                {
                    llenartabla();
                    inicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: \n" + ex);
            }
        }

        private void txtidp_TextChanged(object sender, EventArgs e)
        {
            if (txtidp.Text == "")
            {
                llenartabla();
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }
    }
}
