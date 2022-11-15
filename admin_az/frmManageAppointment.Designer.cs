namespace admin_az
{
    partial class frmManageAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAppointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pagado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_metodo = new System.Windows.Forms.ComboBox();
            this.txt_hora = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_estimado = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel1_pago = new System.Windows.Forms.Panel();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_artista = new System.Windows.Forms.ComboBox();
            this.artistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_oferta = new System.Windows.Forms.ComboBox();
            this.ofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dgvdescripcion = new System.Windows.Forms.DataGridView();
            this.ausnto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1_pago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(100, 164);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(665, 32);
            this.dtpDate.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Silver;
            this.Label1.Location = new System.Drawing.Point(13, 171);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 25);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(12, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Asunto:";
            // 
            // txtasunto
            // 
            this.txtasunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtasunto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasunto.Location = new System.Drawing.Point(100, 131);
            this.txtasunto.MaxLength = 30;
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(666, 26);
            this.txtasunto.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(779, 28);
            this.txtapellido.MaxLength = 30;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(233, 26);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.Silver;
            this.Codigo.Location = new System.Drawing.Point(9, 86);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(85, 25);
            this.Codigo.TabIndex = 84;
            this.Codigo.Text = "Codigo:";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(319, 87);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(447, 26);
            this.txtnombre.TabIndex = 1;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(100, 86);
            this.txt_codigo.MaxLength = 30;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(106, 26);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(508, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Costo:";
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(586, 212);
            this.txtcosto.MaxLength = 30;
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(179, 30);
            this.txtcosto.TabIndex = 6;
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 129;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(4, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 32);
            this.label6.TabIndex = 102;
            this.label6.Text = "Total A Pagar:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(232, 205);
            this.txtTotal.MaxLength = 30;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(339, 83);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(7, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 32);
            this.label9.TabIndex = 108;
            this.label9.Text = "Monto Pagado:";
            // 
            // txt_pagado
            // 
            this.txt_pagado.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pagado.Location = new System.Drawing.Point(232, 294);
            this.txt_pagado.MaxLength = 30;
            this.txt_pagado.Name = "txt_pagado";
            this.txt_pagado.Size = new System.Drawing.Size(339, 83);
            this.txt_pagado.TabIndex = 4;
            this.txt_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pagado_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(12, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 122;
            this.label11.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(356, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 32);
            this.label8.TabIndex = 123;
            this.label8.Text = "Agendar Cita";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(4, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 32);
            this.label12.TabIndex = 110;
            this.label12.Text = "Metodo de Pago:";
            // 
            // cbo_metodo
            // 
            this.cbo_metodo.BackColor = System.Drawing.Color.White;
            this.cbo_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_metodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_metodo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_metodo.FormattingEnabled = true;
            this.cbo_metodo.Location = new System.Drawing.Point(232, 69);
            this.cbo_metodo.Name = "cbo_metodo";
            this.cbo_metodo.Size = new System.Drawing.Size(339, 36);
            this.cbo_metodo.TabIndex = 0;
            this.cbo_metodo.SelectedIndexChanged += new System.EventHandler(this.cbo_metodo_SelectedIndexChanged);
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.Location = new System.Drawing.Point(99, 211);
            this.txt_hora.Mask = "90:00";
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(106, 26);
            this.txt_hora.TabIndex = 4;
            this.txt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(227, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 25);
            this.label16.TabIndex = 130;
            this.label16.Text = "Cliente:";
            // 
            // txt_estimado
            // 
            this.txt_estimado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estimado.Location = new System.Drawing.Point(396, 211);
            this.txt_estimado.Mask = "90:00";
            this.txt_estimado.Name = "txt_estimado";
            this.txt_estimado.Size = new System.Drawing.Size(106, 26);
            this.txt_estimado.TabIndex = 5;
            this.txt_estimado.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(206, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 25);
            this.label17.TabIndex = 132;
            this.label17.Text = "Tiempo Estimado:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.Silver;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(361, 438);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(167, 51);
            this.btn_limpiar.TabIndex = 134;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Silver;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(18, 438);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 51);
            this.btn_save.TabIndex = 133;
            this.btn_save.Text = "Agregar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_continuar
            // 
            this.btn_continuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.ForeColor = System.Drawing.Color.Silver;
            this.btn_continuar.Image = ((System.Drawing.Image)(resources.GetObject("btn_continuar.Image")));
            this.btn_continuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_continuar.Location = new System.Drawing.Point(191, 438);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(167, 51);
            this.btn_continuar.TabIndex = 135;
            this.btn_continuar.Text = "Siguiente";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(534, 438);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(167, 51);
            this.btn_cerrar.TabIndex = 136;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1_pago
            // 
            this.panel1_pago.Controls.Add(this.picBarcode);
            this.panel1_pago.Controls.Add(this.piclogo);
            this.panel1_pago.Controls.Add(this.label5);
            this.panel1_pago.Controls.Add(this.cbo_artista);
            this.panel1_pago.Controls.Add(this.button1);
            this.panel1_pago.Controls.Add(this.button2);
            this.panel1_pago.Controls.Add(this.label4);
            this.panel1_pago.Controls.Add(this.cbo_oferta);
            this.panel1_pago.Controls.Add(this.label2);
            this.panel1_pago.Controls.Add(this.pictureBox1);
            this.panel1_pago.Controls.Add(this.label6);
            this.panel1_pago.Controls.Add(this.label12);
            this.panel1_pago.Controls.Add(this.cbo_metodo);
            this.panel1_pago.Controls.Add(this.txt_pagado);
            this.panel1_pago.Controls.Add(this.label9);
            this.panel1_pago.Controls.Add(this.txtTotal);
            this.panel1_pago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_pago.Location = new System.Drawing.Point(0, 0);
            this.panel1_pago.Name = "panel1_pago";
            this.panel1_pago.Size = new System.Drawing.Size(782, 512);
            this.panel1_pago.TabIndex = 137;
            this.panel1_pago.Visible = false;
            // 
            // picBarcode
            // 
            this.picBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBarcode.Image = ((System.Drawing.Image)(resources.GetObject("picBarcode.Image")));
            this.picBarcode.Location = new System.Drawing.Point(613, 204);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(122, 133);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarcode.TabIndex = 142;
            this.picBarcode.TabStop = false;
            this.picBarcode.Visible = false;
            // 
            // piclogo
            // 
            this.piclogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.piclogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(613, 59);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(122, 133);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 141;
            this.piclogo.TabStop = false;
            this.piclogo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 140;
            this.label5.Text = "Artista:";
            // 
            // cbo_artista
            // 
            this.cbo_artista.DataSource = this.artistaBindingSource;
            this.cbo_artista.DisplayMember = "nombre";
            this.cbo_artista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_artista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_artista.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_artista.FormattingEnabled = true;
            this.cbo_artista.Location = new System.Drawing.Point(233, 116);
            this.cbo_artista.Name = "cbo_artista";
            this.cbo_artista.Size = new System.Drawing.Size(339, 36);
            this.cbo_artista.TabIndex = 1;
            this.cbo_artista.ValueMember = "idartista";
            this.cbo_artista.DropDown += new System.EventHandler(this.cbo_artista_DropDown);
            this.cbo_artista.SelectedIndexChanged += new System.EventHandler(this.cbo_artista_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(404, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 51);
            this.button1.TabIndex = 138;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(231, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 51);
            this.button2.TabIndex = 137;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 32);
            this.label4.TabIndex = 133;
            this.label4.Text = "Oferta Sugerida:";
            // 
            // cbo_oferta
            // 
            this.cbo_oferta.DataSource = this.ofertaBindingSource;
            this.cbo_oferta.DisplayMember = "titulo";
            this.cbo_oferta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_oferta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_oferta.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_oferta.FormattingEnabled = true;
            this.cbo_oferta.Location = new System.Drawing.Point(232, 163);
            this.cbo_oferta.Name = "cbo_oferta";
            this.cbo_oferta.Size = new System.Drawing.Size(339, 36);
            this.cbo_oferta.TabIndex = 2;
            this.cbo_oferta.ValueMember = "porcentaje";
            this.cbo_oferta.DropDown += new System.EventHandler(this.cbo_oferta_DropDown);
            this.cbo_oferta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(281, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 32);
            this.label2.TabIndex = 131;
            this.label2.Text = "Ventana de Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dgvdescripcion
            // 
            this.dgvdescripcion.AllowUserToAddRows = false;
            this.dgvdescripcion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdescripcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdescripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ausnto,
            this.Costo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdescripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdescripcion.EnableHeadersVisualStyles = false;
            this.dgvdescripcion.Location = new System.Drawing.Point(18, 248);
            this.dgvdescripcion.Name = "dgvdescripcion";
            this.dgvdescripcion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdescripcion.RowHeadersVisible = false;
            this.dgvdescripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdescripcion.Size = new System.Drawing.Size(747, 183);
            this.dgvdescripcion.TabIndex = 138;
            // 
            // ausnto
            // 
            this.ausnto.HeaderText = "Asunto";
            this.ausnto.Name = "ausnto";
            this.ausnto.Width = 450;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Width = 350;
            // 
            // frmManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(782, 512);
            this.Controls.Add(this.panel1_pago);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_estimado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvdescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b ;";
            this.Load += new System.EventHandler(this.frmManageAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1_pago.ResumeLayout(false);
            this.panel1_pago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtasunto;
        public System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label Codigo;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_pagado;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_metodo;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.MaskedTextBox txt_hora;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txt_estimado;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel panel1_pago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_oferta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource ofertaBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_artista;
        private System.Windows.Forms.BindingSource artistaBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.DataGridView dgvdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ausnto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}