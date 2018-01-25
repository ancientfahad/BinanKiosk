using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Diagnostics;
using System.Timers;
using System.IO;

namespace BinanKiosk
{
    public partial class Home : Form
    {
        private static int i;
        private static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        private static string[] pictures = new string[]
        {
            Path.Combine(projectPath, "Resources\\Slides\\1.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\2.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\3.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\4.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\5.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\6.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\7.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\8.jpg"),
            Path.Combine(projectPath, "Resources\\Slides\\9.jpg"),
    };


        public Home()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = pictures[i];
            timer1.Interval = 5000;
            timer1.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Changing the button texts programmatically. Global variable is being checked if the user choosed English or Tagalog;

            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";
                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
            }

            timestamp.Interval = 1;
            timestamp.Start();
        }

        public int seconds = 0;

        public void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 900) {
                this.Hide();
                Language lg = new Language();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.FormClosed += (s, args) => this.Close();
            hm.ShowDialog();
            hm.Focus();

            //this.Hide();
            //Home hm = new Home();
            //hm.ShowDialog();
            //this.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search src = new Search();
            this.Hide();
            src.FormClosed += (s, args) => this.Close();
            src.ShowDialog();
            src.Focus();
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {

            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.FormClosed += (s, args) => this.Close();
            gf.ShowDialog();
            gf.Focus();
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
            Jobs jb = new Jobs();
            this.Hide();
            jb.FormClosed += (s, args) => this.Close();
            jb.ShowDialog();
            jb.Focus();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            /* Help hlp = new Help();
             this.Hide();
             hlp.FormClosed += (s, args) => this.Close();
             hlp.ShowDialog();
             hlp.Focus();*/
            MessageBox.Show("Welcome to the Binan City Hall Kiosk, the MAP button provides an interactive map that directs you to your choice of destination. The ");
        }



        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i += 1;
            if (i == pictures.Length) i = 0;
            pictureBox1.ImageLocation = pictures[i];
            Text = pictureBox1.ImageLocation;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0) i = pictures.Length;
            i -= 1;
            pictureBox1.ImageLocation = pictures[i];
            Text = pictureBox1.ImageLocation;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i == pictures.Length) i = 0;
            pictureBox1.ImageLocation = pictures[i];
            Text = pictureBox1.ImageLocation;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
