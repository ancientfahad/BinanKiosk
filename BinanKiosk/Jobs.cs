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
using System.IO;
using System.Diagnostics;

namespace BinanKiosk
{
    public partial class Jobs : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=" + "localhost" + ";" + "DATABASE=" + "binan_kiosk" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";");
        MySqlDataReader reader;
        MySqlCommand cmd;

        String[] jobList = new String[100], categoryList = new String[100];

        string jobID = "";
        bool exist = false;
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
            valueBox.Text = "";
        }


        //FUNCTIONS///////////////////////////////////////////////////////////////////////
        public void Reader()
        {
            conn.Open();

            cmd = new MySqlCommand("SELECT jobs.job_name, jobs.job_id FROM jobs WHERE jobs.job_name ='" + valueBox.Text + "' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                jobID = reader["job_id"].ToString();
                exist = true;
            }
            else
            {
                exist = false;
            }
            reader.Close();

            cmd = new MySqlCommand("SELECT COUNT(jobtypes.job_id) AS count FROM jobtypes WHERE jobtypes.job_id = '" + jobID +  "' ", conn);
            //cmd1 = new MySqlCommand("SELECT COUNT(officials.first_name) AS count FROM officials WHERE officials.first_name LIKE '"+ txtSearch.Text +"%' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                index = Convert.ToInt32(reader["count"]);
                Global.gbJobtype = new string[index];
                Global.gbJoblocation = new string[index];
                Global.gbJobdescription = new string[index];
                Global.gbJobCompany = new string[index];
            }
            reader.Close();
            
            //MessageBox.Show(Global.gbJobtype.Length.ToString());

            if (exist == true) {
                cmd = new MySqlCommand("SELECT jobtypes.job_types, jobtypes.job_location, jobtypes.job_company, jobtypes.job_description FROM jobtypes WHERE jobtypes.job_id = '" + jobID + "' ", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    Global.gbJobtype[count] = reader["job_types"].ToString();
                    Global.gbJoblocation[count] = reader["job_location"].ToString();
                    Global.gbJobCompany[count] = reader["job_company"].ToString();
                    Global.gbJobdescription[count] = reader["job_description"].ToString();

                    count++;
                }

                reader.Close();
                conn.Close();
            }
        }

        public void NextForm()
        {
            JobResult jr = new JobResult(valueBox.Text);
            this.Hide();
            jr.FormClosed += (s, args) => this.Close();
            jr.ShowDialog();
            jr.Focus();
        }
        
        private void Jobs_Load(object sender, EventArgs e)
        {
            //hideButtons();

            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";

                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblJob.Text = "       MGA TRABAHO";
                lblList.Text = "Listahan Ng Trabaho";
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

        /*public void hidePanels()
        {

            Button[] btnArray = { searchResult1, searchResult2, searchResult3, searchResult4, searchResult5, searchResult6, searchResult7, searchResult8, searchResult9, searchResult10 };

            for (int i = 0; i < btnArray.Length; i++)
            {
                btnArray[i].Visible = false;
            }
        }*/
        ///MENU BUTTONS/////////////////////////////////////////////////////////////////

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

        private void searchResult_Click(object sender, EventArgs e)
        {
            Global.job = (sender as Button).Text;
            MessageBox.Show(Global.job);

            JobResult jr = new JobResult(valueBox.Text);
            this.Hide();
            jr.FormClosed += (s, args) => this.Close();
            jr.ShowDialog();
            jr.Focus();
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString() + System.Environment.NewLine + DateTime.Now.ToLongTimeString();
        }
        ///JOB BUTTONS////////////////////////////////////////////////////////////////////////////////

        private void Ad_Jobsbtn_Click(object sender, EventArgs e)
        {
            valueBox.Text = Ad_Jobsbtn.Text;
            Reader();
            NextForm();
        }

        private void Agriculture_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = Agriculture_btn.Text;
            Reader();
            NextForm();
        }

        private void archi_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = archi_btn.Text;
            Reader();
            NextForm();
        }

        private void elect_Engbtn_Click(object sender, EventArgs e)
        {
            valueBox.Text = elect_Engbtn.Text;
            Reader();
            NextForm();
        }

        private void ent_jobbtn_Click(object sender, EventArgs e)
        {
            valueBox.Text = ent_jobbtn.Text;
            Reader();
            NextForm();
        }

        private void civil_engbtn_Click(object sender, EventArgs e)
        {
            valueBox.Text = civil_engbtn.Text;
            Reader();
            NextForm();
        }

        private void secretary_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = secretary_btn.Text;
            Reader();
            NextForm();
        }

        private void hotel_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = hotel_btn.Text;
            Reader();
            NextForm();
        }

        private void merchandising_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = merchandising_btn.Text;
            Reader();
            NextForm();
        }

        private void restaurant_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = restaurant_btn.Text;
            Reader();
            NextForm();
        }

        private void retail_sales_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = retail_sales_btn.Text;
            Reader();
            NextForm();
        }

        private void manufacturing_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = manufacturing_btn.Text;
            Reader();
            NextForm();
        }

        private void realEstate_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = realEstate_btn.Text;
            Reader();
            NextForm();
        }

        private void education_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = education_btn.Text;
            Reader();
            NextForm();
        }

        private void customerService_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = customerService_btn.Text;
            Reader();
            NextForm();
        }

        private void IT_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = IT_btn.Text;
            Reader();
            NextForm();
        }

        private void bankingFinancial_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = bankingFinancial_btn.Text;
            Reader();
            NextForm();
        }

        private void oilGasEngr_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = oilGasEngr_btn.Text;
            Reader();
            NextForm();
        }

        private void industrialEngr_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = industrialEngr_btn.Text;
            Reader();
            NextForm();
        }

        private void personalCare_btn_Click(object sender, EventArgs e)
        {
            valueBox.Text = personalCare_btn.Text;
            Reader();
            NextForm();
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
        }




        ///ETC//////////////////////////////////////////////////////////////////////////////////////////////
        private void timestamp_Tick(object sender, EventArgs e)
        {
            timestamp.Enabled = true;
            timestamp.Tick += new System.EventHandler(OnTimerEvent);
        }
    }
}

/*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    conn.Close();
}
}*/


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
