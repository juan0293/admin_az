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
    public partial class FormDetalleCita : Form
    {
       public int idcita, idcliente;
        public string codigo, apellido, telefono;
       public  double restante;
        public FormDetalleCita()
        {
            InitializeComponent();
        }
        public void coloresestado()
        {
            if(lbestado.Text == "Finalizada")
            {
                lbestado.ForeColor = Color.Green;
            }
            else if (lbestado.Text == "Pendiente")
            {
                lbestado.ForeColor = Color.Orange;
            }
            else if (lbestado.Text == "Anulada")
            {
                lbestado.ForeColor = Color.Red;
              
            }
            else
            {
                lbestado.Text = "";
            }

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            buscar();
            coloresestado();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void updateestado()
        {
            try
            {
                  
                    using (softcitaEntities db = new softcitaEntities())

                    {  
                        
                        cita ocita = db.citas.Find(idcita);

                        ocita.idestado = 3;
                    ocita.condicion = false;

                    db.Entry(ocita).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos Actualizados");
                        Close();

                    }
                
            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void pendienteestado()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    cita ocita = db.citas.Find(idcita);

                    ocita.idestado = 2;

                    db.Entry(ocita).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados");
                    Close();

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        private void picAnular_Click(object sender, EventArgs e)
        {
            if (lbestado.Text == "Anulada")
            {
                MessageBox.Show("Ya la cita ha sido anulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                if (MessageBox.Show("Seguro de Anular Cita?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    updateestado();
                }
                else
                {

                }
            }
       
        }
        public void updatefecha()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    cita ocita = db.citas.Find(idcita);

                    ocita.fechaCita = Convert.ToDateTime(dtpDate.Text);

                    db.Entry(ocita).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void buscar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    int citaid = Convert.ToInt32(txt_codigo.Text);


                    var lst = db.View_Cliente.Where(f => f.idcita == citaid);

                    foreach (var ocita in lst)

                    {
                        FormDetalleCita detalle = new FormDetalleCita();
                        idcita = ocita.idcita;
                        idcliente = ocita.idcliente;
                        txt_codigo.Text = ocita.idcita.ToString();
                        txtnombre.Text = ocita.nombre;
                        txtapellido.Text = ocita.apellido;
                        txt_hora.Text = ocita.hora.ToString();
                        lbestado.Text = ocita.estado;
                        dtpDate.Text = ocita.fechaCita.ToString();

                    }
                    
                }
            }
            catch { }
        }    
        private void picfecha_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de mover la Cita?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updatefecha();
            }
            else
            {

            }
        }
        public void finalizar()
        {
            try
            {
                form_finalizar finalizar = new form_finalizar();

                finalizar.txtTotal.Text = restante.ToString();
                finalizar.idcita = idcita;
                finalizar.cliente = txtnombre.Text;
                finalizar.idcliente = idcliente.ToString();
             
                finalizar.ShowDialog();
            }
            catch { }
        }
    
        private void picactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    int appID = Convert.ToInt32(txt_codigo.Text);
                    var lst = db.View_Cliente.Where(f => f.idcita == appID);


                    foreach (var ocita in lst)

                    {
                        FormEditar detalle = new FormEditar();
                        detalle.idcita = ocita.idcita;
                        detalle.idcliente = ocita.idcliente;
                        detalle.txt_codigo.Text = ocita.idcita.ToString();
                        detalle.txtnombre.Text = ocita.nombre;
                        detalle.txtapellido.Text = ocita.apellido;
                        detalle.txt_hora.Text = ocita.hora;
                       
                        detalle.dtpDate.Text = ocita.fechaCita.ToString();
                        
                        detalle.ShowDialog();
                        Close();
                    }
                   
                }
            }
            catch { }
        }

        public void reimprimir()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    double resta = 0.00;
                    
                    var lst = db.View_Cliente.Where(f => f.idcita == idcita);


                    foreach (var ocita in lst)

                    {
                        Formterminar fat = new Formterminar();
                        Datos dat = new Datos();
                        dat.idcita = idcita.ToString();
                        dat.telefono = ocita.idcliente.ToString();
                        dat.Usuario = Global.nombre;
                        dat.nombre = ocita.nombre.ToString();
                        dat.fecha = DateTime.Now.ToString();
                        dat.tipodepago = ocita.metodo;
                        dat.totalpagado = ocita.monto.ToString();
                        dat.total = ocita.monto.ToString();
                        dat.restante = resta.ToString();
                        dat.telefono = ocita.telefono;
                        dat.codigo = ocita.codigo;
                        dat.apellido = ocita.apellido;
                        fat.datos.Add(dat);
                        fat.Show();
                        

                    }
                    
                }
            }
            catch { }
        }
        private void picFinalizar_Click(object sender, EventArgs e)
        {
            if (lbestado.Text == "Finalizada")
            {
                if (MessageBox.Show("Ya la cita ha sido Finalizada, desea Reimprimir?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    reimprimir();
                    Close();
                    
                }
                else
                {
                }
            }

           else if (lbestado.Text == "Anulada")
            {
                MessageBox.Show("Imposible finalizar cita, Porque ha sido anulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                finalizar();
                Close();
               
            }
        }

        private void FormDetalleCita_Load(object sender, EventArgs e)
        {
            coloresestado();
        }
    }
}
