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
    public partial class ThirdFloor : Form
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

        public ThirdFloor()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);

            Button[] buttonArrayF2 = { Genbtton, tourbtton, pesdbtton, hrmobtton, ctyadbtton, budgetbtton, conf1btton, staffleftbtton, receptionbtton, staffrightbtton,
                mayorbtton, engbtton, conf2btton, ctyplanbtton, funcroombtton};

            PictureBox[] pictureArray2 = { grid1, grid2, grid3, grid4, grid5, grid6, grid7, grid8, grid9, grid10, grid11, grid12,
            grid13, grid14, grid15, grid16, grid17, grid18, grid19, grid20, grid21, grid22, grid23, grid24, grid25, grid26,
             grid27, grid28, grid29, grid30, grid31, grid32, grid33, grid34, grid35, grid36, grid37, grid38, grid39, grid40,
             grid41, grid42, grid43, grid44, grid45, grid46, grid47,switch1,switch2,grid48,grid49,grid50,grid51,grid52,
             grid53,grid54,grid55};

            for (int i = 0; i < buttonArrayF2.Length; i++)
            {
                var RegOffice = this.PointToScreen(buttonArrayF2[i].Location);
                RegOffice = Map.PointToClient(RegOffice);
                buttonArrayF2[i].Parent = Map;
                buttonArrayF2[i].Location = RegOffice;
            }


            for (int i = 0; i < pictureArray2.Length; i++)
            {
                var RegOffice = this.PointToScreen(pictureArray2[i].Location);
                RegOffice = Map.PointToClient(RegOffice);
                pictureArray2[i].Parent = Map;
                pictureArray2[i].Location = RegOffice;
            }



        }

        private void ThirdFloor_Load(object sender, EventArgs e)
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
                lblFloorName.Text = "Pangatlong Palapag";
                lblMaps.Text = "       MAPA";

                secondbtton.Text = "Pangalawang Palapag";
                groundbtton.Text = "Unang Palapag";
            }

            timestamp.Interval = 10;
            timestamp.Start();
        }

        public void clearImage()
        {

            PictureBox[] pictureArray = { grid1, grid2, grid3, grid4, grid5, grid6, grid7, grid8, grid9, grid10, grid11, grid12,
            grid13, grid14, grid15, grid16, grid17, grid18, grid19, grid20, grid21, grid22, grid23, grid24, grid25, grid26,
             grid27, grid28, grid29, grid30, grid31, grid32, grid33, grid34, grid35, grid36, grid37, grid38, grid39, grid40,
             grid41, grid42, grid43, grid44, grid45, grid46, grid47,switch1,switch2,grid48,grid49,grid50,grid51,grid52,
             grid53,grid54,grid55};

            for (int i = 0; i < pictureArray.Length; i++)
            {
                pictureArray[i].Visible = false;
            }

        }

        public void disableButton()
        {
            Button[] buttonArray = { Genbtton, tourbtton, pesdbtton, hrmobtton, ctyadbtton, budgetbtton, conf1btton, staffleftbtton, receptionbtton, staffrightbtton,
                mayorbtton, engbtton, conf2btton, ctyplanbtton, funcroombtton};

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = false;
            }
        }

        public async void enableButton()
        {
            Button[] buttonArray = { Genbtton, tourbtton, pesdbtton, hrmobtton, ctyadbtton, budgetbtton, conf1btton, staffleftbtton, receptionbtton, staffrightbtton,
                mayorbtton, engbtton, conf2btton, ctyplanbtton, funcroombtton};

            await Task.Delay(500);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = true;
            }
        }

        public async void Floor3_1()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18, grid19, grid1, grid2, grid3, grid4, grid5, grid6, grid7, grid8,grid48 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_2()
        {
            clearImage();
            disableButton();

            int ctr = 0;

            await Task.Delay(500);

            PictureBox[] path2 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18, grid19, grid1, grid2, grid3, grid4, switch1 };

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
        }

        public async void Floor3_3()
        {
            clearImage();
            disableButton();

            int ctr = 0;

            await Task.Delay(500);

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18, grid19, grid1, grid2, grid31, grid32, grid33,grid49 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_4()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18, grid19, grid1, grid2, grid31, grid32, grid33, grid34, grid35, grid36, grid37, grid38 ,grid50 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }


        public async void Floor3_5()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18, grid19, grid1, grid2, grid31, grid32, grid33, grid34, grid35, grid36, switch2 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_6()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18, grid19, grid1, grid2, grid31, grid32, grid33,grid34 ,grid55};

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_7()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid18,grid51 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_8()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            await Task.Delay(500);

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid16, grid14, grid13, grid12 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_9()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid16, grid14 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_10()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid16, grid14, grid15, grid20, grid21, grid22, grid23, grid24,grid54 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        public async void Floor3_11()
        {
            clearImage();
            disableButton();

            await Task.Delay(500);

            int ctr = 0;

            PictureBox[] path1 = { grid42, grid43, grid44, grid45, grid46, grid47, grid17, grid16, grid14, grid15, grid20, grid21,grid53 };

            for (int i = 0; i < path1.Length; i++)
            {
                path1[i].Visible = true;

                await Task.Delay(500);
                this.Enabled = true;
                this.Cursor = Cursors.Default;

            }

            do
            {
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

            } while (ctr < 3);
            enableButton();
        }

        private void Genbtton_Click(object sender, EventArgs e)
        {
            //Floor3_1();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair1");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void tourbtton_Click(object sender, EventArgs e)
        {
            //Floor3_2();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair2");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();

        }

        private void pesdbtton_Click(object sender, EventArgs e)
        {
            //Floor3_3();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair3");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void hrmobtton_Click(object sender, EventArgs e)
        {
            //Floor3_4();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair4");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void ctyadbtton_Click(object sender, EventArgs e)
        {
            //Floor3_5();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair5");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void budgetbtton_Click(object sender, EventArgs e)
        {
            //Floor3_6();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair6");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void receptionbtton_Click(object sender, EventArgs e)
        {
            //Floor3_7();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair7");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void funcroombtton_Click(object sender, EventArgs e)
        {
            //Floor3_8();

            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair8");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();

        }

        private void conf2btton_Click(object sender, EventArgs e)
        {
            //Floor3_9();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair9");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void ctyplanbtton_Click(object sender, EventArgs e)
        {
            //Floor3_10();
            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair10");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void engbtton_Click(object sender, EventArgs e)
        {
            //Floor3_11();

            this.Hide();
            GroundFloor gf = new GroundFloor();
            gf.proceed("Floor2_stair11");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
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

        private void secondbtton_Click(object sender, EventArgs e)
        {
            SecondFloor sf = new SecondFloor();
            this.Hide();
            sf.FormClosed += (s, args) => this.Close();
            sf.ShowDialog();
            sf.Focus();
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

        private void groundbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.FormClosed += (s, args) => this.Close();
            gf.ShowDialog();
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


    }
}
