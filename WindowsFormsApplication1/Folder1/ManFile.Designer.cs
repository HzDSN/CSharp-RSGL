﻿namespace WindowsFormsApplication1
{
    partial class ManFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManFile));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Sut_Save = new System.Windows.Forms.Button();
            this.Sut_Cancel = new System.Windows.Forms.Button();
            this.Sut_Delete = new System.Windows.Forms.Button();
            this.Sut_Amend = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Sut_Add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.S_7 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.S_10 = new System.Windows.Forms.TextBox();
            this.S_9 = new System.Windows.Forms.TextBox();
            this.S_11 = new System.Windows.Forms.TextBox();
            this.S_8 = new System.Windows.Forms.TextBox();
            this.S_4 = new System.Windows.Forms.TextBox();
            this.S_1 = new System.Windows.Forms.TextBox();
            this.S_0 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.Img_Save = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.Img_Clear = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.S_Photo = new System.Windows.Forms.PictureBox();
            this.S_5 = new System.Windows.Forms.ComboBox();
            this.S_6 = new System.Windows.Forms.ComboBox();
            this.S_3 = new System.Windows.Forms.MaskedTextBox();
            this.S_2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Ind_Mome = new System.Windows.Forms.TextBox();
            this.Col_StuffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.N_Next = new System.Windows.Forms.Button();
            this.N_Previous = new System.Windows.Forms.Button();
            this.N_First = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.N_Cauda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_Photo)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Sut_Save
            // 
            this.Sut_Save.Enabled = false;
            this.Sut_Save.Location = new System.Drawing.Point(448, 17);
            this.Sut_Save.Name = "Sut_Save";
            this.Sut_Save.Size = new System.Drawing.Size(75, 23);
            this.Sut_Save.TabIndex = 4;
            this.Sut_Save.Text = "保存";
            this.Sut_Save.UseVisualStyleBackColor = true;
            this.Sut_Save.Click += new System.EventHandler(this.Sut_Save_Click);
            // 
            // Sut_Cancel
            // 
            this.Sut_Cancel.Enabled = false;
            this.Sut_Cancel.Location = new System.Drawing.Point(339, 17);
            this.Sut_Cancel.Name = "Sut_Cancel";
            this.Sut_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Sut_Cancel.TabIndex = 3;
            this.Sut_Cancel.Text = "取消";
            this.Sut_Cancel.UseVisualStyleBackColor = true;
            // 
            // Sut_Delete
            // 
            this.Sut_Delete.Location = new System.Drawing.Point(230, 17);
            this.Sut_Delete.Name = "Sut_Delete";
            this.Sut_Delete.Size = new System.Drawing.Size(75, 23);
            this.Sut_Delete.TabIndex = 2;
            this.Sut_Delete.Text = "删除";
            this.Sut_Delete.UseVisualStyleBackColor = true;
            // 
            // Sut_Amend
            // 
            this.Sut_Amend.Location = new System.Drawing.Point(121, 17);
            this.Sut_Amend.Name = "Sut_Amend";
            this.Sut_Amend.Size = new System.Drawing.Size(75, 23);
            this.Sut_Amend.TabIndex = 1;
            this.Sut_Amend.Text = "修改";
            this.Sut_Amend.UseVisualStyleBackColor = true;
            this.Sut_Amend.Click += new System.EventHandler(this.Sut_Amend_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Sut_Save);
            this.groupBox5.Controls.Add(this.Sut_Cancel);
            this.groupBox5.Controls.Add(this.Sut_Delete);
            this.groupBox5.Controls.Add(this.Sut_Amend);
            this.groupBox5.Controls.Add(this.Sut_Add);
            this.groupBox5.Location = new System.Drawing.Point(10, 241);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(539, 46);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // Sut_Add
            // 
            this.Sut_Add.Location = new System.Drawing.Point(12, 17);
            this.Sut_Add.Name = "Sut_Add";
            this.Sut_Add.Size = new System.Drawing.Size(75, 23);
            this.Sut_Add.TabIndex = 0;
            this.Sut_Add.Text = "添加";
            this.Sut_Add.UseVisualStyleBackColor = true;
            this.Sut_Add.Click += new System.EventHandler(this.Sut_Add_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Location = new System.Drawing.Point(187, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 290);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(6, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.S_7);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.S_10);
            this.tabPage1.Controls.Add(this.S_9);
            this.tabPage1.Controls.Add(this.S_11);
            this.tabPage1.Controls.Add(this.S_8);
            this.tabPage1.Controls.Add(this.S_4);
            this.tabPage1.Controls.Add(this.S_1);
            this.tabPage1.Controls.Add(this.S_0);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.Img_Save);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.Img_Clear);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.S_Photo);
            this.tabPage1.Controls.Add(this.S_5);
            this.tabPage1.Controls.Add(this.S_6);
            this.tabPage1.Controls.Add(this.S_3);
            this.tabPage1.Controls.Add(this.S_2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "职工基本信息";
            // 
            // S_7
            // 
            this.S_7.FormattingEnabled = true;
            this.S_7.Location = new System.Drawing.Point(246, 65);
            this.S_7.Name = "S_7";
            this.S_7.Size = new System.Drawing.Size(132, 20);
            this.S_7.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 87;
            this.label12.Text = "政治面貌：";
            // 
            // S_10
            // 
            this.S_10.Location = new System.Drawing.Point(50, 144);
            this.S_10.Name = "S_10";
            this.S_10.Size = new System.Drawing.Size(124, 21);
            this.S_10.TabIndex = 79;
            // 
            // S_9
            // 
            this.S_9.Location = new System.Drawing.Point(74, 118);
            this.S_9.Name = "S_9";
            this.S_9.Size = new System.Drawing.Size(305, 21);
            this.S_9.TabIndex = 70;
            // 
            // S_11
            // 
            this.S_11.Location = new System.Drawing.Point(244, 146);
            this.S_11.Name = "S_11";
            this.S_11.Size = new System.Drawing.Size(134, 21);
            this.S_11.TabIndex = 64;
            // 
            // S_8
            // 
            this.S_8.Location = new System.Drawing.Point(62, 92);
            this.S_8.Name = "S_8";
            this.S_8.Size = new System.Drawing.Size(316, 21);
            this.S_8.TabIndex = 31;
            // 
            // S_4
            // 
            this.S_4.Location = new System.Drawing.Point(220, 40);
            this.S_4.Name = "S_4";
            this.S_4.Size = new System.Drawing.Size(43, 21);
            this.S_4.TabIndex = 30;
            // 
            // S_1
            // 
            this.S_1.Location = new System.Drawing.Point(199, 13);
            this.S_1.Name = "S_1";
            this.S_1.Size = new System.Drawing.Size(62, 21);
            this.S_1.TabIndex = 26;
            // 
            // S_0
            // 
            this.S_0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S_0.Location = new System.Drawing.Point(73, 13);
            this.S_0.Name = "S_0";
            this.S_0.ReadOnly = true;
            this.S_0.Size = new System.Drawing.Size(58, 21);
            this.S_0.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 149);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 12);
            this.label30.TabIndex = 77;
            this.label30.Text = "薪资：";
            // 
            // Img_Save
            // 
            this.Img_Save.Enabled = false;
            this.Img_Save.Location = new System.Drawing.Point(391, 168);
            this.Img_Save.Name = "Img_Save";
            this.Img_Save.Size = new System.Drawing.Size(75, 23);
            this.Img_Save.TabIndex = 71;
            this.Img_Save.Text = "选择图片";
            this.Img_Save.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 12);
            this.label29.TabIndex = 69;
            this.label29.Text = "家庭地址：";
            // 
            // Img_Clear
            // 
            this.Img_Clear.Enabled = false;
            this.Img_Clear.Location = new System.Drawing.Point(475, 168);
            this.Img_Clear.Name = "Img_Clear";
            this.Img_Clear.Size = new System.Drawing.Size(45, 23);
            this.Img_Clear.TabIndex = 68;
            this.Img_Clear.Text = "清除";
            this.Img_Clear.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(187, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 60;
            this.label25.Text = "手机：";
            // 
            // S_Photo
            // 
            this.S_Photo.BackColor = System.Drawing.Color.LavenderBlush;
            this.S_Photo.Location = new System.Drawing.Point(391, 12);
            this.S_Photo.Name = "S_Photo";
            this.S_Photo.Size = new System.Drawing.Size(129, 149);
            this.S_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.S_Photo.TabIndex = 58;
            this.S_Photo.TabStop = false;
            // 
            // S_5
            // 
            this.S_5.FormattingEnabled = true;
            this.S_5.Items.AddRange(new object[] {
            "男",
            "女"});
            this.S_5.Location = new System.Drawing.Point(314, 40);
            this.S_5.Name = "S_5";
            this.S_5.Size = new System.Drawing.Size(64, 20);
            this.S_5.TabIndex = 36;
            // 
            // S_6
            // 
            this.S_6.FormattingEnabled = true;
            this.S_6.Location = new System.Drawing.Point(72, 67);
            this.S_6.Name = "S_6";
            this.S_6.Size = new System.Drawing.Size(101, 20);
            this.S_6.TabIndex = 34;
            // 
            // S_3
            // 
            this.S_3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.S_3.Location = new System.Drawing.Point(73, 39);
            this.S_3.Name = "S_3";
            this.S_3.Size = new System.Drawing.Size(100, 21);
            this.S_3.TabIndex = 29;
            // 
            // S_2
            // 
            this.S_2.FormattingEnabled = true;
            this.S_2.Location = new System.Drawing.Point(305, 14);
            this.S_2.Name = "S_2";
            this.S_2.Size = new System.Drawing.Size(73, 20);
            this.S_2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "身份证：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "性别：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "文化程度：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "年龄：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "出生日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "民族：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "职工姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "职工编号：";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Ind_Mome);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(531, 201);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "个人简历";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Ind_Mome
            // 
            this.Ind_Mome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ind_Mome.Location = new System.Drawing.Point(3, 3);
            this.Ind_Mome.Multiline = true;
            this.Ind_Mome.Name = "Ind_Mome";
            this.Ind_Mome.Size = new System.Drawing.Size(525, 195);
            this.Ind_Mome.TabIndex = 0;
            // 
            // Col_StuffName
            // 
            this.Col_StuffName.DataPropertyName = "StuffName";
            this.Col_StuffName.HeaderText = "职工姓名";
            this.Col_StuffName.Name = "Col_StuffName";
            // 
            // Col_ID
            // 
            this.Col_ID.DataPropertyName = "ID";
            this.Col_ID.HeaderText = "编号";
            this.Col_ID.Name = "Col_ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "显示所有信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_StuffName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(157, 198);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // N_Next
            // 
            this.N_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N_Next.BackgroundImage")));
            this.N_Next.Location = new System.Drawing.Point(130, 18);
            this.N_Next.Name = "N_Next";
            this.N_Next.Size = new System.Drawing.Size(58, 23);
            this.N_Next.TabIndex = 2;
            this.N_Next.UseVisualStyleBackColor = true;
            this.N_Next.Click += new System.EventHandler(this.N_Next_Click);
            // 
            // N_Previous
            // 
            this.N_Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N_Previous.BackgroundImage")));
            this.N_Previous.Enabled = false;
            this.N_Previous.Location = new System.Drawing.Point(73, 18);
            this.N_Previous.Name = "N_Previous";
            this.N_Previous.Size = new System.Drawing.Size(57, 23);
            this.N_Previous.TabIndex = 1;
            this.N_Previous.UseVisualStyleBackColor = true;
            // 
            // N_First
            // 
            this.N_First.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N_First.BackgroundImage")));
            this.N_First.Enabled = false;
            this.N_First.Location = new System.Drawing.Point(16, 18);
            this.N_First.Name = "N_First";
            this.N_First.Size = new System.Drawing.Size(57, 23);
            this.N_First.TabIndex = 0;
            this.N_First.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "当前记录：";
            // 
            // N_Cauda
            // 
            this.N_Cauda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("N_Cauda.BackgroundImage")));
            this.N_Cauda.Location = new System.Drawing.Point(188, 18);
            this.N_Cauda.Name = "N_Cauda";
            this.N_Cauda.Size = new System.Drawing.Size(57, 23);
            this.N_Cauda.TabIndex = 3;
            this.N_Cauda.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.N_Cauda);
            this.groupBox2.Controls.Add(this.N_Next);
            this.groupBox2.Controls.Add(this.N_Previous);
            this.groupBox2.Controls.Add(this.N_First);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 46);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "浏览按钮";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询类型：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(307, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 20);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "查询条件：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按工号查询",
            "按姓名查询",
            "按性别查询",
            "按民族查询",
            "按文化程度查询",
            "按政治面貌查询"});
            this.comboBox1.Location = new System.Drawing.Point(88, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 290);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类查询";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 378);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(709, 21);
            this.textBox2.TabIndex = 8;
            // 
            // ManFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManFile";
            this.Text = "ManFile";
            this.Load += new System.EventHandler(this.ManFile_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.S_Photo)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Sut_Save;
        private System.Windows.Forms.Button Sut_Cancel;
        private System.Windows.Forms.Button Sut_Delete;
        private System.Windows.Forms.Button Sut_Amend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Sut_Add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_StuffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button N_Next;
        private System.Windows.Forms.Button N_Previous;
        private System.Windows.Forms.Button N_First;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button N_Cauda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox S_7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox S_10;
        private System.Windows.Forms.TextBox S_9;
        private System.Windows.Forms.TextBox S_11;
        private System.Windows.Forms.TextBox S_8;
        private System.Windows.Forms.TextBox S_4;
        private System.Windows.Forms.TextBox S_1;
        private System.Windows.Forms.TextBox S_0;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button Img_Save;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button Img_Clear;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox S_Photo;
        private System.Windows.Forms.ComboBox S_5;
        private System.Windows.Forms.ComboBox S_6;
        private System.Windows.Forms.MaskedTextBox S_3;
        private System.Windows.Forms.ComboBox S_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox Ind_Mome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}