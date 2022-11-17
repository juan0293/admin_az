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
    public partial class Form_cxc : Form
    {
        public Form_cxc()
        {
            InitializeComponent();
        }

        public void Formadd_pasado(string dato)
        {
            cargarDatos();
        }
        public void ListarCita()
        {
            try
            {

                DateTime startDate = Convert.ToDateTime(dtp_fecha_inicio.Text);
                DateTime endDate = Convert.ToDateTime(dtp_fecha_fin.Text);
                using (softcitaEntities db = new softcitaEntities())

                {

                    cuentaCXCBindingSource.Clear();
                    cuentaCXCBindingSource.DataSource = db.cuentaCXCs.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate );

                }

            }

            catch { }
        }
        public void eventoestado()
        {
            try
            {
                foreach (DataGridViewRow row in dgv_citas.Rows)
                {

                    bool estado = Convert.ToBoolean(row.Cells[5].Value);



                    if (estado == true)
                    {
                        //row.Cells[1].Value = "Pendiente";


                        row.DefaultCellStyle.ForeColor = Color.Red;



                    }
                    if (estado ==false)
                    {
                        //row.Cells[1].Value = "Pagada";
                        row.DefaultCellStyle.ForeColor = Color.Blue;



                    }

                   
                }

            }
            catch { }
        }

        public void anular()
        {
            try
            {


                using (softcitaEntities db = new softcitaEntities())

                {

                    foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                    {

                        int idcita = Convert.ToInt32(row.Cells[0].Value);
                        cuentaCXC ocxc = db.cuentaCXCs.Find(idcita);
                        db.Entry(ocxc).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                      
                        ListarCita();



                    }
                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }
        }
        public void pagar()
        {
            try
            {


                using (softcitaEntities db = new softcitaEntities())

                {

                    foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                    {

                        int idcita = Convert.ToInt32(row.Cells[0].Value);
                        cuentaCXC ocxc = db.cuentaCXCs.Find(idcita);
                        ocxc.estado = false;
                        db.Entry(ocxc).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        cargarDatos();



                    }
                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }
        }
        private void Form_cxc_Load(object sender, EventArgs e)
        {
            dtp_fecha_inicio.Select();
            DateTime date = DateTime.Now;
            DateTime oPrimerDiaDelMes = new DateTime(date.Year, date.Month, 1);
            DateTime oUltimoDiaDelMes = oPrimerDiaDelMes.AddMonths(1).AddDays(-1);
            dtp_fecha_inicio.Value = oPrimerDiaDelMes;
            dtp_fecha_fin.Value = oUltimoDiaDelMes;
            cargarDatos();
        }
        public void cargarDatos()
        {
            ListarCita();
            listarpagada();
            ListarPendientes();
            lb_cantidad.Text = dgv_citas.RowCount.ToString();
        } 
        public void ListarPendientes()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime startDate = Convert.ToDateTime(dtp_fecha_inicio.Text);
                    DateTime endDate = Convert.ToDateTime(dtp_fecha_fin.Text);
                   
                    var lst = db.cuentaCXCs.Where(f => f.fecha >= startDate && f.fecha <= endDate && f.estado ==true).Sum(s => s.monto);

                    lb_pendientes.Text = Convert.ToDecimal(lst).ToString("#,##0.00");
                }

            }

            catch { }
        }
        public void listarpagada()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime startDate = Convert.ToDateTime(dtp_fecha_inicio.Text);
                    DateTime endDate = Convert.ToDateTime(dtp_fecha_fin.Text);

                    var lst = db.cuentaCXCs.Where(f => f.fecha >= startDate && f.fecha <= endDate && f.estado == false).Sum(s => s.monto);

                    lb_finalizada.Text = Convert.ToDecimal(lst).ToString("#,##0.00");
                }

            }

            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anular();
        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            pagar();
        }

        private void dtp_fecha_fin_ValueChanged(object sender, EventArgs e)
        {
            
            cargarDatos();
        }

        private void dgv_citas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            eventoestado();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            Form_new_cxccs formadd = new Form_new_cxccs();
            formadd.pasado += Formadd_pasado;
            formadd.ShowDialog();
        }
    }
}
