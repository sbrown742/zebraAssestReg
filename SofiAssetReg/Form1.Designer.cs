namespace SofiAssetReg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBatchFile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLabelPrefix = new System.Windows.Forms.Label();
            this.lblLabelSerial = new System.Windows.Forms.Label();
            this.lblLabelMac = new System.Windows.Forms.Label();
            this.lblLabelZwave = new System.Windows.Forms.Label();
            this.lblLabelModel = new System.Windows.Forms.Label();
            this.lblLabelYear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkSerialGenerate = new System.Windows.Forms.CheckBox();
            this.chkPrintLabel = new System.Windows.Forms.CheckBox();
            this.chkRegisterAsset = new System.Windows.Forms.CheckBox();
            this.chkClearFields = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZwave = new System.Windows.Forms.TextBox();
            this.txtSnPrefix = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.printerSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // printerSettingsToolStripMenuItem
            // 
            this.printerSettingsToolStripMenuItem.Name = "printerSettingsToolStripMenuItem";
            this.printerSettingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.printerSettingsToolStripMenuItem.Text = "Printer Settings";
            this.printerSettingsToolStripMenuItem.Click += new System.EventHandler(this.printerSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Asset";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "ZWAVE | MAC | IMIE | SERIAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Batch Import";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.txtBatchFile);
            this.panel5.Location = new System.Drawing.Point(6, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 37);
            this.panel5.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 21);
            this.button3.TabIndex = 1;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBatchFile
            // 
            this.txtBatchFile.Location = new System.Drawing.Point(0, 8);
            this.txtBatchFile.Name = "txtBatchFile";
            this.txtBatchFile.Size = new System.Drawing.Size(227, 20);
            this.txtBatchFile.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Label Preview";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblLabelPrefix);
            this.panel4.Controls.Add(this.lblLabelSerial);
            this.panel4.Controls.Add(this.lblLabelMac);
            this.panel4.Controls.Add(this.lblLabelZwave);
            this.panel4.Controls.Add(this.lblLabelModel);
            this.panel4.Controls.Add(this.lblLabelYear);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(279, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 144);
            this.panel4.TabIndex = 25;
            // 
            // lblLabelPrefix
            // 
            this.lblLabelPrefix.AutoSize = true;
            this.lblLabelPrefix.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelPrefix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelPrefix.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLabelPrefix.Location = new System.Drawing.Point(47, 70);
            this.lblLabelPrefix.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelPrefix.Name = "lblLabelPrefix";
            this.lblLabelPrefix.Size = new System.Drawing.Size(30, 11);
            this.lblLabelPrefix.TabIndex = 38;
            this.lblLabelPrefix.Text = "12345";
            this.lblLabelPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelSerial
            // 
            this.lblLabelSerial.AutoSize = true;
            this.lblLabelSerial.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelSerial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelSerial.Location = new System.Drawing.Point(43, 119);
            this.lblLabelSerial.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelSerial.Name = "lblLabelSerial";
            this.lblLabelSerial.Size = new System.Drawing.Size(30, 11);
            this.lblLabelSerial.TabIndex = 0;
            this.lblLabelSerial.Text = "12345";
            this.lblLabelSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelMac
            // 
            this.lblLabelMac.AutoSize = true;
            this.lblLabelMac.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelMac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelMac.Location = new System.Drawing.Point(43, 102);
            this.lblLabelMac.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelMac.Name = "lblLabelMac";
            this.lblLabelMac.Size = new System.Drawing.Size(30, 11);
            this.lblLabelMac.TabIndex = 37;
            this.lblLabelMac.Text = "12345";
            this.lblLabelMac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelZwave
            // 
            this.lblLabelZwave.AutoSize = true;
            this.lblLabelZwave.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelZwave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelZwave.Location = new System.Drawing.Point(43, 85);
            this.lblLabelZwave.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelZwave.Name = "lblLabelZwave";
            this.lblLabelZwave.Size = new System.Drawing.Size(30, 11);
            this.lblLabelZwave.TabIndex = 36;
            this.lblLabelZwave.Text = "12345";
            this.lblLabelZwave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelModel
            // 
            this.lblLabelModel.AutoSize = true;
            this.lblLabelModel.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelModel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelModel.Location = new System.Drawing.Point(47, 55);
            this.lblLabelModel.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelModel.Name = "lblLabelModel";
            this.lblLabelModel.Size = new System.Drawing.Size(33, 11);
            this.lblLabelModel.TabIndex = 34;
            this.lblLabelModel.Text = "1AU18";
            this.lblLabelModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelYear
            // 
            this.lblLabelYear.AutoSize = true;
            this.lblLabelYear.BackColor = System.Drawing.Color.Transparent;
            this.lblLabelYear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelYear.Location = new System.Drawing.Point(156, 23);
            this.lblLabelYear.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelYear.Name = "lblLabelYear";
            this.lblLabelYear.Size = new System.Drawing.Size(25, 11);
            this.lblLabelYear.TabIndex = 33;
            this.lblLabelYear.Text = "2020";
            this.lblLabelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkSerialGenerate);
            this.panel3.Controls.Add(this.chkPrintLabel);
            this.panel3.Controls.Add(this.chkRegisterAsset);
            this.panel3.Controls.Add(this.chkClearFields);
            this.panel3.Location = new System.Drawing.Point(6, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // chkSerialGenerate
            // 
            this.chkSerialGenerate.AutoSize = true;
            this.chkSerialGenerate.Checked = true;
            this.chkSerialGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSerialGenerate.Location = new System.Drawing.Point(3, 3);
            this.chkSerialGenerate.Name = "chkSerialGenerate";
            this.chkSerialGenerate.Size = new System.Drawing.Size(155, 17);
            this.chkSerialGenerate.TabIndex = 0;
            this.chkSerialGenerate.Text = "Use MAC for Serial Number";
            this.chkSerialGenerate.UseVisualStyleBackColor = true;
            this.chkSerialGenerate.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkPrintLabel
            // 
            this.chkPrintLabel.AutoSize = true;
            this.chkPrintLabel.Checked = true;
            this.chkPrintLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintLabel.Location = new System.Drawing.Point(3, 26);
            this.chkPrintLabel.Name = "chkPrintLabel";
            this.chkPrintLabel.Size = new System.Drawing.Size(76, 17);
            this.chkPrintLabel.TabIndex = 1;
            this.chkPrintLabel.Text = "Print Label";
            this.chkPrintLabel.UseVisualStyleBackColor = true;
            // 
            // chkRegisterAsset
            // 
            this.chkRegisterAsset.AutoSize = true;
            this.chkRegisterAsset.Checked = true;
            this.chkRegisterAsset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRegisterAsset.Location = new System.Drawing.Point(3, 48);
            this.chkRegisterAsset.Name = "chkRegisterAsset";
            this.chkRegisterAsset.Size = new System.Drawing.Size(99, 17);
            this.chkRegisterAsset.TabIndex = 2;
            this.chkRegisterAsset.Text = "Register Assest";
            this.chkRegisterAsset.UseVisualStyleBackColor = true;
            // 
            // chkClearFields
            // 
            this.chkClearFields.AutoSize = true;
            this.chkClearFields.Location = new System.Drawing.Point(3, 71);
            this.chkClearFields.Name = "chkClearFields";
            this.chkClearFields.Size = new System.Drawing.Size(115, 17);
            this.chkClearFields.TabIndex = 3;
            this.chkClearFields.Text = "Clear Automatically";
            this.chkClearFields.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtImie);
            this.panel2.Controls.Add(this.txtMac);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtZwave);
            this.panel2.Controls.Add(this.txtSnPrefix);
            this.panel2.Controls.Add(this.txtSerial);
            this.panel2.Location = new System.Drawing.Point(6, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 123);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "IMIE";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(83, 57);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(398, 20);
            this.txtImie.TabIndex = 3;
            this.txtImie.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            this.txtImie.Enter += new System.EventHandler(this.txtImie_Enter);
            this.txtImie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(83, 5);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(398, 20);
            this.txtMac.TabIndex = 1;
            this.txtMac.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMac.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtMac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MAC Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zwave ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SN Prefix";
            // 
            // txtZwave
            // 
            this.txtZwave.Location = new System.Drawing.Point(83, 31);
            this.txtZwave.Name = "txtZwave";
            this.txtZwave.Size = new System.Drawing.Size(398, 20);
            this.txtZwave.TabIndex = 2;
            this.txtZwave.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtZwave.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtZwave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtSnPrefix
            // 
            this.txtSnPrefix.Location = new System.Drawing.Point(84, 83);
            this.txtSnPrefix.MaxLength = 6;
            this.txtSnPrefix.Name = "txtSnPrefix";
            this.txtSnPrefix.Size = new System.Drawing.Size(75, 20);
            this.txtSnPrefix.TabIndex = 4;
            this.txtSnPrefix.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtSnPrefix.Enter += new System.EventHandler(this.textBox3_Enter);
            this.txtSnPrefix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtSerial
            // 
            this.txtSerial.Enabled = false;
            this.txtSerial.Location = new System.Drawing.Point(241, 83);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(240, 20);
            this.txtSerial.TabIndex = 5;
            this.txtSerial.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtSerial.Enter += new System.EventHandler(this.textBox4_Enter);
            this.txtSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Print Lablel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(45, 11);
            this.txtModel.MaxLength = 20;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(155, 20);
            this.txtModel.TabIndex = 1;
            this.txtModel.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Model";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(254, 11);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(99, 20);
            this.txtYear.TabIndex = 2;
            this.txtYear.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Year";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 44);
            this.panel1.TabIndex = 0;
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SofiAsset Register V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtSnPrefix;
        private System.Windows.Forms.TextBox txtZwave;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRegisterAsset;
        private System.Windows.Forms.CheckBox chkPrintLabel;
        private System.Windows.Forms.CheckBox chkClearFields;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem printerSettingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkSerialGenerate;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLabelSerial;
        private System.Windows.Forms.Label lblLabelMac;
        private System.Windows.Forms.Label lblLabelZwave;
        private System.Windows.Forms.Label lblLabelModel;
        private System.Windows.Forms.Label lblLabelYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBatchFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label lblLabelPrefix;
    }
}

