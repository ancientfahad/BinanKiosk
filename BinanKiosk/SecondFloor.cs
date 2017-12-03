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

    

    public partial class SecondFloor : Form
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

        public SecondFloor()
        {
            InitializeComponent();

            Button[] buttonArrayF2 = { spbtton, counbtton, coun2btton, coun3btton, dilgbtton, vmsbtton, sessbtton, coun4btton, coun5btton,
            coun6btton, coun7btton, coun8btton, coun9btton, coun10btton, legalbtton, infobtton, btfbtton, confbtton, coabtton, accbtton};

            PictureBox[] pictureArrayF2 = { grid2, grid3, grid4, grid5, grid6, grid7, grid8, grid9, grid10,
                grid11, grid12, grid13, grid14, grid15, grid16, grid17, grid18, grid19, grid20,
                grid21, grid22, grid23, grid24, grid25, grid26, grid27, grid28, grid29, grid30,
                grid31, grid32, grid33, grid34, grid35, grid36, grid37, grid38, grid39, grid40,
                grid41, grid42, grid43,  grid46, grid47, grid48, grid49, grid50,
                grid51, grid52, grid53, grid54, grid55, grid56, grid57, grid58, grid59, grid60,
                grid61, grid62, grid63, grid64, grid65, grid66, grid67, grid68, grid69, grid70,
                grid71, grid72};

            for (int i = 0; i < pictureArrayF2.Length; i++)
            {
                var RegOffice = this.PointToScreen(pictureArrayF2[i].Location);
                RegOffice = Map.PointToClient(RegOffice);
                pictureArrayF2[i].Parent = Map;
                pictureArrayF2[i].Location = RegOffice;
            }


            for (int i = 0; i < buttonArrayF2.Length; i++)
            {
                var RegOffice = this.PointToScreen(buttonArrayF2[i].Location);
                RegOffice = Map.PointToClient(RegOffice);
                buttonArrayF2[i].Parent = Map;
                buttonArrayF2[i].Location = RegOffice;
            }
        }

        private void SecondFloor_Load(object sender, EventArgs e)
        {
            clearImage();

            if (Global.language == "Filipino")
            {
                btnHome.Text = "Home";
                btnSearch.Text = "Hanapin";
                btnMaps.Text = "Mapa";
                btnServices.Text = "Mga Serbisyo";
                btnJob.Text = "Mga Trabaho";
                btnHelp.Text = "Tulong";
                lblFloorName.Text = "Pangalawang Palapag";
                lblMaps.Text = "       MAPA";
            }
            timestamp.Interval = 10;
            timestamp.Start();
        }

        public void clearImage()
        {

            PictureBox[] pictureArray = { grid2, grid3, grid4, grid5, grid6, grid7, grid8, grid9, grid10,
                grid11, grid12, grid13, grid14, grid15, grid16, grid17, grid18, grid19, grid20,
                grid21, grid22, grid23, grid24, grid25, grid26, grid27, grid28, grid29, grid30,
                grid31, grid32, grid33, grid34, grid35, grid36, grid37, grid38, grid39, grid40,
                grid41, grid42, grid43, grid46, grid47, grid48, grid49, grid50,
                grid51, grid52, grid53, grid54, grid55, grid56, grid57, grid58, grid59, grid60,
                grid61, grid62, grid63, grid64, grid65, grid66, grid67, grid68, grid69, grid70};
             
            for (int i = 0; i < pictureArray.Length; i++)
            {
                pictureArray[i].Visible = false;
            }

        }

        public void disableButton()
        {
            Button[] buttonArray = { spbtton, counbtton, coun2btton, coun3btton, dilgbtton, vmsbtton, sessbtton, coun4btton, coun5btton,
            coun6btton, coun7btton, coun8btton, coun9btton, coun10btton, legalbtton, infobtton, btfbtton, confbtton, coabtton, accbtton };

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = false;
            }
        }

        public async void enableButton()
        {
            Button[] buttonArray = { spbtton, counbtton, coun2btton, coun3btton, dilgbtton, vmsbtton, sessbtton, coun4btton, coun5btton,
            coun6btton, coun7btton, coun8btton, coun9btton, coun10btton, legalbtton, infobtton, btfbtton, confbtton, coabtton, accbtton };

            await Task.Delay(500);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = true;
            }
        }

        public async void Floor2_1()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid7, grid8, grid9};

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
        }

        public async void Floor2_2()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path2 = { grid71, grid68, grid2, grid6, grid7, grid8, grid9, grid10, grid11, grid12 };

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
        }

        public async void Floor2_3()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid7, grid8, grid9, grid10, grid11, grid12, grid13 };

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
        }

        public async void Floor2_4()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid7, grid8, grid9, grid10, grid11, grid12, grid13, grid14 };

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
        }

        public async void Floor2_5()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid7, grid8, grid9, grid10, grid11, grid12, grid13, grid14 };

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
        }

        public async void Floor2_6()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid7, grid8, grid9, grid10, grid11, grid12, grid13, grid14, grid15,
                grid16, grid17, grid18 };

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
        }

        public async void Floor2_7()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid5, grid4, grid57, grid58 };

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
        }

        public async void Floor2_8()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid5, grid57, grid58, grid59, grid60, grid61, grid62, grid63 };

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
        }

        public async void Floor2_9()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid71, grid68, grid2, grid6, grid5, grid4, grid57, grid58, grid59 };

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
        }

        public async void Floor2_10()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid37, grid46, grid47 };

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
        }

        public async void Floor2_11()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid37, grid46, grid47, grid48, grid49 };

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
        }

        public async void Floor2_12()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid70, grid69, grid42, grid36, grid37, grid46, grid47, grid48, grid49, grid50, grid51, grid52, grid53, grid54 };

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
        }

        public async void Floor2_13()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid37, grid46, grid47, grid48, grid49, grid50 };

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
        }

        public async void Floor2_14()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33 };

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
        }

        public async void Floor2_15()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33, grid32 };

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
        }

        public async void Floor2_16()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33, grid32, grid31};

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
        }

        public async void Floor2_17()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33, grid32, grid31, grid30, grid29 };

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
        }

        public async void Floor2_18()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33, grid32, grid31, grid30, grid29, grid25, grid24 };

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
        }

        public async void Floor2_19()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33, grid32, grid31, grid30, grid29, grid25, grid24, grid23 };

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
        }

        public async void Floor2_20()
        {
            clearImage();

            int ctr = 0;

            PictureBox[] path1 = { grid70, grid69, grid42, grid36, grid35, grid34, grid33, grid32, grid31, grid30, grid29, grid25, grid24, grid23, grid22 };

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
        }



        public async void Floor2_stair(string func2)
        {
            
            clearImage();

            await Task.Delay(500);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            //71, 68, 2, 43, 72, 73 - 80
            PictureBox[] path10 = { grid71, grid68, grid2, grid43, grid72};
            for (int i = 0; i < path10.Length; i++)
            {
                path10[i].Visible = true;

                await Task.Delay(700);
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            await Task.Delay(700);
            this.Enabled = true;
            this.Cursor = Cursors.Default;

            if (func2 == "Floor3_1")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_1();
                tf.ShowDialog();
            }
            else if (func2 == "Floor3_2")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_2();
                tf.ShowDialog();
            }

            

            else if (func2 == "Floor3_3")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_3();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_4")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_4();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_5")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_5();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_6")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_6();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_7")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_7();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_8")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_8();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_9")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_9();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_10")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_10();
                tf.ShowDialog();
            }

            else if (func2 == "Floor3_11")
            {
                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_11();
                tf.ShowDialog();
            }
            

            else
            {
                //this.Hide();
                //SecondFloor sf = new SecondFloor();
                //sf.Floor2_20();
                //sf.ShowDialog();

                this.Hide();
                ThirdFloor tf = new ThirdFloor();
                tf.Floor3_11();
                tf.ShowDialog();
            }
        }


        private void btnLCRG_Click(object sender, EventArgs e)
        {

        }

        private void spbtton_Click(object sender, EventArgs e)
        {
            //concept is it goes back to the ground floor and gives the directions to the stairs and then lead back up again
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_1");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void counbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_2");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun2btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_3");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun3btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_4");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void vmsbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_5");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void sessbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_6");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void dilgbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_7");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coabtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_8");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void accbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_9");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void legalbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_10");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void confbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_11");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void infobtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_12");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void btfbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_13");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun4btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_14");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun5btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_15");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun6btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_16");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun7btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_17");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun8btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_18");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun9btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_19");
            gf.disableButton();
            gf.ShowDialog();
            this.Close();
        }

        private void coun10btton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.proceed("Floor2_20");
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
            this.Close();
        }

        private void thirdbtton_Click(object sender, EventArgs e)
        {
            ThirdFloor tf = new ThirdFloor();
            this.Hide();
            tf.FormClosed += (s, args) => this.Close();
            tf.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search src = new Search();
            this.Hide();
            src.FormClosed += (s, args) => this.Close();
            src.ShowDialog();
            src.ShowDialog();
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.FormClosed += (s, args) => this.Close();
            gf.ShowDialog();
            gf.ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            GovernmentServices gs = new GovernmentServices();
            this.Hide();
            gs.FormClosed += (s, args) => this.Close();
            gs.ShowDialog();
            gs.ShowDialog();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            Jobs jb = new Jobs();
            this.Hide();
            jb.FormClosed += (s, args) => this.Close();
            jb.ShowDialog();
            jb.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help hp = new Help();
            this.Hide();
            hp.FormClosed += (s, args) => this.Close();
            hp.ShowDialog();
            hp.ShowDialog();
        }

        private void Map_Click(object sender, EventArgs e)
        {

        }

        private void groundbtton_Click(object sender, EventArgs e)
        {
            GroundFloor gf = new GroundFloor();
            this.Hide();
            gf.FormClosed += (s, args) => this.Close();
            gf.ShowDialog();
            this.Close();
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
