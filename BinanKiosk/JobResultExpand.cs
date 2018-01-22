using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace BinanKiosk
{
    public partial class JobResultExpand : Form
    {

        Image img;
        Point mouseDown;
        int startx = 0;             // offset of image when mouse was pressed
        int starty = 0;
        int imgx = 500;               // current offset of image
        int imgy = 0;

        bool mousepressed = false;  // true as long as left mousebutton is pressed
        float zoom = 1;

        public JobResultExpand()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //servicevalue.Text = val;

        }

        private void JobResultExpand_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Global.gbSelectedJob);
            fillPicture(Global.gbSelectedJob);
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            float oldzoom = zoom;

            if (e.Delta > 0)
            {
                zoom += 0.1F;
            }
            else if (e.Delta < 0)
            {
                zoom = Math.Max(zoom - 0.1F, 0.01F);
            }

            MouseEventArgs mouse = e as MouseEventArgs;
            Point mousePosNow = mouse.Location;

            // Where location of the mouse in the pictureframe
            int x = mousePosNow.X - jobpicture.Location.X;
            int y = mousePosNow.Y - jobpicture.Location.Y;

            // Where in the IMAGE is it now
            int oldimagex = (int)(x / oldzoom);
            int oldimagey = (int)(y / oldzoom);

            // Where in the IMAGE will it be when the new zoom i made
            int newimagex = (int)(x / zoom);
            int newimagey = (int)(y / zoom);

            // Where to move image to keep focus on one point
            imgx = newimagex - oldimagex + imgx;
            imgy = newimagey - oldimagey + imgy;

            jobpicture.Refresh();  // calls imageBox_Paint
        }

        private void imageBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.ScaleTransform(zoom, zoom);
            e.Graphics.DrawImage(img, imgx, imgy, 900, 1023);


        }

        private void pictureBox_MouseMove(object sender, EventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                Point mousePosNow = mouse.Location;

                // the distance the mouse has been moved since mouse was pressed
                int deltaX = mousePosNow.X - mouseDown.X;
                int deltaY = mousePosNow.Y - mouseDown.Y;

                // calculate new offset of image based on the current zoom factor
                imgx = (int)(startx + (deltaX / zoom));
                imgy = (int)(starty + (deltaY / zoom));

                jobpicture.Refresh();
            }
        }

        private void imageBox_MouseDown(object sender, EventArgs e)
        {
            MouseEventArgs mouse = e as MouseEventArgs;

            if (mouse.Button == MouseButtons.Left)
            {
                if (!mousepressed)
                {
                    mousepressed = true;
                    mouseDown = mouse.Location;
                    startx = imgx;
                    starty = imgy;
                }
            }
        }

        private void imageBox_MouseUp(object sender, EventArgs e)
        {
            mousepressed = false;
        }

        public void imgtaker(string imgstring)
        {

            //this.servpicture.Size = new System.Drawing.Size(1023, 536);




            img = Image.FromFile(imgstring);
            Graphics g = this.CreateGraphics();
            zoom = ((float)jobpicture.Width / (float)img.Width) *
                   (img.HorizontalResolution / g.DpiX);

            jobpicture.Paint += new PaintEventHandler(imageBox_Paint);
            //this.servpicture.SizeMode = PictureBoxSizeMode.Zoom;
            //System.Drawing.Image test = new Bitmap(img, new Size(500, 500));
            this.jobpicture.BorderStyle = BorderStyle.FixedSingle;


        }

        public void fillPicture(string val)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            if (val == "Payment of Real Property Transfer Tax")
            {

                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfRealPropertyTransferTax.jpg");
                //string imagefilename = @"C:\Users\doratheexplorer\Desktop\BinanKiosk\BinanKiosk\Resources\4_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "Issuance of Community Tax Certificate for Corporation")
            {
                //servpicture.Image = Properties.Resources.Issuance_taxcert_forcorp;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\issuanceOfCommunityTaxCertificate.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\2_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "Issuance of Professional Tax Reciept")
            {
                //servpicture.Image = Properties.Resources.issue_taxreciept;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\issuanceOfProfessionalTaxReceipt.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\3_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "Payment of Real Property Tax")
            {
                //servpicture.Image = Properties.Resources.proftaxreciept;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfRealPropertyTax.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\3_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "Payment of Business Tax")
            {
                //servpicture.Image = Properties.Resources.paymt_bussTax;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfBusinessTax.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\5_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "Certification of Tax Clearance")
            {
                //servpicture.Image = Properties.Resources.cert_taxClear;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\certificationsOfTaxClearence.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\6_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayBurial")
            {
                //servpicture.Image = Properties.Resources.payBurialPerm;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfBurial.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\7_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayBlg")
            {
                //servpicture.Image = Properties.Resources.payBlg;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\payBlg.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\8_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayPol")
            {
                //servpicture.Image = Properties.Resources.payPolMayClear;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfPoliceClearence.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\9_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayCivilReg")
            {
                //servpicture.Image = Properties.Resources.payCivilReg;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfCivilRegistration.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\10_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayTraffic")
            {
                //servpicture.Image = Properties.Resources.payTrafficViolate;

                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfTrafficeViolation.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\11_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "IssueComTax")
            {
                //servpicture.Image = Properties.Resources.issueCommTax;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\issuanceOfCommunityTaxForIndividual.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\12_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayWeight")
            {
                //servpicture.Image = Properties.Resources.payWeightMeasure;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfWeight.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\13_.jpg";
                imgtaker(imagefilename);
            }
            else if (val == "PayPolClear")
            {
                //servpicture.Image = Properties.Resources.payMrktElecFee;
                string imagefilename = Path.Combine(projectPath, "Resources\\Services\\paymentOfMarketStall.jpg");
                //string imagefilename = @"C:\Users\Marvin\Desktop\BinanKiosk\BinanKiosk\Resources\14_.jpg";
                imgtaker(imagefilename);
            }
            else
            {
                //MessageBox.Show("hello world");
            }
        }

        private void timestamp_Tick(object sender, EventArgs e)
        {

        }
    }
}
