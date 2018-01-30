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
namespace BinanKiosk
{
    public partial class GroundFloor : Form
    {

        Image img;
        Point mouseDown;
        int startx = 0;             // offset of image when mouse was pressed
        int starty = 0;
        int imgx = 0;               // current offset of image
        int imgy = 0;

        bool mousepressed = false;  // true as long as left mousebutton is pressed
        float zoom = 1;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public GroundFloor()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);

            //string imagefilename = @"C:\Users\Fahad\Documents\Github\BinanKiosk\BinanKiosk\Resources\First_Floor_Colored.png";
            //img = Image.FromFile(imagefilename);

            //Graphics g = this.CreateGraphics();

            //zoom = ((float)Map.Width / (float)img.Width) *
            //       (img.HorizontalResolution / g.DpiX);

            //Map.Paint += new PaintEventHandler(imageBox_Paint);



            //enter button name here to make it transparent
            Button[] buttonArray = { btnLCRG, btnTreasuryOffice, btnChapel, cnabtton, agrbtton, cenrobtton, bussbtton, asrbtton, btnCSWD};
            
            for(int i = 0; i <buttonArray.Length; i++)
            {
                var RegOffice = this.PointToScreen(buttonArray[i].Location);
                RegOffice = Map.PointToClient(RegOffice);
                buttonArray[i].Parent = Map;
                buttonArray[i].Location = RegOffice;
            }

            PictureBox[] pictureArray = { step1, step2, step3, step4, step5, step6, step7, step8, step9, step10,
                step11, step12, step13, switch2, step15, step16, step17, step18, step19, step20,
                step21, step22, step23, step24, step25, step26, step27, step28, step29, switch3,
                step31, step32, step33, step34, step35, step36, step37, step38, step39, step40,
                step41, step42, step43, step44, step45, switch5, step47, step48, step49, step50,
                step51, step52, step53, step54, step55, step56, step57, step58, step59, step60,
                step61, step62, step63, step64, step65,switch1, switch4,step66, step67, step68, step69, step70, step71, step72, point };

            for (int i = 0; i < pictureArray.Length; i++)
            {
                var RegOffice = this.PointToScreen(pictureArray[i].Location);
                RegOffice = Map.PointToClient(RegOffice);
                pictureArray[i].Parent = Map;
                pictureArray[i].Location = RegOffice;
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
            int x = mousePosNow.X - Map.Location.X;
            int y = mousePosNow.Y - Map.Location.Y;

            // Where in the IMAGE is it now
            int oldimagex = (int)(x / oldzoom);
            int oldimagey = (int)(y / oldzoom);

            // Where in the IMAGE will it be when the new zoom i made
            int newimagex = (int)(x / zoom);
            int newimagey = (int)(y / zoom);

            // Where to move image to keep focus on one point
            imgx = newimagex - oldimagex + imgx;
            imgy = newimagey - oldimagey + imgy;

            Map.Refresh();  // calls imageBox_Paint
        }

        private void imageBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.ScaleTransform(zoom, zoom);
            e.Graphics.DrawImage(img, imgx, imgy);
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

                Map.Refresh();
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

        private void GroundFloor_Load(object sender, EventArgs e)
        {
            clearImage();

            if (Global.language == "Filipino")
            {
                btnLanguages.Text = "PALITAN NG WIKA";
                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                lblFloorName.Text = "Unang Palapag";
                lblMaps.Text = "       MAPA";

                thirdbtton.Text = "Pangatlong Palapag";
                secondbtton.Text = "Pangalawang Palapag";
            }
            timestamp.Interval = 1;
            timestamp.Start();
        }

        public void clearImage()
        {

            PictureBox[] pictureArray = { step1, step2, step3, step4, step5, step6, step7, step8, step9, step10,
            step11, step12, step13, switch2, step15, step16, step17, step18, step19, step20,
            step21, step22, step23, step24, step25, step26, step27, step28, step29, switch3,
            step31, step32, step33, step34, step35, step36, step37, step38, step39, step40,
            step41, step42, step43, step44, step45, switch5, step47, step48, step49, step50,
            step51, step52, step53, step54, step55, step56, step57, step58, step59, step60,
            step61, step62, step63, step64, step65, switch1, switch4, step66, step67, step68, step69, step70, step71, step72,};

            for (int i = 0; i < pictureArray.Length; i++)  //remember to edit this everytime you add steps in array
            {
                pictureArray[i].Visible = false;
            }

        }

