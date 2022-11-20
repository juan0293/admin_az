namespace admin_az
{
    partial class Form_new_cxccs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_new_cxccs));
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.detalle = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_grande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_monto
            // 
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(16, 92);
            this.txt_monto.MaxLength = 11;
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(233, 26);
            this.txt_monto.TabIndex = 155;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(283, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 159;
            this.label4.Text = "Fecha de Pago.:";
            // 
            // dtpfecha_nacimiento
            // 
            this.dtpfecha_nacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpfecha_nacimiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha_nacimiento.Location = new System.Drawing.Point(287, 38);
            this.dtpfecha_nacimiento.Name = "dtpfecha_nacimiento";
            this.dtpfecha_nacimiento.Size = new System.Drawing.Size(233, 26);
            this.dtpfecha_nacimiento.TabIndex = 156;
            // 
            // detalle
            // 
            this.detalle.AutoSize = true;
            this.detalle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalle.ForeColor = System.Drawing.Color.Silver;
            this.detalle.Location = new System.Drawing.Point(12, 70);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(64, 19);
            this.detalle.TabIndex = 158;
            this.detalle.Text = "Monto*";
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cliente.ForeColor = System.Drawing.Color.Silver;
            this.lb_cliente.Location = new System.Drawing.Point(8, 19);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(92, 19);
            this.lb_cliente.TabIndex = 157;
            this.lb_cliente.Text = "Proveedor*";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(12, 41);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 26);
            this.txtnombre.TabIndex = 154;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(311, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 161;
            this.button1.Text = "   Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_grande
            // 
            this.btn_grande.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_grande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grande.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grande.ForeColor = System.Drawing.Color.Silver;
            this.btn_grande.Image = ((System.Drawing.Image)(resources.GetObject("btn_grande.Image")));
            this.btn_grande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grande.Location = new System.Drawing.Point(162, 143);
            this.btn_grande.Name = "btn_grande";
            this.btn_grande.Size = new System.Drawing.Size(131, 40);
            this.btn_grande.TabIndex = 160;
            this.btn_grande.Text = "   Guardar";
            this.btn_grande.UseVisualStyleBackColor = true;
            this.btn_grande.Click += new System.EventHandler(this.btn_grande_Click);
            // 
            // Form_new_cxccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(601, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_grande);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpfecha_nacimiento);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_new_cxccs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cuentas ";
            this.Load += new System.EventHandler(this.Form_new_cxccs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpfecha_nacimiento;
        private System.Windows.Forms.Label detalle;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_grande;
        public System.Windows.Forms.Label lb_cliente;
    }
}