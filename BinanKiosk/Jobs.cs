using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BinanKiosk
{
    public partial class Jobs : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=" + "localhost" + ";" + "DATABASE=" + "binan_kiosk" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";");
        MySqlDataReader reader;
        MySqlCommand cmd;

        String[] jobList = new String[100], categoryList = new String[100];
        
        int index = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public Jobs()
        {
            InitializeComponent();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            hideButtons();

            if (Global.language == "Filipino")
            {
                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Serbisyo";
                btnJob.Text = "Trabaho";
                btnHelp.Text = "Tulong";
                lblJob.Text = "       TRABAHO";
            }

            timestamp.Interval = 10;
            timestamp.Start();
        }



        /*public void lists() {
            //Job
            conn.Open();
            cmd = new MySqlCommand("SELECT job_name FROM jobs", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                jobList[index] = reader.GetString(0).ToString();
                index++;
            }

            MessageBox.Show(jobList[index - 1]);

            reader.Close();
            conn.Close();

            //Category
            conn.Open();
            cmd = new MySqlCommand("SELECT job_category FROM jobs", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categoryList[index] = reader.GetString(0).ToString();
                index++;
            }

            MessageBox.Show(categoryList[index - 1]);

            reader.Close();
            conn.Close();
        }*/

        public void hideButtons()
        {

            Button[] btnArray = { searchResult1, searchResult2, searchResult3, searchResult4, searchResult5, searchResult6, searchResult7, searchResult8, searchResult9, searchResult10 };

            for (int i = 0; i < btnArray.Length; i++)
            {
                btnArray[i].Visible = false;
            }
        }

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
            Help hlp = new Help();
            this.Hide();
            hlp.FormClosed += (s, args) => this.Close();
            hlp.ShowDialog();
            hlp.Focus();
        }

        private void searchResult_Click(object sender, EventArgs e)
        {
            Global.job = (sender as Button).Text;
            MessageBox.Show(Global.job);

            
            JobResult jr = new JobResult();
            this.Hide();
            jr.FormClosed += (s, args) => this.Close();
            jr.ShowDialog();
            jr.Focus();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);

            Button[] btnArray = { searchResult1, searchResult2, searchResult3, searchResult4, searchResult5, searchResult6, searchResult7, searchResult8, searchResult9, searchResult10 };
            hideButtons();

            //Job
            conn.Open();
            cmd = new MySqlCommand("SELECT job_name FROM jobs WHERE job_category = '" +comboBox1.Text+ "' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            index = 0;

            while (reader.Read())
            {
                jobList[index] = reader.GetString(0).ToString();
                index++;
            }

            //MessageBox.Show(index.ToString());
            //MessageBox.Show(jobList[index - 1]);
            //MessageBox.Show(jobList.Length.ToString());

            reader.Close();
            conn.Close();

            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    btnArray[i].Text = jobList[i];
                    btnArray[i].Visible = true;
                }
            }

            //Category

            /*conn.Open();
            cmd = new MySqlCommand("SELECT job_category FROM jobs", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categoryList[index] = reader.GetString(0).ToString();
                index++;
            }

            MessageBox.Show(categoryList[index - 1]);

            reader.Close();
            conn.Close();*/
        }
    }
}

/*Accounting/Finance
Admin/Human Resources
Arts/Media/Communications
Building/Construction
Computer/Information Technology
Education/Training
Engineering
Healthcare
Hotel/Restaurant
Manufacturing
Sales/Marketing
Sciences
Services
Others*/
