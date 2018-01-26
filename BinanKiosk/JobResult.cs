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
        private string selectedJob = "";
        string dumvalue = "dunkin";

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

            //JobTitle.Text = Global.gbJobtype;
            //location.Text = Global.gbJoblocation;
            //jobsCompany1.Text = Global.gbJobCompany;
            //description1.Text = Global.gbJobdescription;

            for (int i = 0; i < Global.gbJobtype.Length; i++)
            {
                var panel = new Panel
                {
                    Name = i.ToString(),
                    //Name = "jobPanel" + (i + 1).ToString(),
                    Size = new Size(1269, 149),
                    Location = new Point(3, 3 + ((i+0) * 155)),
                    AutoScroll = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = System.Drawing.Color.LightGray,
            };
                this.JobResult1_panel.Controls.Add(panel);
                panel.Click += new EventHandler(this.panel_Click);

                var picture = new PictureBox
                {
                    Name = i.ToString(),
                    //Name = "jobPicture" + (i + 1).ToString(),
                    Size = new Size(186, 142),
                    Location = new Point(3, 3),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = BinanKiosk.Properties.Resources.Binan_City_Logo,

                };
                panel.Controls.Add(picture);
                picture.Click += new EventHandler(this.picture_Click);

                var job_locationlbl = new Label
                {
                    Name = "jobLocation" + (i + 1).ToString(),
                    Text = Global.gbJoblocation[i],
                    //Text = "Location" + i.ToString(),
                    Size = new Size(131, 24),
                    Location = new Point(195, 49),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                };
                panel.Controls.Add(job_locationlbl);

                var job_companylbl = new Label
                {
                    Name = "jobCompany" + (i + 1).ToString(),
                    Text = Global.gbJobCompany[i],
                    //Text = "Company" + i.ToString(),
                    Size = new Size(131, 24),
                    Location = new Point(562, 49),
                    Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular),
                };
                panel.Controls.Add(job_companylbl);

                var job_descriptionlbl = new Label
                {
                    Name = "jobDescription" + (i + 1).ToString(),
                    Text = Global.gbJobdescription[i],
                    //Text = "Description" + i.ToString(),
                    Size = new Size(749, 64),
                    Location = new Point(195, 81),
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular),
                };
                panel.Controls.Add(job_descriptionlbl);

                var lbl = new Label
                {
                    Name = "jobLabel" + (i + 1).ToString(),
                    Text = Global.gbJobtype[i],
                    //Text = "---" + i.ToString(),
                    Size = new Size(300, 29),
                    Location = new Point(195, 3),
                    Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold),
                };
                panel.Controls.Add(lbl);

                var btn = new Button
                {
                    Name = i.ToString(),
                    //Name = "jobButton" + (i + 1).ToString(),
                    Text = "View Details",
                    Size = new Size(193, 56),
                    Location = new Point(1060, 89),
                    BackgroundImage = BinanKiosk.Properties.Resources.button1,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackColor = Color.LightGray,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Arial Narrow", 18, FontStyle.Bold),
                };
                panel.Controls.Add(btn);
                btn.Click += new EventHandler(this.button_Click);
                btn.FlatAppearance.BorderSize = 0;
            }



            


        }//Load Ends

        void picture_Click(object sender, System.EventArgs e)
        {
            PictureBox pictureClick = sender as PictureBox;
            MessageBox.Show(Global.gbJobtype[Convert.ToInt32(pictureClick.Name)]);

            selectedJob = Global.gbJobtype[Convert.ToInt32(pictureClick.Name)];
            Global.gbSelectedJob = selectedJob;

            JobResultExpand jre = new JobResultExpand(dumvalue);
            this.Hide();
            jre.FormClosed += (s, args) => this.Close();
            jre.ShowDialog();
            jre.Focus();

            //MessageBox.Show(pictureClick.Name);
            //your stuff...
        }

        void button_Click(object sender, System.EventArgs e)
        {
            
            Button btnClick = sender as Button;
            MessageBox.Show(Global.gbJobtype[Convert.ToInt32(btnClick.Name)]);

            selectedJob = Global.gbJobtype[Convert.ToInt32(btnClick.Name)];
            Global.gbSelectedJob = selectedJob;

            JobResultExpand jre = new JobResultExpand(dumvalue);
            this.Hide();
            jre.FormClosed += (s, args) => this.Close();
            jre.ShowDialog();
            jre.Focus();

            //MessageBox.Show(btnClick.Name);

            //your stuff...
        }

        void panel_Click(object sender, System.EventArgs e)
        {
            Panel pnlClick = sender as Panel;
            MessageBox.Show(Global.gbJobtype[Convert.ToInt32(pnlClick.Name)]);

            selectedJob = Global.gbJobtype[Convert.ToInt32(pnlClick.Name)];
            Global.gbSelectedJob = selectedJob;

            JobResultExpand jre = new JobResultExpand(dumvalue);
            this.Hide();
            jre.FormClosed += (s, args) => this.Close();
            jre.ShowDialog();
            jre.Focus();

            //MessageBox.Show(pnlClick.Name);

            //your stuff...
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
            lbldate.Text = DateTime.Now.ToLongDateString() + System.Environment.NewLine + DateTime.Now.ToLongTimeString();
        }

        private void timestamp_Tick(object sender, EventArgs e)
        {
            timestamp.Enabled = true;
            timestamp.Tick += new System.EventHandler(OnTimerEvent);
        }
    }
}
