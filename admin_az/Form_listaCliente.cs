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
        Panel panelcontrol = Global.Panel1;
        public Form_listaCliente()
        {
            InitializeComponent();
        }
        public string id_s;
        public int idcategoria;
        private void btn_close_Click(object sender, EventArgs e)
        {
           
            panelcontrol.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelcontrol.Controls.Add(open);
            open.Show();
        }

        public void resfrescar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                   
                    clienteBindingSource.Clear();
                    clienteBindingSource.DataSource = db.clientes.ToList().OrderByDescending(f=> f.idcliente);

                }
            }
            catch { }
        }

        public void listarload()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    clienteBindingSource.Clear();
                    clienteBindingSource.DataSource = db.clientes.ToList().OrderByDescending(f=> f.idcliente).Take(20);

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
                    var lst = from m in db.clientes
                              where m.nombre.Contains(txtBuscar.Text) || m.apellido.Contains(txtBuscar.Text) || m.cedula.Contains(txtBuscar.Text) || m.sangre.Contains(txtBuscar.Text)
                              select m;
                    clienteBindingSource.Clear();
                    clienteBindingSource.DataSource = lst.ToList();


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
            listarload();

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
                        int clienteID  = Convert.ToInt32(row.Cells[8].Value);
                        string clientes = row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString();
                        ajustar.clienteid = clienteID;
                        ajustar.lbcliente.Text = clientes;
                        panelcontrol.Controls.Clear();
                        ajustar.TopLevel = false;
                        panelcontrol.Controls.Add(ajustar);
                        ajustar.Show();
                     
                      

                    }

                }
                if (e.ColumnIndex == dgvproducto.Columns["editar"].Index && e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                    {
                     
                        Form_newcliente ajustar = new Form_newcliente();
                        string codCliente = row.Cells[8].Value.ToString();
                        string codigo = row.Cells[2].Value.ToString();
                        string nombre = row.Cells[3].Value.ToString();
                        string apellido = row.Cells[4].Value.ToString();
                        string telefono = row.Cells[5].Value.ToString();
                        string correo = row.Cells[6].Value.ToString();
                        string fechanac = row.Cells[7].Value.ToString();
                        string cedula = row.Cells[9].Value.ToString();
                        string sangre = row.Cells[10].Value.ToString();

                        //'''''''''''''''''''''''''''''''''''''''''''''''''''''
                        ajustar.codCliente = codCliente;
                        ajustar.txt_codigo.Text = codigo;
                        ajustar.txtnombre.Text = nombre;
                        ajustar.txtapellido.Text = apellido;
                        ajustar.txt_telefono1.Text = telefono;
                        ajustar.txtcorreo.Text = correo;
                        ajustar.dtpfecha_nacimiento.Text = fechanac;
                        ajustar.txt_cedula.Text = cedula;
                        ajustar.cbo_tipo_sangre.Text = sangre;
                        panelcontrol.Controls.Clear();
                        ajustar.TopLevel = false;
                        panelcontrol.Controls.Add(ajustar);
                        ajustar.Show();


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
            //if (txtBuscar.Text =="*")
            //{
            //    listarload();
            //}
            //else 
            //{
            //    listarBuscarnombre();
            //}
            resfrescar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            //if (rdb_nombre.Checked == true && rdbCodigo.Checked == false)
            //{
            //    listarBuscarnombre();
            //}
            //else if (rdb_nombre.Checked == false && rdbCodigo.Checked == true)
            //{
            //    listarBuscarcodigo();
            //}
            //else
            //{
            //    MessageBox.Show("Por favor selecionar la opcion de busquedad");
            //}


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_listaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    //if (txtBuscar.Text == "**")

                    //{
                    //    MessageBox.Show("**");
                    //    resfrescar();
                    //}
                    if (txtBuscar.Text == "*")
                    {
                        
                        listarload();
                    }
                    else
                    {

                        listarBuscarnombre();
                    }


                }
                catch { }
            }
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            try
            {


                foreach (DataGridViewRow row in dgvproducto.SelectedRows)
                {
                  
                    int idcliente = Convert.ToInt32(row.Cells[8].Value);
                    string nombre = row.Cells[3].Value.ToString() + " " + row.Cells[4].Value.ToString();
                    string codigo = row.Cells[2].Value.ToString();
                    panelcontrol.Controls.Clear();
                   frmManageAppointment cita = new frmManageAppointment();
                    cita.txt_codigo.Text = codigo;
                    cita.txtnombre.Text = nombre;
                    cita.clienteID = idcliente;
                    cita.TopLevel = false;
                    panelcontrol.Controls.Add(cita);
                    cita.Show();
                
            }

            }
            catch { }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            panelcontrol.Controls.Clear();
            Form_newcliente cita = new Form_newcliente();
            cita.TopLevel = false;
            panelcontrol.Controls.Add(cita);
            cita.Show();
        }
    }
}
