using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace BinanKiosk
{
    public partial class Search : Form
    {

        MySqlConnection conn = new MySqlConnection("SERVER=" + "localhost" + ";" + "DATABASE=" + "binan_kiosk" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";");
        MySqlDataReader reader, reader1;
        MySqlCommand cmd, cmd1;

        AutoCompleteStringCollection officerCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection officeCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection serviceCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection jobCollection = new AutoCompleteStringCollection();

        String[] officerList, officeList, serviceList, jobList;

        int count = 0, countOffice = 0, countService = 0, countJob = 0;
        int index = 0, indexOffice = 0, indexService = 0, indexJob = 0;

        string jobID = "";
        bool exist = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            //Language
            #region

            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";

                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblSearch.Text = "       HANAPIN";

                radioOfficers.Text = "Mga Opisyal";
                radioOffices.Text = "Kagawaran";
                radioApplications.Text = "Mga Serbisyo"; 
            }

            #endregion

            //Officer
            #region

            conn.Open();
            cmd = new MySqlCommand("SELECT CONCAT (officials.first_name, ' ', officials.middle_initial, ' ', officials.last_name, ' ', officials.suffex) AS name FROM officials", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                officerCollection.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();

            #endregion

            //Office
            #region

            conn.Open();
            cmd = new MySqlCommand("SELECT department_name FROM departments", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                officeCollection.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();

            #endregion

            //Services
            #region

            conn.Open();
            cmd = new MySqlCommand("SELECT service_name FROM services", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                serviceCollection.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();

            #endregion

            //Jobs
            #region
            
            conn.Open();
            cmd = new MySqlCommand("SELECT job_name FROM jobs", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                jobCollection.Add(reader.GetString(0));
            }

            reader.Close();
            conn.Close();

            #endregion

            timestamp.Interval = 1;
            timestamp.Start();

        }

        //RadioButtons
        #region

        private void radioOfficers_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.AutoCompleteCustomSource = officerCollection;
        }
    
        private void radioOffices_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.AutoCompleteCustomSource = officeCollection;
        }

        private void radioApplications_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.AutoCompleteCustomSource = serviceCollection;
        }

        private void radioJob_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.AutoCompleteCustomSource = jobCollection;
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnSrch_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string clicked = btn.Text;

            if (radioOfficers.Checked)
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT officials.first_name, officials.last_name, officials.middle_initial, departments.department_name, positions.position_name, departments.room_name FROM officials JOIN departments ON officials.officials_id = departments.officials_id JOIN positions ON officials.officials_id = positions.officials_id WHERE CONCAT (officials.first_name, ' ', officials.middle_initial, ' ', officials.last_name, ' ', officials.suffex) LIKE '%" + clicked + "%' ", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    Global.gbFirstName = reader["first_name"].ToString();
                    Global.gbLastName = reader["last_name"].ToString();
                    Global.gbMI = reader["middle_initial"].ToString();
                    Global.gbDepartment = reader["department_name"].ToString();
                    Global.gbPosition = reader["position_name"].ToString();
                    Global.gbRoom = reader["room_name"].ToString();
                }

                reader.Close();
                conn.Close();

                OfficerResult officer = new OfficerResult();
                this.Hide();
                officer.FormClosed += (s, args) => this.Close();
                officer.ShowDialog();
                this.Close();

            }
            else if (radioOffices.Checked)
            {

                conn.Open();
                cmd = new MySqlCommand("SELECT officials.first_name, officials.last_name, officials.middle_initial, departments.department_name, departments.room_name, departments.Dep_description FROM officials JOIN departments ON officials.officials_id = departments.officials_id JOIN positions ON officials.officials_id = positions.officials_id WHERE departments.department_name LIKE '%" + clicked + "%' ", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Read();
                    Global.gbFirstName = reader["first_name"].ToString();
                    Global.gbLastName = reader["last_name"].ToString();
                    Global.gbMI = reader["middle_initial"].ToString();
                    Global.gbDepartment = reader["department_name"].ToString();
                    Global.gbRoom = reader["room_name"].ToString();
                    Global.gbDepDesc = reader["Dep_description"].ToString();
                }
                reader.Close();
                conn.Close();

                OfficeResults office = new OfficeResults();
                this.Hide();
                office.FormClosed += (s, args) => this.Close();
                office.ShowDialog();
                this.Close();

            }
            else if (radioApplications.Checked)
            {

                conn.Open();
                cmd = new MySqlCommand("SELECT services.service_name FROM services WHERE service_name LIKE '%" + clicked + "%' ", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Read();
                    Global.gbService = reader["service_name"].ToString();
                }

                reader.Close();
                conn.Close();


                /*string passed = "";

                if (Global.gbService == "Payment of Real Property Transfer Tax") {
                    passed = "a";
                }
                else if (Global.gbService == "Issuance of Community Tax Certificate for Corporation")
                {
                    passed = "b";
                }
                else if (Global.gbService == "Issuance of Professional Tax Reciept")
                {
                    passed = "c";
                }
                else if (Global.gbService == "Payment of Real Property Tax")
                {
                    passed = "d";
                }
                else if (Global.gbService == "Payment of Business Tax")
                {
                    passed = "e";
                }
                else if (Global.gbService == "Certification of Tax Clearance")
                {
                    passed = "f";
                }
                */
                ServiceView sv = new ServiceView(Global.gbService);
                this.Hide();
                sv.FormClosed += (s, args) => this.Close();
                sv.ShowDialog();
                sv.Focus();
            }
            else if (radioJob.Checked)
            {
                Global.gbSelectedSearchJob = (sender as Button).Text;
                ReaderSearch();

                JobResult jr = new JobResult(Global.gbSelectedSearchJob);
                this.Hide();
                jr.FormClosed += (s, args) => this.Close();
                jr.ShowDialog();
                jr.Focus();
            }
            else
            {
                ///
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //Code being used to open the virtual keyboard. This is something fishy, sometimes it works, sometimes it doesn't;
            ///Fahad it works well if the computer is on tablet mode **for touchscreen laptops**
            ///change file location for any other computer, taptip file location


            string progFiles = @"C:\Program Files\Common Files\microsoft shared\ink";
            string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            Process.Start(onScreenKeyboardPath);

            //to check what radio button has been checked
            /*if (radioButton1.Checked)
            {
                ///once we have the database, we can streamread the userinput that matches with the database name and info
                ///i put sir mon's name for now as a testing since we don't have a result's form yet and database
                if (txtSearch.Text == "mon")
                {
                    search_animate.Visible = true;//just an illusion that the program is searching
                    nothing_found.Visible = false;
                    Thread.Sleep(3000);
                    OfficerResult offres = new OfficerResult();
                    this.Hide();
                    offres.ShowDialog();
                    this.ShowDialog();
                }

                else
                {
                    nothing_found.Visible = true;//what to appear if nothing matches the query to the database
                }
            }

            if (Search_all.Checked == true)
            {
                if (txtSearch.Text == "Mon")
                {
                    nothing_found.Visible = false;
                    OfficerResult offres = new OfficerResult();
                    this.Hide();
                    offres.ShowDialog();
                    this.ShowDialog();
                }

                else
                {
                    nothing_found.Visible = true;
                }
            }*/
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Button[] btnArray = { searchResult1, searchResult2, searchResult3, searchResult4, searchResult5, searchResult6, searchResult7, searchResult8, searchResult9, searchResult10, searchResult11, searchResult12, searchResult13, searchResult14, searchResult15 };

            if (radioOfficers.Checked)
            {
                lists();
                hideButtons();

                if (index > 0 && index != 15)
                {
                    for (int i = 0; i < officerList.Length; i++)
                    {
                        btnArray[i].Text = officerList[i];
                        btnArray[i].Visible = true;
                    }
                }
                else
                {
                    hideButtons();
                }
            }
            else if (radioOffices.Checked)
            {
                officeLists();
                hideButtons();

                if (indexOffice > 0 && indexOffice != 15)
                {
                    /*if (index > 10) {
                        index = 10;
                    }*/

                    for (int i = 0; i < indexOffice; i++)
                    {
                        btnArray[i].Text = officeList[i];
                        btnArray[i].Visible = true;
                    }
                }
                else
                {
                    hideButtons();
                }
            }
            else if (radioApplications.Checked)
            {

                if (txtSearch.TextLength != 0)
                {
                    serviceLists();
                    hideButtons();
                    
                    if (indexService > 0 && indexService != 15)
                    {
                        /*if (index > 10) {
                            index = 10;
                        }*/

                        for (int i = 0; i < indexService; i++)
                        {
                            btnArray[i].Text = serviceList[i];
                            btnArray[i].Visible = true;
                        }
                    }
                }
                else
                {
                    hideButtons();
                }
            }
            else if (radioJob.Checked)
            {

                if (txtSearch.TextLength != 0)
                {
                    jobLists();
                    hideButtons();

                    if (indexJob > 0 && indexJob <= 15)
                    {
                        /*if (index > 10) {
                            index = 10;
                        }*/

                        for (int i = 0; i < indexJob; i++)
                        {
                            btnArray[i].Text = jobList[i];
                            btnArray[i].Visible = true;
                        }
                    }
                    else if (indexJob > 15)
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            btnArray[i].Text = jobList[i];
                            btnArray[i].Visible = true;
                        }
                    }
                }
                else
                {
                    hideButtons();
                }
            }
        } //text changed

        private void OnTimerEvent(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void timestamp_Tick(object sender, EventArgs e)
        {
            timestamp.Enabled = true;
            timestamp.Tick += new System.EventHandler(OnTimerEvent);
        }

        public void ReaderSearch()
        {
            conn.Open();

            cmd = new MySqlCommand("SELECT jobs.job_name, jobs.job_id FROM jobs WHERE jobs.job_name LIKE '%" + Global.gbSelectedSearchJob + "%' ", conn);
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

            cmd = new MySqlCommand("SELECT COUNT(jobtypes.job_id) AS count FROM jobtypes WHERE jobtypes.job_id LIKE '%" + jobID + "%' ", conn);
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

            if (exist == true)
            {
                cmd = new MySqlCommand("SELECT jobtypes.job_types, jobtypes.job_location, jobtypes.job_company, jobtypes.job_description FROM jobtypes WHERE jobtypes.job_id LIKE '%" + jobID + "%' ", conn);
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

        public void lists() {

            conn.Open();

            cmd1 = new MySqlCommand("SELECT COUNT(officials.first_name) AS count FROM officials WHERE officials.first_name LIKE '%"+ txtSearch.Text + "%' OR officials.last_name LIKE '%" + txtSearch.Text + "%' OR officials.middle_initial LIKE '%" + txtSearch.Text + "%' ", conn);
            //cmd1 = new MySqlCommand("SELECT COUNT(officials.first_name) AS count FROM officials WHERE officials.first_name LIKE '"+ txtSearch.Text +"%' ", conn);
            cmd1.ExecuteNonQuery();
            reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                reader1.Read();
                index = Convert.ToInt32(reader1["count"]);
                officerList = new String[index];
            }
            reader1.Close();

            cmd = new MySqlCommand("SELECT CONCAT (officials.first_name, ' ', officials.middle_initial, ' ', officials.last_name, ' ', officials.suffex) AS name FROM officials WHERE officials.first_name LIKE '%"+ txtSearch.Text + "%' OR officials.last_name LIKE '%" + txtSearch.Text + "%' OR officials.middle_initial LIKE '%" + txtSearch.Text + "%' ", conn);
            //cmd = new MySqlCommand("SELECT CONCAT (officials.first_name, ' ', officials.middle_initial, ' ', officials.last_name, ' ', officials.suffex) AS name FROM officials WHERE officials.first_name LIKE '"+ txtSearch.Text +"%' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            count = 0;

            while (reader.Read())
            {
                officerList[count] = reader.GetString(0).ToString();
                count++;
            }

            reader.Close();
            conn.Close();
        }

        public void officeLists() {

            conn.Open();

            cmd1 = new MySqlCommand("SELECT COUNT(departments.department_name) AS count FROM departments WHERE department_name LIKE '%" + txtSearch.Text + "%' ", conn);
            cmd1.ExecuteNonQuery();
            reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                reader1.Read();
                indexOffice = Convert.ToInt32(reader1["count"]);
                officeList = new String[indexOffice];
            }
            reader1.Close();

            cmd = new MySqlCommand("SELECT departments.department_name FROM departments WHERE department_name LIKE '%" + txtSearch.Text + "%' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            countOffice = 0;

            while (reader.Read())
            {
                officeList[countOffice] = reader.GetString(0).ToString();
                countOffice++;
            }

            reader.Close();
            conn.Close();
        }

        public void serviceLists()
        {
            conn.Open();

            cmd1 = new MySqlCommand("SELECT COUNT(services.service_name) AS count FROM services WHERE service_name LIKE '%" + txtSearch.Text + "%' ", conn);
            cmd1.ExecuteNonQuery();
            reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                reader1.Read();
                indexService = Convert.ToInt32(reader1["count"]);
                serviceList = new String[indexService];

            }
            reader1.Close();

            cmd = new MySqlCommand("SELECT services.service_name FROM services WHERE service_name LIKE '%" + txtSearch.Text + "%'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            countService = 0;

            while (reader.Read())
            {
                serviceList[countService] = reader.GetString(0).ToString();
                countService++;
            }
            reader.Close();
            conn.Close();
        }

        public void jobLists()
        {
            conn.Open();

            cmd1 = new MySqlCommand("SELECT COUNT(jobs.job_name) AS count FROM jobs WHERE jobs.job_name LIKE '%" + txtSearch.Text + "%' ", conn);
            cmd1.ExecuteNonQuery();
            reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                reader1.Read();
                indexJob = Convert.ToInt32(reader1["count"]);
                jobList = new String[indexJob];
            }
            reader1.Close();
            
            cmd = new MySqlCommand("SELECT jobs.job_name FROM jobs WHERE jobs.job_name LIKE '%" + txtSearch.Text + "%' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            countJob = 0;

            while (reader.Read())
            {
                jobList[countJob] = reader.GetString(0).ToString();
                countJob++;
            }
            reader.Close();
            conn.Close();
        }

        public void allLists()
        {

            conn.Open();

            cmd1 = new MySqlCommand("SELECT COUNT(officials.first_name, officials.last_name, officials.middle_initial, departments.department_name, services.service_name, jobs.job_name) AS count FROM officials WHERE officials.first_name LIKE '%" + txtSearch.Text + "%' OR officials.last_name LIKE '%" + txtSearch.Text + "%' OR officials.middle_initial LIKE '%" + txtSearch.Text + "%' ", conn);
            //cmd1 = new MySqlCommand("SELECT COUNT(officials.first_name) AS count FROM officials WHERE officials.first_name LIKE '"+ txtSearch.Text +"%' ", conn);
            cmd1.ExecuteNonQuery();
            reader1 = cmd1.ExecuteReader();

            if (reader1.HasRows)
            {
                reader1.Read();
                index = Convert.ToInt32(reader1["count"]);
                officerList = new String[index];
            }
            reader1.Close();

            cmd = new MySqlCommand("SELECT CONCAT (officials.first_name, ' ', officials.middle_initial, ' ', officials.last_name, ' ', officials.suffex) AS name FROM officials WHERE officials.first_name LIKE '%" + txtSearch.Text + "%' OR officials.last_name LIKE '%" + txtSearch.Text + "%' OR officials.middle_initial LIKE '%" + txtSearch.Text + "%' ", conn);
            //cmd = new MySqlCommand("SELECT CONCAT (officials.first_name, ' ', officials.middle_initial, ' ', officials.last_name, ' ', officials.suffex) AS name FROM officials WHERE officials.first_name LIKE '"+ txtSearch.Text +"%' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            count = 0;

            while (reader.Read())
            {
                officerList[count] = reader.GetString(0).ToString();
                count++;
            }

            reader.Close();
            conn.Close();
        }

        public void hideButtons()
        {

            Button[] btnArray = { searchResult1, searchResult2, searchResult3, searchResult4, searchResult5, searchResult6, searchResult7, searchResult8, searchResult9, searchResult10, searchResult11, searchResult12, searchResult13, searchResult14, searchResult15 };

            for (int i = 0; i < btnArray.Length; i++)
            {
                btnArray[i].Visible = false;
            }
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
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

    }
}