        public void disableButton()
        {
            Button[] buttonArray = { btnLCRG, btnTreasuryOffice, btnChapel, cnabtton, agrbtton, cenrobtton, bussbtton, asrbtton, btnCSWD };

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = false;
            }
        }

        public async void enableButton()
        {
            Button[] buttonArray = { btnLCRG, btnTreasuryOffice, btnChapel, cnabtton, agrbtton, cenrobtton, bussbtton, asrbtton, btnCSWD };

            await Task.Delay(500);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = true;
            }
        }

        //Path 1
        public async void Floor1_1()
        {
            clearImage();
            hideButton();
            int ctr = 0;

            PictureBox[] path1 = {step1, step2, step3, step4, step5, step6, step7, step8, step9, step10, step11, step12};

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path1.Length; i++)
                {
                    path1[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path1.Length; i++)
                {
                    path1[i].Visible = true;
                }
                ctr++;
            } while (ctr <3);
            showButton();
            enableButton();
        }

        //Path2
        public async void Floor1_2()
        {
            clearImage();
            hideButton();

            int ctr = 0;

            PictureBox[] path2 = {step1, step2, step3, step59, step60, step66};

            for (int i = 0; i < path2.Length; i++)
            {
                path2[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path2.Length; i++)
                {
                    path2[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path2.Length; i++)
                {
                    path2[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
            showButton();
        }

        //Path3
        public async void Floor1_3()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path3 = {step1, step2, step3, step4, step5, step6, step7, step8, step9, step10, step11, step13, switch2, step15, step70};

            for (int i = 0; i < path3.Length; i++)
            {
                path3[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path3.Length; i++)
                {
                    path3[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path3.Length; i++)
                {
                    path3[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void Floor1_4()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path4 = {step1, step2, step3, step4, step5, step6, step7, step8, step9, step10, step11, step13, switch1, step19, step20, step21, step22, step72};

            for (int i = 0; i < path4.Length; i++)
            {
                path4[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path4.Length; i++)
                {
                    path4[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path4.Length; i++)
                {
                    path4[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void Floor1_5()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path5 = {step1, step2, step3, step4, step5, step6, step7, step8, step9, step10,
            step11, step13, switch2, step71};

            for (int i = 0; i < path5.Length; i++)
            {
                path5[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path5.Length; i++)
                {
                    path5[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path5.Length; i++)
                {
                    path5[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void Floor1_6()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path6 = {switch5, step47, step48, step50, step49, step39, step38, step37, step36, step35, step33, step32, step31, switch4, step68};

            for (int i = 0; i < path6.Length; i++)
            {
                path6[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path6.Length; i++)
                {
                    path6[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path6.Length; i++)
                {
                    path6[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void Floor1_7()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path7 = { switch5, step47, step48, step50, step49, step39, step38, step37, step36, step35, step33, step32, step31, switch4, step29,step28, step27, step69 };

            for (int i = 0; i < path7.Length; i++)
            {
                path7[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path7.Length; i++)
                {
                    path7[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path7.Length; i++)
                {
                    path7[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void Floor1_8()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path8 = { switch5, step47, step48, step50, step49, step39, step38, step37, step36, step35, step33, step34};

            for (int i = 0; i < path8.Length; i++)
            {
                path8[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path8.Length; i++)
                {
                    path8[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path8.Length; i++)
                {
                    path8[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void Floor1_9()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path9 = { switch5, step47, step48, step50, step51, step52, step53, step54, step55, step56, step57, step58, step67 };

            for (int i = 0; i < path9.Length; i++)
            {
                path9[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            do
            {
                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path9.Length; i++)
                {
                    path9[i].Visible = false;
                }

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

                for (int i = 0; i < path9.Length; i++)
                {
                    path9[i].Visible = true;
                }
                ctr++;
            } while (ctr < 3);

            enableButton();
        }

        public async void proceed(string func) {

            clearImage();

            await Task.Delay(500);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            PictureBox[] path10 = { switch6, step65 };

            for (int i = 0; i < path10.Length; i++) {
                path10[i].Visible = true;

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            await Task.Delay(700);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            if (func == "Floor2_1")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_1();
                sf.ShowDialog();
            }
            else if (func == "Floor2_2")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_2();
                sf.ShowDialog();
            }

            else if (func == "Floor2_2")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_2();
                sf.ShowDialog();
            }

            else if (func == "Floor2_3")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_3();
                sf.ShowDialog();
            }

            else if (func == "Floor2_4")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_4();
                sf.ShowDialog();
            }

            else if (func == "Floor2_5")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_5();
                sf.ShowDialog();
            }

            else if (func == "Floor2_6")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_6();
                sf.ShowDialog();
            }

            else if (func == "Floor2_7")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_7();
                sf.ShowDialog();
            }

            else if (func == "Floor2_8")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_8();
                sf.ShowDialog();
            }

            else if (func == "Floor2_9")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_9();
                sf.ShowDialog();
            }

            else if (func == "Floor2_10")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_10();
                sf.ShowDialog();
            }

            else if (func == "Floor2_11")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_11();
                sf.ShowDialog();
            }
            else if (func == "Floor2_12")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_12();
                sf.ShowDialog();
            }

            else if (func == "Floor2_13")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_13();
                sf.ShowDialog();
            }

            else if (func == "Floor2_14")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_14();
                sf.ShowDialog();
            }

            else if (func == "Floor2_15")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_15();
                sf.ShowDialog();
            }

            else if (func == "Floor2_16")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_16();
                sf.ShowDialog();
            }

            else if (func == "Floor2_17")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_17();
                sf.ShowDialog();
            }

            else if (func == "Floor2_18")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_18();
                sf.ShowDialog();
            }

            else if (func == "Floor2_19")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_19();
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair1")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_1");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair2")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_2");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair3")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_3");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair4")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_4");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair5")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_5");
                sf.ShowDialog();
            }
            else if (func == "Floor2_stair6")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_6");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair7")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_7");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair8")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_8");
                sf.ShowDialog();
            }
            else if (func == "Floor2_stair9")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_9");
                sf.ShowDialog();
            }

            else if (func == "Floor2_stair10")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_10");
                sf.ShowDialog();
            }
            else if (func == "Floor2_stair11")
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_stair("Floor3_11");
                sf.ShowDialog();
            }

            else
            {
                this.Hide();
                SecondFloor sf = new SecondFloor();
                sf.Floor2_20();
                sf.ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Hide();
            hm.FormClosed += (s, args) => this.Close();
            hm.ShowDialog();
            hm.Focus();

            //this.Hide();
            //Home hm = new Home();
            //hm.ShowDialog();
            //Show();
        }

        private void btnLCRG_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_1();
        }
        
        private void btnTreasuryOffice_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_2();
        }

        private void btnCSWD_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_3();
        }

        private void btnChapel_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_4();
        }

        private void cnabtton_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_5();
        }

        private void agrbtton_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_6();
        }

        private void cenrobtton_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_7();
        }

        private void bussbtton_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_8();
        }

        private void asrbtton_Click(object sender, EventArgs e)
        {
            disableButton();
            Floor1_9();
        }

        private void secondbtton_Click(object sender, EventArgs e)
        {
            SecondFloor hm = new SecondFloor();
            this.Hide();
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

        private void OnTimerEvent(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString() + System.Environment.NewLine + DateTime.Now.ToLongTimeString();
        }

        private void timestamp_Tick(object sender, EventArgs e)
        {
            timestamp.Enabled = true;
            timestamp.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void thirdbtton_Click(object sender, EventArgs e)
        {
            ThirdFloor tf = new ThirdFloor();
            this.Hide();
            tf.FormClosed += (s, args) => this.Close();
            tf.ShowDialog();
            this.Close();
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            Language lng = new Language();
            this.Hide();
            lng.FormClosed += (s, args) => this.Close();
            lng.ShowDialog();
            lng.Focus();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void Map_Click(object sender, EventArgs e)
        {

        }

        private void point_Click(object sender, EventArgs e)
        {

        }

        public void hideButton() {
            secondbtton.Visible = false;
            thirdbtton.Visible = false;
        }

        public void showButton()
        {
            secondbtton.Visible = true;
            thirdbtton.Visible = true;
        }
    }
}
