using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_az
{
    public partial class FormcCitaR : Form
    {
        public int idusuario;
        public FormcCitaR()
        {
            InitializeComponent();
        }
        public void factura()
        {
            try
            {
                Formprintcita fat = new Formprintcita();

                for (int i = 0; i < dgvtrabajo.Rows.Count - 0; i++)
                {
                    Datos dat = new Datos();
                    dat.asunto = dgvtrabajo.Rows[i].Cells[0].Value.ToString();
                    dat.monto = dgvtrabajo.Rows[i].Cells[1].Value.ToString();
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {
                        dat.idcita = row.Cells[0].Value.ToString();
                        dat.nombre = row.Cells[1].Value.ToString();
                        dat.telefono = row.Cells[8].Value.ToString();
                        dat.fechacita = row.Cells[3].Value.ToString();

                        dat.Usuario = row.Cells[7].Value.ToString();
                        dat.fecha = row.Cells[2].Value.ToString();
                        dat.restante = row.Cells[6].Value.ToString();
                        dat.totalpagar = row.Cells[4].Value.ToString(); ;
                        dat.totalpagado = row.Cells[5].Value.ToString(); ;
                        dat.tipodepago = row.Cells[10].Value.ToString();
                        dat.hora = row.Cells[9].Value.ToString();
                    }
                    fat.datos.Add(dat);

                }
                fat.Show();
            }
            catch { }
        }
        //public void ListarUsuario()
        //{
        //    try
        //    {

        //        using (softcitaEntities db = new softcitaEntities())

        //        {
        //            var lst = db.usuarios.ToList();
        //            foreach (var ousuario in lst)
        //            {
        //                cboUsuario.Items.Add(ousuario.nombre);

        //            }

        //        }

        //    }

        //    catch { }
        //}
        //public void ListarIDusuario()
        //{
        //    try
        //    {

        //        using (softcitaEntities db = new softcitaEntities())

        //        {
        //            var lst = db.usuarios.ToList().Where(m => m.nombre == cboUsuario.Text);
        //            foreach (var ousuario in lst)
        //            {
        //                idusuario = ousuario.iduser;
        //                //MessageBox.Show(idsuario.ToString());
        //            }

        //        }

        //    }

        //    catch { }
        //}
        public void listarcita()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    

                    viewreimprimirBindingSource.DataSource = db.View_reimprimir.ToList().Where(c => c.idcita == Convert.ToInt32(txtcita.Text));

                }
            }
            catch { }
        }
        public void trabajo()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {


                    trabajoBindingSource.DataSource = db.trabajoes.ToList().Where(c => c.idcita == Convert.ToInt32(txtcita.Text));

                }
            }
            catch { }
        }
        //public void listarbuscar()
        //{
        //    try
        //    {
        //        using (softcitaEntities db = new softcitaEntities())

        //        {
        //            DateTime fecha = Convert.ToDateTime(dtpDate.Text);

        //            viewreimprimirBindingSource.DataSource = db.View_reimprimir.ToList().Where(c => c.fecha == fecha && c.iduser == idusuario);

        //        }
        //    }
        //    catch { }
        //}
        private void FormcCitaR_Load(object sender, EventArgs e)
        {
            
            
        }

      
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listarcita();
            trabajo();
        }

        private void dgvtrabajo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void picregresar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            imprimirfactura();
            Close();
        }
        public void imprimirfactura()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {

                    Font font_6 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
                    Font font_8 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                    Font font_16 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
                    Font font_10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
                    Font font_28 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

                    int y = 20;


                    string itb = "ITBIS";
                    string subtotal = "MONTO BRUTO";
                    string oferta = "DESCUENTO";
                    string total = "TOTAL A PAGAR RD$";
                    string efectivo = "EFECTIVO";
                    string tarjeta = "TARJETA";
                    string cambio = "RESTANTE";
                    string pagado = "PAGADO";
                    string ley = "10% LEY";
                    string descuento = "DESCUENTO";
                    string empresa = "             VARGAS TATTO";
                    string direccion = "Calle 12 Julio #27 Bonao, Rep. Dom.";
                    string telefono1 = "829-644-2592";
                    string rnc = "40225197439";


                    e.Graphics.DrawImage(piclogo.Image, new RectangleF(45, 0, 200, 110));
                    e.Graphics.DrawString(empresa.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 100, 300, 0));
                    e.Graphics.DrawString(direccion.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
                    e.Graphics.DrawString("TELEFONO: " + telefono1, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("RNC: " + rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FECHA: "+ Convert.ToDateTime(row.Cells[2].Value).ToShortDateString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("CAJERO:" + row.Cells[13].Value.ToString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    // e.Graphics.DrawString("MESA: #" + global.numeromesag, font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));

                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FACTURA PARA CONSUMIDOR FINAL", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("CLIENTE: " + row.Cells[1].Value.ToString() + " " + row.Cells[11].Value.ToString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("TELEFONO: " + row.Cells[12].Value.ToString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FECHA/CITA: " + Convert.ToDateTime(row.Cells[3].Value).ToShortDateString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("HORA: " + row.Cells[9].Value.ToString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("TIEMPO ESTIMADO: " + row.Cells[14].Value.ToString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("DESCRIPCION                    VALOR  ", font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                    for (int i = 0; i < dgvproducto.Rows.Count - 0; i++)
                    {
                        e.Graphics.DrawString(dgvtrabajo.Rows[i].Cells[0].Value.ToString().ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                        e.Graphics.DrawString("1" + "   x   " + Convert.ToDecimal(dgvtrabajo.Rows[i].Cells[1].Value).ToString("#,##0.00").PadRight(30) + Convert.ToDecimal(dgvtrabajo.Rows[i].Cells[1].Value).ToString("#,##0.00"), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));

                    }
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                    e.Graphics.DrawString(subtotal.PadRight(27) + (Convert.ToDouble(row.Cells[5].Value)).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));

                    //if (porcentaje > 0)
                    //{
                    //e.Graphics.DrawString(descuento.PadRight(28) + Convert.ToDecimal(porcentaje).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                    //}
                    e.Graphics.DrawString(total.PadRight(17) + Convert.ToDecimal(row.Cells[5].Value).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(2, y += 15, 400, 50));
                    e.Graphics.DrawString("METODO " + row.Cells[10].Value.ToString(), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                    e.Graphics.DrawString(pagado.PadRight(33) + Convert.ToDecimal(row.Cells[0].Value).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));

                    e.Graphics.DrawString(cambio.PadRight(33) + Convert.ToDecimal(row.Cells[0].Value).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("FACTURA: 000" + (row.Cells[0].Value.ToString()), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    //e.Graphics.DrawString("GRACIAS POR SU VISITA", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString("ESCANEA EL CODIGO Y SIGUENOS!", font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
                    e.Graphics.DrawImage(picBarcode.Image, new RectangleF(45, 600, 200, 110));
                    e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                    // e.Graphics.DrawString("FACTURADO EN PESOS DOMINICANOS", font_6, Brushes.Black, new RectangleF(80, y += 7, 300, 50));
                    //e.Graphics.DrawString("             WWW.ERMSOFTS.COM     ", font_10, Brushes.Black, new RectangleF(2, y += 100, 300, 50));
                    e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    e.Graphics.DrawString(".", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                    }
                }
            catch
            {

            }
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
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
