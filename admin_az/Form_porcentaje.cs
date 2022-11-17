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
    public partial class Form_porcentaje : Form
    {
        Panel panelcontrol = Global.Panel1;
        public Form_porcentaje()
        {
            InitializeComponent();
        }

        private void txt_telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        public void addoferta()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    oferta oferta = new oferta();

                    oferta.titulo = txtnombre.Text;
                    oferta.porcentaje =Convert.ToDouble(txt_porcentaje.Text);
                    oferta.fechaInicio =  DateTime.Now;
                    oferta.fechaFin = Convert.ToDateTime(dtpfecha_vencimiento.Text);
                    oferta.estado = true;

                    db.ofertas.Add(oferta);
                    db.SaveChanges();
                    Listaroferta();
                    txtnombre.Clear();
                    txt_porcentaje.Clear();

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
   
        public void guardar()
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de nombre.");
               
            }
            if (txt_porcentaje.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de porcentaje.");
                
            }
           
            else
            {

                addoferta();

            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void anular()
        {
            try
            {


                using (softcitaEntities db = new softcitaEntities())

                {

                    foreach (DataGridViewRow row in dgvreporte.SelectedRows)
                    {

                        int idcita = Convert.ToInt32(row.Cells[0].Value);
                        oferta oferta = db.ofertas.Find(idcita);    
                        oferta.estado = false;
                        db.Entry(oferta).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        Listaroferta();
                      



                    }
                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }
        }
        private void btn_anular_Click(object sender, EventArgs e)
        {
          
        }
        public void eventoestado()
        {
            try
            {
                foreach (DataGridViewRow row in dgvreporte.Rows)
                {

                    bool estado = Convert.ToBoolean(row.Cells[5].Value);



                    if (estado == true)
                    {
                        row.Cells[6].Value = "Activa";


                        row.DefaultCellStyle.ForeColor = Color.Green;



                    }
                    if (estado == false)
                    {
                        row.Cells[6].Value = "Finalizada";
                        row.DefaultCellStyle.ForeColor = Color.Red;



                    }

                   
                }

            }
            catch { }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            guardar();
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
        private void dgvreporte_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            eventoestado();
        }

        private void Form_porcentaje_Load(object sender, EventArgs e)
        {
            Listaroferta();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Por favor confirme antes de continuar" + "\n" + "Quieres continuar ?", "            SEGURO QUE DESEA ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                anular();
            }

            else

            {
                //do something if NO
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
