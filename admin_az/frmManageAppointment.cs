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
    public partial class frmManageAppointment : Form
    {
        public int AppID = 0;
        public int metodoID = 0;
        public int clienteID = 0;
        public int idcita, idartista, idoferta;
        public double resultado;
        public double totalcliente = 0.00;
        public string telefono, codigo, Apellido;
        public frmManageAppointment()
        {
            InitializeComponent();
        }
        public void verificar()
        {
            try
            {
                
                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.clientes.ToList().Where(c => c.codigo == txt_codigo.Text);
                    foreach (var ocliente in lst)
                    {
                        txt_codigo.Text = ocliente.codigo;
                        clienteID = ocliente.idcliente;
                        txtnombre.Text = ocliente.nombre;
                        txtapellido.Text = ocliente.apellido;
                        telefono = ocliente.telefono;
                        codigo = ocliente.codigo;
                        Apellido = ocliente.apellido;

                        clienteID = ocliente.idcliente;
                    }

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
                    var lst = db.metodoppagoes.ToList().Where(m => m.nombre == cbo_metodo.Text );
                    foreach (var ometodo in lst)
                    {
                        metodoID = ometodo.idmetodo;
                        
                    }

                }

            }

            catch { }
        }
        public void ListarIdcita()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.citas.ToList().Where(c => c.idcliente == clienteID && c.fechaCita == Convert.ToDateTime(dtpDate.Text));
                    foreach (var ocita in lst) 
                    {
                       idcita = ocita.idcita;
                      

                    }

                }

            }

            catch { }
        }
        public void siguiente()
        {
            try
            {
                 totalcliente = dgvdescripcion.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[1].Value));
                txtTotal.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(txtTotal.Text, out Tpago2))
                    txtTotal.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);
                panel1_pago.Visible = true;

            }
            catch { }

        }
        public void addcliente()
       
        {
            //try
            //{
                double montopagado = Convert.ToDouble(txt_pagado.Text);
                double montoapagar = Convert.ToDouble(txtTotal.Text);
                 resultado = montoapagar - montopagado;
               
                using (softcitaEntities db = new softcitaEntities())

                {
                    cita ocita = new cita();

                    ocita.idcliente = clienteID;
                    ocita.idestado = 2;
                    ocita.iduser = Convert.ToInt32(Global.idusuario);
                    ocita.idmetodo= metodoID;
                    ocita.fechaCita = Convert.ToDateTime(dtpDate.Text);
                    ocita.monto =Convert.ToDouble(txtTotal.Text);
                    ocita.fecha = DateTime.Now;
                    ocita.resta = resultado;
                    ocita.artista = idartista;
                    ocita.oferta = idoferta;
                    ocita.montopagado = Convert.ToDouble(txt_pagado.Text);
                    ocita.condicion = true;
                    ocita.hora =txt_hora.Text;

                    db.citas.Add(ocita);
                    db.SaveChanges();
                    idcita = ocita.idcita;
                   
                }

            //}
            //catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void factura()
        {
            Formprintcita fat = new Formprintcita();
            for (int i = 0; i < dgvdescripcion.Rows.Count - 0; i++)
            {
                Datos dat = new Datos();
                dat.idcita = idcita.ToString();
                dat.nombre = txtnombre.Text;
                dat.telefono = clienteID.ToString();
                dat.fechacita = dtpDate.Text;

                dat.Usuario = Global.nombre;
                dat.fecha = DateTime.Now.ToShortDateString();
                dat.asunto = dgvdescripcion.Rows[i].Cells[0].Value.ToString();
                dat.monto = dgvdescripcion.Rows[i].Cells[1].Value.ToString();
                dat.restante = resultado.ToString();
                dat.totalpagar= txtTotal.Text;
                dat.totalpagado = txt_pagado.Text;
                dat.tipodepago = cbo_metodo.Text;
                dat.hora = txt_hora.Text;
                dat.telefono = telefono;
                dat.codigo = codigo;
                dat.apellido = Apellido;
                fat.datos.Add(dat);
              
            }
            fat.Show();
        }
        private void frmManageAppointment_Load(object sender, EventArgs e)
        {
            //txt_hora.Format = DateTimePickerFormat.Custom;
            //txt_hora.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            //txt_hora.Format = DateTimePickerFormat.Time;
            //txt_hora.ShowUpDown = true;
          
            txtasunto.Focus();
            ListarMetodo();
            cbo_metodo.Text = "Efectivo";


        }

        //public void limpiar()
        //{
        //    txtapellido.Text = txtasunto.Text = txtnombre.Text = txtcosto.Text = txt_codigo.Text = "";

        //    paneltotal.Visible = false;
        //    txtTotal.Clear();
        //    cbo_metodo.SelectedIndex = -1;
        //    txt_pagado.Clear();
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
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
                    

                }
            }
            catch { }
        }
        public void addtrabajo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    for (int i = 0; i < dgvdescripcion.Rows.Count - 0; i++)
                    {
                        trabajo ocita = new trabajo();
                      
                        ocita.idcita = idcita;
                        ocita.asunto = dgvdescripcion.Rows[i].Cells[0].Value.ToString();
                        ocita.monto =Convert.ToDouble(dgvdescripcion.Rows[i].Cells[1].Value);
                        db.trabajoes.Add(ocita);
                        db.SaveChanges();
                    }          

                }
            }

            catch { }
         
        }
        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            verificar();
        }
        public void agregar()
        {
            double costo = Convert.ToDouble(txtcosto.Text);
            dgvdescripcion.Rows.Add(txtasunto.Text, costo);
            txtasunto.Clear();
            txtcosto.Clear();
            txtasunto.Focus();
        }
        private void picAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void picregresar_Click(object sender, EventArgs e)
        {
           
        }

        private void picsiguiente_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txt_pagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void cbo_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIDMetodo();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
          
           

           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcosto.Text))
            {
                MessageBox.Show("El costo del trabajo es requerido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtasunto.Text))
            {
                MessageBox.Show("El asunto del trabajo es requerido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                agregar();
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (dgvdescripcion.Rows.Count == 0)
            {
                MessageBox.Show("No tiene trabajo Agreado  es requerido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                siguiente();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dgvdescripcion.Rows.Remove(dgvdescripcion.CurrentRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel1_pago.Visible = false;
            txtTotal.Clear();
            cbo_metodo.SelectedIndex = -1;
            txt_pagado.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbo_metodo.Text == "")
            {
                MessageBox.Show("Por fovor seleccionar metodo de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addcliente();
               
                guardar();
                addtrabajo();
                factura();
                factura();
                telefono = "";
                Close();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1_pago.Visible = false;
            txtTotal.Clear();
            cbo_metodo.SelectedIndex = -1;
            txt_pagado.Clear();
        }

        private void picFinalizar_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarDescuento();
        }

        private void cbo_artista_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            ListarIDartista();
        }

        public void ListarArtista()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                
                    artistaBindingSource.DataSource = db.artistas.ToList();

                }

            }

            catch { }
        }

        private void cbo_artista_DropDown(object sender, EventArgs e)
        {
            ListarArtista();
        }

        private void cbo_oferta_DropDown(object sender, EventArgs e)
        {
            Listaroferta();
        }

        public void Listaroferta()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    ofertaBindingSource.DataSource = db.ofertas.ToList();
                 

                }

            }

            catch { }
        }

        public void ListarIDartista()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.artistas.ToList().Where(m => m.nombre == cbo_artista.Text);
                    foreach (var oartista in lst)
                    {
                       idartista = oartista.idartista;
                       

                    }

                }

            }

            catch { }
        }
        public void ListarDescuento()
        {
            try
            {
                double resultado = 0.00;
                double porcentaje = 0.00;
                double monto = Convert.ToDouble(txtTotal.Text);

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.ofertas.ToList().Where(m => m.titulo == cbo_oferta.Text);
                    foreach (var oferta in lst)
                    {
                        porcentaje = monto * Convert.ToDouble(oferta.porcentaje) / 100;
                        resultado = monto - porcentaje;
                        idoferta = oferta.idoferta;
                        txtTotal.Text = Convert.ToDecimal(resultado).ToString("#,###,##0.00");
                        txt_pagado.Text = Convert.ToDecimal(resultado).ToString("#,###,##0.00");

                    }

                }

            }

            catch { }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
