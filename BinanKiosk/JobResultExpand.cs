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
        int imgx = 200;               // current offset of image
        int imgy = 0;
        
        

        bool mousepressed = false;  // true as long as left mousebutton is pressed
        float zoom = 1;

        public JobResultExpand(string dummy)
        {
            
            InitializeComponent();
            this.DoubleBuffered = true;
            //servicevalue.Text = val;
            fillPicture(dummy);

        }

        private void JobResultExpand_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Global.gbSelectedJob);
            //fillPicture(Global.gbSelectedJob);
            timestamp.Interval = 1;
            timestamp.Start();
            this.jobpicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseDown);
            this.jobpicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.jobpicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseUp);

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
            e.Graphics.DrawImage(img, imgx, imgy, 400, 400);


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

            if (val == "dunkin")
            {

                string imagefilename = Path.Combine(projectPath, "Resources\\job_1.jpg");
                //string imagefilename = @"C:\Users\doratheexplorer\Desktop\BinanKiosk\BinanKiosk\Resources\4_.jpg";
                imgtaker(imagefilename);
            }
           
        }

        private void timestamp_Tick(object sender, EventArgs e)
        {
            timestamp.Enabled = true;
            timestamp.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString() + System.Environment.NewLine + DateTime.Now.ToLongTimeString();
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
            Search sr = new Search();
            this.Hide();
            sr.FormClosed += (s, args) => this.Close();
            sr.ShowDialog();
            sr.Focus();
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.FormClosed += (s, args) => this.Close();
            gf.ShowDialog();
            gf.Focus();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These are the available jobs posted here in the City of Binan. Click the view details to see details and requirements of the jobs.");
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
