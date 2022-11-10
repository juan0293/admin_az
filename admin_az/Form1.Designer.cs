namespace admin_az
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.btn_slide = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_espandir = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimprimirCuadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tosfinanza = new System.Windows.Forms.ToolStripMenuItem();
            this.reimprimirCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tosajuste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_slide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_espandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.panel_titulo.Controls.Add(this.btn_slide);
            this.panel_titulo.Controls.Add(this.btn_minimizar);
            this.panel_titulo.Controls.Add(this.btn_espandir);
            this.panel_titulo.Controls.Add(this.btn_close);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(1300, 50);
            this.panel_titulo.TabIndex = 1;
            this.panel_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_titulo_Paint);
            this.panel_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseDown);
            // 
            // btn_slide
            // 
            this.btn_slide.BackColor = System.Drawing.Color.White;
            this.btn_slide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_slide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_slide.Image = ((System.Drawing.Image)(resources.GetObject("btn_slide.Image")));
            this.btn_slide.Location = new System.Drawing.Point(0, 0);
            this.btn_slide.Name = "btn_slide";
            this.btn_slide.Size = new System.Drawing.Size(63, 50);
            this.btn_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_slide.TabIndex = 0;
            this.btn_slide.TabStop = false;
            this.btn_slide.Click += new System.EventHandler(this.btn_slide_Click);
            this.btn_slide.MouseEnter += new System.EventHandler(this.btn_slide_MouseEnter);
            this.btn_slide.MouseLeave += new System.EventHandler(this.btn_slide_MouseLeave);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.White;
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1171, 9);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(35, 35);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Visible = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_espandir
            // 
            this.btn_espandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_espandir.BackColor = System.Drawing.Color.White;
            this.btn_espandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_espandir.Image = global::admin_az.Properties.Resources.full_screen_64px;
            this.btn_espandir.Location = new System.Drawing.Point(1212, 9);
            this.btn_espandir.Name = "btn_espandir";
            this.btn_espandir.Size = new System.Drawing.Size(35, 35);
            this.btn_espandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_espandir.TabIndex = 1;
            this.btn_espandir.TabStop = false;
            this.btn_espandir.Click += new System.EventHandler(this.btn_espandir_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::admin_az.Properties.Resources.shutdown_40px;
            this.btn_close.Location = new System.Drawing.Point(1253, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(50, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem31,
            this.toolStripMenuItem32,
            this.toolStripMenuItem40,
            this.toolStripMenuItem41,
            this.tosajuste,
            this.toolStripMenuItem60});
            this.menuStrip.Location = new System.Drawing.Point(0, 50);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1300, 48);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem31.Image = global::admin_az.Properties.Resources.home_40px;
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(133, 44);
            this.toolStripMenuItem31.Text = "    Inicio";
            this.toolStripMenuItem31.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem31.Click += new System.EventHandler(this.toolStripMenuItem31_Click);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem32.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem33,
            this.toolStripMenuItem34});
            this.toolStripMenuItem32.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem32.Image = global::admin_az.Properties.Resources.person_40px;
            this.toolStripMenuItem32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(128, 44);
            this.toolStripMenuItem32.Text = "Cliente";
            this.toolStripMenuItem32.Click += new System.EventHandler(this.toolStripMenuItem32_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItem33.Text = "Nuevo Cliente";
            this.toolStripMenuItem33.Click += new System.EventHandler(this.toolStripMenuItem33_Click);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItem34.Text = "Lista de Clientes";
            this.toolStripMenuItem34.Click += new System.EventHandler(this.toolStripMenuItem34_Click);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.buscarCitaToolStripMenuItem});
            this.toolStripMenuItem40.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem40.Image = global::admin_az.Properties.Resources.calendar_plus_40px;
            this.toolStripMenuItem40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(133, 44);
            this.toolStripMenuItem40.Text = "Agenda";
            this.toolStripMenuItem40.Click += new System.EventHandler(this.toolStripMenuItem40_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // buscarCitaToolStripMenuItem
            // 
            this.buscarCitaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.buscarCitaToolStripMenuItem.Name = "buscarCitaToolStripMenuItem";
            this.buscarCitaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.buscarCitaToolStripMenuItem.Text = "Buscar Cita";
            this.buscarCitaToolStripMenuItem.Click += new System.EventHandler(this.buscarCitaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadrarCajaToolStripMenuItem,
            this.tosfinanza,
            this.reimprimirCitaToolStripMenuItem});
            this.toolStripMenuItem41.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem41.Image = global::admin_az.Properties.Resources.investment_portfolio_40px;
            this.toolStripMenuItem41.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(138, 44);
            this.toolStripMenuItem41.Text = "Informe";
            // 
            // cuadrarCajaToolStripMenuItem
            // 
            this.cuadrarCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reimprimirCuadreToolStripMenuItem});
            this.cuadrarCajaToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadrarCajaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.cuadrarCajaToolStripMenuItem.Name = "cuadrarCajaToolStripMenuItem";
            this.cuadrarCajaToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.cuadrarCajaToolStripMenuItem.Text = "Cuadrar caja";
            this.cuadrarCajaToolStripMenuItem.Click += new System.EventHandler(this.cuadrarCajaToolStripMenuItem_Click);
            // 
            // reimprimirCuadreToolStripMenuItem
            // 
            this.reimprimirCuadreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.reimprimirCuadreToolStripMenuItem.Name = "reimprimirCuadreToolStripMenuItem";
            this.reimprimirCuadreToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.reimprimirCuadreToolStripMenuItem.Text = "Reimprimir Cuadre";
            this.reimprimirCuadreToolStripMenuItem.Click += new System.EventHandler(this.reimprimirCuadreToolStripMenuItem_Click);
            // 
            // tosfinanza
            // 
            this.tosfinanza.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosfinanza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.tosfinanza.Name = "tosfinanza";
            this.tosfinanza.Size = new System.Drawing.Size(188, 24);
            this.tosfinanza.Text = "Finanzas";
            this.tosfinanza.Click += new System.EventHandler(this.toolStripMenuItem42_Click);
            // 
            // reimprimirCitaToolStripMenuItem
            // 
            this.reimprimirCitaToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reimprimirCitaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.reimprimirCitaToolStripMenuItem.Name = "reimprimirCitaToolStripMenuItem";
            this.reimprimirCitaToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.reimprimirCitaToolStripMenuItem.Text = "Reimprimir Cita";
            this.reimprimirCitaToolStripMenuItem.Click += new System.EventHandler(this.reimprimirCitaToolStripMenuItem_Click);
            // 
            // tosajuste
            // 
            this.tosajuste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem54});
            this.tosajuste.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosajuste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.tosajuste.Image = global::admin_az.Properties.Resources.settings_40px1;
            this.tosajuste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tosajuste.Name = "tosajuste";
            this.tosajuste.Size = new System.Drawing.Size(139, 44);
            this.tosajuste.Text = "  Ajustes";
            this.tosajuste.Click += new System.EventHandler(this.toolStripMenuItem53_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem55});
            this.toolStripMenuItem54.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(140, 24);
            this.toolStripMenuItem54.Text = "Usuarios";
            this.toolStripMenuItem54.Click += new System.EventHandler(this.toolStripMenuItem54_Click);
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(183, 24);
            this.toolStripMenuItem55.Text = "Agregar Nuevo";
            this.toolStripMenuItem55.Click += new System.EventHandler(this.toolStripMenuItem55_Click);
            // 
            // toolStripMenuItem60
            // 
            this.toolStripMenuItem60.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.toolStripMenuItem60.Image = global::admin_az.Properties.Resources.shutdown_40px1;
            this.toolStripMenuItem60.Name = "toolStripMenuItem60";
            this.toolStripMenuItem60.Size = new System.Drawing.Size(102, 44);
            this.toolStripMenuItem60.Text = "Salir";
            this.toolStripMenuItem60.Click += new System.EventHandler(this.toolStripMenuItem60_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 675);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(1080, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sr ( a ):";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lbusuario.Location = new System.Drawing.Point(1183, 194);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(0, 25);
            this.lbusuario.TabIndex = 6;
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lbhora.Location = new System.Drawing.Point(1116, 465);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(90, 32);
            this.lbhora.TabIndex = 7;
            this.lbhora.Text = "Sr ( a )";
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1086, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_slide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_espandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.PictureBox btn_slide;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_espandir;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41;
        private System.Windows.Forms.ToolStripMenuItem tosfinanza;
        private System.Windows.Forms.ToolStripMenuItem tosajuste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem54;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem55;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem60;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem buscarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadrarCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimprimirCuadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimprimirCitaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

