namespace Distribuidora
{
    partial class Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btcancelar = new System.Windows.Forms.Button();
            this.mdtelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.btconsultar = new System.Windows.Forms.Button();
            this.btingresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btrestaurar = new System.Windows.Forms.PictureBox();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.btmaximizar = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.btcancelar);
            this.panel3.Controls.Add(this.mdtelefono);
            this.panel3.Controls.Add(this.txtnombre);
            this.panel3.Controls.Add(this.txtidp);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtdireccion);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tabla);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(200, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 397);
            this.panel3.TabIndex = 12;
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Black;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btcancelar.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcancelar.Image = ((System.Drawing.Image)(resources.GetObject("btcancelar.Image")));
            this.btcancelar.Location = new System.Drawing.Point(422, 88);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(65, 50);
            this.btcancelar.TabIndex = 30;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Visible = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // mdtelefono
            // 
            this.mdtelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mdtelefono.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdtelefono.Location = new System.Drawing.Point(350, 18);
            this.mdtelefono.Mask = "0000-0000";
            this.mdtelefono.Name = "mdtelefono";
            this.mdtelefono.Size = new System.Drawing.Size(102, 25);
            this.mdtelefono.TabIndex = 27;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(85, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 25);
            this.txtnombre.TabIndex = 26;
            // 
            // txtidp
            // 
            this.txtidp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidp.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidp.Location = new System.Drawing.Point(114, 18);
            this.txtidp.Name = "txtidp";
            this.txtidp.Size = new System.Drawing.Size(67, 25);
            this.txtidp.TabIndex = 25;
            this.txtidp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtidp.TextChanged += new System.EventHandler(this.txtidp_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dirección";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(85, 102);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(317, 25);
            this.txtdireccion.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre";
            // 
            // tabla
            // 
            this.tabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(58)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.Location = new System.Drawing.Point(5, 144);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.tabla.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla.Size = new System.Drawing.Size(485, 241);
            this.tabla.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 214;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(281, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Proveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.bteliminar);
            this.panel1.Controls.Add(this.btmodificar);
            this.panel1.Controls.Add(this.btconsultar);
            this.panel1.Controls.Add(this.btingresar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 397);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(2, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 44);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(2, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 44);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(2, 177);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 44);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(2, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 44);
            this.panel7.TabIndex = 16;
            // 
            // bteliminar
            // 
            this.bteliminar.FlatAppearance.BorderSize = 0;
            this.bteliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bteliminar.Image = ((System.Drawing.Image)(resources.GetObject("bteliminar.Image")));
            this.bteliminar.Location = new System.Drawing.Point(3, 285);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.bteliminar.Size = new System.Drawing.Size(194, 44);
            this.bteliminar.TabIndex = 4;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bteliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btmodificar
            // 
            this.btmodificar.FlatAppearance.BorderSize = 0;
            this.btmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btmodificar.Image")));
            this.btmodificar.Location = new System.Drawing.Point(3, 230);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btmodificar.Size = new System.Drawing.Size(194, 44);
            this.btmodificar.TabIndex = 3;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // btconsultar
            // 
            this.btconsultar.FlatAppearance.BorderSize = 0;
            this.btconsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconsultar.Image = ((System.Drawing.Image)(resources.GetObject("btconsultar.Image")));
            this.btconsultar.Location = new System.Drawing.Point(3, 177);
            this.btconsultar.Name = "btconsultar";
            this.btconsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btconsultar.Size = new System.Drawing.Size(194, 44);
            this.btconsultar.TabIndex = 2;
            this.btconsultar.Text = "Consultar";
            this.btconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btconsultar.UseVisualStyleBackColor = true;
            this.btconsultar.Click += new System.EventHandler(this.btconsultar_Click);
            // 
            // btingresar
            // 
            this.btingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btingresar.FlatAppearance.BorderSize = 0;
            this.btingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btingresar.Image = ((System.Drawing.Image)(resources.GetObject("btingresar.Image")));
            this.btingresar.Location = new System.Drawing.Point(3, 122);
            this.btingresar.Name = "btingresar";
            this.btingresar.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btingresar.Size = new System.Drawing.Size(194, 44);
            this.btingresar.TabIndex = 1;
            this.btingresar.Text = "Ingresar";
            this.btingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btingresar.UseVisualStyleBackColor = true;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btrestaurar);
            this.panel2.Controls.Add(this.btminimizar);
            this.panel2.Controls.Add(this.btmaximizar);
            this.panel2.Controls.Add(this.btcerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 24);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btrestaurar
            // 
            this.btrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btrestaurar.Image")));
            this.btrestaurar.Location = new System.Drawing.Point(631, -1);
            this.btrestaurar.Name = "btrestaurar";
            this.btrestaurar.Size = new System.Drawing.Size(25, 25);
            this.btrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btrestaurar.TabIndex = 4;
            this.btrestaurar.TabStop = false;
            this.btrestaurar.Visible = false;
            this.btrestaurar.Click += new System.EventHandler(this.btrestaurar_Click);
            // 
            // btminimizar
            // 
            this.btminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btminimizar.Image")));
            this.btminimizar.Location = new System.Drawing.Point(600, 0);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(25, 25);
            this.btminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btminimizar.TabIndex = 3;
            this.btminimizar.TabStop = false;
            this.btminimizar.Click += new System.EventHandler(this.btminimizar_Click);
            // 
            // btmaximizar
            // 
            this.btmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btmaximizar.Image")));
            this.btmaximizar.Location = new System.Drawing.Point(631, 0);
            this.btmaximizar.Name = "btmaximizar";
            this.btmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btmaximizar.TabIndex = 2;
            this.btmaximizar.TabStop = false;
            this.btmaximizar.Click += new System.EventHandler(this.btmaximizar_Click);
            // 
            // btcerrar
            // 
            this.btcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcerrar.Image = ((System.Drawing.Image)(resources.GetObject("btcerrar.Image")));
            this.btcerrar.Location = new System.Drawing.Point(662, 0);
            this.btcerrar.Name = "btcerrar";
            this.btcerrar.Size = new System.Drawing.Size(25, 25);
            this.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btcerrar.TabIndex = 1;
            this.btcerrar.TabStop = false;
            this.btcerrar.Click += new System.EventHandler(this.btcerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button btconsultar;
        public System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btrestaurar;
        private System.Windows.Forms.PictureBox btminimizar;
        private System.Windows.Forms.PictureBox btmaximizar;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mdtelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btcancelar;
    }
}