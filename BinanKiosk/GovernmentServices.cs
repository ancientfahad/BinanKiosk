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

        public void nextForm()
        {
            ServiceView sv = new ServiceView(valuebtn.Text);
            this.Hide();
            sv.FormClosed += (s, args) => this.Close();
            sv.ShowDialog();
            sv.Focus();
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
        
        
        //
        ///
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

            timestamp.Interval = 1;
            timestamp.Start();
        }

        private void Pay_PropTransbtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "Payment of Real Property Transfer Tax";
            nextForm();
        }

        private void IssueTaxCert_btn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "Issuance of Community Tax Certificate for Corporation";
            nextForm();
        }

        private void IssueProfTaxRec_btn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "Issuance of Professional Tax Reciept";
            nextForm();
        }

        private void PayRealPRopTax_btn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "Payment of Real Property Tax";
            nextForm();
        }

        private void PayBussTax_btn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "Payment of Business Tax";
            nextForm();
        }

        private void certofTaxClear_btn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "Certification of Tax Clearance";
            nextForm();
        }

        private void paymentBurialbtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayBurial";
            nextForm();
        }

        private void paymentBldgbtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayBlg";
            nextForm();
        }

        private void paymentPolMaybtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayPol";
            nextForm();
        }

        private void payCivRegFreebtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayCivilReg";
            nextForm();
        }

        private void payTraffViolatebtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayTraffic";
            nextForm();
        }

        private void issuanceComTaxbtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "IssueComTax";
            nextForm();
        }

        private void payWeightLicFeesbtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayWeight";
            nextForm();
        }

        private void payPolClearbtn_Click(object sender, EventArgs e)
        {
            valuebtn.Text = "PayPolClear";
            nextForm();
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
    }
}
