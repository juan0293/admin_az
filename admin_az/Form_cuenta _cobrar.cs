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
    public partial class Form_cuenta__cobrar : Form
    {
        public Form_cuenta__cobrar()
        {
            InitializeComponent();
        }

        public void listarcuentasCXP()
        {
           using( softcitaEntities db = new softcitaEntities())
            {
                cuentacxpBindingSource.DataSource = db.Cuentacxps.ToList().Where(x=> x.estado == true);
                int cantidad = db.Cuentacxps.Count(c => c.estado == true);
                if(cantidad <=0)
                {
                    cuentacxpBindingSource.Clear();
                }
              
            }
        }
        public void contarcita()
        {
            try
            {
                //Contar clientes 
                int totalfilas = dgv_citas.Rows.Count;
                lb_cantidad.Text = totalfilas.ToString();

                double totalcliente = 0.00; totalcliente = dgv_citas.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDouble(t.Cells[3].Value));
                lb_pendientes.Text = totalcliente.ToString();
                Double Tpago2 = 0.00;
                if (Double.TryParse(lb_pendientes.Text, out Tpago2))
                    lb_pendientes.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", Tpago2);

                //contar dependientes

            }
            catch { }

        }
        public void Formadd_pasado(string dato)
        {
            listarcuentasCXP();
            contarcita();
        }
        private void Form_cuenta__cobrar_Load(object sender, EventArgs e)
        {
            listarcuentasCXP();
            contarcita();
        }
        public void anular()
        {
            try
            {
                foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                {
                    using (softcitaEntities db = new softcitaEntities())
                    {

                        int idcuenta = Convert.ToInt32(row.Cells[0].Value);
                        Cuentacxp ocxc = db.Cuentacxps.Find(idcuenta);
                        db.Entry(ocxc).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();

                    }

                }

            }
            catch { }
        }
        private void btn_estado_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv_citas.SelectedRows)
                {               
                    Form_add_pago_cxc open = new Form_add_pago_cxc();

                    open.txtTotal.Text = Convert.ToDecimal(row.Cells[3].Value).ToString("#,##0.00");
                    open.txt_pagado.Text = Convert.ToDecimal(row.Cells[3].Value).ToString("#,##0.00");
                    open.idcliente = Convert.ToInt32(row.Cells[5].Value);
                    open.opcion = "1";
                    open.idcuenta = Convert.ToInt32(row.Cells[0].Value);
                    open.idcita = Convert.ToInt32(row.Cells[6].Value);
                    open.cliente = row.Cells[1].Value.ToString();
                    open.pasado += Formadd_pasado;
                    open.ShowDialog();

                }

            }
            catch { }
        }

        private void dgv_citas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Por favor confirme antes de continuar" + "\n" + "Quieres continuar ?", "            SEGURO QUE DESEA ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                anular();
                listarcuentasCXP();
                contarcita();
            }

            else

            {
                //do something if NO
            }
        }
    }
}
