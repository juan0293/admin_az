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
    public partial class Form_vista_cita : Form
    {
        Panel panelcontrol = Global.Panel1;
        public Form_vista_cita()
        {
            InitializeComponent();
        }

        public int nuevas, agendada;
        //public void listarload()
        //{
        //    try
        //    {
        //        DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
        //        using (softcitaEntities db = new softcitaEntities())

        //        {
        //            viewClienteBindingSource.Clear();
        //            viewClienteBindingSource.DataSource = db.View_Cliente.ToList();

        //        }
        //    }
        //    catch { }
        //}
        public void Listaragendada()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.fechaCita == fecha);
                    agendada = lst;
                    lb_cantidad.Text = lst.ToString();
                }

            }

            catch { }
        }
        public void listaranuladas()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.idestado ==3 && o.fecha ==fecha);
                    lb_nuevas.Text = lst.ToString();
                
                   
                }

            }

            catch { }
        }
        public void ListarCita()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    dgv_citas.Rows.Clear();
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    var lst = db.View_Cliente.ToList().Where(f=> f.fecha == fecha);
                    foreach (var ocita in lst)
                    {
                        dgv_citas.Rows.Add(dgv_citas.RowCount +1, ocita.nombre + " " + ocita.apellido, ocita.telefono, ocita.codigo, ocita.estado, ocita.metodo, ocita.montopagado, ocita.resta, ocita.fecha, ocita.idcita, ocita.idcliente);


                    }

                }

            }

            catch { }
        }
        public void Listarpendiente()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.estado == "Pendiente" && o.fecha ==fecha);
                    lb_pendientes.Text = lst.ToString();
                }

            }

            catch { }
        }
        public void Listarfinaaliza()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.estado == "Finalizada" && o.fecha == fecha);
                    lb_finalizada.Text = lst.ToString();
                }

            }

            catch { }
        }
        public void ListarTotal()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    var  lst = db.View_Cliente.Where(o => o.fecha == fecha && o.condicion ==true).Sum(s=> s.montopagado);

                    lb_total.Text = Convert.ToDecimal(lst).ToString("#,##0.00");
                }

            }

            catch { }
        }

        public void cargarDatoss()
        {
            Listaragendada();
            Listarpendiente();
            Listarfinaaliza();
            ListarTotal();
            ListarCita();
            listaranuladas();
        }
        public void eventoestado()
        {
            try
            {
                foreach (DataGridViewRow row in dgv_citas.Rows)
                {

                    string estado =Convert.ToString(row.Cells[4].Value);



                    if (estado == "Pendiente")
                    {
                        //row.Cells[1].Value = "Pendiente";


                        row.DefaultCellStyle.ForeColor = Color.Goldenrod;



                    }
                    if (estado == "Finalizada")
                    {
                        //row.Cells[1].Value = "Pagada";
                        row.DefaultCellStyle.ForeColor = Color.Green;



                    }

                    if (estado == "Anulada")
                    {
                        //row.Cells[1].Value = "Pagada";
                        row.DefaultCellStyle.ForeColor = Color.Red;



                    }
                }

            }
            catch { }
        }


        /// <summary>
        /// 
        /// </summary>
        public void upestado()
        {
            try
            {


                using (softcitaEntities db = new softcitaEntities())

                {

                    foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                    {

                        int idcita = Convert.ToInt32(row.Cells[9].Value);
                        cita ocita = db.citas.Find(idcita);

                        string estado = Convert.ToString(row.Cells[4].Value);
                        if(estado == "Pendiente")
                        {
                            ocita.idestado = 1;
                        }

                        if (estado == "Finalizada")
                        {
                            ocita.idestado = 2;
                        }



                        db.Entry(ocita).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        cargarDatoss();
                        ListarCita();



                    }
                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }
        }
        public void anular()
        {
            try
            {


                using (softcitaEntities db = new softcitaEntities())

                {

                    foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                    {

                        int idcita = Convert.ToInt32(row.Cells[9].Value);
                        cita ocita = db.citas.Find(idcita);
                        string estado = Convert.ToString(row.Cells[4].Value);
                        ocita.idestado = 3;
                        ocita.condicion = false;
                        db.Entry(ocita).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        cargarDatoss();
                        ListarCita();



                    }
                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }
        }

        private void dgv_citas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            eventoestado();
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            cargarDatoss();
        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            upestado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Por favor confirme antes de continuar" + "\n" + "Quieres continuar ?", "            SEGURO QUE DESEA ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                anular();
            }

            else

            {
                //do something if NO
            }
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            try
            {


                foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                {

                    int idcliente = Convert.ToInt32(row.Cells[10].Value);
                    string nombre = row.Cells[1].Value.ToString();
                    string codigo = row.Cells[3].Value.ToString();

             
                    panelcontrol.Controls.Clear(); 
                    frmManageAppointment cita = new frmManageAppointment();
                    cita.txt_codigo.Text = codigo;
                    cita.txtnombre.Text = nombre;
                    cita.clienteID = idcliente;
                    cita.TopLevel = false;
                    panelcontrol.Controls.Add(cita);
                    cita.Show();

                }

            }
            catch { }
        }

        private void dgv_citas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_vista_cita_Load(object sender, EventArgs e)
        {
      
            ListarCita();
            cargarDatoss();
        }
    }
}
