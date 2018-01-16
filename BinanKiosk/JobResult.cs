using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace BinanKiosk
{
    public partial class JobResult : Form
    {
        private int i = 0;

        private static string[] pictures = new string[]
        {
            @"C:\Users\Fahad\Documents\GitHub\BinanKiosk\BinanKiosk\Resources\Jobs\Logo\SYKES.jpg",
            @"C:\Users\Fahad\Documents\GitHub\BinanKiosk\BinanKiosk\Resources\Jobs\Advertisement\Sykes1.PNG"
        };

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        public JobResult(string val)
        {
            InitializeComponent();
            /*logo.ImageLocation = pictures[0];
            //ad.ImageLocation = pictures[1];
            logo1.ImageLocation = pictures[0];
            ad1.ImageLocation = pictures[1];
            logo2.ImageLocation = pictures[0];
            ad2.ImageLocation = pictures[1];*/
        }

        private void JobResult_Load(object sender, EventArgs e)
        {
            //hidePanels();
            String[] name = { "job1", "job2", "job3", "job4", "job5", "job6", "job7", "job8", "job9", "job10" };

            //JobTitle.Text = Global.gbJobtype;
            //location.Text = Global.gbJoblocation;
            //jobsCompany1.Text = Global.gbJobCompany;
            //description1.Text = Global.gbJobdescription;

            timestamp.Interval = 1;
            timestamp.Start();

            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";

                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblJob.Text = "       RESULTA";
            }

            for (int i = 0; i < 10; i++)
            {
                var panel = new Panel
                {
                    Name = "panel" + (i + 1).ToString(),
                    Size = new Size(1269, 149),
                    Location = new Point(3, 3 + ((i+0) * 155)),
                    AutoScroll = true,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                this.JobResult1_panel.Controls.Add(panel);

                var picture = new PictureBox
                {
                    Name = name[i],
                    Size = new Size(186, 142),
                    Location = new Point(3, 3),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = BinanKiosk.Properties.Resources.Binan_City_Logo,

                };
                panel.Controls.Add(picture);

                var job_locationlbl = new Label
                {
                    Name = name[i] + "job_locationlbl",
                    Text = "Binan, Kiosk" + i.ToString(),
                    Size = new Size(131, 24),
                    Location = new Point(195, 49),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                };
                panel.Controls.Add(job_locationlbl);

                var job_companylbl = new Label
                {
                    Name = name[i] + "job_companylbl",
                    Text = "Microsoft Company" + i.ToString(),
                    Size = new Size(131, 24),
                    Location = new Point(562, 49),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                };
                panel.Controls.Add(job_companylbl);

                var job_descriptionlbl = new Label
                {
                    Name = name[i] + "job_descriptionlbl",
                    Text = "txt1" + i.ToString(),
                    Size = new Size(749, 64),
                    Location = new Point(195, 81),
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                };
                panel.Controls.Add(job_descriptionlbl);

                var lbl = new Label
                {
                    Name = name[i] + "lbl",
                    Text = "txt" + i.ToString(),
                    Size = new Size(85, 29),
                    Location = new Point(195, 3),
                    Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold),
                };
                panel.Controls.Add(lbl);

                var btn = new Button
                {
                    Name = name[i] + "btn",
                    Text = "View Details",
                    Size = new Size(193, 56),
                    Location = new Point(1060, 89),
                    BackgroundImage = BinanKiosk.Properties.Resources.button1,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Arial Narrow", 18, FontStyle.Bold),
                };
                panel.Controls.Add(btn);
            }

            /*
             * for (int i = 0; i < 3; i++)
            {
                var picture = new PictureBox
                {
                    Name = name[i],
                    Size = new Size(186, 142),
                    Location = new Point(3, 3 + (i * 153)),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = BinanKiosk.Properties.Resources.Binan_City_Logo,

                };
                this.JobResult1_panel.Controls.Add(picture);

                var job_locationlbl = new Label
                {
                    Name = name[i] + "job_locationlbl",
                    Text = "Binan, Kiosk" + i.ToString(),
                    Size = new Size(131, 24),
                    Location = new Point(195, 49 + (i * 150)),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                };
                this.JobResult1_panel.Controls.Add(job_locationlbl);

                var job_companylbl = new Label
                {
                    Name = name[i] + "job_companylbl",
                    Text = "Microsoft Company" + i.ToString(),
                    Size = new Size(131, 24),
                    Location = new Point(562, 49 + (i * 148)),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                };
                this.JobResult1_panel.Controls.Add(job_companylbl);

                var job_descriptionlbl = new Label
                {
                    Name = name[i] + "job_descriptionlbl",
                    Text = "txt1" + i.ToString(),
                    Size = new Size(749, 64),
                    Location = new Point(195, 81 + (i * 148)),
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                };
                this.JobResult1_panel.Controls.Add(job_descriptionlbl);

                var lbl = new Label
                {
                    Name = name[i] + "lbl",
                    Text = "txt" + i.ToString(),
                    Size = new Size(85, 29),
                    Location = new Point(195, 3 + (i * 153)),
                    Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold),
                };
                this.JobResult1_panel.Controls.Add(lbl);

                var btn = new Button
                {
                    Name = name[i] + "btn",
                    Text = "View Details",
                    Size = new Size(193, 56),
                    Location = new Point(950, 89 + (i * 148)),
                    BackgroundImage = BinanKiosk.Properties.Resources.button1,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Arial Narrow", 18, FontStyle.Bold),

                };
                this.JobResult1_panel.Controls.Add(btn);
            }
             */


        }



        /*public void hidePanels()
       {

           Button[] btnArray = { JobResult1_Panel, JobResult2_Panel, JobResult3_Panel };

           for (int i = 0; i < btnArray.Length; i++)
           {
               btnArray[i].Visible = false;
           }
       }*/

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.FormClosed += (s, args) => this.Close();
            hm.ShowDialog();
            hm.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search sr = new Search();
            this.Hide();
            sr.FormClosed += (s, args) => this.Close();
            sr.ShowDialog();
            sr.Focus();
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            GroundFloor mp = new GroundFloor();
            this.Hide();
            mp.FormClosed += (s, args) => this.Close();
            mp.ShowDialog();
            mp.Focus();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            GovernmentServices gs = new GovernmentServices();
            this.Hide();
            gs.FormClosed += (s, args) => this.Close();
            gs.ShowDialog();
            gs.Focus();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            Jobs js = new Jobs();
            this.Hide();
            js.FormClosed += (s, args) => this.Close();
            js.ShowDialog();
            js.Focus();
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToLongDateString();
        }

        private void timestamp_Tick(object sender, EventArgs e)
        {
            timestamp.Enabled = true;
            timestamp.Tick += new System.EventHandler(OnTimerEvent);
        }
    }
}
