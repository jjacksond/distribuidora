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
    public partial class Factura : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParan, int v);
        public Factura()
        {
            InitializeComponent();
            inicio();
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            privilegios();
            cargarcajero();
        }
        public void inicio()
        {
            txtidfact.Text = "";
            cbidcaj.Text = "";
            txtidcli.Text = "";
            ndcantidad.Value = 0;
            DateTime fecha = DateTime.Today;
            dtfecha.Text = fecha.ToString();
            txtidprod.Text = "";
            txtnprod.Text = "";
            btmodificar.Text = "Modificar";
            txtidfact.Focus();
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
        public void cargarcajero()
        {
            try
            {
                con.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("SELECT CAJ_ID FROM CAJERO", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                cbidcaj.DisplayMember = "CAJ_ID";
                cbidcaj.ValueMember = "CAJ_ID";
                cbidcaj.DataSource = tab;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
        public void llenartabla()
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
                tabla.Rows[N].Cells[1].Value = LECTURA["FAC_TOTALV"].ToString().ToUpper();
                tabla.Rows[N].Cells[2].Value = LECTURA["FAC_FECHAV"].ToString().ToUpper();
                tabla.Rows[N].Cells[3].Value = LECTURA["CLI_ID"].ToString();
                tabla.Rows[N].Cells[4].Value = LECTURA["CAJ_ID"].ToString();
                tabla.Rows[N].Cells[4].Value = LECTURA["FAC_ESTADO"].ToString();

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

        private void btingresar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            conteo = tabla.RowCount;
            double stotal = 0;
            for (int i = 0; i < conteo; i++)
            {
                stotal += Convert.ToDouble(tabla.Rows[i].Cells[4].Value);
            }
            totalp = ((stotal * 0.15) + stotal);
            string estado = "Activo";
            try
            {
                con.Open();
                MySqlCommand COMANDO = new MySqlCommand();
                COMANDO.Connection = con;
                COMANDO.CommandText = "INSERT INTO FACTURA(FAC_ID,FAC_TOTALV,FAC_FECHAV,CLI_ID,CAJ_ID,FAC_ESTADO) VALUES('" + txtidfact.Text + "','" + totalp + "','" + dtfecha.Value.Date.ToString("yyy-MM-dd") + "','" + txtidcli.Text + "','" + cbidcaj.Text + "','" + estado + "')";
                COMANDO.ExecuteNonQuery();
                MessageBox.Show("La factura < " + txtidfact.Text + "> fue guardado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: \n" + ex);
                }
                inicio();
        }

        private void btprod_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.label6.Visible = true;
            AddOwnedForm(prod);
            prod.ShowDialog();
        }

        private void btcliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.label9.Visible = true;
            AddOwnedForm(cliente);
            cliente.ShowDialog();
        }       
        public void bProductos()
        {
            txtidprod.Text = "";
            txtnprod.Text = "";
            txtprecio.Text = "";
            ndcantidad.Value = 0;
        }
        public void calculosf()
        {
            int conteo = 0;
            conteo = tabla.RowCount;
            double stotal = 0;
            for (int i = 0; i < conteo; i++)
            {
                stotal += Convert.ToDouble(tabla.Rows[i].Cells[4].Value);
            }
            txtsubt.Text = "L " + stotal.ToString();
            totalp = ((stotal * 0.15) + stotal);
            txtotal.Text = "L " + totalp.ToString();
            bProductos();
        }
        public static int contf = 0;
        public static double totalp = 0;
        private void btañadirc_Click(object sender, EventArgs e)
        {      
            int cantidad = (int) ndcantidad.Value;
            double precio = Convert.ToDouble(txtprecio.Text); 
            double subtotal = cantidad * precio;
            if (contf == 0)
            {
                tabla.Rows.Add(txtidprod.Text, txtnprod.Text.ToUpper(), ndcantidad.Value, txtprecio.Text, subtotal);
                contf++;
                calculosf();
            }
            else
            {
                tabla.Rows.Add(txtidprod.Text, txtnprod.Text.ToUpper(), ndcantidad.Value, txtprecio.Text, subtotal);
                contf++;
                calculosf();
            }           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabla.Rows.Remove(tabla.CurrentRow);
            calculosf();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            string estado = "Inactivo";          
            try
            {
                if ((MessageBox.Show("Esta seguro de eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE FACTURA SET FAC_ESTADO=@estado WHERE FAC_ID='" + txtidfact.Text + "'", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado exitosamente!");                   
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
                MessageBox.Show("ERROR" + ex);
            }
            con.Close();
            inicio();
        }

        private void btconsultar_Click(object sender, EventArgs e)
        {
            Consulta_Factura consulta = new Consulta_Factura();
            AddOwnedForm(consulta);
            consulta.ShowDialog();
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            conteo = tabla.RowCount;
            double stotal = 0;
            for (int i = 0; i < conteo; i++)
            {
                stotal += Convert.ToDouble(tabla.Rows[i].Cells[4].Value);
            }
            totalp = ((stotal * 0.15) + stotal);
            string estado = "Activo";
            try
            {
                con.Open();
                MySqlCommand COMANDO = new MySqlCommand();
                COMANDO.Connection = con;
                COMANDO.CommandText = "UPDATE FACTURA SET FAC_TOTALV='" + totalp + "',FAC_FECHAV='" + dtfecha.Value.Date.ToString("yyy-MM-dd") + "',CLI_ID='" + txtidcli.Text + "',CAJ_ID='" + cbidcaj.Text + "',FAC_ESTADO='" + estado + "' WHERE FAC_ID ='" + txtidfact.Text + "'";
                COMANDO.ExecuteNonQuery();
                MessageBox.Show("La factura < " + txtidfact.Text + " > fue actualizado exitosamente!", "Dato guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: \n" + ex);
            }
            inicio();
        }
    }
}
