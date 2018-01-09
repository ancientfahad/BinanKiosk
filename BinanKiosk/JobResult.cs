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
            JobTitle.Text = Global.gbJobtype;
            location.Text = Global.gbJoblocation;
            jobsCompany1.Text = Global.gbJobCompany;
            description1.Text = Global.gbJobdescription;

            timestamp.Interval = 1;
            timestamp.Start();

            if (Global.language == "Filipino") {
                btnLanguages.Text = "PALITAN NG WIKA";

                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblJob.Text = "       RESULTA";
            }


        }

        public void pictureFill()
        {

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
