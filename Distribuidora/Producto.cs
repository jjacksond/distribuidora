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
    public partial class Producto : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public Producto()
        {
            InitializeComponent();           
        }
        public void inicio()
        {
            txtid.Text = "";
            txtnom.Text = "";
            txtmarca.Text = "";
            txtprecio.Text = "";
            ndstock.Value = 0;
            btmodificar.Text = "Modificar";
            btcancelar.Visible = false;
            txtid.Focus();
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
            COMANDO.CommandText = "SELECT * FROM PRODUCTO";
            MySqlDataReader LECTURA = COMANDO.ExecuteReader();
            while (LECTURA.Read())
            {
                int N = tabla.Rows.Add();
                tabla.Rows[N].Cells[0].Value = LECTURA["PROD_ID"].ToString();
                tabla.Rows[N].Cells[1].Value = LECTURA["PROD_NOM"].ToString().ToUpper();
                tabla.Rows[N].Cells[2].Value = LECTURA["PROD_MARCA"].ToString().ToUpper();
                tabla.Rows[N].Cells[3].Value = LECTURA["PROD_PRECIOV"].ToString();
                tabla.Rows[N].Cells[4].Value = LECTURA["PROD_STOCK"].ToString();
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

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Factura fact = Owner as Factura;
            fact.txtidprod.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            fact.txtnprod.Text = tabla.CurrentRow.Cells[1].Value.ToString().ToLower() + ' ' + tabla.CurrentRow.Cells[2].Value.ToString().ToLower();
            fact.txtprecio.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            fact.txtnprod.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fact.txtnprod.Text);
            this.Close();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            llenartabla();
            privilegios();
            inicio();
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
                    COMANDO.CommandText = "UPDATE PRODUCTO SET PROD_NOM='" + txtnom.Text + "',PROD_MARCA='" + txtmarca.Text + "',PROD_STOCK='" + ndstock.Value + "',PROD_PRECIOV='" + txtprecio.Text + "' WHERE PROD_ID ='" + txtid.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtnom.Text + " > fue actualizado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    COMANDO.CommandText = "INSERT INTO PRODUCTO(PROD_ID,PROD_NOM,PROD_MARCA,PROD_STOCK,PROD_PRECIOV) VALUES('" + txtid.Text + "','" + txtnom.Text + "','" + txtmarca.Text + "','" + ndstock.Value + "','" + txtprecio.Text + "')";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtnom.Text + " " + txtmarca.Text + "> fue guardado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                COMANDO.CommandText = "SELECT * FROM PRODUCTO WHERE PROD_ID='" + txtid.Text + "'";
                COMANDO.ExecuteNonQuery();
                MySqlDataReader LECTURA = COMANDO.ExecuteReader();
                while (LECTURA.Read())
                {
                    int N = tabla.Rows.Add();
                    tabla.Rows[N].Cells[0].Value = LECTURA["PROD_ID"].ToString();
                    tabla.Rows[N].Cells[1].Value = LECTURA["PROD_NOM"].ToString().ToUpper();
                    tabla.Rows[N].Cells[2].Value = LECTURA["PROD_MARCA"].ToString().ToUpper();
                    tabla.Rows[N].Cells[3].Value = LECTURA["PROD_PRECIOV"].ToString();
                    tabla.Rows[N].Cells[4].Value = LECTURA["PROD_STOCK"].ToString();
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
            txtnom.Text= this.tabla.CurrentRow.Cells[1].Value.ToString().ToLower();
            txtmarca.Text = this.tabla.CurrentRow.Cells[2].Value.ToString().ToLower();
            txtprecio.Text = this.tabla.CurrentRow.Cells[3].Value.ToString();
            ndstock.Text = this.tabla.CurrentRow.Cells[4].Value.ToString();
            txtnom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnom.Text);
            txtmarca.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtmarca.Text);
            btcancelar.Visible = true;
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if((MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand COMANDO = new MySqlCommand();
                    COMANDO.Connection = con;
                    COMANDO.CommandText = "DELETE FROM PRODUCTO WHERE PROD_ID='" + txtid.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtid.Text + " > fue eliminado exitosamente!", "Dato borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btcancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                llenartabla();
            }
        }
    }
}
