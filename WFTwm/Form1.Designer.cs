namespace WFTwm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_home = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tabname = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.tp_settings = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_charset = new System.Windows.Forms.TextBox();
            this.tb_pooling = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_userid = new System.Windows.Forms.TextBox();
            this.tb_datasource = new System.Windows.Forms.TextBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_sheet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_frequency = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tp_home.SuspendLayout();
            this.tp_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_home);
            this.tabControl1.Controls.Add(this.tp_settings);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_home
            // 
            this.tp_home.AutoScroll = true;
            this.tp_home.Controls.Add(this.label10);
            this.tp_home.Controls.Add(this.label9);
            this.tp_home.Controls.Add(this.label8);
            this.tp_home.Controls.Add(this.tb_frequency);
            this.tp_home.Controls.Add(this.tb_sheet);
            this.tp_home.Controls.Add(this.tb_tabname);
            this.tp_home.Location = new System.Drawing.Point(4, 25);
            this.tp_home.Name = "tp_home";
            this.tp_home.Padding = new System.Windows.Forms.Padding(3);
            this.tp_home.Size = new System.Drawing.Size(768, 358);
            this.tp_home.TabIndex = 0;
            this.tp_home.Text = "操作页";
            this.tp_home.UseVisualStyleBackColor = true;
            this.tp_home.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "表名：";
            // 
            // tb_tabname
            // 
            this.tb_tabname.Location = new System.Drawing.Point(109, 29);
            this.tb_tabname.Name = "tb_tabname";
            this.tb_tabname.Size = new System.Drawing.Size(166, 25);
            this.tb_tabname.TabIndex = 1;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(12, 9);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(81, 36);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "导入";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // tp_settings
            // 
            this.tp_settings.Controls.Add(this.label7);
            this.tp_settings.Controls.Add(this.label6);
            this.tp_settings.Controls.Add(this.label5);
            this.tp_settings.Controls.Add(this.label4);
            this.tp_settings.Controls.Add(this.label3);
            this.tp_settings.Controls.Add(this.label2);
            this.tp_settings.Controls.Add(this.label1);
            this.tp_settings.Controls.Add(this.tb_port);
            this.tp_settings.Controls.Add(this.tb_charset);
            this.tp_settings.Controls.Add(this.tb_pooling);
            this.tp_settings.Controls.Add(this.tb_Password);
            this.tp_settings.Controls.Add(this.tb_userid);
            this.tp_settings.Controls.Add(this.tb_datasource);
            this.tp_settings.Controls.Add(this.tb_database);
            this.tp_settings.Controls.Add(this.btn_save);
            this.tp_settings.Location = new System.Drawing.Point(4, 25);
            this.tp_settings.Name = "tp_settings";
            this.tp_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_settings.Size = new System.Drawing.Size(768, 358);
            this.tp_settings.TabIndex = 1;
            this.tp_settings.Text = "配置页";
            this.tp_settings.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "CharSet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "pooling:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Source:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database:";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(188, 265);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(199, 25);
            this.tb_port.TabIndex = 1;
            // 
            // tb_charset
            // 
            this.tb_charset.Location = new System.Drawing.Point(188, 229);
            this.tb_charset.Name = "tb_charset";
            this.tb_charset.Size = new System.Drawing.Size(199, 25);
            this.tb_charset.TabIndex = 1;
            // 
            // tb_pooling
            // 
            this.tb_pooling.Location = new System.Drawing.Point(188, 193);
            this.tb_pooling.Name = "tb_pooling";
            this.tb_pooling.Size = new System.Drawing.Size(199, 25);
            this.tb_pooling.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(188, 157);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(199, 25);
            this.tb_Password.TabIndex = 1;
            // 
            // tb_userid
            // 
            this.tb_userid.Location = new System.Drawing.Point(188, 121);
            this.tb_userid.Name = "tb_userid";
            this.tb_userid.Size = new System.Drawing.Size(199, 25);
            this.tb_userid.TabIndex = 1;
            // 
            // tb_datasource
            // 
            this.tb_datasource.Location = new System.Drawing.Point(188, 85);
            this.tb_datasource.Name = "tb_datasource";
            this.tb_datasource.Size = new System.Drawing.Size(199, 25);
            this.tb_datasource.TabIndex = 1;
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(188, 49);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(199, 25);
            this.tb_database.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(297, 308);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 26);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "确定";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_sheet
            // 
            this.tb_sheet.Location = new System.Drawing.Point(109, 69);
            this.tb_sheet.Name = "tb_sheet";
            this.tb_sheet.Size = new System.Drawing.Size(166, 25);
            this.tb_sheet.TabIndex = 1;
            this.tb_sheet.Text = "Sheet1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sheet名：";
            // 
            // tb_frequency
            // 
            this.tb_frequency.Location = new System.Drawing.Point(109, 112);
            this.tb_frequency.Name = "tb_frequency";
            this.tb_frequency.Size = new System.Drawing.Size(166, 25);
            this.tb_frequency.TabIndex = 1;
            this.tb_frequency.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "频次：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_import);
            this.Name = "Form1";
            this.Text = "From";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_home.ResumeLayout(false);
            this.tp_home.PerformLayout();
            this.tp_settings.ResumeLayout(false);
            this.tp_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_home;
        private System.Windows.Forms.TabPage tp_settings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pooling;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_userid;
        private System.Windows.Forms.TextBox tb_datasource;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_charset;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tabname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_sheet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_frequency;
    }
}

