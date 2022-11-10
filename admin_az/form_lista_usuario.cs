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
    public partial class form_listaUsuario : Form
    {
        public form_listaUsuario()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        #region HELPER
        public void resfrescar()
        {
            //using (softmarketEntities1 db = new softmarketEntities1())

            //{
            //    productoBindingSource.DataSource = db.productoes.ToList();
            //    proveedorBindingSource.DataSource = db.proveedors.ToList();
            //    categoriaBindingSource.DataSource = db.categorias.ToList();
            //}
        }
        #endregion
     

        private void picatras_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void eliminarsuario()
        {
            try
            {
                    using (softcitaEntities db = new softcitaEntities())

                    {
                        foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                        {

                        int idusuario = Convert.ToInt32(row.Cells[2].Value.ToString());

                            usuario ousuario = db.usuarios.Find(idusuario);
                            ousuario.estado = false;
                        
                            db.Entry(ousuario).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listar();


                        }
                }
            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void listar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    view1usuarioBindingSource.DataSource = db.View_1_usuario.ToList().Where(u => u.estado ==true);

                }
            }
            catch { }
        }
     
        private void form_listaUsuario_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvproducto.Columns["seleccionar"].Index && e.RowIndex >= 0)
                {
                    if (MessageBox.Show("Seguro de eliminar este usuario?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        eliminarsuario();

                    }
                    else
                    {

                    }

                }
                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        Form_addusuario ajustar = new Form_addusuario();
                        ajustar.coduser = Convert.ToInt32(row.Cells[2].Value.ToString());
                        ajustar.txtnombre.Text = row.Cells[3].Value.ToString();
                        ajustar.txtusuario.Text = row.Cells[4].Value.ToString();
                        ajustar.txt_password.Text = row.Cells[5].Value.ToString();
                      
                        ajustar.ShowDialog();
                        Close();

                    }

                }

            }
            catch { }

        }
    }
}
