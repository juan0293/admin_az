using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_az
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }
        public void user()
        {
            try
            {

                if (string.IsNullOrEmpty(txtnombre.Text))
                {
                    // check voor invoeren van wachtwoord en email.
                    MessageBox.Show("Por favor completar campo Usuario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnombre.Focus();
                    return;
                }
                var login = new acceso();
                string nombre_user, password;

                nombre_user = txtnombre.Text;
                password = txtpassword.Text;

                if (!login.login(nombre_user, password))
                {
                    MessageBox.Show("Contraseña o Usuario Incorrecto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var menu = new Form_new_menu();
                    menu.Show();
                    this.Hide();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void picatras_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }

        private void picentrar_Click(object sender, EventArgs e)
        {
           
        }

        private void formlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                user();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            user();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
