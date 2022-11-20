namespace admin_az
{
    partial class FormcCitaR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormcCitaR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcita = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvtrabajo = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewreimprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idcitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montopagadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_estimado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewreimprimirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToAddRows = false;
            this.dgvproducto.AutoGenerateColumns = false;
            this.dgvproducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvproducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcitaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.montopagadoDataGridViewTextBoxColumn,
            this.restaDataGridViewTextBoxColumn,
            this.nombreUDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.metodoPDataGridViewTextBoxColumn,
            this.apellido,
            this.telefono,
            this.nombreU,
            this.tiempo_estimado,
            this.nombreArtista,
            this.descuento});
            this.dgvproducto.DataSource = this.viewreimprimirBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvproducto.EnableHeadersVisualStyles = false;
            this.dgvproducto.Location = new System.Drawing.Point(12, 67);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvproducto.RowHeadersVisible = false;
            this.dgvproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducto.Size = new System.Drawing.Size(949, 665);
            this.dgvproducto.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 134;
            this.label3.Text = "ID cita:";
            // 
            // txtcita
            // 
            this.txtcita.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcita.Location = new System.Drawing.Point(87, 26);
            this.txtcita.Name = "txtcita";
            this.txtcita.Size = new System.Drawing.Size(273, 30);
            this.txtcita.TabIndex = 135;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvtrabajo
            // 
            this.dgvtrabajo.AllowUserToAddRows = false;
            this.dgvtrabajo.AutoGenerateColumns = false;
            this.dgvtrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asuntoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn1,
            this.idcitaDataGridViewTextBoxColumn1,
            this.idtrabajoDataGridViewTextBoxColumn});
            this.dgvtrabajo.DataSource = this.trabajoBindingSource;
            this.dgvtrabajo.Location = new System.Drawing.Point(179, 738);
            this.dgvtrabajo.Name = "dgvtrabajo";
            this.dgvtrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtrabajo.Size = new System.Drawing.Size(447, 150);
            this.dgvtrabajo.TabIndex = 137;
            this.dgvtrabajo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtrabajo_CellContentClick);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Silver;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(437, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 41);
            this.btn_save.TabIndex = 138;
            this.btn_save.Text = "Imprimir";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(610, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(167, 41);
            this.btn_cerrar.TabIndex = 139;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // piclogo
            // 
            this.piclogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.piclogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(482, 172);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(122, 133);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 142;
            this.piclogo.TabStop = false;
            this.piclogo.Visible = false;
            // 
            // picBarcode
            // 
            this.picBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBarcode.Image = ((System.Drawing.Image)(resources.GetObject("picBarcode.Image")));
            this.picBarcode.Location = new System.Drawing.Point(610, 172);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(122, 133);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarcode.TabIndex = 143;
            this.picBarcode.TabStop = false;
            this.picBarcode.Visible = false;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn1
            // 
            this.montoDataGridViewTextBoxColumn1.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn1.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn1.Name = "montoDataGridViewTextBoxColumn1";
            // 
            // idcitaDataGridViewTextBoxColumn1
            // 
            this.idcitaDataGridViewTextBoxColumn1.DataPropertyName = "idcita";
            this.idcitaDataGridViewTextBoxColumn1.HeaderText = "idcita";
            this.idcitaDataGridViewTextBoxColumn1.Name = "idcitaDataGridViewTextBoxColumn1";
            // 
            // idtrabajoDataGridViewTextBoxColumn
            // 
            this.idtrabajoDataGridViewTextBoxColumn.DataPropertyName = "idtrabajo";
            this.idtrabajoDataGridViewTextBoxColumn.HeaderText = "idtrabajo";
            this.idtrabajoDataGridViewTextBoxColumn.Name = "idtrabajoDataGridViewTextBoxColumn";
            // 
            // trabajoBindingSource
            // 
            this.trabajoBindingSource.DataSource = typeof(admin_az.trabajo);
            // 
            // viewreimprimirBindingSource
            // 
            this.viewreimprimirBindingSource.DataSource = typeof(admin_az.View_reimprimir);
            // 
            // idcitaDataGridViewTextBoxColumn
            // 
            this.idcitaDataGridViewTextBoxColumn.DataPropertyName = "idcita";
            this.idcitaDataGridViewTextBoxColumn.HeaderText = "ID cita";
            this.idcitaDataGridViewTextBoxColumn.Name = "idcitaDataGridViewTextBoxColumn";
            this.idcitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "fechaCita";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fechaCitaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "Fecha/cita";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montopagadoDataGridViewTextBoxColumn
            // 
            this.montopagadoDataGridViewTextBoxColumn.DataPropertyName = "montopagado";
            this.montopagadoDataGridViewTextBoxColumn.HeaderText = "Monto/pagado";
            this.montopagadoDataGridViewTextBoxColumn.Name = "montopagadoDataGridViewTextBoxColumn";
            this.montopagadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montopagadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // restaDataGridViewTextBoxColumn
            // 
            this.restaDataGridViewTextBoxColumn.DataPropertyName = "resta";
            this.restaDataGridViewTextBoxColumn.HeaderText = "Resta";
            this.restaDataGridViewTextBoxColumn.Name = "restaDataGridViewTextBoxColumn";
            this.restaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUDataGridViewTextBoxColumn
            // 
            this.nombreUDataGridViewTextBoxColumn.DataPropertyName = "nombreU";
            this.nombreUDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nombreUDataGridViewTextBoxColumn.Name = "nombreUDataGridViewTextBoxColumn";
            this.nombreUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "IDcliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoPDataGridViewTextBoxColumn
            // 
            this.metodoPDataGridViewTextBoxColumn.DataPropertyName = "metodoP";
            this.metodoPDataGridViewTextBoxColumn.HeaderText = "Metodo/pago";
            this.metodoPDataGridViewTextBoxColumn.Name = "metodoPDataGridViewTextBoxColumn";
            this.metodoPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // nombreU
            // 
            this.nombreU.DataPropertyName = "nombreU";
            this.nombreU.HeaderText = "nombreU";
            this.nombreU.Name = "nombreU";
            this.nombreU.ReadOnly = true;
            // 
            // tiempo_estimado
            // 
            this.tiempo_estimado.DataPropertyName = "tiempo_estimado";
            this.tiempo_estimado.HeaderText = "tiempo_estimado";
            this.tiempo_estimado.Name = "tiempo_estimado";
            this.tiempo_estimado.ReadOnly = true;
            // 
            // nombreArtista
            // 
            this.nombreArtista.DataPropertyName = "nombreArtista";
            this.nombreArtista.HeaderText = "nombreArtista";
            this.nombreArtista.Name = "nombreArtista";
            this.nombreArtista.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle4;
            this.descuento.HeaderText = "descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // FormcCitaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(960, 788);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgvtrabajo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormcCitaR";
            this.Text = "FormcCitaR";
            this.Load += new System.EventHandler(this.FormcCitaR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewreimprimirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.BindingSource viewreimprimirBindingSource;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvtrabajo;
        private System.Windows.Forms.BindingSource trabajoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montopagadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_estimado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}