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
    public partial class Form_listaCliente : Form
    {
        public Form_listaCliente()
        {
            InitializeComponent();
        }
        public string id_s;
        public int idcategoria;
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void resfrescar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    clienteBindingSource.DataSource = db.clientes.ToList();

                }
            }
            catch { }
        }
      
       
        public void listarBuscarnombre()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    clienteBindingSource.DataSource = db.clientes.ToList().Where(c => c.nombre == txtBuscar.Text);

                }
            }
            catch { }
        }
        public void listarBuscarcodigo()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    clienteBindingSource.DataSource = db.clientes.ToList().Where(c => c.codigo == txtBuscar.Text);

                }
            }
            catch { }
        }
      
       
      
        private void Formadd_pasado(string dato)
        {
            resfrescar();

        }

        private void Form_equipo_Load(object sender, EventArgs e)
        {
            resfrescar();

        }

        private void btn_saves_Click(object sender, EventArgs e)
        {
          
        }

        private void dgv_equipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txt_serial_Enter(object sender, EventArgs e)
        {
           
        }

        private void txt_serial_Leave(object sender, EventArgs e)
        {
          
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
         
              
            
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
          
        }

        private void dgvproducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvproducto.Refresh();
        }

        private void dgvproducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgvproducto.Rows[e.RowIndex].Cells[0].Value = "Editar";
            //dgvproducto.Rows[e.RowIndex].Cells[1].Value = "Ajustar";
            //dgvproducto.Rows[e.RowIndex].Cells[2].Value = "Cambiar estatus";
        }

       

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    metodo();
            //}
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvproducto.Columns["seleccionar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        Form_historial ajustar = new Form_historial();
                       
                        ajustar.clienteid = Convert.ToInt32(row.Cells[8].Value);
                        ajustar.lbcliente.Text = row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString();
                        ajustar.ShowDialog();
                      

                    }

                }
                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {


                        Form_newcliente ajustar = new Form_newcliente();
                        ajustar.codCliente = row.Cells[8].Value.ToString();
                        ajustar.txt_codigo.Text = row.Cells[2].Value.ToString();
                        ajustar.txtnombre.Text = row.Cells[3].Value.ToString();
                        ajustar.txtapellido.Text = row.Cells[4].Value.ToString();
                        ajustar.txt_telefono1.Text = row.Cells[5].Value.ToString();
                        ajustar.txtcorreo.Text = row.Cells[6].Value.ToString();
                        ajustar.dtpfecha_nacimiento.Text = row.Cells[7].Value.ToString();
                        ajustar.ShowDialog();


                    }

                }

            }
            catch { }

           
        }

        private void dgvproducto_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            


        }

        private void picActualizar_Click(object sender, EventArgs e)
        {
            resfrescar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (rdb_nombre.Checked == true && rdbCodigo.Checked == false)
            {
                listarBuscarnombre();
            }
            else if (rdb_nombre.Checked == false && rdbCodigo.Checked == true)
            {
                listarBuscarcodigo();
            }
            else
            {
                MessageBox.Show("Por favor selecionar la opcion de busquedad");
            }


        }
    }
}
