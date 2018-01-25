using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace BinanKiosk
{
    public partial class GovernmentServices : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=" + "localhost" + ";" + "DATABASE=" + "binan_kiosk" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "" + ";");
        MySqlDataReader reader;
        MySqlCommand cmd;

        int index = 0, pages = 0, serviceIndex = 0;

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

        public GovernmentServices()
        {

            InitializeComponent();
            valuebtn.Text = "";

        }

        ////********Government Service Buttons********////
        private void GovernmentServices_Load(object sender, EventArgs e)
        {


            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";

                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblServices.Text = "       MGA SERBISYO";
            }

            conn.Open();
            cmd = new MySqlCommand("SELECT COUNT(services.service_name) AS count FROM services", conn);
            //cmd1 = new MySqlCommand("SELECT COUNT(officials.first_name) AS count FROM officials WHERE officials.first_name LIKE '"+ txtSearch.Text +"%' ", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                index = Convert.ToInt32(reader["count"]);
                exist = true;
                Global.gbDbService = new string[index];
            }
            reader.Close();

            if (exist == true)
            {
                cmd = new MySqlCommand("SELECT services.service_name FROM services", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    Global.gbDbService[count] = reader["service_name"].ToString();
                    count++;
                }

                reader.Close();
                conn.Close();
            }

            timestamp.Interval = 1;
            timestamp.Start();

            showObjects();
        }

        ///*********Basic Buttons**********///
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

            MessageBox.Show("These are the services provided by the City of Binan. The Search button allows you to search our directory for officers, rooms, and applications. You may select the service you choose to the view its requirements and process.");
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

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            index = index - 6;
            pages++;

            if (index < 0)
            {
                pages--;
                index = index + 6;
                MessageBox.Show("YOU ARE AT THE LAST PAGE!");
            }
            else
            {
                showObjects();
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (pages != 0)
            {
                pages--;
                index = index + 6;

                showObjects();
            }
            else
            {
                MessageBox.Show("YOU ARE AT THE FIRST PAGE!");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Global.selectedBox0 = 0;
            for (int x = 0; x < pages; x++)
            {
                Global.selectedBox0 = Global.selectedBox0 + 6;
            }

            ServiceView sv = new ServiceView(Global.selectedBox0);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();

            MessageBox.Show(Global.gbDbService[Global.selectedBox0]);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Global.selectedBox0 = 1;
            for (int x = 0; x < pages; x++)
            {
                Global.selectedBox1 = Global.selectedBox1 + 6;
            }

            ServiceView sv = new ServiceView(Global.selectedBox1);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();

            MessageBox.Show(Global.gbDbService[Global.selectedBox1]);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Global.selectedBox0 = 2;
            for (int x = 0; x < pages; x++)
            {
                Global.selectedBox2 = Global.selectedBox2 + 6;
            }

            ServiceView sv = new ServiceView(Global.selectedBox2);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();

            MessageBox.Show(Global.gbDbService[Global.selectedBox2]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Global.selectedBox0 = 3;
            for (int x = 0; x < pages; x++)
            {
                Global.selectedBox3 = Global.selectedBox3 + 6;
            }

            ServiceView sv = new ServiceView(Global.selectedBox3);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();

            MessageBox.Show(Global.gbDbService[Global.selectedBox3]);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Global.selectedBox0 = 4;
            for (int x = 0; x < pages; x++)
            {
                Global.selectedBox4 = Global.selectedBox4 + 6;
            }

            ServiceView sv = new ServiceView(Global.selectedBox4);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();

            MessageBox.Show(Global.gbDbService[Global.selectedBox4]);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Global.selectedBox0 = 5;
            for (int x = 0; x < pages; x++)
            {
                Global.selectedBox5 = Global.selectedBox5 + 6;
            }

            ServiceView sv = new ServiceView(Global.selectedBox5);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();

            MessageBox.Show(Global.gbDbService[Global.selectedBox5]);
        }

        public void hideObjects()
        {
            Button[] btnArray = { btn0, btn1, btn2, btn3, btn4, btn5 };
            Label[] lblArray = { label0, label1, label2, label3, label4, label5 };
            PictureBox[] pboxArray = { pictureBox0, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            for (int i = 0; i < btnArray.Length; i++)
            {
                btnArray[i].Visible = false;
                lblArray[i].Visible = false;
                pboxArray[i].Visible = false;
            }
        }

        public void showObjects()
        {
            Button[] btnArray = { btn0, btn1, btn2, btn3, btn4, btn5 };
            Label[] lblArray = { label0, label1, label2, label3, label4, label5};
            PictureBox[] pboxArray = { pictureBox0, pictureBox1, pictureBox2,pictureBox3, pictureBox4, pictureBox5};

            serviceIndex = 0;
            for (int x = 0; x < pages; x++)
            {
                serviceIndex = serviceIndex + 6;
            }
            
            if (btnArray.Length < index)
            {
                hideObjects();
                
                for (int i = 0; i < btnArray.Length; i++)
                {
                    btnArray[i].Visible = true;
                    lblArray[i].Visible = true;
                    pboxArray[i].Visible = true;

                    lblArray[i].Text = Global.gbDbService[serviceIndex];
                    serviceIndex++;
                }
            }
            else if (btnArray.Length > index)
            {
                hideObjects();
                
                for (int i = 0; i < index; i++)
                {
                    btnArray[i].Visible = true;
                    lblArray[i].Visible = true;
                    pboxArray[i].Visible = true;

                    lblArray[i].Text = Global.gbDbService[serviceIndex];
                    serviceIndex++;
                }
            }
        }
    }
}
