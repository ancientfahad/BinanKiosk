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
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
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

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            //Global is  a class & language is a variable which is basically being used as a global variable for storing the choosen language;
            Global.language = "English";

            Home hm = new Home();
            this.Hide();
            hm.FormClosed += (s, args) => this.Close();
            hm.ShowDialog();
            hm.Focus();
        }

        private void btnFilipino_Click(object sender, EventArgs e)
        {
            Global.language = "Filipino";

            this.Hide();
            Home hm = new Home();
            hm.ShowDialog();
            hm.Focus();
        }

        private void Language_Load(object sender, EventArgs e)
        {
        }
    }
}
