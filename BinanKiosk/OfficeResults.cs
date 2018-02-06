﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanKiosk
{
    

    public partial class OfficeResults : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public OfficeResults()
        {
            InitializeComponent();
        }

        private void OfficeResults_Load(object sender, EventArgs e)
        {

            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";
                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblSearch.Text = "       RESULTA";

                lblOfficeName.Text = "Departamento";
                lblPersonnels.Text = "Mga Empleado";
                lblDescription.Text = "Paglalarawan";

                btnLocate.Text = "Hanapin Ang Opisina";
            }
            else
            {
                btnLocate.Size = new Size(175, 90);
            }

            lblName.Text = Global.gbDepartment;
            lblLocation.Text = Global.gbRoom;
            lblPersonel.Text = Global.gbFirstName + " " + Global.gbMI + " " + Global.gbLastName;
            dep_description.Text = Global.gbDepDesc;

            if (Global.gbDepartment == "OFFICE OF THE CITY COOPERATIVES") {
                btnLocate.Visible = false;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY VETERINARIAN")
            {
                btnLocate.Visible = false;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY EDUCATION")
            {
                btnLocate.Visible = false;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY POPULATION ")
            {
                btnLocate.Visible = false;
            }
            else if (Global.gbDepartment == "PUBLIC EMPLOYMENT SERVICE OFFICE")
            {
                btnLocate.Visible = false;
            }
            else if (Global.gbDepartment == "OSPITAL NG BIÑAN")
            {
                btnLocate.Visible = false;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY HEALTH OFFICER")
            {
                btnLocate.Visible = false;
            }


            timestamp.Interval = 10;
            timestamp.Start();
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

        private void btnLocate_Click(object sender, EventArgs e)
        {
            if (Global.gbDepartment == "OFFICE OF THE CITY COOPERATIVES OFFICER")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY MAYOR")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.proceed("Floor2_stair7");
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY ASSESSOR")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.Floor1_9();
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY CIVIL REGISTRAR")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.Floor1_1();
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OFFICE OF THE CHRD")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY INFORMATION OFFICER")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.proceed("Floor2_12");
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY VETERINARIAN")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY EDUCATION OFFICER")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY POPULATION OFFICER")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "PUBLIC EMPLOYMENT SERVICE OFFICE")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.proceed("Floor2_stair3");
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OSPITAL NG BIÑAN")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY VICE MAYOR")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.proceed("Floor2_5");
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY HEALTH OFFICER")
            {
                btnLocate.Visible = true;
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY ENGINEER")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.proceed("Floor2_stair11");
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
            else if (Global.gbDepartment == "OFFICE OF THE CITY GERNERAL SERVICES OFFICER")
            {
                this.Hide();
                GroundFloor gf = new GroundFloor();
                gf.proceed("Floor2_stair1");
                gf.disableButton();
                gf.ShowDialog();
                this.Close();
            }
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            Jobs jb = new Jobs();
            this.Hide();
            jb.FormClosed += (s, args) => this.Close();
            jb.Show();
            jb.Focus();

        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            GovernmentServices sv = new GovernmentServices();
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.Show();
            sv.Focus();
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.FormClosed += (s, args) => this.Close();
            gf.Show();
            gf.Focus();
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

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
        }
    }
}
