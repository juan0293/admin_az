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
            factura();
            Close();
            
        }

        private void picregresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
