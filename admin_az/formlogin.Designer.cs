namespace admin_az
{
    partial class formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlogin));
            this.panellogin = new System.Windows.Forms.Panel();
            this.txt_apellido = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbentrar = new System.Windows.Forms.Label();
            this.picatras = new System.Windows.Forms.PictureBox();
            this.picentrar = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picentrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.panellogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellogin.Location = new System.Drawing.Point(0, 0);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(56, 391);
            this.panellogin.TabIndex = 0;
            // 
            // txt_apellido
            // 
            this.txt_apellido.AutoSize = true;
            this.txt_apellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.txt_apellido.Location = new System.Drawing.Point(115, 221);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 19);
            this.txt_apellido.TabIndex = 77;
            this.txt_apellido.Text = "Contraseña*";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(119, 243);
            this.txtpassword.MaxLength = 30;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '.';
            this.txtpassword.Size = new System.Drawing.Size(208, 30);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(115, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 76;
            this.label1.Text = "Usuario*";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(119, 191);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(208, 26);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.label11.Location = new System.Drawing.Point(213, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 22);
            this.label11.TabIndex = 81;
            this.label11.Text = "Salir";
            // 
            // lbentrar
            // 
            this.lbentrar.AutoSize = true;
            this.lbentrar.BackColor = System.Drawing.Color.Transparent;
            this.lbentrar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbentrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lbentrar.Location = new System.Drawing.Point(126, 332);
            this.lbentrar.Name = "lbentrar";
            this.lbentrar.Size = new System.Drawing.Size(63, 22);
            this.lbentrar.TabIndex = 79;
            this.lbentrar.Text = "Entrar";
            // 
            // picatras
            // 
            this.picatras.Image = global::admin_az.Properties.Resources.return_48px;
            this.picatras.Location = new System.Drawing.Point(213, 286);
            this.picatras.Name = "picatras";
            this.picatras.Size = new System.Drawing.Size(50, 43);
            this.picatras.TabIndex = 80;
            this.picatras.TabStop = false;
            this.picatras.Click += new System.EventHandler(this.picatras_Click);
            // 
            // picentrar
            // 
            this.picentrar.BackColor = System.Drawing.Color.White;
            this.picentrar.Image = global::admin_az.Properties.Resources.play_30px;
            this.picentrar.Location = new System.Drawing.Point(126, 286);
            this.picentrar.Name = "picentrar";
            this.picentrar.Size = new System.Drawing.Size(63, 43);
            this.picentrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picentrar.TabIndex = 78;
            this.picentrar.TabStop = false;
            this.picentrar.Click += new System.EventHandler(this.picentrar_Click);
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(141, 21);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(162, 145);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 1;
            this.piclogo.TabStop = false;
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(414, 391);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picatras);
            this.Controls.Add(this.lbentrar);
            this.Controls.Add(this.picentrar);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.panellogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formlogin";
            this.Load += new System.EventHandler(this.formlogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formlogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picentrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label txt_apellido;
        public System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picatras;
        private System.Windows.Forms.Label lbentrar;
        private System.Windows.Forms.PictureBox picentrar;
    }
}