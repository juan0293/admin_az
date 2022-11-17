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
    public partial class Form_Reporte_pago : Form
    {
        public int idartista;
        public double porcentaje;
        public Form_Reporte_pago()
        {
            InitializeComponent();
        }
        public void ListarArtista()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.artistas.ToList();
                    foreach (var oartista in lst)
                    {
                        cbo_metodo.Items.Add(oartista.nombre);
                        

                    }

                }

            }

            catch { }
        }
        public void contarcita()
        {
            try
            {
                //Contar clientes 
                int totalfilas = dgvreporte.Rows.Count;
                txttrabajos.Text = totalfilas.ToString();

                double totalcliente = 0.00; totalcliente = dgvreporte.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[4].Value));
                txt_bruto.Text = Convert.ToDecimal(totalcliente).ToString("#,##0.00");

                double montoPagar = totalcliente * porcentaje / 100;
                txt_total.Text = Convert.ToDecimal(montoPagar).ToString("#,##0.00");

                //contar dependientes

            }
            catch { }

        }
        public void ListarIDartista()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.artistas.ToList().Where(m => m.nombre == cbo_metodo.Text);
                    foreach (var oartista in lst)
                    {
                        idartista = oartista.idartista;
                        porcentaje = Convert.ToDouble(oartista.Porcentaje);
                        txt_porcentaje.Text = Convert.ToDecimal(porcentaje).ToString("#,##0.00");

                    }

                }

            }

            catch { }
        }
        public void listarreporte()
        {
            try
            {

                DateTime startDate = Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (softcitaEntities db = new softcitaEntities())

                {

                    viewhistorialBindingSource.DataSource = db.View_historial.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate && f.condicion == true && f.artista == idartista);
                    metodoppagoBindingSource.DataSource = db.metodoppagoes.ToList();

                }
            }
            catch { }
        }
        private void Form_Reporte_pago_Load(object sender, EventArgs e)
        {
            ListarArtista();
        }

        private void cbo_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIDartista();
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            listarreporte();
            contarcita();
        }

        private void picatras_Click(object sender, EventArgs e)
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
