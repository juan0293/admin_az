using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_az
{
    public partial class form_finalizar : Form
    {
        
        public form_finalizar()
        {
            InitializeComponent();
        }

        public int idcita, metodoID;
        public string detalle, cliente, fechacita,hora, idcliente;
        public double resultado = 0;
        public void guardar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    factura ocita = new factura();                 
                    ocita.idusuer = Convert.ToInt32(Global.idusuario);
                    ocita.idcita = idcita;
                    ocita.idmetodo = metodoID;
                    ocita.monto = Convert.ToDouble(txt_pagado.Text);
                    ocita.fecha = DateTime.Now;
                    db.facturas.Add(ocita);
                    db.SaveChanges();
                    MessageBox.Show("Datos Almacenados!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
            }
            catch { }
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
        public void updateestado()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    cita ocita = db.citas.Find(idcita);

                    ocita.idestado = 1;

                    db.Entry(ocita).State = EntityState.Modified;
                    db.SaveChanges();
                   

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void factura()
        {
            Formterminar fat = new Formterminar();
            Datos dat = new Datos();
            dat.idcita = idcita.ToString();
            dat.telefono = idcliente.ToString();
            dat.Usuario = Global.nombre;
            dat.nombre = cliente.ToString();
            dat.fecha = DateTime.Now.ToString();
            dat.tipodepago = cbo_metodo.Text;
            dat.totalpagado = txt_pagado.Text;
            dat.total = txtTotal.Text;
            dat.restante = resultado.ToString();
            fat.datos.Add(dat);
            fat.Show();

        }
        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        private void pic_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void form_finalizar_Load(object sender, EventArgs e)
        {
            ListarMetodo();
        }

        private void cbo_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIDMetodo();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void picregresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_pagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                double montopagado = Convert.ToDouble(txt_pagado.Text);
                double montoapagar = Convert.ToDouble(txtTotal.Text);
                resultado = montoapagar - montopagado;
                if(montopagado < montoapagar)
                {
                    MessageBox.Show("El monto pagado debe de ser mayor o igual para finalizar!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_pagado.Clear();
                }


               else if (montopagado >= montoapagar)
                {
                    if (cbo_metodo.Text == "")
                    {
                        MessageBox.Show("Por selecionar metodo de pago", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        updateestado();
                        guardar();
                        factura();
                        Close();
                       
                    }
                   
                }

            }
            catch { MessageBox.Show("Por favor seleccionar metodo de pago","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}
