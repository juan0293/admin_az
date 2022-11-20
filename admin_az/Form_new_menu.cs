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
            acceso();
            Global.Panel1 = panelChildForm;

            panelChildForm.Controls.Clear();
            form_vista_cita open = new form_vista_cita();
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
            form_vista_cita open = new form_vista_cita();
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

        private void btn_finanza_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            FormReporteM open = new FormReporteM();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            form_listaUsuario open = new form_listaUsuario();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_addusuario open = new Form_addusuario();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_Reporte_pago open = new Form_Reporte_pago();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_porcentaje open = new Form_porcentaje();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            FormCuadreR open = new FormCuadreR();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void btn_cxc_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_cxc open = new Form_cxc();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }
        public void acceso()
        {
            if (Global.tipoUsuario == "2")
            {
               btnajustes.Enabled = false;
                btnreport.Enabled = false;
            }

            if (Global.tipoUsuario == "3")
            {
                btnajustes.Enabled = false;
                btn_finanza.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_Artista open = new Form_Artista();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void btn_cxc_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_cxc open = new Form_cxc();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_cuadre open = new Form_cuadre();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            Form_cuenta__cobrar open = new Form_cuenta__cobrar();
            open.TopLevel = false;
            panelChildForm.Controls.Add(open);
            open.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Por favor confirme antes de continuar" + "\n" + "Quieres continuar ?", "            SEGURO QUE DESEA ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }

            else

            {
                //do something if NO
            }
        }
    }
}
