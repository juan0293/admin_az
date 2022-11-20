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
    public partial class Form_add_pago_cxc : Form
    {
        public delegate void pasar(string dato);
        public event pasar pasado;
        public int idusuario = Convert.ToInt32(Global.idusuario);
        public int idcuenta, idcuentacxp, idcita, numero_sesion;
        public int  idcliente;
        public int cantidad_sesion;
        public string cliente, opcion, telefono;
        public double nuevoMonto;
        public Form_add_pago_cxc()
        {
            InitializeComponent();
        }

        //CUENTA POR COBRAR
        public void addcxc()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                   
                    Cuentacxp ocxc = db.Cuentacxps.Find(idcuenta);
                    ocxc.monto = nuevoMonto;
                    db.Entry(ocxc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                   
                }
            }
            catch { }
        }
        public void addpago_cxc()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    pago_cxc opago = new pago_cxc();

                    opago.idcliente = idcliente;
                    opago.cliente = cliente;
                    opago.fecha = DateTime.Now;
                    opago.monto = Convert.ToDouble(txt_pagado.Text);                
                    db.pago_cxc.Add(opago);
                    db.SaveChanges();

                }
            }
            catch { }
        }
        public void deletecxc()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {


                    Cuentacxp ocxc = db.Cuentacxps.Find(idcuenta);
                    db.Entry(ocxc).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                }
            }
            catch { }
        }

        //CUENTA POR PAGAR
        public void add_cuenta_pagar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {


                    cuentaCXC ocxc = db.cuentaCXCs.Find(idcuentacxp);
                    ocxc.monto = nuevoMonto;
                    db.Entry(ocxc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch { }
        }
        public void addpago_cxp()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    pago_cxp opago = new pago_cxp();

                    opago.idcxc = idcuentacxp;
                    opago.proveedor = cliente;
                    opago.fecha = DateTime.Now;
                    opago.monto = Convert.ToDouble(txt_pagado.Text);
                    db.pago_cxp.Add(opago);
                    db.SaveChanges();

                }
            }
            catch { }
        }
        public void delete_cuenta_pagar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {


                    cuentaCXC ocxc = db.cuentaCXCs.Find(idcuentacxp);
                    db.Entry(ocxc).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                }
            }
            catch { }
        }

        //Finalizar cita;

        public void updateCita()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {


                    cita ocxc = db.citas.Find(idcita);
                    ocxc.resta = nuevoMonto;
                    ocxc.fechaCita = Convert.ToDateTime(dtp_fecha_sesion.Text);
                    db.Entry(ocxc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch { }
        }
        public void addfactura()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    factura opago = new factura();

                    opago.idcita = idcita;
                    opago.idusuer = idusuario;
                    opago.fecha = DateTime.Now;
                    opago.monto = Convert.ToDouble(txt_pagado.Text);
                    opago.idmetodo = 1;
                    db.facturas.Add(opago);
                    db.SaveChanges();

                }
            }
            catch { }
        }
        public void addcxp()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    pago_cxp opago = new pago_cxp();

                    opago.idcxc = idcita;
                    opago.fecha = DateTime.Now;
                    opago.monto = Convert.ToDouble(txt_pagado.Text);
                    opago.proveedor = cliente;
                    db.pago_cxp.Add(opago);
                    db.SaveChanges();

                }
            }
            catch { }
        }
        public void updatecxp()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    foreach (var ocxp in db.Cuentacxps.Where(c => c.idcita == idcita))
                    {

                        ocxp.monto = nuevoMonto;
                       
                        db.Entry(ocxp).State = System.Data.Entity.EntityState.Modified;

                    }

                    db.SaveChanges();
                   

                }
            }
            catch { }
        }
        public void deletecxp()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    foreach (var ocxp in db.Cuentacxps.Where(c => c.idcita == idcita))
                    {

                      

                        db.Entry(ocxp).State = System.Data.Entity.EntityState.Deleted;

                    }

                    db.SaveChanges();


                }
            }
            catch { }
        }
        public void Finalizar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {


                    cita ocxc = db.citas.Find(idcita);
                    ocxc.idestado = 1;
                    ocxc.resta = 0.00;
                    db.Entry(ocxc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch { }
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


                e.Graphics.DrawImage(piclogo.Image, new RectangleF(45, 0, 150, 150));
                e.Graphics.DrawString(empresa.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 120, 300, 0));
                e.Graphics.DrawString(direccion.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
                e.Graphics.DrawString("TELEFONO: " + telefono1, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("RNC: " + rnc.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("CAJERO:" + Global.nombre.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                // e.Graphics.DrawString("MESA: #" + global.numeromesag, font_10, Brushes.Black, new RectangleF(10, y += 15, 300, 50));

                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("FACTURA PARA CONSUMIDOR FINAL", font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                //e.Graphics.DrawString("Artista: " + cbo_artista.Text.ToUpper(), font_28, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("CLIENTE: " + cliente.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
                e.Graphics.DrawString("TELEFONO: " + telefono, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("FECHA/CITA: " + Convert.ToDateTime(dtp_fecha_sesion.Text).ToShortDateString(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("SESION: " + numero_sesion + "/"+ cantidad_sesion, font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                //e.Graphics.DrawString("TIEMPO ESTIMADO: " + txt_estimado.Text.ToUpper(), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("DESCRIPCION                    VALOR  ", font_10, Brushes.Black, new RectangleF(2, y += 20, 300, 50));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
               
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                e.Graphics.DrawString(subtotal.PadRight(27) + (Convert.ToDouble(txtTotal.Text)).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));

            
                e.Graphics.DrawString(total.PadRight(17) + Convert.ToDecimal(txtTotal.Text).ToString("#,##0.00").PadLeft(20), font_28, Brushes.Black, new RectangleF(2, y += 15, 400, 50));
                e.Graphics.DrawString("METODO " + "EFECTIVO", font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));
                e.Graphics.DrawString(pagado.PadRight(33) + Convert.ToDecimal(txt_pagado.Text).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 18, 300, 50));

                e.Graphics.DrawString(cambio.PadRight(33) + Convert.ToDecimal(nuevoMonto).ToString("#,##0.00").PadLeft(20), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("FACTURA: 000" + (idcita), font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                //e.Graphics.DrawString("GRACIAS POR SU VISITA", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("ESCANEA EL CODIGO Y SIGUENOS!", font_10, Brushes.Black, new RectangleF(2, y += 30, 300, 50));
                e.Graphics.DrawImage(picBarcode.Image, new RectangleF(45, 700, 150, 150));
                e.Graphics.DrawString("----------------------------------------------------------------------------", font_8, Brushes.Black, new RectangleF(2, y += 12, 300, 50));
                // e.Graphics.DrawString("FACTURADO EN PESOS DOMINICANOS", font_6, Brushes.Black, new RectangleF(80, y += 7, 300, 50));
                //e.Graphics.DrawString("             WWW.ERMSOFTS.COM     ", font_10, Brushes.Black, new RectangleF(2, y += 100, 300, 50));
                e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString("", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));
                e.Graphics.DrawString(".", font_10, Brushes.Black, new RectangleF(2, y += 15, 300, 50));


            }
            catch
            {

            }
        }
        private void Form_add_pago_cxc_Load(object sender, EventArgs e)
        {
            if(opcion=="3")
            {
                lb_sesion.Visible = true;
                dtp_fecha_sesion.Visible = true;
            }
        }
        public void addsesiones()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())
                {

                    sesion osesion = new sesion();
                    osesion.idcita = idcita;
                    osesion.cantidad = 1;
                    db.sesions.Add(osesion);
                    db.SaveChanges();



                }
            }
            catch { }
        }
        public void Listarsesion()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    int lst = db.sesions.Count(c => c.idcita == idcita);
                    numero_sesion = lst +1;
                   

                }

            }

            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtTotal.Text);
            double monto_pago = Convert.ToDouble(txt_pagado.Text);
          

          if(opcion =="2")
            {
                if (monto_pago >= monto)
                {
                    
                    delete_cuenta_pagar();

                }

                if (monto_pago < monto)
                {
                    nuevoMonto = monto - monto_pago;
                   
                    add_cuenta_pagar();

                }
                addpago_cxp();
                pasado(" ");
                Close();
            }


        if(opcion=="1")

            {
                if (monto_pago >= monto)
                {
                   
                    deletecxc();

                }

                if (monto_pago < monto)
                {
                    nuevoMonto = monto - monto_pago;
                   
                    addcxc();

                }
                addfactura();
                addpago_cxc();
                imprimirfactura();
                pasado(" ");
                Close();
            }
           
             if(opcion =="3")
            {
                Listarsesion();

                if (monto_pago >= monto)
                {

                    Finalizar();
                    deletecxp();

                }

                if (monto_pago < monto)
                {
                    nuevoMonto = monto - monto_pago;
                    updatecxp();
                    updateCita();
                   

                }
                addfactura();
                addcxp();
                imprimirfactura();
                pasado(" ");
                Close();
            }
        }
    }
}
