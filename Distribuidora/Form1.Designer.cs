namespace Distribuidora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrden = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnDetfact = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btcsesion = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.tablas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptusuario = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(694, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.BackColor = System.Drawing.Color.Black;
            this.btnOrden.FlatAppearance.BorderSize = 0;
            this.btnOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnOrden.Image")));
            this.btnOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrden.Location = new System.Drawing.Point(1, 308);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(196, 36);
            this.btnOrden.TabIndex = 5;
            this.btnOrden.Text = "Orden de entrega";
            this.btnOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrden.UseVisualStyleBackColor = false;
            this.btnOrden.Visible = false;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // btnProv
            // 
            this.btnProv.BackColor = System.Drawing.Color.Black;
            this.btnProv.FlatAppearance.BorderSize = 0;
            this.btnProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProv.Image = ((System.Drawing.Image)(resources.GetObject("btnProv.Image")));
            this.btnProv.Location = new System.Drawing.Point(4, 262);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(193, 36);
            this.btnProv.TabIndex = 4;
            this.btnProv.Text = "Proveedor";
            this.btnProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProv.UseVisualStyleBackColor = false;
            this.btnProv.Visible = false;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.Black;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProd.Image = ((System.Drawing.Image)(resources.GetObject("btnProd.Image")));
            this.btnProd.Location = new System.Drawing.Point(1, 215);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(196, 36);
            this.btnProd.TabIndex = 3;
            this.btnProd.Text = "Producto";
            this.btnProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Visible = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnDetfact
            // 
            this.btnDetfact.BackColor = System.Drawing.Color.Black;
            this.btnDetfact.FlatAppearance.BorderSize = 0;
            this.btnDetfact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDetfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetfact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetfact.Image = ((System.Drawing.Image)(resources.GetObject("btnDetfact.Image")));
            this.btnDetfact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetfact.Location = new System.Drawing.Point(1, 169);
            this.btnDetfact.Name = "btnDetfact";
            this.btnDetfact.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetfact.Size = new System.Drawing.Size(196, 36);
            this.btnDetfact.TabIndex = 2;
            this.btnDetfact.Text = "Detalle Factura";
            this.btnDetfact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetfact.UseVisualStyleBackColor = false;
            this.btnDetfact.Visible = false;
            this.btnDetfact.Click += new System.EventHandler(this.btnDetfact_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Black;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.Location = new System.Drawing.Point(1, 123);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.btnFactura.Size = new System.Drawing.Size(196, 36);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Factura";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Visible = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Black;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(1, 77);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(0, 0, 19, 0);
            this.btnCliente.Size = new System.Drawing.Size(195, 36);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Visible = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(222, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 82);
            this.label5.TabIndex = 8;
            this.label5.Text = "BIENVENIDO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(279, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btcsesion
            // 
            this.btcsesion.BackColor = System.Drawing.Color.Black;
            this.btcsesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btcsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcsesion.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcsesion.Image = ((System.Drawing.Image)(resources.GetObject("btcsesion.Image")));
            this.btcsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcsesion.Location = new System.Drawing.Point(3, 358);
            this.btcsesion.Name = "btcsesion";
            this.btcsesion.Size = new System.Drawing.Size(192, 58);
            this.btcsesion.TabIndex = 11;
            this.btcsesion.Text = "Cerrar sesión";
            this.btcsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btcsesion.UseVisualStyleBackColor = false;
            this.btcsesion.Click += new System.EventHandler(this.btcsesion_Click_1);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login.Controls.Add(this.pictureBox4);
            this.Login.Controls.Add(this.pictureBox3);
            this.Login.Controls.Add(this.pictureBox1);
            this.Login.Controls.Add(this.btnIngresar);
            this.Login.Controls.Add(this.txtcontraseña);
            this.Login.Controls.Add(this.txtusuario);
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(198, 29);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(496, 419);
            this.Login.TabIndex = 12;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(144, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(145, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(151, 293);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(193, 41);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcontraseña.BackColor = System.Drawing.Color.Black;
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.txtcontraseña.Location = new System.Drawing.Point(178, 240);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(166, 23);
            this.txtcontraseña.TabIndex = 9;
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.BackColor = System.Drawing.Color.Black;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.Control;
            this.txtusuario.Location = new System.Drawing.Point(178, 196);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(166, 23);
            this.txtusuario.TabIndex = 8;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.Black;
            this.tablas.Controls.Add(this.label1);
            this.tablas.Controls.Add(this.ptusuario);
            this.tablas.Controls.Add(this.panel6);
            this.tablas.Controls.Add(this.panel5);
            this.tablas.Controls.Add(this.panel4);
            this.tablas.Controls.Add(this.panel3);
            this.tablas.Controls.Add(this.panel2);
            this.tablas.Controls.Add(this.panel1);
            this.tablas.Controls.Add(this.btnOrden);
            this.tablas.Controls.Add(this.btcsesion);
            this.tablas.Controls.Add(this.btnProv);
            this.tablas.Controls.Add(this.btnProd);
            this.tablas.Controls.Add(this.btnDetfact);
            this.tablas.Controls.Add(this.btnFactura);
            this.tablas.Controls.Add(this.btnCliente);
            this.tablas.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablas.Location = new System.Drawing.Point(0, 29);
            this.tablas.Name = "tablas";
            this.tablas.Size = new System.Drawing.Size(198, 419);
            this.tablas.TabIndex = 7;
            this.tablas.TabStop = false;
            this.tablas.Text = "Tablas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // ptusuario
            // 
            this.ptusuario.BackColor = System.Drawing.Color.Transparent;
            this.ptusuario.Image = ((System.Drawing.Image)(resources.GetObject("ptusuario.Image")));
            this.ptusuario.Location = new System.Drawing.Point(20, 23);
            this.ptusuario.Name = "ptusuario";
            this.ptusuario.Size = new System.Drawing.Size(58, 50);
            this.ptusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptusuario.TabIndex = 18;
            this.ptusuario.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(1, 308);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 36);
            this.panel6.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(1, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 36);
            this.panel5.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(1, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 36);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(1, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 36);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(1, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 36);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(1, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 36);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(694, 448);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tablas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablas.ResumeLayout(false);
            this.tablas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnDetfact;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btcsesion;
        private System.Windows.Forms.GroupBox tablas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptusuario;
        public System.Windows.Forms.Label label1;
    }
}

