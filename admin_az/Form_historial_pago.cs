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
    public partial class Form_historial_pago : Form
    {
        public int idcxp;
        public Form_historial_pago()
        {
            InitializeComponent();
        }
        public void listarcuentasCXP()
        {
            using (softcitaEntities db = new softcitaEntities())
            {
                pagocxpBindingSource.DataSource = db.pago_cxp.ToList().Where(x => x.idcxc == idcxp);
                int cantidad = db.pago_cxp.Count(x => x.idcxc == idcxp);
                if (cantidad <= 0)
                {
                    pagocxpBindingSource.Clear();
                }

            }
        }
        public void contarcita()
        {
            try
            {
                //Contar clientes 
                int totalfilas = dgv_citas.Rows.Count;
                lb_cantidad.Text = totalfilas.ToString();

                double totalcliente = 0.00; totalcliente = dgv_citas.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[3].Value));
                lb_pendientes.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(lb_pendientes.Text, out Tpago2))
                    lb_pendientes.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //contar dependientes

            }
            catch { }

        }
        private void Form_historial_pago_Load(object sender, EventArgs e)
        {
            listarcuentasCXP();
            contarcita();
        }
    }
}
