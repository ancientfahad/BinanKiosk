namespace BinanKiosk
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.Filters = new System.Windows.Forms.GroupBox();
            this.radioJob = new System.Windows.Forms.RadioButton();
            this.radioApplications = new System.Windows.Forms.RadioButton();
            this.radioOffices = new System.Windows.Forms.RadioButton();
            this.radioOfficers = new System.Windows.Forms.RadioButton();
            this.btnLanguages = new System.Windows.Forms.Button();
            this.timestamp = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.searchResult14 = new System.Windows.Forms.Button();
            this.searchResult12 = new System.Windows.Forms.Button();
            this.searchResult13 = new System.Windows.Forms.Button();
            this.searchResult15 = new System.Windows.Forms.Button();
            this.searchResult11 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.searchResult9 = new System.Windows.Forms.Button();
            this.searchResult7 = new System.Windows.Forms.Button();
            this.searchResult8 = new System.Windows.Forms.Button();
            this.searchResult10 = new System.Windows.Forms.Button();
            this.searchResult6 = new System.Windows.Forms.Button();
            this.searchResult4 = new System.Windows.Forms.Button();
            this.searchResult2 = new System.Windows.Forms.Button();
            this.searchResult3 = new System.Windows.Forms.Button();
            this.searchResult5 = new System.Windows.Forms.Button();
            this.searchResult1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.search_animate = new System.Windows.Forms.PictureBox();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnMaps = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_animate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(248, 152);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(934, 46);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radioAll
            // 
            this.radioAll.BackColor = System.Drawing.Color.Transparent;
            this.radioAll.Checked = true;
            this.radioAll.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.Location = new System.Drawing.Point(1002, 12);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(106, 35);
            this.radioAll.TabIndex = 61;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = false;
            this.radioAll.Visible = false;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // Filters
            // 
            this.Filters.BackColor = System.Drawing.Color.Transparent;
            this.Filters.Controls.Add(this.radioJob);
            this.Filters.Controls.Add(this.radioApplications);
            this.Filters.Controls.Add(this.radioOffices);
            this.Filters.Controls.Add(this.radioAll);
            this.Filters.Controls.Add(this.radioOfficers);
            this.Filters.Location = new System.Drawing.Point(128, 64);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(1101, 53);
            this.Filters.TabIndex = 66;
            this.Filters.TabStop = false;
            // 
            // radioJob
            // 
            this.radioJob.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJob.Image = global::BinanKiosk.Properties.Resources.jobsIcon;
            this.radioJob.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioJob.Location = new System.Drawing.Point(756, 12);
            this.radioJob.Name = "radioJob";
            this.radioJob.Size = new System.Drawing.Size(221, 35);
            this.radioJob.TabIndex = 44;
            this.radioJob.Text = "Jobs";
            this.radioJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioJob.UseVisualStyleBackColor = true;
            this.radioJob.CheckedChanged += new System.EventHandler(this.radioJob_CheckedChanged);
            // 
            // radioApplications
            // 
            this.radioApplications.AutoSize = true;
            this.radioApplications.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioApplications.Image = global::BinanKiosk.Properties.Resources.servicessIcon;
            this.radioApplications.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioApplications.Location = new System.Drawing.Point(506, 12);
            this.radioApplications.Name = "radioApplications";
            this.radioApplications.Size = new System.Drawing.Size(165, 36);
            this.radioApplications.TabIndex = 42;
            this.radioApplications.Text = "Services";
            this.radioApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioApplications.UseVisualStyleBackColor = true;
            this.radioApplications.CheckedChanged += new System.EventHandler(this.radioApplications_CheckedChanged);
            // 
            // radioOffices
            // 
            this.radioOffices.AutoSize = true;
            this.radioOffices.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOffices.Image = global::BinanKiosk.Properties.Resources.officeIcon;
            this.radioOffices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioOffices.Location = new System.Drawing.Point(256, 12);
            this.radioOffices.Name = "radioOffices";
            this.radioOffices.Size = new System.Drawing.Size(145, 36);
            this.radioOffices.TabIndex = 43;
            this.radioOffices.Text = "Offices";
            this.radioOffices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioOffices.UseVisualStyleBackColor = true;
            this.radioOffices.CheckedChanged += new System.EventHandler(this.radioOffices_CheckedChanged);
            // 
            // radioOfficers
            // 
            this.radioOfficers.AutoSize = true;
            this.radioOfficers.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOfficers.Image = global::BinanKiosk.Properties.Resources.officerIcon;
            this.radioOfficers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioOfficers.Location = new System.Drawing.Point(6, 12);
            this.radioOfficers.Name = "radioOfficers";
            this.radioOfficers.Size = new System.Drawing.Size(154, 36);
            this.radioOfficers.TabIndex = 40;
            this.radioOfficers.Text = "Officers";
            this.radioOfficers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioOfficers.UseVisualStyleBackColor = true;
            this.radioOfficers.CheckedChanged += new System.EventHandler(this.radioOfficers_CheckedChanged);
            // 
            // btnLanguages
            // 
            this.btnLanguages.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLanguages.FlatAppearance.BorderSize = 0;
            this.btnLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguages.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguages.ForeColor = System.Drawing.Color.White;
            this.btnLanguages.Location = new System.Drawing.Point(1170, -2);
            this.btnLanguages.Name = "btnLanguages";
            this.btnLanguages.Size = new System.Drawing.Size(128, 64);
            this.btnLanguages.TabIndex = 79;
            this.btnLanguages.Text = "CHANGE LANGUAGE";
            this.btnLanguages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLanguages.UseVisualStyleBackColor = false;
            this.btnLanguages.Click += new System.EventHandler(this.btnLanguages_Click);
            // 
            // timestamp
            // 
            this.timestamp.Interval = 1000;
            this.timestamp.Tick += new System.EventHandler(this.timestamp_Tick);
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
            this.lbltime.TabIndex = 246;
            this.lbltime.Text = ".";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchResult14
            // 
            this.searchResult14.BackColor = System.Drawing.Color.Transparent;
            this.searchResult14.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult14.FlatAppearance.BorderSize = 0;
            this.searchResult14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult14.ForeColor = System.Drawing.Color.White;
            this.searchResult14.Location = new System.Drawing.Point(801, 370);
            this.searchResult14.Name = "searchResult14";
            this.searchResult14.Size = new System.Drawing.Size(230, 65);
            this.searchResult14.TabIndex = 252;
            this.searchResult14.Text = "Search";
            this.searchResult14.UseVisualStyleBackColor = false;
            this.searchResult14.Visible = false;
            this.searchResult14.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult12
            // 
            this.searchResult12.BackColor = System.Drawing.Color.Transparent;
            this.searchResult12.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult12.FlatAppearance.BorderSize = 0;
            this.searchResult12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult12.ForeColor = System.Drawing.Color.White;
            this.searchResult12.Location = new System.Drawing.Point(329, 370);
            this.searchResult12.Name = "searchResult12";
            this.searchResult12.Size = new System.Drawing.Size(230, 65);
            this.searchResult12.TabIndex = 251;
            this.searchResult12.Text = "Search";
            this.searchResult12.UseVisualStyleBackColor = false;
            this.searchResult12.Visible = false;
            this.searchResult12.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult13
            // 
            this.searchResult13.BackColor = System.Drawing.Color.Transparent;
            this.searchResult13.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult13.FlatAppearance.BorderSize = 0;
            this.searchResult13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult13.ForeColor = System.Drawing.Color.White;
            this.searchResult13.Location = new System.Drawing.Point(565, 370);
            this.searchResult13.Name = "searchResult13";
            this.searchResult13.Size = new System.Drawing.Size(230, 65);
            this.searchResult13.TabIndex = 250;
            this.searchResult13.Text = "Search";
            this.searchResult13.UseVisualStyleBackColor = false;
            this.searchResult13.Visible = false;
            this.searchResult13.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult15
            // 
            this.searchResult15.BackColor = System.Drawing.Color.Transparent;
            this.searchResult15.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult15.FlatAppearance.BorderSize = 0;
            this.searchResult15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult15.ForeColor = System.Drawing.Color.White;
            this.searchResult15.Location = new System.Drawing.Point(1037, 370);
            this.searchResult15.Name = "searchResult15";
            this.searchResult15.Size = new System.Drawing.Size(230, 65);
            this.searchResult15.TabIndex = 249;
            this.searchResult15.Text = "Search";
            this.searchResult15.UseVisualStyleBackColor = false;
            this.searchResult15.Visible = false;
            this.searchResult15.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult11
            // 
            this.searchResult11.BackColor = System.Drawing.Color.Transparent;
            this.searchResult11.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult11.FlatAppearance.BorderSize = 0;
            this.searchResult11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult11.ForeColor = System.Drawing.Color.White;
            this.searchResult11.Location = new System.Drawing.Point(93, 370);
            this.searchResult11.Name = "searchResult11";
            this.searchResult11.Size = new System.Drawing.Size(230, 65);
            this.searchResult11.TabIndex = 248;
            this.searchResult11.Text = "Search";
            this.searchResult11.UseVisualStyleBackColor = false;
            this.searchResult11.Visible = false;
            this.searchResult11.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox7.BackgroundImage = global::BinanKiosk.Properties.Resources.Binan_City_Logo;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(7, 695);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(58, 55);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 245;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox8.BackgroundImage = global::BinanKiosk.Properties.Resources.Binan_City;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(71, 695);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(160, 55);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 244;
            this.pictureBox8.TabStop = false;
            // 
            // searchResult9
            // 
            this.searchResult9.BackColor = System.Drawing.Color.Transparent;
            this.searchResult9.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult9.FlatAppearance.BorderSize = 0;
            this.searchResult9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult9.ForeColor = System.Drawing.Color.White;
            this.searchResult9.Location = new System.Drawing.Point(801, 299);
            this.searchResult9.Name = "searchResult9";
            this.searchResult9.Size = new System.Drawing.Size(230, 65);
            this.searchResult9.TabIndex = 77;
            this.searchResult9.Text = "Search";
            this.searchResult9.UseVisualStyleBackColor = false;
            this.searchResult9.Visible = false;
            this.searchResult9.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult7
            // 
            this.searchResult7.BackColor = System.Drawing.Color.Transparent;
            this.searchResult7.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult7.FlatAppearance.BorderSize = 0;
            this.searchResult7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult7.ForeColor = System.Drawing.Color.White;
            this.searchResult7.Location = new System.Drawing.Point(329, 299);
            this.searchResult7.Name = "searchResult7";
            this.searchResult7.Size = new System.Drawing.Size(230, 65);
            this.searchResult7.TabIndex = 76;
            this.searchResult7.Text = "Search";
            this.searchResult7.UseVisualStyleBackColor = false;
            this.searchResult7.Visible = false;
            this.searchResult7.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult8
            // 
            this.searchResult8.BackColor = System.Drawing.Color.Transparent;
            this.searchResult8.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult8.FlatAppearance.BorderSize = 0;
            this.searchResult8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult8.ForeColor = System.Drawing.Color.White;
            this.searchResult8.Location = new System.Drawing.Point(565, 299);
            this.searchResult8.Name = "searchResult8";
            this.searchResult8.Size = new System.Drawing.Size(230, 65);
            this.searchResult8.TabIndex = 75;
            this.searchResult8.Text = "Search";
            this.searchResult8.UseVisualStyleBackColor = false;
            this.searchResult8.Visible = false;
            this.searchResult8.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult10
            // 
            this.searchResult10.BackColor = System.Drawing.Color.Transparent;
            this.searchResult10.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult10.FlatAppearance.BorderSize = 0;
            this.searchResult10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult10.ForeColor = System.Drawing.Color.White;
            this.searchResult10.Location = new System.Drawing.Point(1037, 299);
            this.searchResult10.Name = "searchResult10";
            this.searchResult10.Size = new System.Drawing.Size(230, 65);
            this.searchResult10.TabIndex = 74;
            this.searchResult10.Text = "Search";
            this.searchResult10.UseVisualStyleBackColor = false;
            this.searchResult10.Visible = false;
            this.searchResult10.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult6
            // 
            this.searchResult6.BackColor = System.Drawing.Color.Transparent;
            this.searchResult6.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult6.FlatAppearance.BorderSize = 0;
            this.searchResult6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult6.ForeColor = System.Drawing.Color.White;
            this.searchResult6.Location = new System.Drawing.Point(93, 299);
            this.searchResult6.Name = "searchResult6";
            this.searchResult6.Size = new System.Drawing.Size(230, 65);
            this.searchResult6.TabIndex = 73;
            this.searchResult6.Text = "Search";
            this.searchResult6.UseVisualStyleBackColor = false;
            this.searchResult6.Visible = false;
            this.searchResult6.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult4
            // 
            this.searchResult4.BackColor = System.Drawing.Color.Transparent;
            this.searchResult4.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult4.FlatAppearance.BorderSize = 0;
            this.searchResult4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult4.ForeColor = System.Drawing.Color.White;
            this.searchResult4.Location = new System.Drawing.Point(801, 228);
            this.searchResult4.Name = "searchResult4";
            this.searchResult4.Size = new System.Drawing.Size(230, 65);
            this.searchResult4.TabIndex = 72;
            this.searchResult4.Text = "Search";
            this.searchResult4.UseVisualStyleBackColor = false;
            this.searchResult4.Visible = false;
            this.searchResult4.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult2
            // 
            this.searchResult2.BackColor = System.Drawing.Color.Transparent;
            this.searchResult2.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult2.FlatAppearance.BorderSize = 0;
            this.searchResult2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult2.ForeColor = System.Drawing.Color.White;
            this.searchResult2.Location = new System.Drawing.Point(329, 228);
            this.searchResult2.Name = "searchResult2";
            this.searchResult2.Size = new System.Drawing.Size(230, 65);
            this.searchResult2.TabIndex = 71;
            this.searchResult2.Text = "Search";
            this.searchResult2.UseVisualStyleBackColor = false;
            this.searchResult2.Visible = false;
            this.searchResult2.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult3
            // 
            this.searchResult3.BackColor = System.Drawing.Color.Transparent;
            this.searchResult3.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult3.FlatAppearance.BorderSize = 0;
            this.searchResult3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult3.ForeColor = System.Drawing.Color.White;
            this.searchResult3.Location = new System.Drawing.Point(565, 228);
            this.searchResult3.Name = "searchResult3";
            this.searchResult3.Size = new System.Drawing.Size(230, 65);
            this.searchResult3.TabIndex = 70;
            this.searchResult3.Text = "Search";
            this.searchResult3.UseVisualStyleBackColor = false;
            this.searchResult3.Visible = false;
            this.searchResult3.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult5
            // 
            this.searchResult5.BackColor = System.Drawing.Color.Transparent;
            this.searchResult5.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult5.FlatAppearance.BorderSize = 0;
            this.searchResult5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.searchResult5.ForeColor = System.Drawing.Color.White;
            this.searchResult5.Location = new System.Drawing.Point(1037, 228);
            this.searchResult5.Name = "searchResult5";
            this.searchResult5.Size = new System.Drawing.Size(230, 65);
            this.searchResult5.TabIndex = 69;
            this.searchResult5.Text = "Search";
            this.searchResult5.UseVisualStyleBackColor = false;
            this.searchResult5.Visible = false;
            this.searchResult5.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // searchResult1
            // 
            this.searchResult1.BackColor = System.Drawing.Color.Transparent;
            this.searchResult1.BackgroundImage = global::BinanKiosk.Properties.Resources.button1;
            this.searchResult1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchResult1.FlatAppearance.BorderSize = 0;
            this.searchResult1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchResult1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult1.ForeColor = System.Drawing.Color.White;
            this.searchResult1.Location = new System.Drawing.Point(93, 228);
            this.searchResult1.Name = "searchResult1";
            this.searchResult1.Size = new System.Drawing.Size(230, 65);
            this.searchResult1.TabIndex = 68;
            this.searchResult1.Text = "Search";
            this.searchResult1.UseVisualStyleBackColor = false;
            this.searchResult1.Visible = false;
            this.searchResult1.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(177, 148);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BinanKiosk.Properties.Resources.boxu;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(133, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1090, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 67;
            this.pictureBox4.TabStop = false;
            // 
            // search_animate
            // 
            this.search_animate.Location = new System.Drawing.Point(586, 523);
            this.search_animate.Name = "search_animate";
            this.search_animate.Size = new System.Drawing.Size(185, 131);
            this.search_animate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_animate.TabIndex = 63;
            this.search_animate.TabStop = false;
            this.search_animate.Visible = false;
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
            this.btnHelp.Location = new System.Drawing.Point(1299, -2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(67, 64);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.UseVisualStyleBackColor = false;
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
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Image = global::BinanKiosk.Properties.Resources.srchcn1;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearch.Location = new System.Drawing.Point(24, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(237, 39);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "       SEARCH";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 677);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1459, 94);
            this.pictureBox6.TabIndex = 78;
            this.pictureBox6.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BinanKiosk.Properties.Resources.bgopacity3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.searchResult14);
            this.Controls.Add(this.searchResult12);
            this.Controls.Add(this.searchResult13);
            this.Controls.Add(this.searchResult15);
            this.Controls.Add(this.searchResult11);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnLanguages);
            this.Controls.Add(this.searchResult9);
            this.Controls.Add(this.searchResult7);
            this.Controls.Add(this.searchResult8);
            this.Controls.Add(this.searchResult10);
            this.Controls.Add(this.searchResult6);
            this.Controls.Add(this.searchResult4);
            this.Controls.Add(this.searchResult2);
            this.Controls.Add(this.searchResult3);
            this.Controls.Add(this.searchResult5);
            this.Controls.Add(this.searchResult1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.search_animate);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnMaps);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_animate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton radioApplications;
        private System.Windows.Forms.RadioButton radioOfficers;
        private System.Windows.Forms.RadioButton radioOffices;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.PictureBox search_animate;
        private System.Windows.Forms.GroupBox Filters;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button searchResult1;
        private System.Windows.Forms.Button searchResult5;
        private System.Windows.Forms.Button searchResult3;
        private System.Windows.Forms.Button searchResult2;
        private System.Windows.Forms.Button searchResult4;
        private System.Windows.Forms.Button searchResult9;
        private System.Windows.Forms.Button searchResult7;
        private System.Windows.Forms.Button searchResult8;
        private System.Windows.Forms.Button searchResult10;
        private System.Windows.Forms.Button searchResult6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLanguages;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer timestamp;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button searchResult14;
        private System.Windows.Forms.Button searchResult12;
        private System.Windows.Forms.Button searchResult13;
        private System.Windows.Forms.Button searchResult15;
        private System.Windows.Forms.Button searchResult11;
        private System.Windows.Forms.RadioButton radioJob;
    }
}

