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
    public partial class OrdenEntrega : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public OrdenEntrega()
        {
            InitializeComponent();
        }
        public void inicio()
        {
            txtid.Text = "";
            ndcantidad.Value = 0;
            cbprod.SelectedValue = 0;
            cbproveedor.SelectedValue = 0;
            DateTime fecha = DateTime.Today;
            dtfecha.Text = fecha.ToString();
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
            COMANDO.CommandText = "SELECT * FROM ORDEN";
            MySqlDataReader LECTURA = COMANDO.ExecuteReader();
            while (LECTURA.Read())
            {
                int N = tabla.Rows.Add();
                tabla.Rows[N].Cells[0].Value = LECTURA["ORD_ID"].ToString();
                tabla.Rows[N].Cells[1].Value = LECTURA["ORD_FECHA"].ToString();
                tabla.Rows[N].Cells[2].Value = LECTURA["ORD_CANTIDAD"].ToString();
                tabla.Rows[N].Cells[3].Value = LECTURA["PROD_ID"].ToString();
                tabla.Rows[N].Cells[4].Value = LECTURA["PROV_ID"].ToString();

            }
            con.Close();
        }
        public void cargarprod()
        {           
            try
            {
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT PROD_ID, PROD_NOM FROM PRODUCTO", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                cbprod.DisplayMember = "PROD_NOM";
                cbprod.ValueMember = "PROD_ID";
                cbprod.DataSource = tab;
                con.Close();
                cbprod.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
        public void cargarprov()
        {
            try
            {
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT PROV_ID, PROV_NOM FROM PROVEEDOR", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                cbproveedor.DisplayMember = "PROV_NOM";
                cbproveedor.ValueMember = "PROV_ID";
                cbproveedor.DataSource = tab;
                con.Close();
                cbproveedor.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
        private void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmaximizar.Visible = false;
            btrestaurar.Visible = true;
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

        private void OrdenEntrega_Load(object sender, EventArgs e)
        {            
            inicio();
            llenartabla();
            cargarprod();
            cargarprov();
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
                    COMANDO.CommandText = "UPDATE ORDEN SET ORD_CANTIDAD='" + ndcantidad.Value + "',ORD_FECHA='" + dtfecha.Value.Date.ToString("yyy-MM-dd") + "',PROD_ID='" + cbprod.SelectedValue + "',PROV_ID='" + cbproveedor.SelectedValue + "' WHERE ORD_ID ='" + txtid.Text + "'";
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
                    COMANDO.CommandText = "INSERT INTO ORDEN(ORD_ID,ORD_CANTIDAD,ORD_FECHA,PROD_ID,PROV_ID) VALUES('" + txtid.Text + "','" + ndcantidad.Value + "','" + dtfecha.Value.Date.ToString("yyy-MM-dd") + "','" + cbprod.SelectedValue + "','" + cbproveedor.SelectedValue + "')";
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
                COMANDO.CommandText = "SELECT * FROM ORDEN WHERE ORD_ID='" + txtid.Text + "'";
                COMANDO.ExecuteNonQuery();
                MySqlDataReader LECTURA = COMANDO.ExecuteReader();
                while (LECTURA.Read())
                {
                    int N = tabla.Rows.Add();
                    tabla.Rows[N].Cells[0].Value = LECTURA["ORD_ID"].ToString();
                    tabla.Rows[N].Cells[1].Value = LECTURA["ORD_CANT"].ToString();
                    tabla.Rows[N].Cells[2].Value = LECTURA["ORD_FECHA"].ToString();
                    tabla.Rows[N].Cells[3].Value = LECTURA["PROD_ID"].ToString();
                    tabla.Rows[N].Cells[4].Value = LECTURA["PROV_ID"].ToString();
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
            dtfecha.Text = this.tabla.CurrentRow.Cells[1].Value.ToString();
            ndcantidad.Text = this.tabla.CurrentRow.Cells[2].Value.ToString();
            cbprod.SelectedValue = this.tabla.CurrentRow.Cells[3].Value.ToString();
            cbproveedor.SelectedValue = this.tabla.CurrentRow.Cells[4].Value.ToString();
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
                    COMANDO.CommandText = "DELETE FROM ORDEN WHERE ORD_ID='" + txtid.Text + "'";
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
