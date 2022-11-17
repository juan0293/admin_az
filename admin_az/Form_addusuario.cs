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
    public partial class Form_addusuario : Form
    {
        public Form_addusuario()
        {
            InitializeComponent();
        }

        public string id_s;
        public int idtipo;
        public int coduser;

        private void btn_saves_Click(object sender, EventArgs e)
        {
          
        }
        public void ListarIDtipo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.tipoUsuarios.ToList().Where(m => m.nombre == cbo_tipo.Text);
                    foreach (var otipo in lst)
                    {
                        idtipo = otipo.idtipo;

                    }

                }

            }

            catch { }
        }
        public void ListarTipo()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.tipoUsuarios.ToList();
                    foreach (var otipo in lst)
                    {
                        cbo_tipo.Items.Add(otipo.nombre);

                    }

                }

            }

            catch { }
        }
        public void addusuario()
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    usuario ousuario = new usuario();

                    ousuario.nombre = txtnombre.Text;
                    ousuario.usuario1 = txtusuario.Text;
                    ousuario.clave = txt_password.Text;
                    ousuario.idtipo = idtipo;
                    ousuario.estado = true;
                    db.usuarios.Add(ousuario);
                    db.SaveChanges();
                    MessageBox.Show("Datos Almacenados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                }

            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void guardar()
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de nombre.");
                txtnombre.BackColor = Color.Crimson;
            }
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de usuario.");
                txtusuario.BackColor = Color.Crimson;
            }
            if (cbo_tipo.Text == "")
            {
                MessageBox.Show("Por favor llenar el campo de Tipo de usuario.");
                cbo_tipo.BackColor = Color.Crimson;
            }

            else
            {

                addusuario();
                Close();
            }

        }
        public void updatecliente()
        {
            try
            {
              
                if (cbo_tipo.Text == "")
                {
                    MessageBox.Show("Por favor llenar el campo de tipo de usuario.");
                    cbo_tipo.BackColor = Color.Crimson;
                }

                else
                {
                    using (softcitaEntities db = new softcitaEntities())

                    {
                     
                        usuario ousuario = db.usuarios.Find(coduser);
                        ousuario.nombre = txtnombre.Text;
                        ousuario.usuario1 = txtusuario.Text;
                        ousuario.clave = txt_password.Text;
                        ousuario.idtipo = idtipo;   
                        db.Entry(ousuario).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
            }
            catch { MessageBox.Show("Algo salio Mal"); }

        }
        public void lb()
        {
            if (coduser == 0)
            {

                lbusuario.Text = "Nuevo Usuario";

            }
            else
            {
                lbusuario.Text = "Editar Usuario";
            }
        }
        private void dgv_servicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form_tipo_servicio_Load(object sender, EventArgs e)
        {
            ListarTipo();
            lb();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Panel panelcontrol = Global.Panel1;
            panelcontrol.Controls.Clear();
            Form_home open = new Form_home();
            open.TopLevel = false;
            panelcontrol.Controls.Add(open);
            open.Show();
        }

        private void cbo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIDtipo();
        }

        private void picbGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void picatras_Click(object sender, EventArgs e)
            
        {
            this.Close();
        }

        private void picbLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void btn_grande_Click(object sender, EventArgs e)
        {
            if (coduser == 0)
            {

                guardar();

            }
            else
            {
                updatecliente();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtnombre.Clear();
            txtusuario.Clear();
            txt_password.Clear();
            cbo_tipo.SelectedIndex = -1;
        }
    }
}
