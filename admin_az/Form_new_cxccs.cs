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

    public partial class Form_new_cxccs : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;
        public Form_new_cxccs()
        {
            InitializeComponent();
        }

        private void Form_new_cxccs_Load(object sender, EventArgs e)
        {

        }
        public void addcxc()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    cuentaCXC ocxc = new cuentaCXC();

                    ocxc.proveedor = txtnombre.Text;
                    ocxc.monto =Convert.ToDouble(txt_monto.Text);
                    ocxc.fecha = DateTime.Now;
                    ocxc.fechaPago = Convert.ToDateTime(dtpfecha_nacimiento.Text);
                    ocxc.estado = true;
                    ocxc.usuario = Global.nombre;
                    db.cuentaCXCs.Add(ocxc);
                    db.SaveChanges();
                 


                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void guardar()
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Proveedor.");
                txtnombre.Focus();
            }
           

            else
            {

                addcxc();
                pasado(" ");
                Close();
               
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txt_monto.Clear();
          
        }

        private void btn_grande_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
