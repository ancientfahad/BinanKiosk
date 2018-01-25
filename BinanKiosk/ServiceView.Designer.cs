namespace BinanKiosk
{
    partial class ServiceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.servpicture = new System.Windows.Forms.PictureBox();
            this.servicevalue = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timestamp = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnMaps = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLanguages = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.servpicture);
            this.panel1.Location = new System.Drawing.Point(48, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 536);
            this.panel1.TabIndex = 50;
            // 
            // servpicture
            // 
            this.servpicture.BackColor = System.Drawing.Color.Transparent;
            this.servpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servpicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("servpicture.InitialImage")));
            this.servpicture.Location = new System.Drawing.Point(135, 0);
            this.servpicture.Name = "servpicture";
            this.servpicture.Size = new System.Drawing.Size(1023, 536);
            this.servpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.servpicture.TabIndex = 50;
            this.servpicture.TabStop = false;
            // 
            // servicevalue
            // 
            this.servicevalue.Location = new System.Drawing.Point(75, 467);
            this.servicevalue.Name = "servicevalue";
            this.servicevalue.Size = new System.Drawing.Size(53, 20);
            this.servicevalue.TabIndex = 51;
            this.servicevalue.Visible = false;
            // 
            // lbldate
            // 
            this.lbldate.BackColor = System.Drawing.Color.ForestGreen;
            this.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbldate.Location = new System.Drawing.Point(1010, 695);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(356, 77);
            this.lbldate.TabIndex = 94;
            this.lbldate.Text = ".";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.ForestGreen;
            this.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltime.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(1186, 720);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(180, 39);
            this.lbltime.TabIndex = 251;
            this.lbltime.Text = ".";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timestamp
            // 
            this.timestamp.Interval = 1000;
            this.timestamp.Tick += new System.EventHandler(this.timestamp_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.Image = global::BinanKiosk.Properties.Resources.helpIcon2;
            this.btnHelp.Location = new System.Drawing.Point(1299, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(67, 64);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "HELP";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.BackColor = System.Drawing.Color.ForestGreen;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.ForeColor = System.Drawing.Color.White;
            this.lblServices.Image = global::BinanKiosk.Properties.Resources.paper;
            this.lblServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServices.Location = new System.Drawing.Point(24, 13);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(234, 37);
            this.lblServices.TabIndex = 58;
            this.lblServices.Text = "     SERVICES";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnJob
            // 
            this.btnJob.BackColor = System.Drawing.Color.ForestGreen;
            this.btnJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJob.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJob.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.ForeColor = System.Drawing.Color.Transparent;
            this.btnJob.Image = global::BinanKiosk.Properties.Resources.jobIcon;
            this.btnJob.Location = new System.Drawing.Point(849, 683);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(155, 88);
            this.btnJob.TabIndex = 32;
            this.btnJob.Text = " Jobs";
            this.btnJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJob.UseVisualStyleBackColor = false;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.ForestGreen;
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServices.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.Transparent;
            this.btnServices.Image = global::BinanKiosk.Properties.Resources.servicesIcon;
            this.btnServices.Location = new System.Drawing.Point(695, 683);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(155, 88);
            this.btnServices.TabIndex = 30;
            this.btnServices.Text = "Services";
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnMaps
            // 
            this.btnMaps.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaps.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnMaps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaps.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaps.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaps.Image = global::BinanKiosk.Properties.Resources.mapIcon;
            this.btnMaps.Location = new System.Drawing.Point(541, 683);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(155, 88);
            this.btnMaps.TabIndex = 29;
            this.btnMaps.Text = " Maps";
            this.btnMaps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaps.UseVisualStyleBackColor = false;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::BinanKiosk.Properties.Resources.srchicon;
            this.btnSearch.Location = new System.Drawing.Point(387, 683);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 88);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = " Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::BinanKiosk.Properties.Resources.homeIcon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(233, 683);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(155, 88);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1366, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.BackgroundImage = global::BinanKiosk.Properties.Resources.Binan_City_Logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(7, 695);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox4.BackgroundImage = global::BinanKiosk.Properties.Resources.Binan_City;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(71, 695);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(160, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(0, 677);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1459, 94);
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // btnLanguages
            // 
            this.btnLanguages.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLanguages.FlatAppearance.BorderSize = 0;
            this.btnLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguages.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguages.ForeColor = System.Drawing.Color.White;
            this.btnLanguages.Location = new System.Drawing.Point(1171, -1);
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.Size = new System.Drawing.Size(127, 64);
            this.btnLanguages.TabIndex = 280;
            this.btnLanguages.Text = "CHANGE LANGUAGE";
            this.btnLanguages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLanguages.UseVisualStyleBackColor = false;
            this.btnLanguages.Click += new System.EventHandler(this.btnLanguages_Click);
            // 
            // ServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnLanguages);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.servicevalue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnMaps);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.ServiceView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.PictureBox servpicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox servicevalue;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timestamp;
        private System.Windows.Forms.Button btnLanguages;
    }
}

