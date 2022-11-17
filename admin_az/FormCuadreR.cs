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
    public partial class FormCuadreR : Form
    {
        public int idsuario;
        public double efectivo, deposito, tarjeta, anulada, resultado, total, defectivo, ddeposito, dtarjeta, dtotal =0;
        public FormCuadreR()
        {
            InitializeComponent();
        }
        public void ListarUsuario()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.usuarios.ToList();
                    foreach (var ousuario in lst)
                    {
                        cboUsuario.Items.Add(ousuario.nombre);

                    }

                }

            }

            catch { }
        }
        public void ListarIDusuario()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.usuarios.ToList().Where(m => m.nombre == cboUsuario.Text);
                    foreach (var ousuario in lst)
                    {
                        idsuario = ousuario.iduser;
                        //MessageBox.Show(idsuario.ToString());
                    }

                }

            }

            catch { }
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            if (cboUsuario.Text == "")
            {
                MessageBox.Show("Por favor seleccionar el Usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Listarefetivo();
                Listaredeposito();
                Listartarjeta();
                Listaranulada();
                cuadre();
                Listarcierre(); 
                factura();
                Close();
                
            }
        }

        public void Listarefetivo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpDate.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idmetodo == 1 && c.fecha == fecha && c.idusuer == idsuario);
                    foreach (var ocuadre in lst)
                    {
                        efectivo += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(efectivo.ToString());
                }

            }

            catch { }
        }
        public void Listaredeposito()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpDate.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idmetodo == 2 && c.fecha == fecha && c.idusuer == idsuario);
                    foreach (var ocuadre in lst)
                    {
                        deposito += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(deposito.ToString());
                }

            }

            catch { }
        }
        public void Listartarjeta()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpDate.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idmetodo == 3 && c.fecha == fecha && c.idusuer == idsuario);
                    foreach (var ocuadre in lst)
                    {
                        tarjeta += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(tarjeta.ToString());
                }

            }

            catch { }
        }
        public void Listaranulada()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpDate.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idestado == 3 && c.fecha == fecha && c.idusuer == idsuario);
                    foreach (var ocuadre in lst)
                    {
                        anulada += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(anulada.ToString());
                }

            }

            catch { }
        }
        public void Listarcierre()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpDate.Text);
                    var lst = db.cierres.ToList().Where(c => c.fecha == fecha && c.idusuario == idsuario);
                    foreach (var ocuadre in lst)
                    {
                        defectivo = Convert.ToDouble(ocuadre.efectivo);
                        ddeposito = Convert.ToDouble(ocuadre.deposito);
                        dtarjeta = Convert.ToDouble(ocuadre.tarjeta);
                        dtotal = Convert.ToDouble(ocuadre.total);


                    }
                    //MessageBox.Show(dtotal.ToString());
                }

            }

            catch { }
        }
        public void cuadre()
        {
            resultado = efectivo + deposito + tarjeta;
            total = resultado - anulada;

        }
        public void factura()
        {
            Formfactura fat = new Formfactura();
            Datos dat = new Datos();
            dat.efectivo = defectivo.ToString();
            dat.deposito = ddeposito.ToString();
            dat.tarjeta = dtarjeta.ToString();
            dat.total = dtotal.ToString();

            dat.nombre = cboUsuario.Text;
            dat.fecha = dtpDate.Text;
            dat.sfectivo = efectivo.ToString();
            dat.sdeposito = deposito.ToString();
            dat.starjeta = tarjeta.ToString();
            dat.anulada = anulada.ToString();
            dat.totalsistema = total.ToString();
            fat.datos.Add(dat);
            fat.Show();

        }

        private void picregresar_Click(object sender, EventArgs e)
        {
            Panel panelcontrol = Global.Panel1;
            panelcontrol.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelcontrol.Controls.Add(open);
            open.Show();
        }

        private void FormCuadreR_Load(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIDusuario();
        }
    }
}
