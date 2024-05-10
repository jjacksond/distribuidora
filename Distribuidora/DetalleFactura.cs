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
    public partial class DetalleFactura : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public DetalleFactura()
        {
            InitializeComponent();
        }
        public void inicio()
        {
            txtiddet.Text = "";
            ndcantidad.Value = 0;
            cbidfact.SelectedValue = 0;
            cbidprod.SelectedValue = 0;
            txtsubt.Text = "";
            txtotal.Text = "";
            btmodificar.Text = "Modificar";
            btcancelar.Visible = false;
            txtiddet.Focus();
        }
        public void llenartabla()
        {
            tabla.Rows.Clear();
            con.Open();
            MySqlCommand COMANDO = new MySqlCommand();
            COMANDO.Connection = con;
            COMANDO.CommandText = "SELECT * FROM DETALLE";
            MySqlDataReader LECTURA = COMANDO.ExecuteReader();
            while (LECTURA.Read())
            {
                int N = tabla.Rows.Add();
                tabla.Rows[N].Cells[0].Value = LECTURA["DET_ID"].ToString();
                tabla.Rows[N].Cells[1].Value = LECTURA["FAC_ID"].ToString();
                tabla.Rows[N].Cells[2].Value = LECTURA["PROD_ID"].ToString();
                tabla.Rows[N].Cells[3].Value = LECTURA["DET_CANT"].ToString();
                tabla.Rows[N].Cells[4].Value = LECTURA["DET_SUBTOTAL"].ToString();
                tabla.Rows[N].Cells[5].Value = LECTURA["DET_IMP"].ToString();
                tabla.Rows[N].Cells[6].Value = LECTURA["DET_TOTAL"].ToString();
                tabla.Rows[N].Cells[7].Value = LECTURA["DET_ESTADO"].ToString();
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
                cbidprod.DisplayMember = "PROD_NOM";
                cbidprod.ValueMember = "PROD_ID";
                cbidprod.DataSource = tab;
                con.Close();
                cbidprod.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }          
        }
        public void cargaridfact()
        {
            try
            {
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT FAC_ID FROM FACTURA WHERE FAC_ESTADO ='ACTIVO'", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                cbidfact.DisplayMember = "FAC_ID";
                cbidfact.ValueMember = "FAC_ID";
                cbidfact.DataSource = tab;
                con.Close();
                cbidfact.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }       
        }
        public static double totalp = 0;
        private void DetalleFactura_Load(object sender, EventArgs e)
        {
            inicio();
            llenartabla();
            cargarprod();
            cargaridfact();
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

        private void btprod_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            AddOwnedForm(prod);
            prod.ShowDialog();
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            string estado = "Activo";
            double impuesto = 0.15;
            if (btmodificar.Text == "Modificando...")
            {
                try
                {
                    con.Open();
                    MySqlCommand COMANDO = new MySqlCommand();
                    COMANDO.Connection = con;
                    COMANDO.CommandText = "UPDATE DETALLE SET DET_CANT='" + ndcantidad.Value + "',DET_SUBTOTAL='" + txtsubt.Text + "',DET_IMP='" + impuesto + "',DET_TOTAL='" + txtotal.Text + "',FAC_ID='" + cbidfact.SelectedValue + "',PROD_ID='" + cbidprod.SelectedValue + "',DET_ESTADO='" + estado + "' WHERE DET_ID ='" + txtiddet.Text + "'";
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("El registro < " + txtiddet.Text + " > fue actualizado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    COMANDO.CommandText = "INSERT INTO DETALLE(DET_ID,DET_CANT,DET_SUBTOTAL,DET_IMP,DET_TOTAL,FAC_ID,PROD_ID,DET_ESTADO) VALUES(@id,@cant,@subtotal,@impuesto,@total,@idfac,@idprod,@estado)";
                    COMANDO.Parameters.AddWithValue("@id", txtiddet.Text);
                    COMANDO.Parameters.AddWithValue("@cant", ndcantidad.Value);
                    COMANDO.Parameters.AddWithValue("@subtotal", txtsubt.Text);
                    COMANDO.Parameters.AddWithValue("@impuesto", impuesto);
                    COMANDO.Parameters.AddWithValue("@total", txtotal.Text);
                    COMANDO.Parameters.AddWithValue("@idfac", cbidfact.SelectedValue);
                    COMANDO.Parameters.AddWithValue("@idprod", cbidprod.SelectedValue);
                    COMANDO.Parameters.AddWithValue("@estado", estado);
                    COMANDO.ExecuteNonQuery();
                    MessageBox.Show("La factura < " + txtiddet.Text + "> fue guardado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                COMANDO.CommandText = "SELECT * FROM DETALLE WHERE DET_ID='" + txtiddet.Text + "'";
                COMANDO.ExecuteNonQuery();
                MySqlDataReader LECTURA = COMANDO.ExecuteReader();
                while (LECTURA.Read())
                {
                    int N = tabla.Rows.Add();
                    tabla.Rows[N].Cells[0].Value = LECTURA["DET_ID"].ToString();
                    tabla.Rows[N].Cells[1].Value = LECTURA["FAC_ID"].ToString();
                    tabla.Rows[N].Cells[2].Value = LECTURA["PROD_ID"].ToString();
                    tabla.Rows[N].Cells[3].Value = LECTURA["DET_CANT"].ToString();
                    tabla.Rows[N].Cells[4].Value = LECTURA["DET_SUBTOTAL"].ToString();
                    tabla.Rows[N].Cells[5].Value = LECTURA["DET_IMP"].ToString();
                    tabla.Rows[N].Cells[6].Value = LECTURA["DET_TOTAL"].ToString();
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
            txtiddet.Text = this.tabla.CurrentRow.Cells[0].Value.ToString();
            cbidfact.Text = this.tabla.CurrentRow.Cells[1].Value.ToString();
            cbidprod.SelectedValue = this.tabla.CurrentRow.Cells[2].Value.ToString();
            ndcantidad.Text = this.tabla.CurrentRow.Cells[3].Value.ToString();
            txtsubt.Text = this.tabla.CurrentRow.Cells[4].Value.ToString();
            txtotal.Text = this.tabla.CurrentRow.Cells[6].Value.ToString();
            btcancelar.Visible = true;
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            string estado = "Inactivo";
            try
            {
                if ((MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE DETALLE SET DET_ESTADO=@estado WHERE DET_ID='" + txtiddet.Text + "'", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado exitosamente!");
                    con.Close();
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
                MessageBox.Show("ERROR" + ex);
            }
            inicio();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void txtiddet_TextChanged(object sender, EventArgs e)
        {
            if (txtiddet.Text == "")
            {
                llenartabla();
            }
        }
    }
}
