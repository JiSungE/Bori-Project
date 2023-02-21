namespace KMap230106
{
    partial class AdminMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TP_Main = new System.Windows.Forms.TabControl();
            this.TP_Map = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_imgname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_longtitude = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_latitude = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.TP_MainForm = new System.Windows.Forms.TabPage();
            this.PB_imgurl = new System.Windows.Forms.PictureBox();
            this.PB_img = new System.Windows.Forms.PictureBox();
            this.btn_mf_create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_mf_delete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_mf_imgurl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mf_img = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mf_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TP_SubMain = new System.Windows.Forms.TabPage();
            this.btn_sub_createNupdate = new System.Windows.Forms.Button();
            this.btn_sub_delete = new System.Windows.Forms.Button();
            this.pb_sub_imgurl = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pb_sub_img = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_sub_imgurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sub_img = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_sub_description = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_sub_title = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_sub_id = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.LV_MarkData = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tb_tureFalse = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.TP_Main.SuspendLayout();
            this.TP_Map.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TP_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imgurl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.TP_SubMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sub_imgurl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sub_img)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TP_Main
            // 
            this.TP_Main.Controls.Add(this.TP_Map);
            this.TP_Main.Controls.Add(this.TP_MainForm);
            this.TP_Main.Controls.Add(this.TP_SubMain);
            this.TP_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.TP_Main.Location = new System.Drawing.Point(0, 0);
            this.TP_Main.Margin = new System.Windows.Forms.Padding(4);
            this.TP_Main.Name = "TP_Main";
            this.TP_Main.SelectedIndex = 0;
            this.TP_Main.Size = new System.Drawing.Size(1091, 343);
            this.TP_Main.TabIndex = 23;
            this.TP_Main.SelectedIndexChanged += new System.EventHandler(this.TP_Main_SelectedIndexChanged);
            // 
            // TP_Map
            // 
            this.TP_Map.BackColor = System.Drawing.Color.White;
            this.TP_Map.Controls.Add(this.groupBox3);
            this.TP_Map.Controls.Add(this.groupBox2);
            this.TP_Map.Controls.Add(this.groupBox1);
            this.TP_Map.Controls.Add(this.tb_result);
            this.TP_Map.Controls.Add(this.btn_create);
            this.TP_Map.Controls.Add(this.btn_delete);
            this.TP_Map.Controls.Add(this.btn_update);
            this.TP_Map.Location = new System.Drawing.Point(4, 29);
            this.TP_Map.Margin = new System.Windows.Forms.Padding(4);
            this.TP_Map.Name = "TP_Map";
            this.TP_Map.Padding = new System.Windows.Forms.Padding(4);
            this.TP_Map.Size = new System.Drawing.Size(1083, 310);
            this.TP_Map.TabIndex = 0;
            this.TP_Map.Text = "Map_Admin";
            this.TP_Map.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.tb_imgname);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tb_description);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(343, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 238);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // tb_imgname
            // 
            this.tb_imgname.Location = new System.Drawing.Point(135, 165);
            this.tb_imgname.Multiline = true;
            this.tb_imgname.Name = "tb_imgname";
            this.tb_imgname.Size = new System.Drawing.Size(421, 50);
            this.tb_imgname.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "IMGNAME";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(135, 30);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(421, 117);
            this.tb_description.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "DESCRIPTION";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.tb_longtitude);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_latitude);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(9, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 86);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // tb_longtitude
            // 
            this.tb_longtitude.Location = new System.Drawing.Point(110, 46);
            this.tb_longtitude.Name = "tb_longtitude";
            this.tb_longtitude.Size = new System.Drawing.Size(179, 27);
            this.tb_longtitude.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "LONGTITUDE";
            // 
            // tb_latitude
            // 
            this.tb_latitude.Location = new System.Drawing.Point(110, 13);
            this.tb_latitude.Name = "tb_latitude";
            this.tb_latitude.Size = new System.Drawing.Size(179, 27);
            this.tb_latitude.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "LATITUDE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tb_tag);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 167);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // tb_tag
            // 
            this.tb_tag.Location = new System.Drawing.Point(86, 115);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(205, 27);
            this.tb_tag.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "TAG";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(86, 82);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(205, 27);
            this.tb_address.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "ADDRESS";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(86, 49);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(205, 27);
            this.tb_name.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "NAME";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(86, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(205, 27);
            this.tb_id.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            // 
            // tb_result
            // 
            this.tb_result.Enabled = false;
            this.tb_result.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_result.Location = new System.Drawing.Point(194, 268);
            this.tb_result.Margin = new System.Windows.Forms.Padding(4);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(726, 27);
            this.tb_result.TabIndex = 43;
            this.tb_result.Text = "반환 값";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(963, 11);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(96, 86);
            this.btn_create.TabIndex = 42;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(963, 209);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 86);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(963, 111);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 86);
            this.btn_update.TabIndex = 42;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // TP_MainForm
            // 
            this.TP_MainForm.Controls.Add(this.PB_imgurl);
            this.TP_MainForm.Controls.Add(this.PB_img);
            this.TP_MainForm.Controls.Add(this.btn_mf_create);
            this.TP_MainForm.Controls.Add(this.label6);
            this.TP_MainForm.Controls.Add(this.label5);
            this.TP_MainForm.Controls.Add(this.btn_mf_delete);
            this.TP_MainForm.Controls.Add(this.groupBox4);
            this.TP_MainForm.Location = new System.Drawing.Point(4, 29);
            this.TP_MainForm.Name = "TP_MainForm";
            this.TP_MainForm.Padding = new System.Windows.Forms.Padding(3);
            this.TP_MainForm.Size = new System.Drawing.Size(1083, 310);
            this.TP_MainForm.TabIndex = 1;
            this.TP_MainForm.Text = "Mainform_Admin";
            this.TP_MainForm.UseVisualStyleBackColor = true;
            // 
            // PB_imgurl
            // 
            this.PB_imgurl.BackgroundImage = global::KMap230106.Properties.Resources.noImg;
            this.PB_imgurl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_imgurl.Location = new System.Drawing.Point(898, 47);
            this.PB_imgurl.Name = "PB_imgurl";
            this.PB_imgurl.Size = new System.Drawing.Size(166, 146);
            this.PB_imgurl.TabIndex = 48;
            this.PB_imgurl.TabStop = false;
            // 
            // PB_img
            // 
            this.PB_img.BackgroundImage = global::KMap230106.Properties.Resources.noImg;
            this.PB_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_img.Location = new System.Drawing.Point(693, 46);
            this.PB_img.Name = "PB_img";
            this.PB_img.Size = new System.Drawing.Size(186, 146);
            this.PB_img.TabIndex = 48;
            this.PB_img.TabStop = false;
            // 
            // btn_mf_create
            // 
            this.btn_mf_create.Location = new System.Drawing.Point(749, 199);
            this.btn_mf_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mf_create.Name = "btn_mf_create";
            this.btn_mf_create.Size = new System.Drawing.Size(76, 86);
            this.btn_mf_create.TabIndex = 46;
            this.btn_mf_create.Text = "Create";
            this.btn_mf_create.UseVisualStyleBackColor = true;
            this.btn_mf_create.Click += new System.EventHandler(this.btn_mf_create_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(898, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "imgurl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "img";
            // 
            // btn_mf_delete
            // 
            this.btn_mf_delete.Enabled = false;
            this.btn_mf_delete.Location = new System.Drawing.Point(937, 200);
            this.btn_mf_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mf_delete.Name = "btn_mf_delete";
            this.btn_mf_delete.Size = new System.Drawing.Size(76, 86);
            this.btn_mf_delete.TabIndex = 47;
            this.btn_mf_delete.Text = "Delete";
            this.btn_mf_delete.UseVisualStyleBackColor = true;
            this.btn_mf_delete.Click += new System.EventHandler(this.btn_mf_delete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.tb_mf_imgurl);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tb_mf_img);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tb_mf_id);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(25, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(619, 267);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // tb_mf_imgurl
            // 
            this.tb_mf_imgurl.Location = new System.Drawing.Point(122, 181);
            this.tb_mf_imgurl.Multiline = true;
            this.tb_mf_imgurl.Name = "tb_mf_imgurl";
            this.tb_mf_imgurl.Size = new System.Drawing.Size(420, 60);
            this.tb_mf_imgurl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "IMGURL";
            // 
            // tb_mf_img
            // 
            this.tb_mf_img.Location = new System.Drawing.Point(122, 75);
            this.tb_mf_img.Multiline = true;
            this.tb_mf_img.Name = "tb_mf_img";
            this.tb_mf_img.Size = new System.Drawing.Size(420, 80);
            this.tb_mf_img.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IMG";
            // 
            // tb_mf_id
            // 
            this.tb_mf_id.Enabled = false;
            this.tb_mf_id.Location = new System.Drawing.Point(122, 16);
            this.tb_mf_id.Name = "tb_mf_id";
            this.tb_mf_id.Size = new System.Drawing.Size(205, 27);
            this.tb_mf_id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // TP_SubMain
            // 
            this.TP_SubMain.Controls.Add(this.btn_sub_createNupdate);
            this.TP_SubMain.Controls.Add(this.btn_sub_delete);
            this.TP_SubMain.Controls.Add(this.pb_sub_imgurl);
            this.TP_SubMain.Controls.Add(this.label20);
            this.TP_SubMain.Controls.Add(this.pb_sub_img);
            this.TP_SubMain.Controls.Add(this.label8);
            this.TP_SubMain.Controls.Add(this.groupBox5);
            this.TP_SubMain.Controls.Add(this.groupBox6);
            this.TP_SubMain.Location = new System.Drawing.Point(4, 29);
            this.TP_SubMain.Name = "TP_SubMain";
            this.TP_SubMain.Padding = new System.Windows.Forms.Padding(3);
            this.TP_SubMain.Size = new System.Drawing.Size(1083, 310);
            this.TP_SubMain.TabIndex = 2;
            this.TP_SubMain.Text = "Sub_Mainform_Admin";
            this.TP_SubMain.UseVisualStyleBackColor = true;
            // 
            // btn_sub_createNupdate
            // 
            this.btn_sub_createNupdate.Enabled = false;
            this.btn_sub_createNupdate.Location = new System.Drawing.Point(814, 211);
            this.btn_sub_createNupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sub_createNupdate.Name = "btn_sub_createNupdate";
            this.btn_sub_createNupdate.Size = new System.Drawing.Size(148, 86);
            this.btn_sub_createNupdate.TabIndex = 53;
            this.btn_sub_createNupdate.Text = "Create OR  Update";
            this.btn_sub_createNupdate.UseVisualStyleBackColor = true;
            this.btn_sub_createNupdate.Click += new System.EventHandler(this.btn_sub_createNupdate_Click);
            // 
            // btn_sub_delete
            // 
            this.btn_sub_delete.Enabled = false;
            this.btn_sub_delete.Location = new System.Drawing.Point(970, 211);
            this.btn_sub_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sub_delete.Name = "btn_sub_delete";
            this.btn_sub_delete.Size = new System.Drawing.Size(76, 86);
            this.btn_sub_delete.TabIndex = 54;
            this.btn_sub_delete.Text = "Delete";
            this.btn_sub_delete.UseVisualStyleBackColor = true;
            this.btn_sub_delete.Click += new System.EventHandler(this.btn_sub_delete_Click);
            // 
            // pb_sub_imgurl
            // 
            this.pb_sub_imgurl.BackgroundImage = global::KMap230106.Properties.Resources.noImg;
            this.pb_sub_imgurl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_sub_imgurl.Location = new System.Drawing.Point(879, 53);
            this.pb_sub_imgurl.Name = "pb_sub_imgurl";
            this.pb_sub_imgurl.Size = new System.Drawing.Size(166, 146);
            this.pb_sub_imgurl.TabIndex = 52;
            this.pb_sub_imgurl.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(879, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 20);
            this.label20.TabIndex = 51;
            this.label20.Text = "imgurl";
            // 
            // pb_sub_img
            // 
            this.pb_sub_img.BackgroundImage = global::KMap230106.Properties.Resources.noImg;
            this.pb_sub_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_sub_img.Location = new System.Drawing.Point(672, 53);
            this.pb_sub_img.Name = "pb_sub_img";
            this.pb_sub_img.Size = new System.Drawing.Size(186, 146);
            this.pb_sub_img.TabIndex = 50;
            this.pb_sub_img.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "img";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.tb_sub_imgurl);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tb_sub_img);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(17, 218);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(790, 86);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            // 
            // tb_sub_imgurl
            // 
            this.tb_sub_imgurl.Location = new System.Drawing.Point(110, 46);
            this.tb_sub_imgurl.Name = "tb_sub_imgurl";
            this.tb_sub_imgurl.Size = new System.Drawing.Size(663, 27);
            this.tb_sub_imgurl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMGURL";
            // 
            // tb_sub_img
            // 
            this.tb_sub_img.Location = new System.Drawing.Point(110, 13);
            this.tb_sub_img.Name = "tb_sub_img";
            this.tb_sub_img.Size = new System.Drawing.Size(663, 27);
            this.tb_sub_img.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "IMG";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.tb_sub_description);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.tb_sub_title);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.tb_sub_id);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(17, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(587, 178);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            // 
            // tb_sub_description
            // 
            this.tb_sub_description.Location = new System.Drawing.Point(145, 82);
            this.tb_sub_description.Multiline = true;
            this.tb_sub_description.Name = "tb_sub_description";
            this.tb_sub_description.Size = new System.Drawing.Size(420, 83);
            this.tb_sub_description.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "DESCRIPTION";
            // 
            // tb_sub_title
            // 
            this.tb_sub_title.Location = new System.Drawing.Point(145, 49);
            this.tb_sub_title.Name = "tb_sub_title";
            this.tb_sub_title.Size = new System.Drawing.Size(420, 27);
            this.tb_sub_title.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "TITLE";
            // 
            // tb_sub_id
            // 
            this.tb_sub_id.Location = new System.Drawing.Point(145, 16);
            this.tb_sub_id.Name = "tb_sub_id";
            this.tb_sub_id.Size = new System.Drawing.Size(206, 27);
            this.tb_sub_id.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "ID";
            // 
            // LV_MarkData
            // 
            this.LV_MarkData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LV_MarkData.FullRowSelect = true;
            this.LV_MarkData.Location = new System.Drawing.Point(15, 389);
            this.LV_MarkData.Margin = new System.Windows.Forms.Padding(4);
            this.LV_MarkData.Name = "LV_MarkData";
            this.LV_MarkData.Size = new System.Drawing.Size(967, 193);
            this.LV_MarkData.TabIndex = 25;
            this.LV_MarkData.UseCompatibleStateImageBehavior = false;
            this.LV_MarkData.View = System.Windows.Forms.View.Details;
            this.LV_MarkData.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LV_MarkData_ColumnClick);
            this.LV_MarkData.SelectedIndexChanged += new System.EventHandler(this.LV_MarkData_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // tb_tureFalse
            // 
            this.tb_tureFalse.Enabled = false;
            this.tb_tureFalse.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_tureFalse.Location = new System.Drawing.Point(120, 351);
            this.tb_tureFalse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tureFalse.Name = "tb_tureFalse";
            this.tb_tureFalse.Size = new System.Drawing.Size(948, 27);
            this.tb_tureFalse.TabIndex = 24;
            this.tb_tureFalse.Text = "성공 실패";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(15, 351);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(97, 31);
            this.btn_load.TabIndex = 23;
            this.btn_load.Text = "불러오기";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 600);
            this.Controls.Add(this.TP_Main);
            this.Controls.Add(this.tb_tureFalse);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.LV_MarkData);
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainForm";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.TP_Main.ResumeLayout(false);
            this.TP_Map.ResumeLayout(false);
            this.TP_Map.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TP_MainForm.ResumeLayout(false);
            this.TP_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_imgurl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TP_SubMain.ResumeLayout(false);
            this.TP_SubMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sub_imgurl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sub_img)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl TP_Main;
        private ListView LV_MarkData;
        private ColumnHeader columnHeader1;
        private TextBox tb_tureFalse;
        private Button btn_load;
        private TabPage TP_Map;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox tb_result;
        private Button btn_create;
        private Button btn_delete;
        private Button btn_update;

        private TextBox tb_imgname;
        private Label label16;
        private TextBox tb_description;
        private Label label15;
        private TextBox tb_longtitude;
        private Label label14;
        private TextBox tb_latitude;
        private Label label13;
        private TextBox tb_tag;
        private Label label12;
        private TextBox tb_address;
        private Label label11;
        private TextBox tb_name;
        private Label label10;
        private TextBox tb_id;
        private Label label9;
        private TabPage TP_MainForm;
        private TabPage TP_SubMain;
        private GroupBox groupBox4;
        private TextBox tb_mf_imgurl;
        private Label label2;
        private TextBox tb_mf_img;
        private Label label3;
        private TextBox tb_mf_id;
        private Label label4;
        private Button btn_mf_create;
        private Button btn_mf_delete;
        private PictureBox PB_imgurl;
        private PictureBox PB_img;
        private Label label6;
        private Label label5;
        private GroupBox groupBox5;
        private TextBox tb_sub_imgurl;
        private Label label1;
        private TextBox tb_sub_img;
        private Label label7;
        private GroupBox groupBox6;
        private TextBox tb_sub_description;
        private Label label17;
        private TextBox tb_sub_title;
        private Label label18;
        private TextBox tb_sub_id;
        private Label label19;
        private PictureBox pb_sub_imgurl;
        private Label label20;
        private PictureBox pb_sub_img;
        private Label label8;
        private Button btn_sub_createNupdate;
        private Button btn_sub_delete;
    }
}