using System;
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

        public JobResult()
        {
            InitializeComponent();
            logo.ImageLocation = pictures[0];
            ad.ImageLocation = pictures[1];
            logo1.ImageLocation = pictures[0];
            ad1.ImageLocation = pictures[1];
            logo2.ImageLocation = pictures[0];
            ad2.ImageLocation = pictures[1];
        }

        private void JobResult_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.ShowDialog();
            this.Close();
        }
    }
}
