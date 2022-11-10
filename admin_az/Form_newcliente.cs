using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Formulario Listo
namespace admin_az
{
    public partial class Form_newcliente : Form
    {
        
        public Form_newcliente()
        {
            InitializeComponent();
        }
        public string id_s, codCliente;
        public int idcliente, ideditar; 
        public void listarIDCliente()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.clientes.Where(c => c.codigo == txt_codigo.Text); 
                    foreach (var ocliente in lst)
                    {
                        idcliente = ocliente.idcliente;
                    }

                }

            }

            catch { }
        }
        public void verificar()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.clientes.Where(c => c.codigo == txt_codigo.Text);
                    foreach (var ocliente in lst)
                       {
                       
                            MessageBox.Show("Existe una Persona con ese codigo!");
                            txt_codigo.Clear();
                       }

                    

                }

            }

            catch { }
        }
    
        public void addcliente()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    cliente ocliente = new cliente();
                   
                    ocliente.nombre = txtnombre.Text;
                    ocliente.apellido = txtapellido.Text;
                    ocliente.telefono = txt_telefono1.Text;
                    ocliente.correo = txtcorreo.Text;
                    ocliente.fecha_nacimiento = Convert.ToDateTime(dtpfecha_nacimiento.Text);   
                    ocliente.fecha = DateTime.Now;
                    ocliente.codigo = txt_codigo.Text;

                    db.clientes.Add(ocliente);
                    db.SaveChanges();
                    listarIDCliente();
                    if  (MessageBox.Show("Datos Almacenados, Desea crear una a este cliente?", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmManageAppointment cita = new frmManageAppointment();
                        cita.txt_codigo.Text = txt_codigo.Text;
                        cita.txtnombre.Text = txtnombre.Text;
                        cita.txtapellido.Text = txt_apellido.Text;
                        cita.clienteID = idcliente;
                        cita.ShowDialog();
                      
                    }
                    else
                    {

                    }

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void updatecliente()
        {
            try
            {
                if (txt_codigo.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de codigo.");
                    txt_codigo.BackColor = Color.Crimson;
                }
                if (txtnombre.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de nombre.");
                    txtnombre.BackColor = Color.Crimson;
                }
                if (txt_telefono1.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de detalle.");
                    txt_telefono1.BackColor = Color.Crimson;
                }

                else
                {
                  

                    using (softcitaEntities db = new softcitaEntities())

                    {
                        int persona = Convert.ToInt32(codCliente);
                        cliente ocliente = db.clientes.Find(persona);
                        ocliente.nombre = txtnombre.Text;
                        ocliente.apellido = txtapellido.Text;
                        ocliente.telefono =txt_telefono1.Text;
                        ocliente.correo = txtcorreo.Text;
                        ocliente.fecha_nacimiento = Convert.ToDateTime(dtpfecha_nacimiento.Text);
                        ocliente.codigo = txt_codigo.Text;
                        db.Entry(ocliente).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos Actualizados");
                        Close();

                    }
                }
            }
            catch { MessageBox.Show("Algo salio Mal"); }

        } 
      
        public void limpiar()
        {
            txt_codigo.Text = txtnombre.Text = txt_telefono1.Text   = "";
          
        } 
        public void lb()
        {
            if (codCliente == null)
            {
                lbProducto.Text = "Nuevo Cliente";
            }
            else
            {
                lbProducto.Text = "Editar Cliente";
            }
        }
        public void guardar()
        {
            if(txt_codigo.Text =="")
            {
                MessageBox.Show("Por favor llenar el campo de codigo.");
                txt_codigo.BackColor = Color.Crimson;
            }
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de nombre.");
                txtnombre.BackColor = Color.Crimson;
            }
            if (txt_telefono1.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de detalle.");
                txt_telefono1.BackColor = Color.Crimson;
            }
           
            else
            {

                addcliente();
                Close();
            }

        }
        
        private void Form_gasto_Load(object sender, EventArgs e)
        {
         
          
            lb();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbocategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
           
       
        }

        private void txt_precioentrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_preciosalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            //verificar();

        }

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //verificar();
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void picbLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void cbo_itebis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void picbGuardar_MouseEnter(object sender, EventArgs e)
        {
            if (codCliente == null)
            {
                verificar();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           
        }   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(codCliente == null)
            {

                guardar();
               
            }
            else
            {
                updatecliente();
            }
           
         
          
        }
    }
}
