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
    public partial class Form_Artista : Form
    {
        public Form_Artista()
        {
            InitializeComponent();
        }

        private void txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        public void addartista()
        {
            try
            {

                using (softcitaEntities db = new softcitaEntities())

                {
                    artista oartista = new artista();

                    oartista.nombre = txtnombre.Text;
                    oartista.Porcentaje = Convert.ToDouble(txt_porcentaje.Text);
                    db.artistas.Add(oartista);
                    db.SaveChanges();
                    ListarArtista();
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

               addartista();

            }

        }
        public void ListarArtista()
        {

            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {
                    artistaBindingSource.DataSource = db.artistas.ToList();
                }

            }

            catch { }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Artista_Load(object sender, EventArgs e)
        {
            ListarArtista();
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
