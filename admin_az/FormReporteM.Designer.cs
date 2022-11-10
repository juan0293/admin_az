namespace admin_az
{
    partial class FormReporteM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteM));
            this.dgvreporte = new System.Windows.Forms.DataGridView();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.dtpDateinicio = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpDatefin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txttrabajos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picActualizar = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picatras = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picbGuardar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_deposito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tarjetas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picpequena = new System.Windows.Forms.PictureBox();
            this.metodoppagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewhistorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmetodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpequena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoppagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewhistorialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvreporte
            // 
            this.dgvreporte.AllowUserToAddRows = false;
            this.dgvreporte.AutoGenerateColumns = false;
            this.dgvreporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvreporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfacturaDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.idmetodoDataGridViewTextBoxColumn,
            this.delete});
            this.dgvreporte.DataSource = this.viewhistorialBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvreporte.EnableHeadersVisualStyles = false;
            this.dgvreporte.Location = new System.Drawing.Point(12, 121);
            this.dgvreporte.Name = "dgvreporte";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvreporte.RowHeadersVisible = false;
            this.dgvreporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvreporte.Size = new System.Drawing.Size(978, 395);
            this.dgvreporte.TabIndex = 98;
            this.dgvreporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreporte_CellContentClick);
            this.dgvreporte.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreporte_CellEndEdit);
            this.dgvreporte.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvreporte_RowsAdded);
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.lbdescripcion.Location = new System.Drawing.Point(388, 9);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(260, 32);
            this.lbdescripcion.TabIndex = 97;
            this.lbdescripcion.Text = "REPORTE DE CITAS:";
            // 
            // dtpDateinicio
            // 
            this.dtpDateinicio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateinicio.Location = new System.Drawing.Point(195, 71);
            this.dtpDateinicio.Name = "dtpDateinicio";
            this.dtpDateinicio.Size = new System.Drawing.Size(296, 30);
            this.dtpDateinicio.TabIndex = 116;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(46, 77);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 22);
            this.Label1.TabIndex = 115;
            this.Label1.Text = "Fecha de Inicio:";
            // 
            // dtpDatefin
            // 
            this.dtpDatefin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatefin.Location = new System.Drawing.Point(606, 71);
            this.dtpDatefin.Name = "dtpDatefin";
            this.dtpDatefin.Size = new System.Drawing.Size(296, 30);
            this.dtpDatefin.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(505, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 117;
            this.label2.Text = "Fecha Fin:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(654, 559);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(153, 30);
            this.txt_total.TabIndex = 119;
            // 
            // txttrabajos
            // 
            this.txttrabajos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrabajos.Location = new System.Drawing.Point(16, 559);
            this.txttrabajos.Name = "txttrabajos";
            this.txttrabajos.Size = new System.Drawing.Size(131, 30);
            this.txttrabajos.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 121;
            this.label3.Text = "Total Trabajos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(334, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 122;
            this.label4.Text = "Total Deposito:";
            // 
            // picActualizar
            // 
            this.picActualizar.Image = global::admin_az.Properties.Resources.search_48px;
            this.picActualizar.Location = new System.Drawing.Point(908, 71);
            this.picActualizar.Name = "picActualizar";
            this.picActualizar.Size = new System.Drawing.Size(49, 30);
            this.picActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picActualizar.TabIndex = 123;
            this.picActualizar.TabStop = false;
            this.picActualizar.Click += new System.EventHandler(this.picActualizar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(1000, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 125;
            this.label11.Text = "Atras";
            // 
            // picatras
            // 
            this.picatras.Image = global::admin_az.Properties.Resources.return_48px;
            this.picatras.Location = new System.Drawing.Point(1000, 9);
            this.picatras.Name = "picatras";
            this.picatras.Size = new System.Drawing.Size(50, 43);
            this.picatras.TabIndex = 124;
            this.picatras.TabStop = false;
            this.picatras.Click += new System.EventHandler(this.picatras_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(835, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 129;
            this.label7.Text = "Grande:";
            // 
            // picbGuardar
            // 
            this.picbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("picbGuardar.Image")));
            this.picbGuardar.Location = new System.Drawing.Point(847, 534);
            this.picbGuardar.Name = "picbGuardar";
            this.picbGuardar.Size = new System.Drawing.Size(40, 40);
            this.picbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbGuardar.TabIndex = 128;
            this.picbGuardar.TabStop = false;
            this.picbGuardar.Click += new System.EventHandler(this.picbGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(169, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 131;
            this.label5.Text = "Total Efectivo:";
            // 
            // txt_efectivo
            // 
            this.txt_efectivo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efectivo.Location = new System.Drawing.Point(173, 559);
            this.txt_efectivo.Name = "txt_efectivo";
            this.txt_efectivo.Size = new System.Drawing.Size(153, 30);
            this.txt_efectivo.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(493, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 133;
            this.label6.Text = "Total Tarjetas:";
            // 
            // txt_deposito
            // 
            this.txt_deposito.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deposito.Location = new System.Drawing.Point(338, 559);
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.Size = new System.Drawing.Size(153, 30);
            this.txt_deposito.TabIndex = 132;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(652, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 135;
            this.label8.Text = "Monto Total:";
            // 
            // txt_tarjetas
            // 
            this.txt_tarjetas.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tarjetas.Location = new System.Drawing.Point(495, 559);
            this.txt_tarjetas.Name = "txt_tarjetas";
            this.txt_tarjetas.Size = new System.Drawing.Size(153, 30);
            this.txt_tarjetas.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(913, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 137;
            this.label9.Text = "Pequeña";
            // 
            // picpequena
            // 
            this.picpequena.Image = ((System.Drawing.Image)(resources.GetObject("picpequena.Image")));
            this.picpequena.Location = new System.Drawing.Point(932, 534);
            this.picpequena.Name = "picpequena";
            this.picpequena.Size = new System.Drawing.Size(40, 40);
            this.picpequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picpequena.TabIndex = 136;
            this.picpequena.TabStop = false;
            this.picpequena.Click += new System.EventHandler(this.picpequena_Click);
            // 
            // metodoppagoBindingSource
            // 
            this.metodoppagoBindingSource.DataSource = typeof(admin_az.metodoppago);
            // 
            // viewhistorialBindingSource
            // 
            this.viewhistorialBindingSource.DataSource = typeof(admin_az.View_historial);
            // 
            // idfacturaDataGridViewTextBoxColumn
            // 
            this.idfacturaDataGridViewTextBoxColumn.DataPropertyName = "idfactura";
            this.idfacturaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idfacturaDataGridViewTextBoxColumn.Name = "idfacturaDataGridViewTextBoxColumn";
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idmetodoDataGridViewTextBoxColumn
            // 
            this.idmetodoDataGridViewTextBoxColumn.DataPropertyName = "idmetodo";
            this.idmetodoDataGridViewTextBoxColumn.DataSource = this.metodoppagoBindingSource;
            this.idmetodoDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.idmetodoDataGridViewTextBoxColumn.HeaderText = "Metodo";
            this.idmetodoDataGridViewTextBoxColumn.Name = "idmetodoDataGridViewTextBoxColumn";
            this.idmetodoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idmetodoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idmetodoDataGridViewTextBoxColumn.ValueMember = "idmetodo";
            // 
            // delete
            // 
            this.delete.HeaderText = "Ocultar";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            // 
            // FormReporteM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1062, 675);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picpequena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tarjetas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_deposito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_efectivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picbGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picatras);
            this.Controls.Add(this.picActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttrabajos);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.dtpDatefin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateinicio);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvreporte);
            this.Controls.Add(this.lbdescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteM";
            this.Load += new System.EventHandler(this.FormReporteM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpequena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoppagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewhistorialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvreporte;
        private System.Windows.Forms.Label lbdescripcion;
        public System.Windows.Forms.DateTimePicker dtpDateinicio;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.DateTimePicker dtpDatefin;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txttrabajos;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picActualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picatras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picbGuardar;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_efectivo;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_deposito;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tarjetas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picpequena;
        private System.Windows.Forms.BindingSource metodoppagoBindingSource;
        private System.Windows.Forms.BindingSource viewhistorialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idmetodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}