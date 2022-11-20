namespace admin_az
{
    partial class Form_add_pago_cxc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_pago_cxc));
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pagado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtp_fecha_sesion = new System.Windows.Forms.DateTimePicker();
            this.lb_sesion = new System.Windows.Forms.Label();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(70, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 32);
            this.label6.TabIndex = 141;
            this.label6.Text = "Total A Pagar:";
            // 
            // txt_pagado
            // 
            this.txt_pagado.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pagado.Location = new System.Drawing.Point(76, 246);
            this.txt_pagado.MaxLength = 30;
            this.txt_pagado.Name = "txt_pagado";
            this.txt_pagado.Size = new System.Drawing.Size(339, 83);
            this.txt_pagado.TabIndex = 140;
            this.txt_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(80, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 32);
            this.label9.TabIndex = 142;
            this.label9.Text = "Monto Pagado:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(76, 116);
            this.txtTotal.MaxLength = 30;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(339, 83);
            this.txtTotal.TabIndex = 139;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(249, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 51);
            this.button1.TabIndex = 144;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(76, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 51);
            this.button2.TabIndex = 143;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtp_fecha_sesion
            // 
            this.dtp_fecha_sesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_fecha_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_sesion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_sesion.Location = new System.Drawing.Point(76, 31);
            this.dtp_fecha_sesion.Name = "dtp_fecha_sesion";
            this.dtp_fecha_sesion.Size = new System.Drawing.Size(327, 38);
            this.dtp_fecha_sesion.TabIndex = 154;
            this.dtp_fecha_sesion.Visible = false;
            // 
            // lb_sesion
            // 
            this.lb_sesion.AutoSize = true;
            this.lb_sesion.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sesion.ForeColor = System.Drawing.Color.Silver;
            this.lb_sesion.Location = new System.Drawing.Point(76, 3);
            this.lb_sesion.Name = "lb_sesion";
            this.lb_sesion.Size = new System.Drawing.Size(179, 25);
            this.lb_sesion.TabIndex = 155;
            this.lb_sesion.Text = "Proxima sesión  :";
            this.lb_sesion.Visible = false;
            // 
            // picBarcode
            // 
            this.picBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBarcode.Image = ((System.Drawing.Image)(resources.GetObject("picBarcode.Image")));
            this.picBarcode.Location = new System.Drawing.Point(440, 240);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(122, 133);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarcode.TabIndex = 157;
            this.picBarcode.TabStop = false;
            this.picBarcode.Visible = false;
            // 
            // piclogo
            // 
            this.piclogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.piclogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(440, 95);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(122, 133);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 156;
            this.piclogo.TabStop = false;
            this.piclogo.Visible = false;
            // 
            // Form_add_pago_cxc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(471, 455);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.lb_sesion);
            this.Controls.Add(this.dtp_fecha_sesion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pagado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_add_pago_cxc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_add_pago_cxc";
            this.Load += new System.EventHandler(this.Form_add_pago_cxc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_pagado;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtp_fecha_sesion;
        private System.Windows.Forms.Label lb_sesion;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}