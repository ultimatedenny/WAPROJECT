namespace DemoWhatsAppNETAPICSharp
{
    partial class FrmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGrabContacts = new System.Windows.Forms.Button();
            this.btnGrabGroupAndMembers = new System.Windows.Forms.Button();
            this.btnVerifyContact = new System.Windows.Forms.Button();
            this.btnUnreadMessages = new System.Windows.Forms.Button();
            this.btnAllMessages = new System.Windows.Forms.Button();
            this.btnArchiveChat = new System.Windows.Forms.Button();
            this.btnDeleteChat = new System.Windows.Forms.Button();
            this.btnWANumber = new System.Windows.Forms.Button();
            this.btnSetStatus = new System.Windows.Forms.Button();
            this.btnBatteryStatus = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.chkHeadless = new System.Windows.Forms.CheckBox();
            this.chkMultiDevice = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkKirimFileAja = new System.Windows.Forms.CheckBox();
            this.txtFileDokumen = new System.Windows.Forms.TextBox();
            this.btnCariDokumen = new System.Windows.Forms.Button();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.txtJumlahPesan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkKirimPesanDgGambar = new System.Windows.Forms.CheckBox();
            this.txtFileGambar = new System.Windows.Forms.TextBox();
            this.btnCariGambar = new System.Windows.Forms.Button();
            this.chkKirimGambarDariUrl = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.btnPilihGroup = new System.Windows.Forms.Button();
            this.chkKirimLokasi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkKirimPesanList = new System.Windows.Forms.CheckBox();
            this.chkKirimPesanButton = new System.Windows.Forms.CheckBox();
            this.chkKirimPesanButtonDgGambar = new System.Windows.Forms.CheckBox();
            this.txtFileLocalAtauUrl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLokasiPenyimpananFileAtauGambar = new System.Windows.Forms.Button();
            this.btnLokasiWAAutomateNodejs = new System.Windows.Forms.Button();
            this.txtLokasiPenyimpananFileAtauGambar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLokasiWhatsAppNETAPINodeJs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBatteryStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.chkAutoReplay = new System.Windows.Forms.CheckBox();
            this.lstPesanMasuk = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chkMessageSentSubscribe = new System.Windows.Forms.CheckBox();
            this.lstPesanKeluar = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chkMessageSentStatusSubscribe = new System.Windows.Forms.CheckBox();
            this.lstStatusPesanKeluar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKontak = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(6, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(6, 77);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGrabContacts
            // 
            this.btnGrabContacts.Enabled = false;
            this.btnGrabContacts.Location = new System.Drawing.Point(6, 106);
            this.btnGrabContacts.Name = "btnGrabContacts";
            this.btnGrabContacts.Size = new System.Drawing.Size(111, 23);
            this.btnGrabContacts.TabIndex = 3;
            this.btnGrabContacts.Text = "Contacts";
            this.btnGrabContacts.UseVisualStyleBackColor = true;
            this.btnGrabContacts.Click += new System.EventHandler(this.btnGrabContacts_Click);
            // 
            // btnGrabGroupAndMembers
            // 
            this.btnGrabGroupAndMembers.Enabled = false;
            this.btnGrabGroupAndMembers.Location = new System.Drawing.Point(123, 19);
            this.btnGrabGroupAndMembers.Name = "btnGrabGroupAndMembers";
            this.btnGrabGroupAndMembers.Size = new System.Drawing.Size(111, 23);
            this.btnGrabGroupAndMembers.TabIndex = 5;
            this.btnGrabGroupAndMembers.Text = "Group and members";
            this.btnGrabGroupAndMembers.UseVisualStyleBackColor = true;
            this.btnGrabGroupAndMembers.Click += new System.EventHandler(this.btnGrabGroupAndMembers_Click);
            // 
            // btnVerifyContact
            // 
            this.btnVerifyContact.Enabled = false;
            this.btnVerifyContact.Location = new System.Drawing.Point(123, 77);
            this.btnVerifyContact.Name = "btnVerifyContact";
            this.btnVerifyContact.Size = new System.Drawing.Size(111, 23);
            this.btnVerifyContact.TabIndex = 10;
            this.btnVerifyContact.Text = "Verify Contact";
            this.btnVerifyContact.UseVisualStyleBackColor = true;
            this.btnVerifyContact.Click += new System.EventHandler(this.btnVerifyContact_Click);
            // 
            // btnUnreadMessages
            // 
            this.btnUnreadMessages.Enabled = false;
            this.btnUnreadMessages.Location = new System.Drawing.Point(123, 48);
            this.btnUnreadMessages.Name = "btnUnreadMessages";
            this.btnUnreadMessages.Size = new System.Drawing.Size(111, 23);
            this.btnUnreadMessages.TabIndex = 4;
            this.btnUnreadMessages.Text = "Unread Messages";
            this.btnUnreadMessages.UseVisualStyleBackColor = true;
            this.btnUnreadMessages.Click += new System.EventHandler(this.btnUnreadMessages_Click);
            // 
            // btnAllMessages
            // 
            this.btnAllMessages.Enabled = false;
            this.btnAllMessages.Location = new System.Drawing.Point(6, 135);
            this.btnAllMessages.Name = "btnAllMessages";
            this.btnAllMessages.Size = new System.Drawing.Size(111, 23);
            this.btnAllMessages.TabIndex = 8;
            this.btnAllMessages.Text = "All Messages";
            this.btnAllMessages.UseVisualStyleBackColor = true;
            this.btnAllMessages.Click += new System.EventHandler(this.btnAllMessages_Click);
            // 
            // btnArchiveChat
            // 
            this.btnArchiveChat.Enabled = false;
            this.btnArchiveChat.Location = new System.Drawing.Point(6, 164);
            this.btnArchiveChat.Name = "btnArchiveChat";
            this.btnArchiveChat.Size = new System.Drawing.Size(111, 23);
            this.btnArchiveChat.TabIndex = 4;
            this.btnArchiveChat.Text = "Archive Chat";
            this.btnArchiveChat.UseVisualStyleBackColor = true;
            this.btnArchiveChat.Click += new System.EventHandler(this.btnArchiveChat_Click);
            // 
            // btnDeleteChat
            // 
            this.btnDeleteChat.Enabled = false;
            this.btnDeleteChat.Location = new System.Drawing.Point(6, 193);
            this.btnDeleteChat.Name = "btnDeleteChat";
            this.btnDeleteChat.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteChat.TabIndex = 4;
            this.btnDeleteChat.Text = "Delete Chat";
            this.btnDeleteChat.UseVisualStyleBackColor = true;
            this.btnDeleteChat.Click += new System.EventHandler(this.btnDeleteChat_Click);
            // 
            // btnWANumber
            // 
            this.btnWANumber.Enabled = false;
            this.btnWANumber.Location = new System.Drawing.Point(123, 135);
            this.btnWANumber.Name = "btnWANumber";
            this.btnWANumber.Size = new System.Drawing.Size(111, 23);
            this.btnWANumber.TabIndex = 7;
            this.btnWANumber.Text = "Info Wa Num";
            this.btnWANumber.UseVisualStyleBackColor = true;
            this.btnWANumber.Click += new System.EventHandler(this.btnInfoWANumber_Click);
            // 
            // btnSetStatus
            // 
            this.btnSetStatus.Enabled = false;
            this.btnSetStatus.Location = new System.Drawing.Point(123, 164);
            this.btnSetStatus.Name = "btnSetStatus";
            this.btnSetStatus.Size = new System.Drawing.Size(111, 23);
            this.btnSetStatus.TabIndex = 7;
            this.btnSetStatus.Text = "Set Status";
            this.btnSetStatus.UseVisualStyleBackColor = true;
            this.btnSetStatus.Click += new System.EventHandler(this.btnSetStatus_Click);
            // 
            // btnBatteryStatus
            // 
            this.btnBatteryStatus.Enabled = false;
            this.btnBatteryStatus.Location = new System.Drawing.Point(123, 106);
            this.btnBatteryStatus.Name = "btnBatteryStatus";
            this.btnBatteryStatus.Size = new System.Drawing.Size(111, 23);
            this.btnBatteryStatus.TabIndex = 9;
            this.btnBatteryStatus.Text = "Battery Status";
            this.btnBatteryStatus.UseVisualStyleBackColor = true;
            this.btnBatteryStatus.Click += new System.EventHandler(this.btnBatteryStatus_Click);
            // 
            // btnState
            // 
            this.btnState.Enabled = false;
            this.btnState.Location = new System.Drawing.Point(123, 193);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(111, 23);
            this.btnState.TabIndex = 11;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // chkHeadless
            // 
            this.chkHeadless.AutoSize = true;
            this.chkHeadless.Checked = true;
            this.chkHeadless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHeadless.Location = new System.Drawing.Point(6, 222);
            this.chkHeadless.Name = "chkHeadless";
            this.chkHeadless.Size = new System.Drawing.Size(70, 17);
            this.chkHeadless.TabIndex = 3;
            this.chkHeadless.Text = "Headless";
            this.chkHeadless.UseVisualStyleBackColor = true;
            // 
            // chkMultiDevice
            // 
            this.chkMultiDevice.AutoSize = true;
            this.chkMultiDevice.Location = new System.Drawing.Point(123, 222);
            this.chkMultiDevice.Name = "chkMultiDevice";
            this.chkMultiDevice.Size = new System.Drawing.Size(85, 17);
            this.chkMultiDevice.TabIndex = 3;
            this.chkMultiDevice.Text = "Multi Device";
            this.chkMultiDevice.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pesan";
            // 
            // chkKirimFileAja
            // 
            this.chkKirimFileAja.AutoSize = true;
            this.chkKirimFileAja.Location = new System.Drawing.Point(53, 155);
            this.chkKirimFileAja.Name = "chkKirimFileAja";
            this.chkKirimFileAja.Size = new System.Drawing.Size(95, 17);
            this.chkKirimFileAja.TabIndex = 0;
            this.chkKirimFileAja.Text = "Kirim dokumen";
            this.chkKirimFileAja.UseVisualStyleBackColor = true;
            this.chkKirimFileAja.CheckedChanged += new System.EventHandler(this.chkKirimFileAja_CheckedChanged);
            // 
            // txtFileDokumen
            // 
            this.txtFileDokumen.Location = new System.Drawing.Point(236, 158);
            this.txtFileDokumen.Name = "txtFileDokumen";
            this.txtFileDokumen.ReadOnly = true;
            this.txtFileDokumen.Size = new System.Drawing.Size(279, 20);
            this.txtFileDokumen.TabIndex = 1;
            // 
            // btnCariDokumen
            // 
            this.btnCariDokumen.Enabled = false;
            this.btnCariDokumen.Location = new System.Drawing.Point(521, 156);
            this.btnCariDokumen.Name = "btnCariDokumen";
            this.btnCariDokumen.Size = new System.Drawing.Size(34, 23);
            this.btnCariDokumen.TabIndex = 2;
            this.btnCariDokumen.Text = "...";
            this.btnCariDokumen.UseVisualStyleBackColor = true;
            this.btnCariDokumen.Click += new System.EventHandler(this.btnCariDokumen_Click);
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(53, 42);
            this.txtPesan.Multiline = true;
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(502, 58);
            this.txtPesan.TabIndex = 1;
            // 
            // btnKirim
            // 
            this.btnKirim.Enabled = false;
            this.btnKirim.Location = new System.Drawing.Point(415, 300);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(100, 23);
            this.btnKirim.TabIndex = 2;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // txtJumlahPesan
            // 
            this.txtJumlahPesan.Location = new System.Drawing.Point(236, 302);
            this.txtJumlahPesan.Name = "txtJumlahPesan";
            this.txtJumlahPesan.Size = new System.Drawing.Size(172, 20);
            this.txtJumlahPesan.TabIndex = 1;
            this.txtJumlahPesan.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Broadcast (jumlah Pesan)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkKirimPesanDgGambar
            // 
            this.chkKirimPesanDgGambar.AutoSize = true;
            this.chkKirimPesanDgGambar.Location = new System.Drawing.Point(53, 106);
            this.chkKirimPesanDgGambar.Name = "chkKirimPesanDgGambar";
            this.chkKirimPesanDgGambar.Size = new System.Drawing.Size(133, 17);
            this.chkKirimPesanDgGambar.TabIndex = 0;
            this.chkKirimPesanDgGambar.Text = "Kirim pesan dg gambar";
            this.chkKirimPesanDgGambar.UseVisualStyleBackColor = true;
            this.chkKirimPesanDgGambar.CheckedChanged += new System.EventHandler(this.chkKirimPesanDgGambar_CheckedChanged);
            // 
            // txtFileGambar
            // 
            this.txtFileGambar.Location = new System.Drawing.Point(236, 106);
            this.txtFileGambar.Name = "txtFileGambar";
            this.txtFileGambar.ReadOnly = true;
            this.txtFileGambar.Size = new System.Drawing.Size(279, 20);
            this.txtFileGambar.TabIndex = 1;
            // 
            // btnCariGambar
            // 
            this.btnCariGambar.Enabled = false;
            this.btnCariGambar.Location = new System.Drawing.Point(521, 106);
            this.btnCariGambar.Name = "btnCariGambar";
            this.btnCariGambar.Size = new System.Drawing.Size(34, 23);
            this.btnCariGambar.TabIndex = 2;
            this.btnCariGambar.Text = "...";
            this.btnCariGambar.UseVisualStyleBackColor = true;
            this.btnCariGambar.Click += new System.EventHandler(this.btnCariGambar_Click);
            // 
            // chkKirimGambarDariUrl
            // 
            this.chkKirimGambarDariUrl.AutoSize = true;
            this.chkKirimGambarDariUrl.Location = new System.Drawing.Point(53, 132);
            this.chkKirimGambarDariUrl.Name = "chkKirimGambarDariUrl";
            this.chkKirimGambarDariUrl.Size = new System.Drawing.Size(88, 17);
            this.chkKirimGambarDariUrl.TabIndex = 0;
            this.chkKirimGambarDariUrl.Text = "URL Gambar";
            this.chkKirimGambarDariUrl.UseVisualStyleBackColor = true;
            this.chkKirimGambarDariUrl.CheckedChanged += new System.EventHandler(this.chkKirimGambarDariUrl_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.Control;
            this.txtUrl.Location = new System.Drawing.Point(236, 132);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(279, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Enabled = false;
            this.chkGroup.Location = new System.Drawing.Point(422, 17);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(55, 17);
            this.chkGroup.TabIndex = 1;
            this.chkGroup.Text = "Group";
            this.chkGroup.UseVisualStyleBackColor = true;
            this.chkGroup.CheckedChanged += new System.EventHandler(this.chkGroup_CheckedChanged);
            // 
            // btnPilihGroup
            // 
            this.btnPilihGroup.Enabled = false;
            this.btnPilihGroup.Location = new System.Drawing.Point(483, 13);
            this.btnPilihGroup.Name = "btnPilihGroup";
            this.btnPilihGroup.Size = new System.Drawing.Size(75, 23);
            this.btnPilihGroup.TabIndex = 2;
            this.btnPilihGroup.Text = "Pilih Group";
            this.btnPilihGroup.UseVisualStyleBackColor = true;
            this.btnPilihGroup.Click += new System.EventHandler(this.btnPilihGroup_Click);
            // 
            // chkKirimLokasi
            // 
            this.chkKirimLokasi.AutoSize = true;
            this.chkKirimLokasi.Location = new System.Drawing.Point(53, 178);
            this.chkKirimLokasi.Name = "chkKirimLokasi";
            this.chkKirimLokasi.Size = new System.Drawing.Size(78, 17);
            this.chkKirimLokasi.TabIndex = 0;
            this.chkKirimLokasi.Text = "Kirim lokasi";
            this.chkKirimLokasi.UseVisualStyleBackColor = true;
            this.chkKirimLokasi.CheckedChanged += new System.EventHandler(this.chkKirimLokasi_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Latitude";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(236, 203);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(79, 20);
            this.txtLatitude.TabIndex = 2;
            this.txtLatitude.Text = "1.0725237";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Longitude";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(321, 203);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(79, 20);
            this.txtLongitude.TabIndex = 2;
            this.txtLongitude.Text = "104.0171031";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(406, 203);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(112, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Shimano Batam Manufacturing. PT";
            // 
            // chkKirimPesanList
            // 
            this.chkKirimPesanList.AutoSize = true;
            this.chkKirimPesanList.Location = new System.Drawing.Point(53, 229);
            this.chkKirimPesanList.Name = "chkKirimPesanList";
            this.chkKirimPesanList.Size = new System.Drawing.Size(95, 17);
            this.chkKirimPesanList.TabIndex = 7;
            this.chkKirimPesanList.Text = "Kirim pesan list";
            this.chkKirimPesanList.UseVisualStyleBackColor = true;
            this.chkKirimPesanList.CheckedChanged += new System.EventHandler(this.chkKirimPesanList_CheckedChanged);
            // 
            // chkKirimPesanButton
            // 
            this.chkKirimPesanButton.AutoSize = true;
            this.chkKirimPesanButton.Location = new System.Drawing.Point(53, 252);
            this.chkKirimPesanButton.Name = "chkKirimPesanButton";
            this.chkKirimPesanButton.Size = new System.Drawing.Size(61, 17);
            this.chkKirimPesanButton.TabIndex = 7;
            this.chkKirimPesanButton.Text = "Tombol";
            this.chkKirimPesanButton.UseVisualStyleBackColor = true;
            this.chkKirimPesanButton.CheckedChanged += new System.EventHandler(this.chkKirimPesanButton_CheckedChanged);
            // 
            // chkKirimPesanButtonDgGambar
            // 
            this.chkKirimPesanButtonDgGambar.AutoSize = true;
            this.chkKirimPesanButtonDgGambar.Location = new System.Drawing.Point(53, 275);
            this.chkKirimPesanButtonDgGambar.Name = "chkKirimPesanButtonDgGambar";
            this.chkKirimPesanButtonDgGambar.Size = new System.Drawing.Size(140, 17);
            this.chkKirimPesanButtonDgGambar.TabIndex = 7;
            this.chkKirimPesanButtonDgGambar.Text = "Tombol dengan Gambar";
            this.chkKirimPesanButtonDgGambar.UseVisualStyleBackColor = true;
            this.chkKirimPesanButtonDgGambar.CheckedChanged += new System.EventHandler(this.chkKirimPesanButtonDgGambar_CheckedChanged);
            // 
            // txtFileLocalAtauUrl
            // 
            this.txtFileLocalAtauUrl.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileLocalAtauUrl.Location = new System.Drawing.Point(236, 272);
            this.txtFileLocalAtauUrl.Name = "txtFileLocalAtauUrl";
            this.txtFileLocalAtauUrl.Size = new System.Drawing.Size(279, 20);
            this.txtFileLocalAtauUrl.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLokasiPenyimpananFileAtauGambar);
            this.groupBox2.Controls.Add(this.btnLokasiWAAutomateNodejs);
            this.groupBox2.Controls.Add(this.txtLokasiPenyimpananFileAtauGambar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLokasiWhatsAppNETAPINodeJs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pengaturan Signal R";
            // 
            // btnLokasiPenyimpananFileAtauGambar
            // 
            this.btnLokasiPenyimpananFileAtauGambar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLokasiPenyimpananFileAtauGambar.Location = new System.Drawing.Point(778, 40);
            this.btnLokasiPenyimpananFileAtauGambar.Name = "btnLokasiPenyimpananFileAtauGambar";
            this.btnLokasiPenyimpananFileAtauGambar.Size = new System.Drawing.Size(34, 23);
            this.btnLokasiPenyimpananFileAtauGambar.TabIndex = 2;
            this.btnLokasiPenyimpananFileAtauGambar.Text = "...";
            this.btnLokasiPenyimpananFileAtauGambar.UseVisualStyleBackColor = true;
            this.btnLokasiPenyimpananFileAtauGambar.Click += new System.EventHandler(this.btnLokasiPenyimpananFileAtauGambar_Click);
            // 
            // btnLokasiWAAutomateNodejs
            // 
            this.btnLokasiWAAutomateNodejs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLokasiWAAutomateNodejs.Location = new System.Drawing.Point(778, 15);
            this.btnLokasiWAAutomateNodejs.Name = "btnLokasiWAAutomateNodejs";
            this.btnLokasiWAAutomateNodejs.Size = new System.Drawing.Size(34, 23);
            this.btnLokasiWAAutomateNodejs.TabIndex = 2;
            this.btnLokasiWAAutomateNodejs.Text = "...";
            this.btnLokasiWAAutomateNodejs.UseVisualStyleBackColor = true;
            this.btnLokasiWAAutomateNodejs.Click += new System.EventHandler(this.btnLokasiWAAutomateNodejs_Click);
            // 
            // txtLokasiPenyimpananFileAtauGambar
            // 
            this.txtLokasiPenyimpananFileAtauGambar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLokasiPenyimpananFileAtauGambar.Location = new System.Drawing.Point(101, 43);
            this.txtLokasiPenyimpananFileAtauGambar.Name = "txtLokasiPenyimpananFileAtauGambar";
            this.txtLokasiPenyimpananFileAtauGambar.ReadOnly = true;
            this.txtLokasiPenyimpananFileAtauGambar.Size = new System.Drawing.Size(671, 20);
            this.txtLokasiPenyimpananFileAtauGambar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saved Dir Folder";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLokasiWhatsAppNETAPINodeJs
            // 
            this.txtLokasiWhatsAppNETAPINodeJs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLokasiWhatsAppNETAPINodeJs.Location = new System.Drawing.Point(101, 17);
            this.txtLokasiWhatsAppNETAPINodeJs.Name = "txtLokasiWhatsAppNETAPINodeJs";
            this.txtLokasiWhatsAppNETAPINodeJs.ReadOnly = true;
            this.txtLokasiWhatsAppNETAPINodeJs.Size = new System.Drawing.Size(671, 20);
            this.txtLokasiWhatsAppNETAPINodeJs.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Signal R";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkMultiDevice);
            this.groupBox3.Controls.Add(this.chkHeadless);
            this.groupBox3.Controls.Add(this.btnArchiveChat);
            this.groupBox3.Controls.Add(this.btnAllMessages);
            this.groupBox3.Controls.Add(this.btnUnreadMessages);
            this.groupBox3.Controls.Add(this.btnVerifyContact);
            this.groupBox3.Controls.Add(this.btnDeleteChat);
            this.groupBox3.Controls.Add(this.btnGrabGroupAndMembers);
            this.groupBox3.Controls.Add(this.btnState);
            this.groupBox3.Controls.Add(this.btnSetStatus);
            this.groupBox3.Controls.Add(this.btnWANumber);
            this.groupBox3.Controls.Add(this.btnGrabContacts);
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Controls.Add(this.btnBatteryStatus);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 246);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fungsi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblState,
            this.lblBatteryStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1204, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 17);
            this.lblState.Text = "lblState";
            // 
            // lblBatteryStatus
            // 
            this.lblBatteryStatus.Name = "lblBatteryStatus";
            this.lblBatteryStatus.Size = new System.Drawing.Size(89, 17);
            this.lblBatteryStatus.Text = "lblBatteryStatus";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 480);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 231);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesan Masuk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lstPesanMasuk, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(805, 199);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chkSubscribe);
            this.flowLayoutPanel3.Controls.Add(this.chkAutoReplay);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(799, 20);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Enabled = false;
            this.chkSubscribe.Location = new System.Drawing.Point(3, 3);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(73, 17);
            this.chkSubscribe.TabIndex = 0;
            this.chkSubscribe.Text = "Subscribe";
            this.chkSubscribe.UseVisualStyleBackColor = true;
            this.chkSubscribe.CheckedChanged += new System.EventHandler(this.chkSubscribe_CheckedChanged);
            // 
            // chkAutoReplay
            // 
            this.chkAutoReplay.AutoSize = true;
            this.chkAutoReplay.Enabled = false;
            this.chkAutoReplay.Location = new System.Drawing.Point(82, 3);
            this.chkAutoReplay.Name = "chkAutoReplay";
            this.chkAutoReplay.Size = new System.Drawing.Size(84, 17);
            this.chkAutoReplay.TabIndex = 1;
            this.chkAutoReplay.Text = "Auto Replay";
            this.chkAutoReplay.UseVisualStyleBackColor = true;
            // 
            // lstPesanMasuk
            // 
            this.lstPesanMasuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPesanMasuk.FormattingEnabled = true;
            this.lstPesanMasuk.Location = new System.Drawing.Point(3, 29);
            this.lstPesanMasuk.Name = "lstPesanMasuk";
            this.lstPesanMasuk.Size = new System.Drawing.Size(799, 167);
            this.lstPesanMasuk.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesan Keluar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chkMessageSentSubscribe, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lstPesanKeluar, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(805, 199);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // chkMessageSentSubscribe
            // 
            this.chkMessageSentSubscribe.AutoSize = true;
            this.chkMessageSentSubscribe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMessageSentSubscribe.Enabled = false;
            this.chkMessageSentSubscribe.Location = new System.Drawing.Point(3, 3);
            this.chkMessageSentSubscribe.Name = "chkMessageSentSubscribe";
            this.chkMessageSentSubscribe.Size = new System.Drawing.Size(799, 20);
            this.chkMessageSentSubscribe.TabIndex = 0;
            this.chkMessageSentSubscribe.Text = "Subscribe";
            this.chkMessageSentSubscribe.UseVisualStyleBackColor = true;
            this.chkMessageSentSubscribe.CheckedChanged += new System.EventHandler(this.chkMessageSentSubscribe_CheckedChanged);
            // 
            // lstPesanKeluar
            // 
            this.lstPesanKeluar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPesanKeluar.FormattingEnabled = true;
            this.lstPesanKeluar.Location = new System.Drawing.Point(3, 29);
            this.lstPesanKeluar.Name = "lstPesanKeluar";
            this.lstPesanKeluar.Size = new System.Drawing.Size(799, 167);
            this.lstPesanKeluar.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(811, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Status Pesan Keluar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chkMessageSentStatusSubscribe, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lstStatusPesanKeluar, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(811, 205);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // chkMessageSentStatusSubscribe
            // 
            this.chkMessageSentStatusSubscribe.AutoSize = true;
            this.chkMessageSentStatusSubscribe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMessageSentStatusSubscribe.Enabled = false;
            this.chkMessageSentStatusSubscribe.Location = new System.Drawing.Point(3, 3);
            this.chkMessageSentStatusSubscribe.Name = "chkMessageSentStatusSubscribe";
            this.chkMessageSentStatusSubscribe.Size = new System.Drawing.Size(805, 20);
            this.chkMessageSentStatusSubscribe.TabIndex = 0;
            this.chkMessageSentStatusSubscribe.Text = "Subscribe";
            this.chkMessageSentStatusSubscribe.UseVisualStyleBackColor = true;
            this.chkMessageSentStatusSubscribe.CheckedChanged += new System.EventHandler(this.chkMessageSentStatusSubscribe_CheckedChanged);
            // 
            // lstStatusPesanKeluar
            // 
            this.lstStatusPesanKeluar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStatusPesanKeluar.FormattingEnabled = true;
            this.lstStatusPesanKeluar.Location = new System.Drawing.Point(3, 29);
            this.lstStatusPesanKeluar.Name = "lstStatusPesanKeluar";
            this.lstStatusPesanKeluar.Size = new System.Drawing.Size(805, 173);
            this.lstStatusPesanKeluar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontak";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKontak
            // 
            this.txtKontak.Location = new System.Drawing.Point(53, 16);
            this.txtKontak.Name = "txtKontak";
            this.txtKontak.Size = new System.Drawing.Size(363, 20);
            this.txtKontak.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKirim);
            this.groupBox1.Controls.Add(this.btnCariDokumen);
            this.groupBox1.Controls.Add(this.txtJumlahPesan);
            this.groupBox1.Controls.Add(this.txtFileLocalAtauUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKontak);
            this.groupBox1.Controls.Add(this.txtFileDokumen);
            this.groupBox1.Controls.Add(this.chkKirimPesanButtonDgGambar);
            this.groupBox1.Controls.Add(this.chkGroup);
            this.groupBox1.Controls.Add(this.txtFileGambar);
            this.groupBox1.Controls.Add(this.chkKirimPesanButton);
            this.groupBox1.Controls.Add(this.btnCariGambar);
            this.groupBox1.Controls.Add(this.chkKirimPesanList);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnPilihGroup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLongitude);
            this.groupBox1.Controls.Add(this.txtLatitude);
            this.groupBox1.Controls.Add(this.txtPesan);
            this.groupBox1.Controls.Add(this.chkKirimPesanDgGambar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkKirimGambarDariUrl);
            this.groupBox1.Controls.Add(this.chkKirimLokasi);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.chkKirimFileAja);
            this.groupBox1.Location = new System.Drawing.Point(266, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 387);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pengaturan Pesan";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(1092, 23);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 23);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(837, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(355, 655);
            this.dataGridView1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(837, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 736);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(858, 775);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-RECRUITMENT 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.TextBox txtJumlahPesan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkKirimPesanDgGambar;
        private System.Windows.Forms.TextBox txtFileGambar;
        private System.Windows.Forms.Button btnCariGambar;
        private System.Windows.Forms.CheckBox chkKirimFileAja;
        private System.Windows.Forms.TextBox txtFileDokumen;
        private System.Windows.Forms.Button btnCariDokumen;
        private System.Windows.Forms.Button btnGrabContacts;
        private System.Windows.Forms.Button btnUnreadMessages;
        private System.Windows.Forms.Button btnArchiveChat;
        private System.Windows.Forms.Button btnDeleteChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLokasiWhatsAppNETAPINodeJs;
        private System.Windows.Forms.Button btnLokasiWAAutomateNodejs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLokasiPenyimpananFileAtauGambar;
        private System.Windows.Forms.TextBox txtLokasiPenyimpananFileAtauGambar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGrabGroupAndMembers;
        private System.Windows.Forms.CheckBox chkKirimGambarDariUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.Button btnPilihGroup;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.CheckBox chkKirimLokasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkKirimPesanList;
        private System.Windows.Forms.CheckBox chkKirimPesanButton;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.Button btnWANumber;
        private System.Windows.Forms.Button btnAllMessages;
        private System.Windows.Forms.Button btnBatteryStatus;
        private System.Windows.Forms.Button btnVerifyContact;
        private System.Windows.Forms.CheckBox chkKirimPesanButtonDgGambar;
        private System.Windows.Forms.TextBox txtFileLocalAtauUrl;
        private System.Windows.Forms.CheckBox chkHeadless;
        private System.Windows.Forms.CheckBox chkMultiDevice;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.ToolStripStatusLabel lblBatteryStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkSubscribe;
        private System.Windows.Forms.CheckBox chkAutoReplay;
        private System.Windows.Forms.ListBox lstPesanMasuk;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox chkMessageSentSubscribe;
        private System.Windows.Forms.ListBox lstPesanKeluar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox chkMessageSentStatusSubscribe;
        private System.Windows.Forms.ListBox lstStatusPesanKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKontak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}

