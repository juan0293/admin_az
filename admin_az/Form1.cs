using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace admin_az
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mover pantalla de la pc
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btn_slide_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void btn_slide_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btn_slide_Click(object sender, EventArgs e)
        {
            if (menuStrip.Visible == true)
            {
                menuStrip.Visible = false;
            }

            else if (menuStrip.Visible == false)
            {
                menuStrip.Visible = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de cerrar?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {

            }
            
        }

        private void btn_espandir_Click(object sender, EventArgs e)
        {
            if (this.Width ==1300 && this.Height == 788)
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                
                btn_minimizar.Visible = true;
            }

            else
            {

                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1300, 788);
                btn_minimizar.Visible = true;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btn_espandir.Visible = true;
            btn_minimizar.Visible = true;
        }

        private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
          
        }

        //Objecto mostrar panel 
        public  void AbrirFormInpanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
           
        }
        public void dato()
        {
            lbusuario.Text = Global.nombre;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            mostrarlogo();
            dato();
            acceso();
         

        }

        // objecto mostrar logo
        private void mostrarlogo()
        {
            Form_Agenda frm = new Form_Agenda();
            AbrirFormInpanel(frm); 
        }

        // objecto mostrar logo
        private void mostrarlogocerrarform(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {
            Form_addusuario frm = new Form_addusuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void btn_instalacion_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
           
        }

        private void panel_titulo_Paint(object sender, PaintEventArgs e)
        {
           
        }

      
        private void btninicio_Click(object sender, EventArgs e)
        {

        }

        private void cierresDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*addcliente frm = new addcliente();
           frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

           AbrirFormInpanel(frm);
       */

            form_listaUsuario frm = new form_listaUsuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void menustri_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }

        private void descuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addusuario frm = new Form_addusuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_listaUsuario frm = new form_listaUsuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_newcliente frm = new Form_newcliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {

        }

        private void btn_averias_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Agenda frm = new Form_Agenda();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {

        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listaCliente frm = new Form_listaCliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnProducto_Click_1(object sender, EventArgs e)
        {
          
        }

        private void BtnProducto_Click_2(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            //Form_producto frm = new Form_producto();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            //AbrirFormInpanel(frm);
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            Form_newcliente frm = new Form_newcliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
           


        }

        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {
            Form_Agenda frm = new Form_Agenda();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            Form_listaCliente frm = new Form_listaCliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            Form_listaCliente frm = new Form_listaCliente();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void historialDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
            //Form_proveedor frm = new Form_proveedor();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            //AbrirFormInpanel(frm);
        }

        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de cerrar?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {

            }
        }

        private void buscarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetalleCita frm = new FormDetalleCita();
          ///*  frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarfor*/);

            frm.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Agenda frm = new Form_Agenda();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }

        private void toolStripMenuItem55_Click(object sender, EventArgs e)
        {
            Form_addusuario frm = new Form_addusuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
        }

        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        {
            form_listaUsuario frm = new form_listaUsuario();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
        }

        private void cuadrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cuadre frm = new Form_cuadre();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
        }

        private void reimprimirCuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCuadreR frm = new FormCuadreR();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
           
        }

        private void reimprimirCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormcCitaR frm = new FormcCitaR();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {
            FormReporteM frm = new FormReporteM();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);
            AbrirFormInpanel(frm);
        }

        public void acceso()
        {
            if (Global.tipoUsuario == "2")
            {
                tosfinanza.Visible = false;
                tosajuste.Visible = false;
            }
        }
        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            Form_Agenda frm = new Form_Agenda();
            frm.FormClosed += new FormClosedEventHandler(mostrarlogocerrarform);

            AbrirFormInpanel(frm);
        }
    }
}
