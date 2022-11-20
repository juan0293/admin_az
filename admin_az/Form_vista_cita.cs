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
    public partial class form_vista_cita : Form
    {
        Panel panelcontrol = Global.Panel1;
        public form_vista_cita()
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
                    //agendada = lst;
                   lb_agendada.Text = lst.ToString();
                }

            }

            catch { }
        }
        public void listarfinalizada()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.idestado ==1 && o.fecha ==fecha || o.fechaCita == fecha);
                    lb_finalizada.Text = lst.ToString();
                
                   
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
                    var lst = db.View_Cliente.ToList().Where(f=> f.fecha == fecha || f.fechaCita ==fecha);
                    foreach (var ocita in lst)
                    {
                        dgv_citas.Rows.Add(dgv_citas.RowCount +1, ocita.nombre + " " + ocita.apellido, ocita.telefono, ocita.codigo, ocita.estado, ocita.metodo, ocita.montopagado, ocita.resta, ocita.fecha, ocita.idcita, ocita.idcliente, ocita.fechaCita, ocita.cantidad_sesion);


                    }

                }

            }

            catch { }
        }
        public void Listarhoy()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.fecha ==fecha);
                    lb_hoy.Text = lst.ToString();
                }

            }

            catch { }
        }
        public void Listarcantidad()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    DateTime fecha = Convert.ToDateTime(dtp_fecha.Text);
                    int lst = db.View_Cliente.Count(o => o.fechaCita == fecha || o.fecha == fecha);
                    lb_cantidad.Text = lst.ToString();
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
                    var  lst = db.facturas.Where(o => o.fecha == fecha).Sum(s=> s.monto);

                    lb_total.Text = Convert.ToDecimal(lst).ToString("#,##0.00");
                }

            }

            catch { }
        }

        public void cargarDatoss()
        {
            Listaragendada();
            Listarhoy();
            Listarcantidad();
            ListarTotal();
         
            listarfinalizada();
        }
        public void eventoestado()
        {
            try
            {
                foreach (DataGridViewRow row in dgv_citas.Rows)
                {
                    DateTime hoy = Convert.ToDateTime(dtp_fecha_hoy.Text);
                    DateTime Fecha =Convert.ToDateTime(row.Cells[8].Value);



                    if (Fecha ==hoy)
                    {
                        //row.Cells[1].Value = "Pendiente";


                        row.DefaultCellStyle.ForeColor = Color.Green;



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
            ListarCita();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void Formadd_pasado(string dato)
        {
            ListarCita();
            cargarDatoss();
        }
        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                {
                    Form_add_pago_cxc open = new Form_add_pago_cxc();

                    if(Convert.ToDouble(row.Cells[7].Value) <0)
                    {
                        MessageBox.Show("El cliente no presenta monto pendiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        open.txtTotal.Text = Convert.ToDecimal(row.Cells[7].Value).ToString("#,##0.00");
                        open.txt_pagado.Text = Convert.ToDecimal(row.Cells[7].Value).ToString("#,##0.00");
                        open.opcion = "3";
                        open.telefono = row.Cells[9].Value.ToString();
                        open.cantidad_sesion = Convert.ToInt32(row.Cells[12].Value);
                        open.idcita = Convert.ToInt32(row.Cells[9].Value);
                        open.idcliente = Convert.ToInt32(row.Cells[10].Value);

                        open.cliente = row.Cells[1].Value.ToString();
                        open.pasado += Formadd_pasado;
                        open.ShowDialog();
                    }
                   

                }

            }
            catch { }
        }

        private void Form_vista_cita_Load(object sender, EventArgs e)
        {
           if(Global.tipoUsuario =="1")
            {
                btn_anular.Visible = true;
            }

            else
            {
                btn_anular.Visible = false;
            }
            ListarCita();
            cargarDatoss();
        }
    }
}
