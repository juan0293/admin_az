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
    public partial class Form_historial : Form
    {
        public string cliente;
        public int clienteid;
        public Form_historial()
        {
            InitializeComponent();
        }
        public void operacion()
        {
            try
            {
                //Contar clientes 
               

                double totalcliente = 0.00; totalcliente = dgvreporte.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[1].Value));
                txt_total.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(txt_total.Text, out Tpago2))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //contar dependientes

            }
            catch { }

        }
        public void listar()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    viewclientehBindingSource.DataSource = db.View_cliente_h.ToList().Where(c=>  c.idcliente == clienteid);

                }
            }
            catch { }
        }
        private void Form_historial_Load(object sender, EventArgs e)
        {
            listar();
            operacion();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Panel panelcontrol = Global.Panel1;
            panelcontrol.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelcontrol.Controls.Add(open);
            open.Show();
        }
    }
}
