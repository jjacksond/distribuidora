namespace Distribuidora
{
    partial class Consulta_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Factura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btrestaurar = new System.Windows.Forms.PictureBox();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.btmaximizar = new System.Windows.Forms.PictureBox();
            this.btcerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(728, 24);
            this.panel2.TabIndex = 14;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btrestaurar
            // 
            this.btrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btrestaurar.Image")));
            this.btrestaurar.Location = new System.Drawing.Point(660, -1);
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
            this.btminimizar.Location = new System.Drawing.Point(629, 0);
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
            this.btmaximizar.Location = new System.Drawing.Point(660, 0);
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
            this.btcerrar.Location = new System.Drawing.Point(691, 0);
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
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Factura";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btbuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 363);
            this.panel1.TabIndex = 16;
            // 
            // btbuscar
            // 
            this.btbuscar.BackColor = System.Drawing.Color.Black;
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbuscar.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscar.Location = new System.Drawing.Point(224, 19);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(84, 31);
            this.btbuscar.TabIndex = 22;
            this.btbuscar.Text = "buscar";
            this.btbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Digite el id:";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(92, 23);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(108, 25);
            this.txtid.TabIndex = 18;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // tabla
            // 
            this.tabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(58)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle18;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.Location = new System.Drawing.Point(5, 61);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            this.tabla.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.tabla.Size = new System.Drawing.Size(718, 292);
            this.tabla.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 214;
            // 
            // Column3
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column3.HeaderText = "Id cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id cajero";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total venta";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Consulta_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(728, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_Factura";
            this.Load += new System.EventHandler(this.Consulta_Factura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btrestaurar;
        private System.Windows.Forms.PictureBox btminimizar;
        private System.Windows.Forms.PictureBox btmaximizar;
        private System.Windows.Forms.PictureBox btcerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label label2;
    }
}