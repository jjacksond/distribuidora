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

namespace Distribuidora
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();  
        }
        public void Inicio()
        {
            Login.Visible = false;
            tablas.Text = "";
            btnCliente.Visible = false;
            btnFactura.Visible = false;
            btnDetfact.Visible = false;
            btnProd.Visible = false;
            btnProv.Visible = false;
            btnOrden.Visible = false;
            btcsesion.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            ptusuario.Visible = false;
            label1.Visible = false;
        }
        public void compdba()
        {
            Login.Visible = false;
            tablas.Text = "Tablas";
            btnCliente.Visible = true;
            btnFactura.Visible = true;
            btnDetfact.Visible = true;
            btnProd.Visible = true;
            btnProv.Visible = true;
            btnOrden.Visible = true;
            btcsesion.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            label1.Visible = true;
            txtusuario.Clear();
            txtcontraseña.Clear();
        }
        public void compusu()
        {
            Login.Visible = false;
            tablas.Text = "Tablas";
            btnCliente.Visible = true;
            btnFactura.Visible = true;
            btnProd.Visible = true;
            btcsesion.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            label1.Visible = true;
            txtusuario.Clear();
            txtcontraseña.Clear();
        }
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Visible = true;
            txtusuario.Focus();
            iniciarSesiónToolStripMenuItem.Enabled = false;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Data Source=localhost; database=distribuidora; Uid=root; password=222627;");           
            try
            {
                con.Open();
                MySqlCommand comando = new MySqlCommand("Select * from usuario where usu_nom like @usuario and usu_cont like @contraseña", con);
                comando.Parameters.AddWithValue("@usuario", txtusuario.Text);
                comando.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();            
                da.Fill(dt);

                if (dt.Rows.Count == 1) 
                {
                    if (dt.Rows[0][3].ToString() == "dba") 
                    {
                        compdba();
                        label1.Text = "DBA";
                        ptusuario.Visible = true;
                        usuario.dato = label1.Text;
                    }
                    else if (dt.Rows[0][3].ToString() == "cajero")
                    {
                        compusu();
                        label1.Text = "CAJERO";
                        ptusuario.Visible = true;
                        usuario.dato = label1.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtusuario.Clear();
                    txtcontraseña.Clear();
                    txtusuario.Focus();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
        private void btcsesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Inicio();
                iniciarSesiónToolStripMenuItem.Enabled = true;
            }           
        }     
        private void btnFactura_Click(object sender, EventArgs e)
        {
            Factura Fact = new Factura();
            AddOwnedForm(Fact);
            Fact.ShowDialog();            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.menuStrip1.Enabled = true;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            AddOwnedForm(cliente);
            cliente.ShowDialog();
        }

        private void btnDetfact_Click(object sender, EventArgs e)
        {
            DetalleFactura detalle = new DetalleFactura();
            AddOwnedForm(detalle);
            detalle.ShowDialog();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            AddOwnedForm(prod);
            prod.ShowDialog();
        }
        private void btnProv_Click(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            AddOwnedForm(prov);
            prov.ShowDialog();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            OrdenEntrega orden = new OrdenEntrega();
            AddOwnedForm(orden);
            orden.ShowDialog();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcontraseña.Focus();
            }
        }
    }
}
