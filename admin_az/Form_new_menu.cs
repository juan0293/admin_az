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
    public partial class Form_new_menu : Form
    {
        public Form_new_menu()
        {
            InitializeComponent();
            hideSubMenu();
            //openChildForm(new Form_Agenda());
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panel_ajustes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Form_new_menu_Load(object sender, EventArgs e)
        {
            Global.Panel1 = panelChildForm;

            panelChildForm.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void btnajustes_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_ajustes);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form_Agenda());

            //..
            //your codes
            //..
            Form_Agenda abrir = new Form_Agenda();
            abrir.Show();
            hideSubMenu();
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_newcliente open = new Form_newcliente();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void btn_lista_cliente_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_listaCliente open = new Form_listaCliente();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
          
        }

        private void btn_agendar_cita_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_listaCliente open = new Form_listaCliente();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_vista_cita open = new Form_vista_cita();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panelChildForm.Controls.Clear();
            FormDetalleCita open = new FormDetalleCita();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            FormcCitaR open = new FormcCitaR();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
            
        }
    }
}
