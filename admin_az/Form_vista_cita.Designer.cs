namespace admin_az
{
    partial class form_vista_cita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_vista_cita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_citas = new System.Windows.Forms.DataGridView();
            this.txt_rnc = new System.Windows.Forms.Panel();
            this.lb_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_agendada = new System.Windows.Forms.Label();
            this.lb_hoy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_finalizada = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_anular = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_estado = new System.Windows.Forms.Button();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.dtp_fecha_hoy = new System.Windows.Forms.DateTimePicker();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESTANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).BeginInit();
            this.txt_rnc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_citas
            // 
            this.dgv_citas.AllowUserToAddRows = false;
            this.dgv_citas.AllowUserToOrderColumns = true;
            this.dgv_citas.AllowUserToResizeRows = false;
            this.dgv_citas.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.numero,
            this.cliente,
            this.TELEFONO,
            this.CODIGO,
            this.ESTADO,
            this.METODO,
            this.MONTO,
            this.RESTANTE,
            this.FECHA,
            this.idcita,
            this.idcliente,
            this.FechaC,
            this.sesion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_citas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_citas.EnableHeadersVisualStyles = false;
            this.dgv_citas.Location = new System.Drawing.Point(0, 159);
            this.dgv_citas.Name = "dgv_citas";
            this.dgv_citas.ReadOnly = true;
            this.dgv_citas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_citas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_citas.RowHeadersVisible = false;
            this.dgv_citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_citas.Size = new System.Drawing.Size(833, 354);
            this.dgv_citas.TabIndex = 50;
            this.dgv_citas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_citas_CellContentClick);
            this.dgv_citas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_citas_CellFormatting);
            // 
            // txt_rnc
            // 
            this.txt_rnc.BackColor = System.Drawing.Color.White;
            this.txt_rnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_rnc.Controls.Add(this.lb_total);
            this.txt_rnc.Controls.Add(this.label8);
            this.txt_rnc.Controls.Add(this.lb_agendada);
            this.txt_rnc.Controls.Add(this.lb_hoy);
            this.txt_rnc.Controls.Add(this.label2);
            this.txt_rnc.Controls.Add(this.lb_cantidad);
            this.txt_rnc.Controls.Add(this.label4);
            this.txt_rnc.Controls.Add(this.label3);
            this.txt_rnc.Controls.Add(this.label1);
            this.txt_rnc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_rnc.Location = new System.Drawing.Point(0, 0);
            this.txt_rnc.Name = "txt_rnc";
            this.txt_rnc.Size = new System.Drawing.Size(264, 155);
            this.txt_rnc.TabIndex = 147;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.Navy;
            this.lb_total.Location = new System.Drawing.Point(160, 117);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(47, 22);
            this.lb_total.TabIndex = 144;
            this.lb_total.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 143;
            this.label8.Text = "Total.:";
            // 
            // lb_agendada
            // 
            this.lb_agendada.AutoSize = true;
            this.lb_agendada.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_agendada.ForeColor = System.Drawing.Color.Goldenrod;
            this.lb_agendada.Location = new System.Drawing.Point(160, 127);
            this.lb_agendada.Name = "lb_agendada";
            this.lb_agendada.Size = new System.Drawing.Size(47, 22);
            this.lb_agendada.TabIndex = 140;
            this.lb_agendada.Text = "0.00";
            this.lb_agendada.Visible = false;
            // 
            // lb_hoy
            // 
            this.lb_hoy.AutoSize = true;
            this.lb_hoy.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoy.ForeColor = System.Drawing.Color.Green;
            this.lb_hoy.Location = new System.Drawing.Point(161, 76);
            this.lb_hoy.Name = "lb_hoy";
            this.lb_hoy.Size = new System.Drawing.Size(47, 22);
            this.lb_hoy.TabIndex = 139;
            this.lb_hoy.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-1, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 152;
            this.label2.Text = "Gestor de Citas";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lb_cantidad.Location = new System.Drawing.Point(161, 33);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(21, 22);
            this.lb_cantidad.TabIndex = 138;
            this.lb_cantidad.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 137;
            this.label4.Text = "Agendada.:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 136;
            this.label3.Text = "Hoy.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "Cantidad de Citas:";
            // 
            // lb_finalizada
            // 
            this.lb_finalizada.AutoSize = true;
            this.lb_finalizada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_finalizada.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_finalizada.ForeColor = System.Drawing.Color.Blue;
            this.lb_finalizada.Location = new System.Drawing.Point(915, 62);
            this.lb_finalizada.Name = "lb_finalizada";
            this.lb_finalizada.Size = new System.Drawing.Size(47, 22);
            this.lb_finalizada.TabIndex = 142;
            this.lb_finalizada.Text = "0.00";
            this.lb_finalizada.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(981, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 141;
            this.label6.Text = "Finalizadas.:";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_Finalizar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_anular);
            this.panel1.Controls.Add(this.dtp_fecha);
            this.panel1.Controls.Add(this.lb_finalizada);
            this.panel1.Controls.Add(this.btn_estado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_facturar);
            this.panel1.Controls.Add(this.txt_rnc);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 155);
            this.panel1.TabIndex = 148;
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finalizar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.ForeColor = System.Drawing.Color.Silver;
            this.btn_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Finalizar.Image")));
            this.btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Finalizar.Location = new System.Drawing.Point(270, 101);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(167, 51);
            this.btn_Finalizar.TabIndex = 155;
            this.btn_Finalizar.Text = "   Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(270, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 154;
            this.label5.Text = "Seleccionar Fecha";
            // 
            // btn_anular
            // 
            this.btn_anular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_anular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anular.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular.ForeColor = System.Drawing.Color.Silver;
            this.btn_anular.Image = ((System.Drawing.Image)(resources.GetObject("btn_anular.Image")));
            this.btn_anular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anular.Location = new System.Drawing.Point(614, 100);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(167, 51);
            this.btn_anular.TabIndex = 149;
            this.btn_anular.Text = "   Anular";
            this.btn_anular.UseVisualStyleBackColor = true;
            this.btn_anular.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(270, 35);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(167, 38);
            this.dtp_fecha.TabIndex = 153;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            // 
            // btn_estado
            // 
            this.btn_estado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estado.ForeColor = System.Drawing.Color.Silver;
            this.btn_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado.Image")));
            this.btn_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estado.Location = new System.Drawing.Point(666, 12);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(167, 51);
            this.btn_estado.TabIndex = 151;
            this.btn_estado.Text = "       Cambiar estado";
            this.btn_estado.UseVisualStyleBackColor = true;
            this.btn_estado.Visible = false;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // btn_facturar
            // 
            this.btn_facturar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.ForeColor = System.Drawing.Color.Silver;
            this.btn_facturar.Image = ((System.Drawing.Image)(resources.GetObject("btn_facturar.Image")));
            this.btn_facturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_facturar.Location = new System.Drawing.Point(442, 101);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(167, 51);
            this.btn_facturar.TabIndex = 148;
            this.btn_facturar.Text = "   Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // dtp_fecha_hoy
            // 
            this.dtp_fecha_hoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_fecha_hoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_hoy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_hoy.Location = new System.Drawing.Point(305, 268);
            this.dtp_fecha_hoy.Name = "dtp_fecha_hoy";
            this.dtp_fecha_hoy.Size = new System.Drawing.Size(236, 49);
            this.dtp_fecha_hoy.TabIndex = 155;
            // 
            // numero
            // 
            this.numero.HeaderText = "#";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "CLIENTE";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 250;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Width = 120;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 120;
            // 
            // METODO
            // 
            this.METODO.HeaderText = "METODO";
            this.METODO.Name = "METODO";
            this.METODO.ReadOnly = true;
            this.METODO.Width = 120;
            // 
            // MONTO
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.MONTO.DefaultCellStyle = dataGridViewCellStyle2;
            this.MONTO.HeaderText = "PAGADO";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            this.MONTO.Width = 150;
            // 
            // RESTANTE
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.RESTANTE.DefaultCellStyle = dataGridViewCellStyle3;
            this.RESTANTE.HeaderText = "RESTANTE";
            this.RESTANTE.Name = "RESTANTE";
            this.RESTANTE.ReadOnly = true;
            this.RESTANTE.Width = 150;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "nombre";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle4;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 220;
            // 
            // idcita
            // 
            this.idcita.HeaderText = "idcita";
            this.idcita.Name = "idcita";
            this.idcita.ReadOnly = true;
            this.idcita.Visible = false;
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "idcliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            this.idcliente.Visible = false;
            // 
            // FechaC
            // 
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.FechaC.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaC.HeaderText = "Fecha de Cita";
            this.FechaC.Name = "FechaC";
            this.FechaC.ReadOnly = true;
            this.FechaC.Width = 200;
            // 
            // sesion
            // 
            this.sesion.HeaderText = "sesion";
            this.sesion.Name = "sesion";
            this.sesion.ReadOnly = true;
            // 
            // form_vista_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1346, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_citas);
            this.Controls.Add(this.dtp_fecha_hoy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_vista_cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_vista_cita";
            this.Load += new System.EventHandler(this.Form_vista_cita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).EndInit();
            this.txt_rnc.ResumeLayout(false);
            this.txt_rnc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_citas;
        private System.Windows.Forms.Panel txt_rnc;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_finalizada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_agendada;
        private System.Windows.Forms.Label lb_hoy;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hoy;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn METODO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESTANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcita;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesion;
    }
}