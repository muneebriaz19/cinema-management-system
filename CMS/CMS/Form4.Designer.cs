namespace CMS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.hall_silver = new System.Windows.Forms.Label();
            this.hall_gold = new System.Windows.Forms.Label();
            this.hall_platinum = new System.Windows.Forms.Label();
            this.silver_hall = new System.Windows.Forms.ComboBox();
            this.gold_hall = new System.Windows.Forms.ComboBox();
            this.platinum_hall = new System.Windows.Forms.ComboBox();
            this.platinumtime1 = new System.Windows.Forms.ComboBox();
            this.goldtime1 = new System.Windows.Forms.ComboBox();
            this.silvertime1 = new System.Windows.Forms.ComboBox();
            this.platinum1time = new System.Windows.Forms.Label();
            this.gold1time = new System.Windows.Forms.Label();
            this.silver1time = new System.Windows.Forms.Label();
            this.platinumtime2 = new System.Windows.Forms.ComboBox();
            this.goldtime2 = new System.Windows.Forms.ComboBox();
            this.silvertime2 = new System.Windows.Forms.ComboBox();
            this.platinum2time = new System.Windows.Forms.Label();
            this.gold2time = new System.Windows.Forms.Label();
            this.silver2time = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.ComboBox();
            this.moviecategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemamanagementDataSet = new CMS.cinemamanagementDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.availabletimeTableAdapter1 = new CMS.cinemamanagementDataSetTableAdapters.availabletimeTableAdapter();
            this.moviecategoryTableAdapter = new CMS.cinemamanagementDataSetTableAdapters.moviecategoryTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviecategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemamanagementDataSet)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 64);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.button3.BackgroundImage = global::CMS.Properties.Resources.cancel2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(927, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 39);
            this.button3.TabIndex = 72;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(534, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 36);
            this.label15.TabIndex = 7;
            this.label15.Text = "Update Movies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CMS.Properties.Resources.movie_projector_80px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(94, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(446, 36);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cinema Management System >";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(221, 143);
            this.Name.Margin = new System.Windows.Forms.Padding(2);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(264, 23);
            this.Name.TabIndex = 17;
            this.Name.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(221, 98);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(264, 23);
            this.id.TabIndex = 14;
            this.id.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ticket Category:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(221, 190);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 23);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Silver";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(317, 190);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 23);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Gold";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(402, 190);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 23);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Platinum";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // hall_silver
            // 
            this.hall_silver.AutoSize = true;
            this.hall_silver.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hall_silver.Location = new System.Drawing.Point(31, 245);
            this.hall_silver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hall_silver.Name = "hall_silver";
            this.hall_silver.Size = new System.Drawing.Size(95, 19);
            this.hall_silver.TabIndex = 22;
            this.hall_silver.Text = "Hall(Silver):";
            this.hall_silver.Visible = false;
            // 
            // hall_gold
            // 
            this.hall_gold.AutoSize = true;
            this.hall_gold.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hall_gold.Location = new System.Drawing.Point(31, 320);
            this.hall_gold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hall_gold.Name = "hall_gold";
            this.hall_gold.Size = new System.Drawing.Size(89, 19);
            this.hall_gold.TabIndex = 23;
            this.hall_gold.Text = "Hall(Gold):";
            this.hall_gold.Visible = false;
            // 
            // hall_platinum
            // 
            this.hall_platinum.AutoSize = true;
            this.hall_platinum.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hall_platinum.Location = new System.Drawing.Point(31, 398);
            this.hall_platinum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hall_platinum.Name = "hall_platinum";
            this.hall_platinum.Size = new System.Drawing.Size(122, 19);
            this.hall_platinum.TabIndex = 24;
            this.hall_platinum.Text = "Hall(Platinum):";
            this.hall_platinum.Visible = false;
            // 
            // silver_hall
            // 
            this.silver_hall.FormattingEnabled = true;
            this.silver_hall.Items.AddRange(new object[] {
            "101",
            "102",
            "103"});
            this.silver_hall.Location = new System.Drawing.Point(221, 247);
            this.silver_hall.Margin = new System.Windows.Forms.Padding(2);
            this.silver_hall.Name = "silver_hall";
            this.silver_hall.Size = new System.Drawing.Size(264, 21);
            this.silver_hall.TabIndex = 25;
            this.silver_hall.Visible = false;
            this.silver_hall.SelectedIndexChanged += new System.EventHandler(this.silver_hall_SelectedIndexChanged);
            // 
            // gold_hall
            // 
            this.gold_hall.FormattingEnabled = true;
            this.gold_hall.Items.AddRange(new object[] {
            "201",
            "202",
            "203"});
            this.gold_hall.Location = new System.Drawing.Point(221, 320);
            this.gold_hall.Margin = new System.Windows.Forms.Padding(2);
            this.gold_hall.Name = "gold_hall";
            this.gold_hall.Size = new System.Drawing.Size(264, 21);
            this.gold_hall.TabIndex = 26;
            this.gold_hall.Visible = false;
            this.gold_hall.SelectedIndexChanged += new System.EventHandler(this.gold_hall_SelectedIndexChanged);
            // 
            // platinum_hall
            // 
            this.platinum_hall.FormattingEnabled = true;
            this.platinum_hall.Items.AddRange(new object[] {
            "301",
            "302",
            "303"});
            this.platinum_hall.Location = new System.Drawing.Point(221, 396);
            this.platinum_hall.Margin = new System.Windows.Forms.Padding(2);
            this.platinum_hall.Name = "platinum_hall";
            this.platinum_hall.Size = new System.Drawing.Size(264, 21);
            this.platinum_hall.TabIndex = 27;
            this.platinum_hall.Visible = false;
            this.platinum_hall.SelectedIndexChanged += new System.EventHandler(this.platinum_hall_SelectedIndexChanged);
            // 
            // platinumtime1
            // 
            this.platinumtime1.FormattingEnabled = true;
            this.platinumtime1.Location = new System.Drawing.Point(616, 393);
            this.platinumtime1.Margin = new System.Windows.Forms.Padding(2);
            this.platinumtime1.Name = "platinumtime1";
            this.platinumtime1.Size = new System.Drawing.Size(107, 21);
            this.platinumtime1.TabIndex = 33;
            this.platinumtime1.Visible = false;
            this.platinumtime1.SelectedIndexChanged += new System.EventHandler(this.platinumtime1_SelectedIndexChanged);
            // 
            // goldtime1
            // 
            this.goldtime1.FormattingEnabled = true;
            this.goldtime1.Location = new System.Drawing.Point(616, 317);
            this.goldtime1.Margin = new System.Windows.Forms.Padding(2);
            this.goldtime1.Name = "goldtime1";
            this.goldtime1.Size = new System.Drawing.Size(107, 21);
            this.goldtime1.TabIndex = 32;
            this.goldtime1.Visible = false;
            this.goldtime1.SelectedIndexChanged += new System.EventHandler(this.goldtime1_SelectedIndexChanged);
            // 
            // silvertime1
            // 
            this.silvertime1.FormattingEnabled = true;
            this.silvertime1.Location = new System.Drawing.Point(616, 247);
            this.silvertime1.Margin = new System.Windows.Forms.Padding(2);
            this.silvertime1.Name = "silvertime1";
            this.silvertime1.Size = new System.Drawing.Size(107, 21);
            this.silvertime1.TabIndex = 31;
            this.silvertime1.Visible = false;
            this.silvertime1.SelectedIndexChanged += new System.EventHandler(this.silvertime1_SelectedIndexChanged);
            // 
            // platinum1time
            // 
            this.platinum1time.AutoSize = true;
            this.platinum1time.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platinum1time.Location = new System.Drawing.Point(526, 395);
            this.platinum1time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platinum1time.Name = "platinum1time";
            this.platinum1time.Size = new System.Drawing.Size(57, 19);
            this.platinum1time.TabIndex = 30;
            this.platinum1time.Text = "Time1:";
            this.platinum1time.Visible = false;
            // 
            // gold1time
            // 
            this.gold1time.AutoSize = true;
            this.gold1time.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold1time.Location = new System.Drawing.Point(526, 319);
            this.gold1time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gold1time.Name = "gold1time";
            this.gold1time.Size = new System.Drawing.Size(57, 19);
            this.gold1time.TabIndex = 29;
            this.gold1time.Text = "Time1:";
            this.gold1time.Visible = false;
            // 
            // silver1time
            // 
            this.silver1time.AutoSize = true;
            this.silver1time.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silver1time.Location = new System.Drawing.Point(526, 245);
            this.silver1time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.silver1time.Name = "silver1time";
            this.silver1time.Size = new System.Drawing.Size(57, 19);
            this.silver1time.TabIndex = 28;
            this.silver1time.Text = "Time1:";
            this.silver1time.Visible = false;
            // 
            // platinumtime2
            // 
            this.platinumtime2.FormattingEnabled = true;
            this.platinumtime2.Location = new System.Drawing.Point(847, 393);
            this.platinumtime2.Margin = new System.Windows.Forms.Padding(2);
            this.platinumtime2.Name = "platinumtime2";
            this.platinumtime2.Size = new System.Drawing.Size(107, 21);
            this.platinumtime2.TabIndex = 39;
            this.platinumtime2.Visible = false;
            // 
            // goldtime2
            // 
            this.goldtime2.FormattingEnabled = true;
            this.goldtime2.Location = new System.Drawing.Point(847, 314);
            this.goldtime2.Margin = new System.Windows.Forms.Padding(2);
            this.goldtime2.Name = "goldtime2";
            this.goldtime2.Size = new System.Drawing.Size(107, 21);
            this.goldtime2.TabIndex = 38;
            this.goldtime2.Visible = false;
            // 
            // silvertime2
            // 
            this.silvertime2.FormattingEnabled = true;
            this.silvertime2.Location = new System.Drawing.Point(847, 245);
            this.silvertime2.Margin = new System.Windows.Forms.Padding(2);
            this.silvertime2.Name = "silvertime2";
            this.silvertime2.Size = new System.Drawing.Size(107, 21);
            this.silvertime2.TabIndex = 37;
            this.silvertime2.Visible = false;
            // 
            // platinum2time
            // 
            this.platinum2time.AutoSize = true;
            this.platinum2time.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platinum2time.Location = new System.Drawing.Point(756, 396);
            this.platinum2time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platinum2time.Name = "platinum2time";
            this.platinum2time.Size = new System.Drawing.Size(57, 19);
            this.platinum2time.TabIndex = 36;
            this.platinum2time.Text = "Time2:";
            this.platinum2time.Visible = false;
            // 
            // gold2time
            // 
            this.gold2time.AutoSize = true;
            this.gold2time.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold2time.Location = new System.Drawing.Point(756, 316);
            this.gold2time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gold2time.Name = "gold2time";
            this.gold2time.Size = new System.Drawing.Size(57, 19);
            this.gold2time.TabIndex = 35;
            this.gold2time.Text = "Time2:";
            this.gold2time.Visible = false;
            // 
            // silver2time
            // 
            this.silver2time.AutoSize = true;
            this.silver2time.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silver2time.Location = new System.Drawing.Point(756, 242);
            this.silver2time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.silver2time.Name = "silver2time";
            this.silver2time.Size = new System.Drawing.Size(57, 19);
            this.silver2time.TabIndex = 34;
            this.silver2time.Text = "Time2:";
            this.silver2time.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(434, 463);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 41;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.remove);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(530, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 158);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(187, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 43;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // remove
            // 
            this.remove.DataSource = this.moviecategoryBindingSource;
            this.remove.DisplayMember = "movie_name";
            this.remove.FormattingEnabled = true;
            this.remove.Location = new System.Drawing.Point(119, 32);
            this.remove.Margin = new System.Windows.Forms.Padding(2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(273, 21);
            this.remove.TabIndex = 43;
            this.remove.ValueMember = "movie_id";
            // 
            // moviecategoryBindingSource
            // 
            this.moviecategoryBindingSource.DataMember = "moviecategory";
            this.moviecategoryBindingSource.DataSource = this.cinemamanagementDataSet;
            // 
            // cinemamanagementDataSet
            // 
            this.cinemamanagementDataSet.DataSetName = "cinemamanagementDataSet";
            this.cinemamanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Remove:";
            // 
            // availabletimeTableAdapter1
            // 
            this.availabletimeTableAdapter1.ClearBeforeFill = true;
            // 
            // moviecategoryTableAdapter
            // 
            this.moviecategoryTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 64);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(995, 25);
            this.fillBy1ToolStrip.TabIndex = 43;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.button5.BackgroundImage = global::CMS.Properties.Resources.back2;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(11, 68);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 24);
            this.button5.TabIndex = 75;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.button6.BackgroundImage = global::CMS.Properties.Resources.refresh2;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(40, 68);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 24);
            this.button6.TabIndex = 77;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(974, 553);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.platinumtime2);
            this.Controls.Add(this.goldtime2);
            this.Controls.Add(this.silvertime2);
            this.Controls.Add(this.platinum2time);
            this.Controls.Add(this.gold2time);
            this.Controls.Add(this.silver2time);
            this.Controls.Add(this.platinumtime1);
            this.Controls.Add(this.goldtime1);
            this.Controls.Add(this.silvertime1);
            this.Controls.Add(this.platinum1time);
            this.Controls.Add(this.gold1time);
            this.Controls.Add(this.silver1time);
            this.Controls.Add(this.platinum_hall);
            this.Controls.Add(this.gold_hall);
            this.Controls.Add(this.silver_hall);
            this.Controls.Add(this.hall_platinum);
            this.Controls.Add(this.hall_gold);
            this.Controls.Add(this.hall_silver);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            //this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviecategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemamanagementDataSet)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label hall_silver;
        private System.Windows.Forms.Label hall_gold;
        private System.Windows.Forms.Label hall_platinum;
        private System.Windows.Forms.ComboBox silver_hall;
        private System.Windows.Forms.ComboBox gold_hall;
        private System.Windows.Forms.ComboBox platinum_hall;
        private System.Windows.Forms.ComboBox platinumtime1;
        private System.Windows.Forms.ComboBox goldtime1;
        private System.Windows.Forms.ComboBox silvertime1;
        private System.Windows.Forms.Label platinum1time;
        private System.Windows.Forms.Label gold1time;
        private System.Windows.Forms.Label silver1time;
        private System.Windows.Forms.ComboBox platinumtime2;
        private System.Windows.Forms.ComboBox goldtime2;
        private System.Windows.Forms.ComboBox silvertime2;
        private System.Windows.Forms.Label platinum2time;
        private System.Windows.Forms.Label gold2time;
        private System.Windows.Forms.Label silver2time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox remove;
        private System.Windows.Forms.Label label4;
        private cinemamanagementDataSetTableAdapters.availabletimeTableAdapter availabletimeTableAdapter1;
        private cinemamanagementDataSet cinemamanagementDataSet;
        private System.Windows.Forms.BindingSource moviecategoryBindingSource;
        private cinemamanagementDataSetTableAdapters.moviecategoryTableAdapter moviecategoryTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}