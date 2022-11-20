namespace admin_az
{
    partial class Form_cuenta__cobrar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cuenta__cobrar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_citas = new System.Windows.Forms.DataGridView();
            this.txt_rnc = new System.Windows.Forms.Panel();
            this.lb_pendientes = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_estado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cuentacxpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idcuentacxpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).BeginInit();
            this.txt_rnc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentacxpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_citas
            // 
            this.dgv_citas.AllowUserToAddRows = false;
            this.dgv_citas.AllowUserToOrderColumns = true;
            this.dgv_citas.AllowUserToResizeRows = false;
            this.dgv_citas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_citas.AutoGenerateColumns = false;
            this.dgv_citas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_citas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_citas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_citas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_citas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcuentacxpDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.estado,
            this.idiente,
            this.idcita});
            this.dgv_citas.DataSource = this.cuentacxpBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_citas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_citas.EnableHeadersVisualStyles = false;
            this.dgv_citas.Location = new System.Drawing.Point(0, 162);
            this.dgv_citas.Name = "dgv_citas";
            this.dgv_citas.ReadOnly = true;
            this.dgv_citas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_citas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_citas.RowHeadersVisible = false;
            this.dgv_citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_citas.Size = new System.Drawing.Size(751, 355);
            this.dgv_citas.TabIndex = 151;
            this.dgv_citas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_citas_CellContentClick);
            // 
            // txt_rnc
            // 
            this.txt_rnc.BackColor = System.Drawing.Color.White;
            this.txt_rnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_rnc.Controls.Add(this.lb_pendientes);
            this.txt_rnc.Controls.Add(this.lb_cantidad);
            this.txt_rnc.Controls.Add(this.label2);
            this.txt_rnc.Controls.Add(this.label3);
            this.txt_rnc.Controls.Add(this.label1);
            this.txt_rnc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_rnc.Location = new System.Drawing.Point(0, 0);
            this.txt_rnc.Name = "txt_rnc";
            this.txt_rnc.Size = new System.Drawing.Size(279, 156);
            this.txt_rnc.TabIndex = 147;
            // 
            // lb_pendientes
            // 
            this.lb_pendientes.AutoSize = true;
            this.lb_pendientes.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pendientes.ForeColor = System.Drawing.Color.Red;
            this.lb_pendientes.Location = new System.Drawing.Point(201, 91);
            this.lb_pendientes.Name = "lb_pendientes";
            this.lb_pendientes.Size = new System.Drawing.Size(47, 22);
            this.lb_pendientes.TabIndex = 139;
            this.lb_pendientes.Text = "0.00";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lb_cantidad.Location = new System.Drawing.Point(202, 54);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(21, 22);
            this.lb_cantidad.TabIndex = 138;
            this.lb_cantidad.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 152;
            this.label2.Text = "Cuentas Por Cobrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 136;
            this.label3.Text = "Monto Pendiente.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "Cantidad de Facturas:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_estado);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_rnc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 156);
            this.panel1.TabIndex = 152;
            // 
            // btn_estado
            // 
            this.btn_estado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estado.ForeColor = System.Drawing.Color.Silver;
            this.btn_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado.Image")));
            this.btn_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estado.Location = new System.Drawing.Point(285, 93);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(138, 51);
            this.btn_estado.TabIndex = 151;
            this.btn_estado.Text = "       Pagar";
            this.btn_estado.UseVisualStyleBackColor = true;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(429, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 51);
            this.button1.TabIndex = 149;
            this.button1.Text = "   Anular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuentacxpBindingSource
            // 
            this.cuentacxpBindingSource.DataSource = typeof(admin_az.Cuentacxp);
            // 
            // idcuentacxpDataGridViewTextBoxColumn
            // 
            this.idcuentacxpDataGridViewTextBoxColumn.DataPropertyName = "idcuentacxp";
            this.idcuentacxpDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idcuentacxpDataGridViewTextBoxColumn.Name = "idcuentacxpDataGridViewTextBoxColumn";
            this.idcuentacxpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 300;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 250;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 200;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // idiente
            // 
            this.idiente.DataPropertyName = "idiente";
            this.idiente.HeaderText = "idiente";
            this.idiente.Name = "idiente";
            this.idiente.ReadOnly = true;
            this.idiente.Visible = false;
            // 
            // idcita
            // 
            this.idcita.DataPropertyName = "idcita";
            this.idcita.HeaderText = "idcita";
            this.idcita.Name = "idcita";
            this.idcita.ReadOnly = true;
            // 
            // Form_cuenta__cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.dgv_citas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cuenta__cobrar";
            this.Text = "Form_cuenta__cobrar";
            this.Load += new System.EventHandler(this.Form_cuenta__cobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).EndInit();
            this.txt_rnc.ResumeLayout(false);
            this.txt_rnc.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuentacxpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_citas;
        private System.Windows.Forms.BindingSource cuentacxpBindingSource;
        private System.Windows.Forms.Panel txt_rnc;
        private System.Windows.Forms.Label lb_pendientes;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuentacxpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcita;
    }
}