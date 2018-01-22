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
using System.IO;

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
            filldata();
            testview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void filldata()
        {
            //string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            testview.AutoGenerateColumns = false;
            testview.ColumnCount = 1;
            //testview.Columns[0].Name = "";

            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol.Name = "   ";

            testview.Columns.Add(imgcol);

            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string imgString = Path.Combine(projectPath, "Resources\\btnorangere.png");
            Image img = Image.FromFile(imgString);
            //Image img = Image.FromFile(@"C:/Users/doratheexplorer/Desktop/BINANKIOSK RESOURCE/BinanKiosk marvin/BinanKiosk/Resources/btnorangere.png");

            
            object[] row = new object[] { "Payment of Real Property Transfer Tax", img };
            testview.Rows.Add(row);

            row = new object[] { "Issuance of Community Tax Certificate for Corporation", img };
            testview.Rows.Add(row);

            row = new object[] { "Issuance of Professional Tax Reciept", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Real Property Tax", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Business Tax", img };
            testview.Rows.Add(row);

            row = new object[] { "Certification of Tax Clearance", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Burial", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Building Permit", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Police, Mayor, and Other Certificate Clearance", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Civil Registration", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Traffic Violation", img };
            testview.Rows.Add(row);

            row = new object[] { "Issuance of Community Tax for Individual", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Weight and Measure License Fees", img };
            testview.Rows.Add(row);

            row = new object[] { "Payment of Market Stalls and Electrical Fees", img };
            testview.Rows.Add(row);




            DataGridViewColumn colsize = testview.Columns[0];
            colsize.Width = 420;
            DataGridViewColumn colsize2 = testview.Columns[1];
            colsize2.Width = 250;
            DataGridViewRow rowsize = testview.Rows[0];
            rowsize.Height = 60;

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
            lbldate.Text = DateTime.Now.ToLongDateString();
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

        private void testview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string test2 = testview.SelectedRows[0].Cells[""].Value.ToString();

            if (test2 == "Payment of Real Property Transfer Tax")
            {
                valuebtn.Text = "Payment of Real Property Transfer Tax";
                nextForm();

            }

            else if (test2 == "Issuance of Community Tax Certificate for Corporation")
            {

                valuebtn.Text = "Issuance of Community Tax Certificate for Corporation";
                nextForm();

            }

            else if (test2 == "Issuance of Professional Tax Reciept")
            {

                valuebtn.Text = "Issuance of Professional Tax Reciept";
                nextForm();

            }

            else if (test2 == "Payment of Real Property Tax")
            {

                valuebtn.Text = "Payment of Real Property Tax";
                nextForm();

            }

            else if (test2 == "Payment of Business Tax")
            {

                valuebtn.Text = "Payment of Business Tax";
                nextForm();

            }

            else if (test2 == "Certification of Tax Clearance")
            {

                valuebtn.Text = "Certification of Tax Clearance";
                nextForm();

            }

            else if (test2 == "Payment of Burial")
            {

                valuebtn.Text = "PayBurial";
                nextForm();

            }

            else if (test2 == "Payment of Building Permit")
            {

                valuebtn.Text = "PayBlg";
                nextForm();

            }

            else if (test2 == "Payment of Police, Mayor, and Other Certificate Clearance")
            {

                valuebtn.Text = "PayPol";
                nextForm();

            }

            else if (test2 == "Payment of Civil Registration")
            {

                valuebtn.Text = "PayCivilReg";
                nextForm();

            }

            else if (test2 == "Payment of Traffic Violation")
            {

                valuebtn.Text = "PayTraffic";
                nextForm();

            }

            else if (test2 == "Issuance of Community Tax for Individual")
            {

                valuebtn.Text = "IssueComTax";
                nextForm();

            }

            else if (test2 == "Payment of Weight and Measure License Fees")
            {

                valuebtn.Text = "PayWeight";
                nextForm();

            }

            else if (test2 == "Payment of Market Stalls and Electrical Fees")
            {

                valuebtn.Text = "PayPolClear";
                nextForm();

            }

        }
    }
}
