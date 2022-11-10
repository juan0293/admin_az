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
    public partial class FormReporteM : Form
    {
        public int idcliente;
        public double efectivo, deposito, tarjeta;
        public FormReporteM()
        {
            InitializeComponent();
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
                txt_total.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(txt_total.Text, out Tpago2))
                    txt_total.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //contar dependientes
            
            }
            catch { }

        }
        public void listarreporte()
        {
            try
            {
              
                DateTime startDate =  Convert.ToDateTime(dtpDateinicio.Text);
                DateTime endDate = Convert.ToDateTime(dtpDatefin.Text);
                using (softcitaEntities db = new softcitaEntities())

                {

                   viewhistorialBindingSource.DataSource = db.View_historial.ToList().Where(f => f.fecha >= startDate && f.fecha <= endDate && f.condicion ==true);
                    metodoppagoBindingSource.DataSource = db.metodoppagoes.ToList();
                  
                }
            }
            catch { }
        }
     
        public void listaridcliente()
        {
            try
            {
              
                using (softcitaEntities db = new softcitaEntities())

                {

                    viewhistorialBindingSource.DataSource = db.View_historial.ToList().Where(f => f.idcliente == idcliente);

                }
            }
            catch { }
        }
        public void imprimir_reporte()
        {
            try
            {
                MessageBox.Show("Reporte enviado a Impresion:", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReporte clientes = new FormReporte();

              
                for (int i = 0; i < dgvreporte.Rows.Count - 0; i++)
                {
                    Datos dat = new Datos();


                    dat.nombre = dgvreporte.Rows[i].Cells[2].Value.ToString();
                    dat.apellido = dgvreporte.Rows[i].Cells[3].Value.ToString(); 
                    dat.monto = dgvreporte.Rows[i].Cells[4].Value.ToString(); 
                    dat.fecha = dgvreporte.Rows[i].Cells[5].Value.ToString();
                    int nu = 1 + i;
                    dat.asunto = nu.ToString();
                    int metodo = Convert.ToInt32(dgvreporte.Rows[i].Cells[6].Value);
                
                    if (metodo ==1)
                    {
                        dat.tipodepago = "Efectivo";
                    }
                    if(metodo ==2)
                    {
                        dat.tipodepago = "Deposito";
                    }

                    if (metodo==3)
                    {
                        dat.tipodepago = "Tarjeta";
                    }
                  
                    dat.totalpagar = txttrabajos.Text;
                    dat.total = txt_total.Text;
                    dat.efectivo = txt_efectivo.Text;
                    dat.sdeposito = txt_deposito.Text;
                    dat.tarjeta = txt_tarjetas.Text;

                    clientes.datos.Add(dat);

                }

                clientes.Show();
            }
            catch { }

        }
        public void imprimir_reportepequeno()
        {
            try
            {
                MessageBox.Show("Reporte enviado a Impresion:", "Vista Previa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormreportP clientes = new FormreportP();


                for (int i = 0; i < dgvreporte.Rows.Count - 0; i++)
                {
                    Datos dat = new Datos();



                    dat.fecha = DateTime.Now.ToString();
                    dat.totalsistema = txt_total.Text;
                    dat.efectivo = txt_efectivo.Text;
                    dat.sdeposito = txt_deposito.Text;
                    dat.tarjeta = txt_tarjetas.Text;

                    clientes.datos.Add(dat);

                }

                clientes.Show();
            }
            catch { }

        }
        public void listarefectivo()
        {
            try
            {
               
                foreach (DataGridViewRow Row in dgvreporte.Rows)
                {

                    int metodo = Convert.ToInt32(Row.Cells[6].Value);



                    if (metodo == 1)

                    {
                        efectivo += Convert.ToDouble(Row.Cells[4].Value);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void listardeposito()
        {
            try
            {
             
                foreach (DataGridViewRow Row in dgvreporte.Rows)
                {

                    int metodo = Convert.ToInt32(Row.Cells[6].Value);


                    if (metodo == 2)

                    {
                        deposito += Convert.ToDouble(Row.Cells[4].Value);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void listartarjeta()
        {
            try
            {
             
                foreach (DataGridViewRow Row in dgvreporte.Rows)
                {

                    int metodo = Convert.ToInt32(Row.Cells[6].Value);



                    if (metodo == 3)

                    {
                        tarjeta += Convert.ToDouble(Row.Cells[4].Value);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void formatos()
        {
            Double Tpago2 = 0.00;
            if (Double.TryParse(txt_efectivo.Text, out Tpago2))
                txt_efectivo.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);
            Double Tpago3 = 0.00;
            if (Double.TryParse(txt_deposito.Text, out Tpago3))
                txt_deposito.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago3);
            Double Tpago4 = 0.00;
            if (Double.TryParse(txt_tarjetas.Text, out Tpago4))
                txt_tarjetas.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago4);
        }
        public void listartotales()
        {
            txt_efectivo.Text = efectivo.ToString();
            txt_deposito.Text = deposito.ToString();
            txt_tarjetas.Text = tarjeta.ToString();
        }
        private void FormReporteM_Load(object sender, EventArgs e)
        {
            if (idcliente > 0)
            {
                listaridcliente();
                contarcita();
            }
        }
        public void operacion()
        {
            deposito = 0;
            efectivo = 0;
            tarjeta = 0;
            contarcita();
            listarefectivo();
            listardeposito();
            listartarjeta();
            listartotales();
            formatos();
        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            listarreporte();
            operacion();

        }

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
             imprimir_reporte();
        }

        private void picpequena_Click(object sender, EventArgs e)
        {
            imprimir_reportepequeno();
        }

        private void dgvreporte_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvreporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvreporte.Columns["delete"].Index && e.RowIndex >= 0)
                {

                    dgvreporte.Rows.Remove(dgvreporte.CurrentRow);
                    MessageBox.Show("Producto Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contarcita();
                    operacion();

                }



            }


            catch { }
        
    }

        private void dgvreporte_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            contarcita();
            operacion();
        }
    }
}
