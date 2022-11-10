namespace admin_az
{
    partial class FormEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_hora = new System.Windows.Forms.MaskedTextBox();
            this.paneltotal = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picregresar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_metodo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pagado = new System.Windows.Forms.TextBox();
            this.picbGuardar = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.picsiguiente = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picFinalizar = new System.Windows.Forms.PictureBox();
            this.dgvdescripcion = new System.Windows.Forms.DataGridView();
            this.txt_apellido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.picatras = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneltotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picregresar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 51);
            this.panel1.TabIndex = 95;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::admin_az.Properties.Resources.shutdown_40px;
            this.pictureBox2.Location = new System.Drawing.Point(918, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 129;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.Location = new System.Drawing.Point(696, 168);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hora.Mask = "90:00";
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(114, 36);
            this.txt_hora.TabIndex = 200;
            this.txt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // paneltotal
            // 
            this.paneltotal.Controls.Add(this.label13);
            this.paneltotal.Controls.Add(this.label7);
            this.paneltotal.Controls.Add(this.picregresar);
            this.paneltotal.Controls.Add(this.panel3);
            this.paneltotal.Controls.Add(this.label12);
            this.paneltotal.Controls.Add(this.cbo_metodo);
            this.paneltotal.Controls.Add(this.label6);
            this.paneltotal.Controls.Add(this.txtTotal);
            this.paneltotal.Controls.Add(this.label9);
            this.paneltotal.Controls.Add(this.txt_pagado);
            this.paneltotal.Controls.Add(this.picbGuardar);
            this.paneltotal.Location = new System.Drawing.Point(264, 317);
            this.paneltotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneltotal.Name = "paneltotal";
            this.paneltotal.Size = new System.Drawing.Size(436, 429);
            this.paneltotal.TabIndex = 150;
            this.paneltotal.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(221, 369);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 28);
            this.label13.TabIndex = 114;
            this.label13.Text = "Regresar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(106, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 113;
            this.label7.Text = "Guardar:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // picregresar
            // 
            this.picregresar.Image = global::admin_az.Properties.Resources.return_48px;
            this.picregresar.Location = new System.Drawing.Point(226, 311);
            this.picregresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picregresar.Name = "picregresar";
            this.picregresar.Size = new System.Drawing.Size(75, 51);
            this.picregresar.TabIndex = 112;
            this.picregresar.TabStop = false;
            this.picregresar.Click += new System.EventHandler(this.picregresar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 51);
            this.panel3.TabIndex = 111;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::admin_az.Properties.Resources.shutdown_40px;
            this.btn_close.Location = new System.Drawing.Point(380, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(52, 54);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 128;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(99, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 28);
            this.label12.TabIndex = 110;
            this.label12.Text = "Metodo de Pago:";
            // 
            // cbo_metodo
            // 
            this.cbo_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_metodo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_metodo.FormattingEnabled = true;
            this.cbo_metodo.Location = new System.Drawing.Point(105, 177);
            this.cbo_metodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_metodo.Name = "cbo_metodo";
            this.cbo_metodo.Size = new System.Drawing.Size(235, 36);
            this.cbo_metodo.TabIndex = 109;
            this.cbo_metodo.SelectedIndexChanged += new System.EventHandler(this.cbo_metodo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(104, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 28);
            this.label6.TabIndex = 102;
            this.label6.Text = "Total A Pagar:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(105, 102);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.MaxLength = 30;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(235, 36);
            this.txtTotal.TabIndex = 101;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(106, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 28);
            this.label9.TabIndex = 108;
            this.label9.Text = "Monto Pagado:";
            // 
            // txt_pagado
            // 
            this.txt_pagado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pagado.Location = new System.Drawing.Point(105, 266);
            this.txt_pagado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pagado.MaxLength = 30;
            this.txt_pagado.Name = "txt_pagado";
            this.txt_pagado.Size = new System.Drawing.Size(230, 36);
            this.txt_pagado.TabIndex = 107;
            this.txt_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbGuardar
            // 
            this.picbGuardar.Image = global::admin_az.Properties.Resources.save_40px;
            this.picbGuardar.Location = new System.Drawing.Point(128, 315);
            this.picbGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbGuardar.Name = "picbGuardar";
            this.picbGuardar.Size = new System.Drawing.Size(40, 40);
            this.picbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbGuardar.TabIndex = 87;
            this.picbGuardar.TabStop = false;
            this.picbGuardar.Click += new System.EventHandler(this.picbGuardar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(462, 686);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 28);
            this.label15.TabIndex = 153;
            this.label15.Text = "Regresar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(327, 686);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 28);
            this.label14.TabIndex = 152;
            this.label14.Text = "Siguiente:";
            // 
            // picsiguiente
            // 
            this.picsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("picsiguiente.Image")));
            this.picsiguiente.Location = new System.Drawing.Point(350, 615);
            this.picsiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picsiguiente.Name = "picsiguiente";
            this.picsiguiente.Size = new System.Drawing.Size(75, 66);
            this.picsiguiente.TabIndex = 151;
            this.picsiguiente.TabStop = false;
            this.picsiguiente.Click += new System.EventHandler(this.picsiguiente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(383, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 28);
            this.label8.TabIndex = 149;
            this.label8.Text = "Editar Cita";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(621, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 28);
            this.label11.TabIndex = 148;
            this.label11.Text = "Hora";
            // 
            // picFinalizar
            // 
            this.picFinalizar.Image = global::admin_az.Properties.Resources.person_40px;
            this.picFinalizar.Location = new System.Drawing.Point(431, 61);
            this.picFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFinalizar.Name = "picFinalizar";
            this.picFinalizar.Size = new System.Drawing.Size(40, 40);
            this.picFinalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFinalizar.TabIndex = 147;
            this.picFinalizar.TabStop = false;
            // 
            // dgvdescripcion
            // 
            this.dgvdescripcion.AllowUserToAddRows = false;
            this.dgvdescripcion.BackgroundColor = System.Drawing.Color.White;
            this.dgvdescripcion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdescripcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvdescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdescripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Asunto,
            this.Costo});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdescripcion.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvdescripcion.EnableHeadersVisualStyles = false;
            this.dgvdescripcion.Location = new System.Drawing.Point(117, 397);
            this.dgvdescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvdescripcion.Name = "dgvdescripcion";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdescripcion.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvdescripcion.RowHeadersVisible = false;
            this.dgvdescripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdescripcion.Size = new System.Drawing.Size(701, 208);
            this.dgvdescripcion.TabIndex = 142;
            // 
            // txt_apellido
            // 
            this.txt_apellido.AutoSize = true;
            this.txt_apellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txt_apellido.Location = new System.Drawing.Point(117, 294);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(105, 28);
            this.txt_apellido.TabIndex = 139;
            this.txt_apellido.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(123, 328);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapellido.MaxLength = 30;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(348, 36);
            this.txtapellido.TabIndex = 130;
            // 
            // picatras
            // 
            this.picatras.Image = global::admin_az.Properties.Resources.return_48px;
            this.picatras.Location = new System.Drawing.Point(474, 615);
            this.picatras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picatras.Name = "picatras";
            this.picatras.Size = new System.Drawing.Size(75, 66);
            this.picatras.TabIndex = 138;
            this.picatras.TabStop = false;
            this.picatras.Click += new System.EventHandler(this.picatras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(488, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 137;
            this.label2.Text = "Nombre*";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.DimGray;
            this.Codigo.Location = new System.Drawing.Point(117, 215);
            this.Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(99, 28);
            this.Codigo.TabIndex = 136;
            this.Codigo.Text = "Codigo*";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(494, 249);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(348, 36);
            this.txtnombre.TabIndex = 129;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(117, 249);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_codigo.MaxLength = 30;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(348, 36);
            this.txt_codigo.TabIndex = 128;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(223, 168);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(390, 36);
            this.dtpDate.TabIndex = 135;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(117, 168);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 28);
            this.Label1.TabIndex = 134;
            this.Label1.Text = "Fecha";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Asunto
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Asunto.DefaultCellStyle = dataGridViewCellStyle17;
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.Width = 200;
            // 
            // Costo
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.Costo.DefaultCellStyle = dataGridViewCellStyle18;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Width = 180;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 829);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.paneltotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.picsiguiente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picFinalizar);
            this.Controls.Add(this.dgvdescripcion);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.picatras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditar";
            this.Load += new System.EventHandler(this.FormEditar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneltotal.ResumeLayout(false);
            this.paneltotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picregresar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel paneltotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picregresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_metodo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_pagado;
        private System.Windows.Forms.PictureBox picbGuardar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picsiguiente;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picFinalizar;
        public System.Windows.Forms.DataGridView dgvdescripcion;
        private System.Windows.Forms.Label txt_apellido;
        public System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.PictureBox picatras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Codigo;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txt_codigo;
        public System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.MaskedTextBox txt_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}