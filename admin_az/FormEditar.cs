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
    public partial class FormEditar : Form
    {
        public int idcita, idcliente, metodoID;
        public double resultado;
        public FormEditar()
        {
            InitializeComponent();
        }
        public void ListarMetodo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.metodoppagoes.ToList();
                    foreach (var ometodo in lst)
                    {
                        cbo_metodo.Items.Add(ometodo.nombre);

                    }

                }

            }

            catch { }
        }
        public void ListarIDMetodo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.metodoppagoes.ToList().Where(m => m.nombre == cbo_metodo.Text);
                    foreach (var ometodo in lst)
                    {
                        metodoID = ometodo.idmetodo;

                    }

                }

            }

            catch { }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Panel panelcontrol = Global.Panel1;
            panelcontrol.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelcontrol.Controls.Add(open);
            open.Show();
        }
        public void trabajo()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    int appID = Convert.ToInt32(txt_codigo.Text);
                    var lst = db.trabajoes.Where(f => f.idcita == appID);


                    foreach (var ocita in lst)

                    {
                        dgvdescripcion.Rows.Add(ocita.idtrabajo,ocita.asunto, ocita.monto);

                    }

                }
            }
            catch { }
        }
        public void updatecita()
        {
            try
            {
                double montopagado = Convert.ToDouble(txt_pagado.Text);
                double montoapagar = Convert.ToDouble(txtTotal.Text);
                resultado = montoapagar - montopagado;
                using (softcitaEntities db = new softcitaEntities())

                    {             
                        cita ocita = db.citas.Find(idcita);
                        ocita.hora = txt_hora.Text;
                        ocita.idmetodo = metodoID;
                        ocita.monto =Convert.ToDouble(txtTotal.Text);
                        ocita.montopagado = Convert.ToDouble(txt_pagado.Text);
                        ocita.resta = resultado;
                        db.Entry(ocita).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos Actualizados");
                        Close();

                    }
                
            }
            catch {}

        }
        public void updatetrabajo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    for (int i = 0; i < dgvdescripcion.Rows.Count - 0; i++)
                    {
                         int idtrabajo =Convert.ToInt32(dgvdescripcion.Rows[i].Cells[0].Value.ToString());
                        trabajo otrabajo = db.trabajoes.Find(idtrabajo);

                        otrabajo.asunto = dgvdescripcion.Rows[i].Cells[1].Value.ToString(); 
                        otrabajo.monto = Convert.ToDouble(dgvdescripcion.Rows[i].Cells[2].Value.ToString());

                        db.Entry(otrabajo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                }
            }

            catch { }

        }
        public void factura()
        {
            Formprintcita fat = new Formprintcita();
            for (int i = 0; i < dgvdescripcion.Rows.Count - 0; i++)
            {
                Datos dat = new Datos();
                dat.idcita = idcita.ToString();
                dat.nombre = txtnombre.Text;
                dat.fechacita = dtpDate.Text;

                dat.Usuario = Global.nombre;
                dat.fecha = DateTime.Now.ToShortDateString();
                dat.asunto = dgvdescripcion.Rows[i].Cells[1].Value.ToString();
                dat.monto = dgvdescripcion.Rows[i].Cells[2].Value.ToString();
                dat.restante = resultado.ToString();
                dat.totalpagar = txtTotal.Text;
                dat.totalpagado = txt_pagado.Text;
                dat.tipodepago = cbo_metodo.Text;
                dat.hora = txt_hora.Text;

                fat.datos.Add(dat);

            }
            fat.Show();
        }
        public void siguiente()
        {
            try
            {
                double totalcliente = 0.00; totalcliente = dgvdescripcion.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[2].Value));
                txtTotal.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(txtTotal.Text, out Tpago2))
                    txtTotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);
                paneltotal.Visible = true;

            }
            catch { }

        }
        private void picbGuardar_Click(object sender, EventArgs e)
        {

            updatetrabajo();
            updatecita();
            factura();
        }

        private void picsiguiente_Click(object sender, EventArgs e)
        {
            siguiente();
            }

        private void picregresar_Click(object sender, EventArgs e)
        {
          
        }

        private void cbo_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIDMetodo();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void picFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            updatetrabajo();
            updatecita();
            factura();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            paneltotal.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            siguiente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            trabajo();
            ListarMetodo();
        }
    }
}
