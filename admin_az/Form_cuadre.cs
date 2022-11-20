using Microsoft.Reporting.WinForms;
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
    public partial class Form_cuadre : Form
    {
        public int idusuarios = Convert.ToInt32(Global.idusuario);
        public double suma = 0;
        public double efectivo, deposito, tarjeta, anulada, resultado, total, totaldeglose =0;
        public Form_cuadre()
        {
            InitializeComponent();
        }
        public void Listarefetivo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idmetodo == 1  && c.fecha == fecha  && c.idusuer == idusuarios);
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

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idmetodo == 2 && c.fecha == fecha && c.idusuer == idusuarios);
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

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idmetodo == 3 && c.fecha == fecha && c.idusuer == idusuarios);
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

                    DateTime fecha = Convert.ToDateTime(dtpfecha.Text);
                    var lst = db.View_cuadre.ToList().Where(c => c.idestado ==3  && c.fecha == fecha );
                    foreach (var ocuadre in lst)
                    {
                        anulada += Convert.ToDouble(ocuadre.monto);

                    }
                    //MessageBox.Show(anulada.ToString());
                }

            }

            catch { }
        }
        private void Form_cuadre_Load(object sender, EventArgs e)
        {
            Listarefetivo();
            Listaredeposito();
            Listartarjeta();
            Listaranulada();
            cuadre();
        }
        public void cuadre()
        {
            resultado = efectivo + deposito + tarjeta;
            total = resultado - anulada;

        }
        public void deglose()
        {
            try
            {
                double m1 = 0; m1 = Convert.ToDouble(txt1.Text) * 1;
                double m2 = 0; m2 = Convert.ToDouble(txt5.Text) * 5;
                double m3 = 0; m3 = Convert.ToDouble(txt10.Text) * 10;
                double m4 = 0; m4 = Convert.ToDouble(txt50.Text) * 50;
                double m5 = 0; m5 = Convert.ToDouble(txt100.Text) * 100;
                double m6 = 0; m6 = Convert.ToDouble(txt200.Text) * 200;
                double m7 = 0; m7 = Convert.ToDouble(txt500.Text) * 500;
                double m8 = 0; m8 = Convert.ToDouble(txt1000.Text) * 1000;
                double m9 = 0; m9 = Convert.ToDouble(txt2000.Text) * 2000;
                double m10 = 0; m10 = Convert.ToDouble(txtdeposito.Text);
                double m11 = 0; m11 = Convert.ToDouble(txttarjeta.Text);


                suma = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9;
                totaldeglose = suma + m10 + m11;
                
            }
            catch { MessageBox.Show("Por ingresar cero si no posee de esa moneda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt200_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt2000_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtdeposito_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtdeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txttarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        public void factura()
        {
            Formfactura fat = new Formfactura();
            Datos dat = new Datos();        
            dat.efectivo =suma.ToString();
            dat.deposito = txtdeposito.Text;
            dat.tarjeta = txttarjeta.Text;
            dat.total = totaldeglose.ToString();

            dat.nombre = Global.nombre;
            dat.fecha = DateTime.Now.ToShortDateString();
            dat.sfectivo = efectivo.ToString();
            dat.sdeposito = deposito.ToString();
            dat.starjeta = tarjeta.ToString();
            dat.anulada = anulada.ToString();
            dat.totalsistema = total.ToString();
            fat.datos.Add(dat);
             fat.Show();

        }
        public void addcierre()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    cierre ocierre = new cierre();

                    ocierre.idusuario = Convert.ToInt32(Global.idusuario);
                    ocierre.efectivo = suma;
                    ocierre.tarjeta = Convert.ToDouble(txttarjeta.Text);
                    ocierre.deposito = Convert.ToDouble(txtdeposito.Text);
                    ocierre.total = totaldeglose;
                    ocierre.fecha = DateTime.Now;
                  
                    db.cierres.Add(ocierre);
                    db.SaveChanges();

                    MessageBox.Show("Datos Almacenados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
            deglose();
            addcierre();
            factura();
            Close();
           
         

        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            if(txt1.Text =="")
            {
                txt1.Text = "0";
            }
        }

        private void txt5_Leave(object sender, EventArgs e)
        {
            if (txt5.Text == "")
            {
                txt5.Text = "0";
            }
        }

        private void txt10_Leave(object sender, EventArgs e)
        {
            if (txt10.Text == "")
            {
                txt10.Text = "0";
            }
        }

        private void txt50_Leave(object sender, EventArgs e)
        {
            if (txt50.Text == "")
            {
                txt50.Text = "0";
            }
        }

        private void txt100_Leave(object sender, EventArgs e)
        {
            if (txt100.Text == "")
            {
                txt100.Text = "0";
            }
        }

        private void txt200_Leave(object sender, EventArgs e)
        {
            if (txt200.Text == "")
            {
                txt200.Text = "0";
            }
        }
        public void cerrar()
        {
            Panel panelcontrol = Global.Panel1;
            panelcontrol.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelcontrol.Controls.Add(open);
            open.Show();
        }
        private void btn_grande_Click(object sender, EventArgs e)
        {
            deglose();
            addcierre();
            factura();
            cerrar();
        }

        //public void imprimirfactura()
        //{
        //    printDocument1 = new PrintDocument();
        //    PrinterSettings ps = new PrinterSettings();
        //    printDocument1.PrinterSettings = ps;
        //    printDocument1.PrintPage += Imprimir;
        //    printDocument1.Print();
        //}

        //private void Imprimir(object sender, PrintPageEventArgs e)
        //{

        //    try
        //    {
        //        Font font_6 = new Font("Arial", 6, FontStyle.Regular, GraphicsUnit.Point);
        //        Font font_8 = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
        //        Font font_16 = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
        //        Font font_10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
        //        Font font_28 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

        //        int y = 20;


        //        string itb = "ITBIS";
        //        string subtotal = "MONTO BRUTO";
        //        string oferta = "DESCUENTO";
        //        string total = "TOTAL RD$";
        //        string efectivo = "EFECTIVO";
        //        string tarjeta = "TARJETA";
        //        string deposito = "DEPOSITO";
        //        string pagado = "PAGADO";
        //        string ley = "10% LEY";
        //        string descuento = "DESCUENTO";
        //        string empresa = "             VARGAS TATTO";
        //        string direccion = "Calle 12 Julio #27 Bonao, Rep. Dom.";
        //        string telefono1 = "829-644-2592";
        //        string rnc = "40225197439";


        //        e.Graphics.DrawImage(piclogo.Image, new RectangleF(45, 0, 150, 150));
        //        e.Graphics.DrawString(empresa.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 120, 300, 0));
        //        e.Graphics.DrawString(direccion.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
        //        e.Graphics.DrawString("TELEFONO: " + telefono1, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("RNC: " + rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString(DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("CAJERO:" + Global.nombre.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        // e.Graphics.DrawString("MESA: #" + global.numeromesag, font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));

        //        e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("                     CUADRE", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("Artista: " + cbo_artista.Text.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("CLIENTE: " + cliente.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
        //        //e.Graphics.DrawString("TELEFONO: " + telefono, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("FECHA/CITA: " + Convert.ToDateTime(dtp_fecha_sesion.Text).ToShortDateString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("SESION: " + numero_sesion + "/" + cantidad_sesion, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("TIEMPO ESTIMADO: " + txt_estimado.Text.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("DESCRIPCION                    VALOR  ", font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
        //        e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));

        //        e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
        //        e.Graphics.DrawString(efectivo.PadRight(27) + (Convert.ToDouble(EF)).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));


        //        e.Graphics.DrawString(total.PadRight(17) + Convert.ToDecimal(txtTotal.Text).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(2, y += 15, 400, 50));
        //        e.Graphics.DrawString("METODO " + "EFECTIVO", font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
        //        e.Graphics.DrawString(pagado.PadRight(33) + Convert.ToDecimal(txt_pagado.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));

        //        e.Graphics.DrawString(cambio.PadRight(33) + Convert.ToDecimal(nuevoMonto).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("FACTURA: 000" + (idcita), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        //e.Graphics.DrawString("GRACIAS POR SU VISITA", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("ESCANEA EL CODIGO Y SIGUENOS!", font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
        //        e.Graphics.DrawImage(picBarcode.Image, new RectangleF(45, 700, 150, 150));
        //        e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
        //        // e.Graphics.DrawString("FACTURADO EN PESOS DOMINICANOS", font_6, Brushes.Black, new RectangleF(80, y += 7, 300, 50));
        //        //e.Graphics.DrawString("             WWW.ERMSOFTS.COM     ", font_10, Brushes.Black, new RectangleF(2, y += 100, 300, 50));
        //        e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
        //        e.Graphics.DrawString(".", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));


        //    }
        //    catch
        //    {

        //    }
        //}
        private void txt500_Leave(object sender, EventArgs e)
        {
            if (txt500.Text == "")
            {
                txt500.Text = "0";
            }
        }

        private void txt1000_Leave(object sender, EventArgs e)
        {
            if (txt1000.Text == "")
            {
                txt1000.Text = "0";
            }
        }

        private void txt2000_Leave(object sender, EventArgs e)
        {
            if (txt2000.Text == "")
            {
                txt2000.Text = "0";
            }
        }

        private void txtdeposito_Leave(object sender, EventArgs e)
        {
            if (txtdeposito.Text == "")
            {
                txtdeposito.Text = "0";
            }
        }

        private void txttarjeta_Leave(object sender, EventArgs e)
        {
            if (txttarjeta.Text == "")
            {
                txttarjeta.Text = "0";
            }
        }

        private void picatras_Click(object sender, EventArgs e)
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
