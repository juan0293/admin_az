using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace admin_az
{
    public partial class Form_Agenda : Form
    {
     
      
        public Form_Agenda()
        {
            InitializeComponent();
        }
        public int appID;
        private List<FlowLayoutPanel> listFlDay = new List<FlowLayoutPanel>();
        private DateTime currentDate = DateTime.Today;
        private void AddNewAppointment(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(((FlowLayoutPanel)sender).Tag.ToString());
            if (day != 0)
            {
                {
                    frmManageAppointment withBlock =new  frmManageAppointment();
                    withBlock.AppID = 0;
                    withBlock.opcion = "1";
                    //withBlock.txtName.Text = "";
                    //withBlock.txtAddress.Text = "";
                    //withBlock.txtComment.Text = "";
                    withBlock.dtpDate.Value = new DateTime(currentDate.Year, currentDate.Month, day);
                    withBlock.ShowDialog();
                }
                DisplayCurrentDate();
            }
        }

        private void ShowAppointmentDetail(object sender, EventArgs e)
        {
            try
            {
                using (softcitaEntities db = new softcitaEntities())

                {

                    int appID = Convert.ToInt32(((LinkLabel)sender).Tag.ToString());
                    var lst = db.View_Cliente.Where(f => f.idcita == appID);


                    foreach (var ocita in lst)

                    {
                        FormDetalleCita detalle = new FormDetalleCita();
                        detalle.idcita = ocita.idcita;
                        detalle.idcliente = ocita.idcliente;
                        detalle.txt_codigo.Text = ocita.idcita.ToString();
                        detalle.txtnombre.Text = ocita.nombre;
                        detalle.txtapellido.Text = ocita.apellido;
                        detalle.txt_hora.Text = ocita.hora;
                        detalle.lbestado.Text = ocita.estado;
                        detalle.codigo = ocita.codigo;
                        detalle.telefono= ocita.telefono;
                        detalle.dtpDate.Text = ocita.fechaCita.ToString();
                        detalle.restante =Convert.ToDouble(ocita.resta);
                        detalle.ShowDialog();

                    }
                    DisplayCurrentDate();
                }
            }
            catch { }        
           
        }
       
        private void AddAppointmentToFlDay(int startDayAtFlNumber)
        {
            DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            try
            {
               using (softcitaEntities db = new softcitaEntities())

                {
                    var lst = db.View_Cliente.Where(f => f.fechaCita >=  startDate && f.fechaCita <= endDate && f.condicion ==true);


                    foreach (var oregistro in lst)

                    {
                        DateTime appDay = DateTime.Parse(oregistro.fechaCita.ToString());
                        LinkLabel link = new LinkLabel();
                        link.Tag = oregistro.idcita;
                        appID = oregistro.idcita;
                        link.Name = $"link{oregistro.idcita}";
                        link.Text = oregistro.idcita+" "+oregistro.nombre +" "+oregistro.apellido;
                        link.Click += ShowAppointmentDetail;
                        listFlDay[(appDay.Day - 1) + (startDayAtFlNumber - 1)].Controls.Add(link);

                      

                    }

                }
            }
            catch { }
           
        }
       

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek) +1 ;
        }

        private int GetTotalDaysOfCurrentDate()
        {
            DateTime firstDayOfCurrentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day;
        }

        private void DisplayCurrentDate()
        {
            lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();
            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
            AddAppointmentToFlDay(firstDayAtFlNumber);
        }

        private void PrevMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void NextMonth()
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }

        private void Today()
        {
            currentDate = DateTime.Today;
            DisplayCurrentDate();
        }

        private void GenerateDayPanel(int totalDays)
        {
            flDays.Controls.Clear();
            listFlDay.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                FlowLayoutPanel fl = new FlowLayoutPanel();
                fl.Name = $"flDay{i}";
                fl.Size = new Size(145, 100);
                fl.BackColor = Color.Black;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fl.Cursor = Cursors.Hand;
                fl.AutoScroll = true;
                fl.Click += AddNewAppointment;
                flDays.Controls.Add(fl);
                listFlDay.Add(fl);
            }
        }

        private void AddLabelDayToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            foreach (FlowLayoutPanel fl in listFlDay)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
                fl.BackColor = Color.Silver;
            }

            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                Label lbl = new Label();
                lbl.Name = $"lblDay{i}";
                lbl.AutoSize = false;
                
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(110, 22);
                lbl.ForeColor = Color.Black;
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.HotPink;
            }
        }

        private void Form_empleado_Load(object sender, EventArgs e)
        {
            GenerateDayPanel(41);
            DisplayCurrentDate();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            PrevMonth();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            Today();
        }
    }
}
