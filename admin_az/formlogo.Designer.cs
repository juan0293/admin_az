namespace admin_az
{
    partial class formlogo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pib_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::admin_az.Properties.Resources.logo_del_software;
            this.pictureBox1.Location = new System.Drawing.Point(411, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pib_logo
            // 
            this.pib_logo.BackColor = System.Drawing.Color.White;
            this.pib_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pib_logo.Location = new System.Drawing.Point(0, 0);
            this.pib_logo.Name = "pib_logo";
            this.pib_logo.Size = new System.Drawing.Size(1050, 670);
            this.pib_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pib_logo.TabIndex = 0;
            this.pib_logo.TabStop = false;
            this.pib_logo.Click += new System.EventHandler(this.pib_logo_Click);
            // 
            // formlogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pib_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formlogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formlogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pib_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}