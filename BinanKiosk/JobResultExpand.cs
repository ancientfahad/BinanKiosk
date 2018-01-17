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
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace BinanKiosk
{
    public partial class JobResultExpand : Form
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

        public JobResultExpand()
        {
            InitializeComponent();
        }

        private void JobResultExpand_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Global.gbSelectedJob);

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
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            Jobs js = new Jobs();
            this.Hide();
            js.FormClosed += (s, args) => this.Close();
            js.ShowDialog();
            js.Focus();
        }
    }
}
