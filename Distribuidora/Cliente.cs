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
    public partial class Cliente : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public Cliente()
        {
            InitializeComponent();
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
        public void inicio()
        {
            txtid.Text = "";
            txtpnom.Text = "";
            txtsnom.Text = "";
            txtpape.Text = "";
            txtsape.Text = "";
            txtdireccion.Text = "";
            mdtelefono.Text = "";
            btmodificar.Text = "Modificar";
            btcancelar.Visible = false;
            txtid.Focus();
        }
        public void llenartabla()
        {
            tabla.Rows.Clear();
            con.Open();
            MySqlCommand COMANDO = new MySqlCommand();
            COMANDO.Connection = con;
            COMANDO.CommandText = "SELECT * FROM CLIENTE";
            MySqlDataReader LECTURA = COMANDO.ExecuteReader();
            while (LECTURA.Read())
            {
                int N = tabla.Rows.Add();
                tabla.Rows[N].Cells[0].Value = LECTURA["CLI_ID"].ToString();
                tabla.Rows[N].Cells[1].Value = LECTURA["CLI_PNOM"].ToString().ToUpper();
                tabla.Rows[N].Cells[2].Value = LECTURA["CLI_SNOM"].ToString().ToUpper();
                tabla.Rows[N].Cells[3].Value = LECTURA["CLI_PAPE"].ToString().ToUpper();
                tabla.Rows[N].Cells[4].Value = LECTURA["CLI_SAPE"].ToString().ToUpper();
                tabla.Rows[N].Cells[5].Value = LECTURA["CLI_TEL"].ToString().ToUpper();
                tabla.Rows[N].Cells[6].Value = LECTURA["CLI_DIR"].ToString().ToUpper();
            }
            con.Close();
        }
        private void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btrestaurar.Visible = false;
            btmaximizar.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            privilegios();
            inicio();
            llenartabla();
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Factura fact = Owner as Factura;
            fact.txtidcli.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            this.Close();
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
                    COMANDO.CommandText = "UPDATE CLIENTE SET CLI_PNOM='" + txtpnom.Text + "',CLI_SNOM='" + txtsnom.Text + "',CLI_PAPE='" + txtpape.Text + "',CLI_SAPE='" + txtsape.Text + "',CLI_TEL='" + mdtelefono.Text + "',CLI_DIR='" + txtdireccion.Text + "' WHERE CLI_ID ='" + txtid.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtid.Text + " > fue actualizado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    COMANDO.CommandText = "INSERT INTO CLIENTE(CLI_ID,CLI_PNOM,CLI_SNOM,CLI_PAPE,CLI_SAPE,CLI_TEL,CLI_DIR) VALUES('" + txtid.Text + "','" + txtpnom.Text + "','" + txtsnom.Text + "','" + txtpape.Text + "','" + txtsape.Text + "','" + mdtelefono.Text + "','" + txtdireccion.Text + "')";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtid.Text + "> fue guardado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                tabla.Rows.Clear();
                con.Open();
                MySqlCommand COMANDO = new MySqlCommand();
                COMANDO.Connection = con;
                COMANDO.CommandText = "SELECT * FROM CLIENTE WHERE CLI_ID='" + txtid.Text + "'";
                COMANDO.ExecuteNonQuery();
                MySqlDataReader LECTURA = COMANDO.ExecuteReader();
                while (LECTURA.Read())
                {
                    int N = tabla.Rows.Add();
                    tabla.Rows[N].Cells[0].Value = LECTURA["CLI_ID"].ToString();
                    tabla.Rows[N].Cells[1].Value = LECTURA["CLI_PNOM"].ToString().ToUpper();
                    tabla.Rows[N].Cells[2].Value = LECTURA["CLI_SNOM"].ToString().ToUpper();
                    tabla.Rows[N].Cells[3].Value = LECTURA["CLI_PAPE"].ToString().ToUpper();
                    tabla.Rows[N].Cells[4].Value = LECTURA["CLI_SAPE"].ToString().ToUpper();
                    tabla.Rows[N].Cells[5].Value = LECTURA["CLI_TEL"].ToString().ToUpper();
                    tabla.Rows[N].Cells[6].Value = LECTURA["CLI_DIR"].ToString().ToUpper();
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
            txtid.Text = this.tabla.CurrentRow.Cells[0].Value.ToString();
            txtpnom.Text = this.tabla.CurrentRow.Cells[1].Value.ToString().ToLower();
            txtsnom.Text = this.tabla.CurrentRow.Cells[2].Value.ToString().ToLower();
            txtpape.Text = this.tabla.CurrentRow.Cells[3].Value.ToString().ToLower();
            txtsape.Text = this.tabla.CurrentRow.Cells[4].Value.ToString().ToLower();
            mdtelefono.Text = this.tabla.CurrentRow.Cells[5].Value.ToString();
            txtdireccion.Text = this.tabla.CurrentRow.Cells[6].Value.ToString().ToLower();
            txtpnom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtpnom.Text);
            txtsnom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtsnom.Text);
            txtpape.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtpape.Text);
            txtsape.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtsape.Text);
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
                    COMANDO.CommandText = "DELETE FROM CLIENTE WHERE CLI_ID='" + txtid.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtid.Text + " > fue eliminado exitosamente!", "Dato borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    inicio();
                    llenartabla();
                }
                else
                {
                    inicio();
                    llenartabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: \n" + ex);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text == "")
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
