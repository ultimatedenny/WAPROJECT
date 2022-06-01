﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

using WhatsAppNETAPI;
using ConceptCave.WaitCursor;
using System.IO;
using System.Data;
using ExcelDataReader;
using System.Threading;
using System.Threading.Tasks;

namespace DemoWhatsAppNETAPICSharp
{
    public partial class FrmMain : Form
    {
        private IWhatsAppNETAPI _wa;
        private Group _selectedGroup;
        DataTableCollection tableCollection;

        public FrmMain()
        {
            InitializeComponent();            
            _wa = new WhatsAppNETAPI.WhatsAppNETAPI();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLokasiWhatsAppNETAPINodeJs.Text))
            {
                MessageBox.Show("Maaf, lokasi folder 'WhatsApp NET API NodeJs'  belum di set", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLokasiWhatsAppNETAPINodeJs.Focus();
                return;
            }

            _wa.WaNetApiNodeJsPath = txtLokasiWhatsAppNETAPINodeJs.Text;

            // TODO: aktifkan kode ini agar bisa mengirimkan file dalam format video
            // lokasi file chrome.exe menyesuaikan
            // _wa.ChromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            if (!_wa.IsWaNetApiNodeJsPathExists)
            {
                MessageBox.Show("Maaf, lokasi folder 'WhatsApp NET API NodeJs' tidak ditemukan !!!", "Peringatan", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLokasiWhatsAppNETAPINodeJs.Focus();
                return;
            }

            _wa.IsMultiDevice = chkMultiDevice.Checked;
            _wa.Headless = chkHeadless.Checked;

            Connect();            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var msg = "Fungsi ini akan MENGHAPUS sesi koneksi ke Whatsapp Web.\n" +
                      "Jadi Anda harus melakukan scan ulang qrcode.\n\n" +
                      "Apakah ingin dilanjutkan";

            if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Disconnect(true);
            }
        }

        private void Connect()
        {
            this.UseWaitCursor = true;

            _wa.ImageAndDocumentPath = txtLokasiPenyimpananFileAtauGambar.Text;

            // subscribe event
            _wa.OnStartup += OnStartupHandler;
            _wa.OnChangeState += OnChangeStateHandler;

            if (!_wa.IsMultiDevice)
                _wa.OnChangeBattery += OnChangeBatteryHandler;

            _wa.OnReceiveMessages += OnReceiveMessagesHandler;
            _wa.OnGroupJoin += OnGroupJoinHandler;
            _wa.OnGroupLeave += OnGroupLeaveHandler;
            _wa.OnClientConnected += OnClientConnectedHandler;
            _wa.OnMonitoringLog += OnMonitoringLogHandler;
            _wa.Connect();

            using (var frm = new FrmStartUp())
            {
                // subscribe event
                _wa.OnStartup += frm.OnStartupHandler;
                _wa.OnScanMe += frm.OnScanMeHandler;

                frm.UseWaitCursor = true;
                frm.ShowDialog();

                // unsubscribe event
                _wa.OnStartup -= frm.OnStartupHandler;
                _wa.OnScanMe -= frm.OnScanMeHandler;
            }
        }        

        private void OnMessageAckHandler(WhatsAppNETAPI.Message message, string sessionId)
        {
            var msg = string.Format("Status pengiriman pesan ke {0}, messageId = {1}, status = {2}",
                message.to, message.id, message.ack.ToString());
            
            // update UI dari thread yang berbeda
            lstStatusPesanKeluar.Invoke(() =>
            {
                lstStatusPesanKeluar.Items.Add(msg);
                lstStatusPesanKeluar.SelectedIndex = lstStatusPesanKeluar.Items.Count - 1;
            });
        }

        private void OnGroupJoinHandler(GroupNotification notification, string sessionId)
        {
            var recipients = string.Join(", ", notification.recipients
                .Select(f => f.name)
                .ToArray());

            var msgReplay = string.Format("Selamat bergabung Bpk/Ibu *{0}*, di group *{1}*.",
                        recipients, notification.name);

            var msgArgs = new MsgArgs(notification.id, msgReplay, MsgArgsType.Text);
            _wa.SendMessage(msgArgs);
        }

        private void OnGroupLeaveHandler(GroupNotification notification, string sessionId)
        {
            var recipients = string.Join(", ", notification.recipients
                .Select(f => f.name)
                .ToArray());

            var msgReplay = string.Format("Selamat berpisah Bpk/Ibu *{0}*, semoga bisa join lagi di group *{1}*.",
                        recipients, notification.name);

            var msgArgs = new MsgArgs(notification.id, msgReplay, MsgArgsType.Text);
            _wa.SendMessage(msgArgs);
        }

        private void Disconnect(bool isLogout = false)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnLogout.Enabled = false;
            btnGrabContacts.Enabled = false;
            btnVerifyContact.Enabled = false;
            btnGrabGroupAndMembers.Enabled = false;
            btnUnreadMessages.Enabled = false;
            btnAllMessages.Enabled = false;
            btnWANumber.Enabled = false;
            btnSetStatus.Enabled = false;
            btnBatteryStatus.Enabled = false;
            btnState.Enabled = false;
            btnArchiveChat.Enabled = false;
            btnDeleteChat.Enabled = false;
            btnKirim.Enabled = false;

            chkGroup.Checked = false;
            chkGroup.Enabled = false;

            txtFileDokumen.Clear();
            txtFileGambar.Clear();

            chkSubscribe.Checked = false;
            chkSubscribe.Enabled = false;

            chkMessageSentSubscribe.Checked = false;
            chkMessageSentSubscribe.Enabled = false;

            chkMessageSentStatusSubscribe.Checked = false;
            chkMessageSentStatusSubscribe.Enabled = false;

            chkAutoReplay.Checked = false;
            chkAutoReplay.Enabled = false;

            lstPesanMasuk.Items.Clear();

            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                // unsubscribe event
                _wa.OnStartup -= OnStartupHandler;
                _wa.OnChangeState -= OnChangeStateHandler;

                if (!_wa.IsMultiDevice)
                    _wa.OnChangeBattery -= OnChangeBatteryHandler;

                _wa.OnScanMe -= OnScanMeHandler;
                _wa.OnReceiveMessage -= OnReceiveMessageHandler;
                _wa.OnReceiveMessages -= OnReceiveMessagesHandler;
                _wa.OnMessageAck -= OnMessageAckHandler;
                _wa.OnReceiveMessageStatus -= OnReceiveMessageStatusHandler;
                _wa.OnGroupJoin -= OnGroupJoinHandler;
                _wa.OnGroupLeave -= OnGroupLeaveHandler;
                _wa.OnClientConnected -= OnClientConnectedHandler;
                _wa.OnMonitoringLog -= OnMonitoringLogHandler;

                if (isLogout)
                    _wa.Logout();
                else
                    _wa.Disconnect();
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            var jumlahPesan = int.Parse(txtJumlahPesan.Text);

            if (jumlahPesan > 1) // broadcast
            {
                var list = new List<MsgArgs>();

                var kontak = string.Empty;

                if (chkGroup.Checked)
                {
                    if (_selectedGroup != null)
                        kontak = _selectedGroup.id;
                    else
                        MessageBox.Show("Maaf, group belum dipilih", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    kontak = txtKontak.Text;

                for (int i = 0; i < jumlahPesan; i++)
                {
                    MsgArgs msgArgs = null;

                    if (chkKirimPesanDgGambar.Checked)
                        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Image, txtFileGambar.Text);
                    else if (chkKirimGambarDariUrl.Checked)
                        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Url, txtUrl.Text);
                    else if (chkKirimFileAja.Checked)
                        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.File, txtFileDokumen.Text);
                    else if (chkKirimLokasi.Checked)
                    {
                        var location = new Location
                        {
                            latitude = txtLatitude.Text,
                            longitude = txtLongitude.Text,
                            description = txtDescription.Text
                        };

                        msgArgs = new MsgArgs(kontak, location);
                    }
                    else
                        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Text);

                    list.Add(msgArgs);
                }

                _wa.BroadcastMessage(list);
            }
            else
            {
                MsgArgs msgArgs = null;
                var kontak = string.Empty;
                if (chkGroup.Checked)
                {
                    if (_selectedGroup != null) { kontak = _selectedGroup.id; }
                    else { MessageBox.Show("Maaf, group belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else
                    kontak = txtKontak.Text;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    msgArgs = new MsgArgs(row.Cells["NO"].Value.ToString(), txtPesan.Text, MsgArgsType.Image, txtFileGambar.Text);
                    Task.Delay(1000).Wait();
                    _wa.SendMessage(msgArgs);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var location = new Location
                    {
                        latitude = txtLatitude.Text,
                        longitude = txtLongitude.Text,
                        description = txtDescription.Text
                    };
                    Task.Delay(1000).Wait();
                    msgArgs = new MsgArgs(row.Cells["NO"].Value.ToString(), location);
                    _wa.SendMessage(msgArgs);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var button = new WhatsAppNETAPI.Button();
                    button.title = "Survey Shimano";
                    button.content = "Harap berikan respon terhadap sistem E-Recruitment Shimano";
                    button.items = new ButtonItem[]
                    {
                            new ButtonItem { id = "btn_1", title = "Baik" },
                            new ButtonItem { id = "btn_2", title = "Sangat Baik" }
                    };
                    Task.Delay(1000).Wait();
                    msgArgs = new MsgArgs(row.Cells["NO"].Value.ToString(), button);
                    _wa.SendMessage(msgArgs);
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var list = new WhatsAppNETAPI.List
                    {
                        title = "E-APPROVAL FROM WHATSAPP",
                        listText = "CHOOSE ACTION",
                        content = "You have pending exitpermit for *DENI ANDREAN* [EP-220101-001]\nPlease choose an action."
                    };

                    var section = new Section
                    {
                        title = "Daftar Menu",
                        items = new ListItem[]
                        {
                                new ListItem { id = "0", title = "PILIHAN 0", description = "Deskripsi pilihan 0" },
                                new ListItem { id = "1", title = "PILIHAN 1", description = "Deskripsi pilihan 1" },
                                new ListItem { id = "2", title = "PILIHAN 2", description = "Deskripsi pilihan 2" }
                        }
                    };

                    list.sections = new Section[] { section };
                    msgArgs = new MsgArgs(row.Cells["NO"].Value.ToString(), list);
                    _wa.SendMessage(msgArgs);
                }

                //for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                //{
                //    label9.Text = (i + 1).ToString();
                //    Task.Delay(1000).Wait();
                //    if (chkKirimPesanDgGambar.Checked)
                //    {
                //        msgArgs = new MsgArgs(dataGridView1.Rows[i].Cells[0].Value.ToString(), txtPesan.Text, MsgArgsType.Image, txtFileGambar.Text);
                //    }
                //    else if (chkKirimGambarDariUrl.Checked)
                //    {
                //        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Url, txtUrl.Text);
                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Url, txtUrl.Text, mentions);
                //    }
                //    else if (chkKirimFileAja.Checked)
                //    {
                //        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.File, txtFileDokumen.Text);

                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.File, txtFileDokumen.Text, mentions);
                //    }
                //    else if (chkKirimLokasi.Checked)
                //    {
                //        var location = new Location
                //        {
                //            latitude = txtLatitude.Text,
                //            longitude = txtLongitude.Text,
                //            description = txtDescription.Text
                //        };

                //        msgArgs = new MsgArgs(kontak, location);

                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, location, mentions);
                //    }
                //    else if (chkKirimPesanList.Checked)
                //    {
                //        var list = new WhatsAppNETAPI.List
                //        {
                //            title = "Menu",
                //            listText = "Pilih Menu",
                //            content = "Assalamualaikum warahmatullahi wabarakatuh\nSelamat datang, silahkan pilih menu yang tersedia."
                //        };

                //        var section = new Section
                //        {
                //            title = "Daftar Menu",
                //            items = new ListItem[]
                //            {
                //            new ListItem { id = "zakat", title = "Berzakat", description = "Zakal maal, zakat fitrah, dll" },
                //            new ListItem { id = "infak", title = "Berinfak", description = "Infak pendidikan, infak kesehatan, dll" },
                //            new ListItem { id = "bantuan", title = "Bantuan", description = "Klo masih bingung" }
                //            }
                //        };

                //        list.sections = new Section[] { section };

                //        msgArgs = new MsgArgs(kontak, list);

                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, list, mentions);
                //    }
                //    else if (chkKirimPesanButton.Checked)
                //    {
                //        var button = new WhatsAppNETAPI.Button();
                //        button.title = "Menu";
                //        button.content = "Assalamualaikum warahmatullahi wabarakatuh\nSelamat datang, silahkan klik tombol yang tersedia.";
                //        button.items = new ButtonItem[]
                //        {
                //        new ButtonItem { id = "btn_1", title = "Tombol 1" },
                //        new ButtonItem { id = "btn_2", title = "Tombol 2" }
                //        };
                //        msgArgs = new MsgArgs(kontak, button);
                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, button, mentions);
                //    }
                //    else if (chkKirimPesanButtonDgGambar.Checked)
                //    {
                //        var button = new WhatsAppNETAPI.Button();
                //        button.content = "*Assalamualaikum warahmatullahi wabarakatuh* \nSelamat datang, silahkan klik tombol yang tersedia.";

                //        button.items = new ButtonItem[]
                //        {
                //        new ButtonItem { id = "btn_1", title = "Tombol 1" },
                //        new ButtonItem { id = "btn_2", title = "Tombol 2" }
                //        };

                //        msgArgs = new MsgArgs(kontak, button, txtFileLocalAtauUrl.Text);

                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, button, txtFileLocalAtauUrl.Text, mentions);
                //    }
                //    else
                //    {
                //        msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Text);
                //        // contoh penggunaan mention user
                //        // var mentions = new string[] { "081381712345", "08138174444", "tambahkan nomor yang lain" };
                //        // msgArgs = new MsgArgs(kontak, txtPesan.Text, MsgArgsType.Text, mentions);
                //    }
                //    _wa.SendMessage(msgArgs);
                //    Task.Delay(1000).Wait();
                //    label9.Text = (i + 1).ToString();
                //}
            }
        }

        private void chkSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubscribe.Checked)
                _wa.OnReceiveMessage += OnReceiveMessageHandler; // subscribe event
            else
            {
                _wa.OnReceiveMessage -= OnReceiveMessageHandler; // unsubscribe event
                lstPesanMasuk.Items.Clear();
            }

            chkAutoReplay.Enabled = chkSubscribe.Checked;
        }

        private void btnCariGambar_Click(object sender, EventArgs e)
        {            
            var fileName = Helper.ShowDialogOpen("Lokasi file gambar", true);
            if (!string.IsNullOrEmpty(fileName)) txtFileGambar.Text = fileName;
        }

        private void btnCariDokumen_Click(object sender, EventArgs e)
        {
            var fileName = Helper.ShowDialogOpen("Lokasi file dokumen");
            if (!string.IsNullOrEmpty(fileName)) txtFileDokumen.Text = fileName;
        }        

        private void chkKirimPesanDgGambar_CheckedChanged(object sender, EventArgs e)
        {
            btnCariGambar.Enabled = chkKirimPesanDgGambar.Checked;
            if (chkKirimPesanDgGambar.Checked)
            {
                chkKirimFileAja.Checked = false;
                chkKirimGambarDariUrl.Checked = false;
                chkKirimLokasi.Checked = false;
                chkKirimPesanList.Checked = false;
                chkKirimPesanButton.Checked = false;
                chkKirimPesanButtonDgGambar.Checked = false;

                txtFileDokumen.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
            else
                txtFileGambar.Clear();
        }

        private void chkKirimGambarDariUrl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKirimGambarDariUrl.Checked)
            {
                chkKirimPesanDgGambar.Checked = false;
                chkKirimFileAja.Checked = false;
                chkKirimLokasi.Checked = false;
                chkKirimPesanList.Checked = false;
                chkKirimPesanButton.Checked = false;
                chkKirimPesanButtonDgGambar.Checked = false;

                txtFileGambar.Clear();
                txtFileDokumen.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }            
        }

        private void chkKirimFileAja_CheckedChanged(object sender, EventArgs e)
        {
            btnCariDokumen.Enabled = chkKirimFileAja.Checked;

            if (chkKirimFileAja.Checked)
            {
                chkKirimPesanDgGambar.Checked = false;
                chkKirimGambarDariUrl.Checked = false;
                chkKirimLokasi.Checked = false;
                chkKirimPesanList.Checked = false;
                chkKirimPesanButton.Checked = false;
                chkKirimPesanButtonDgGambar.Checked = false;

                txtFileGambar.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
            else
                txtFileDokumen.Clear();
        }

        private void chkKirimLokasi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKirimLokasi.Checked)
            {
                if (_wa.IsMultiDevice)
                {
                    MessageBox.Show("Maaf fitur pesan dengan tipe location belum support untuk multi device", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKirimLokasi.Checked = false;
                    return;
                }

                chkKirimPesanDgGambar.Checked = false;
                chkKirimGambarDariUrl.Checked = false;
                chkKirimFileAja.Checked = false;
                chkKirimPesanList.Checked = false;
                chkKirimPesanButton.Checked = false;
                chkKirimPesanButtonDgGambar.Checked = false;

                txtFileGambar.Clear();
                txtFileDokumen.Clear();

                txtLatitude.Enabled = true;
                txtLongitude.Enabled = true;
                txtDescription.Enabled = true;
            }
        }

        private void btnGrabContacts_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmContactOrGroup("Contacts"))
            {                
                _wa.OnReceiveContacts += frm.OnReceiveContactsHandler; // subscribe event
                _wa.GetContacts();

                frm.ShowDialog();
                _wa.OnReceiveContacts -= frm.OnReceiveContactsHandler; // unsubscribe event
            }        
        }

        private void btnVerifyContact_Click(object sender, EventArgs e)
        {
            // daftar kontak yang mau di verifikasi
            // bisa diambil dari database atau hasil generatean
            //var contacts = new List<string> { "081381712345", "089652948305",
            //    "085211112345", "081381712345", "085291123456", "081336123456" };

            var contacts = new List<string> { "085729000729", "08122749662",
                "081215358389", "082134921090", "081327190092" };

            using (var frm = new FrmContactOrGroup("Contacts"))
            {
                _wa.OnReceiveContacts += frm.OnReceiveContactsHandler; // subscribe event
                _wa.VerifyWANumber(contacts, true);

                frm.ShowDialog();
                _wa.OnReceiveContacts -= frm.OnReceiveContactsHandler; // unsubscribe event
            }
        }

        private void btnGrabGroupAndMembers_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmContactOrGroup("Groups and Members"))
            {
                _wa.OnReceiveGroups += frm.OnReceiveGroupsHandler; // subscribe event
                _wa.GetGroups();

                frm.ShowDialog();
                _wa.OnReceiveGroups -= frm.OnReceiveGroupsHandler; // unsubscribe event
            }
        }

        private void chkMessageSentSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMessageSentSubscribe.Checked)
            {
                _wa.OnReceiveMessageStatus += OnReceiveMessageStatusHandler; // subscribe event
            }
            else
            {
                _wa.OnReceiveMessageStatus -= OnReceiveMessageStatusHandler; // unsubscribe event
                lstPesanKeluar.Items.Clear();
            }
        }

        private void btnDeleteChat_Click(object sender, EventArgs e)
        {
            var msg = "Fungsi ini akan MENGHAPUS semua pesan.\n" +
                      "Apakah ingin dilanjutkan";

            if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _wa.DeleteChat(); // hapus semua chat

                // contoh jika ingin menghapus berdasarkan phoneNumber
                // var phoneNumber = "0813123456789";
                // _wa.DeleteChat(phoneNumber);
            }
        }

        private void btnArchiveChat_Click(object sender, EventArgs e)
        {
            var msg = "Fungsi ini akan MENGARSIPKAN semua pesan.\n" +
                      "Apakah ingin dilanjutkan";

            if (MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _wa.ArchiveChat(); // arsip semua chat

                // contoh jika ingin mengarsipkan berdasarkan phoneNumber
                // var phoneNumber = "0813123456789";
                // _wa.ArchiveChat(phoneNumber);
            }
        }

        private void btnUnreadMessages_Click(object sender, EventArgs e)
        {
            _wa.GetUnreadMessage();                        
        }

        private void btnAllMessages_Click(object sender, EventArgs e)
        {
            var phoneNumber = "08138171234";
            _wa.GetAllMessage(phoneNumber, 3); // menampilkan 3 pesan terakhir            
        }
        
        # region event handler

        private void OnStartupHandler(string message, string sessionId)
        {
            // koneksi ke WA berhasil
            if (message.IndexOf("Ready") >= 0)
            {
                btnStart.Invoke(new MethodInvoker(() => btnStart.Enabled = false));

                btnStop.Invoke(new MethodInvoker(() => btnStop.Enabled = true));
                btnLogout.Invoke(new MethodInvoker(() => btnLogout.Enabled = true));

                btnGrabContacts.Invoke(new MethodInvoker(() => btnGrabContacts.Enabled = true));
                btnGrabGroupAndMembers.Invoke(new MethodInvoker(() => btnGrabGroupAndMembers.Enabled = true));
                btnVerifyContact.Invoke(new MethodInvoker(() => btnVerifyContact.Enabled = true));

                btnUnreadMessages.Invoke(new MethodInvoker(() => btnUnreadMessages.Enabled = true));
                btnAllMessages.Invoke(new MethodInvoker(() => btnAllMessages.Enabled = true));
                btnArchiveChat.Invoke(new MethodInvoker(() => btnArchiveChat.Enabled = true));
                btnDeleteChat.Invoke(new MethodInvoker(() => btnDeleteChat.Enabled = true));

                btnWANumber.Invoke(new MethodInvoker(() => btnWANumber.Enabled = true));
                btnSetStatus.Invoke(new MethodInvoker(() => btnSetStatus.Enabled = true));
                btnBatteryStatus.Invoke(new MethodInvoker(() => btnBatteryStatus.Enabled = true));
                btnState.Invoke(new MethodInvoker(() => btnState.Enabled = true));

                chkGroup.Invoke(new MethodInvoker(() => chkGroup.Enabled = true));
                btnKirim.Invoke(new MethodInvoker(() => btnKirim.Enabled = true));
                chkSubscribe.Invoke(new MethodInvoker(() => chkSubscribe.Enabled = true));
                chkMessageSentSubscribe.Invoke(new MethodInvoker(() => chkMessageSentSubscribe.Enabled = true));
                chkMessageSentStatusSubscribe.Invoke(new MethodInvoker(() => chkMessageSentStatusSubscribe.Enabled = true));                

                this.UseWaitCursor = false;
            }

            // koneksi ke WA GAGAL, bisa dicoba lagi
            if (message.IndexOf("Failure") >= 0 || message.IndexOf("Timeout") >= 0
                || message.IndexOf("ERR_NAME") >= 0 || message.IndexOf("ERR_CONNECTION") >= 0)
            {
                // unsubscribe event
                _wa.OnStartup -= OnStartupHandler;
                _wa.OnScanMe -= OnScanMeHandler;
                _wa.OnReceiveMessage -= OnReceiveMessageHandler;
                _wa.OnReceiveMessages -= OnReceiveMessagesHandler;
                _wa.OnMessageAck -= OnMessageAckHandler;
                _wa.OnReceiveMessageStatus -= OnReceiveMessageStatusHandler;
                _wa.OnGroupJoin -= OnGroupJoinHandler;
                _wa.OnGroupLeave -= OnGroupLeaveHandler;
                _wa.OnClientConnected -= OnClientConnectedHandler;
                _wa.OnMonitoringLog -= OnMonitoringLogHandler;

                _wa.Disconnect();

                this.UseWaitCursor = false;

                var msg = string.Format("{0}\n\nKoneksi ke WA gagal, silahkan cek koneksi internet Anda", message);
                MessageBox.Show(msg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnChangeStateHandler(WhatsAppNETAPI.WAState state, string sessionId)
        {
            lblState.Text = string.Format("State: {0}", state.ToString());
        }

        private void OnChangeBatteryHandler(BatteryStatus status, string sessionId)
        {
            lblBatteryStatus.Text = string.Format("Battery: {0}% - Charging? {1}", status.battery, status.plugged);
        }

        private void OnScanMeHandler(string qrcodePath, string sessionId)
        {
        }

        private void OnReceiveMessageHandler(WhatsAppNETAPI.Message message, string sessionId)
        {
            var msg = message.content;

            var pengirim = string.Empty;
            var pushName = string.Empty;
            var group = string.Empty;

            if (message.id == "status@broadcast") // status@broadcast -> dummy message, penanda load data selesai
                return;

            var isGroup = message.group != null;

            if (isGroup) // pesan dari group
            {
                group = string.IsNullOrEmpty(message.group.name) ? message.from : message.group.name;

                var sender = message.group.sender;
                pengirim = string.IsNullOrEmpty(sender.name) ? message.from : sender.name;
                pushName = sender.pushname;                
            }
            else
            {
                pengirim = string.IsNullOrEmpty(message.sender.name) ? message.from : message.sender.name;
                pushName = message.sender.pushname;
            }                

            var fileName = message.filename;

            var data = string.Empty;

            if (isGroup)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    data = string.Format("[{0}] Group: {1}, Pesan teks: {2}, Pengirim: {3} [{4}]",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), group, msg, pengirim, pushName);
                }
                else
                    data = string.Format("[{0}] Group: {1}, Pesan gambar/dokumen: {2}, Pengirim: {3} [{4}], nama file: {5}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), group, msg, pengirim, pushName, fileName);
            }
            else
            {
                if (message.type == "call_log") // handle telepon masuk
                {
                    data = string.Format("[{0}] Telpon masuk dari : {1} [{2}]",
                            message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), pengirim, pushName);
                }
                else
                {
                    if (string.IsNullOrEmpty(fileName))
                    {
                        data = string.Format("[{0}] Pengirim: {1} [{2}], Pesan teks: {3}",
                            message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), pengirim, pushName, msg);
                    }
                    else
                        data = string.Format("[{0}] Pengirim: {1} [{2}], Pesan gambar/dokumen: {3}, nama file: {4}",
                            message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), pengirim, pushName, msg, fileName);
                }                
            }

            // khusus pesan masuk dengan tipe button dan list
            // tambahkan pengecekan kode berikut untuk mendapatkan id button/list yang dipilih
            if (message.type == MessageType.ButtonResponse)
                System.Diagnostics.Debug.Print("Id button yang dipilih: {0}", message.selectedButtonId);
            else if (message.type == MessageType.ListResponse)
                System.Diagnostics.Debug.Print("Id list yang dipilih: {0}", message.selectedRowId);

            // update UI dari thread yang berbeda
            lstPesanMasuk.Invoke(() =>
            {
                lstPesanMasuk.Items.Add(data);

                if (message.type == MessageType.Location)
                {
                    var location = message.location;
                    var dataLocation = string.Format("--> latitude: {0}, longitude: {1}, description: {2}",
                        location.latitude, location.longitude, location.description);

                    System.Diagnostics.Debug.Print(dataLocation);

                    lstPesanMasuk.Items.Add(dataLocation);
                }
                else if (message.type == MessageType.VCard || message.type == MessageType.MultiVCard)
                {
                    var vcards = message.vcards;
                    var vcardFilenames = message.vcardFilenames;

                    var index = 0;
                    foreach (var vcard in vcards)
                    {
                        var dataVCard = string.Format("--> N: {0}, FN: {1}, WA Id: {2}, fileName: {3}",
                            vcard.n, vcard.fn, vcard.waId, vcardFilenames[index]);

                        lstPesanMasuk.Items.Add(dataVCard);
                        index++;
                    }
                }

                lstPesanMasuk.SelectedIndex = lstPesanMasuk.Items.Count - 1;
            });

            if (chkAutoReplay.Checked)
            {
                if (chkKirimLokasi.Checked)
                {
                    var location = new Location
                    {
                        latitude = txtLatitude.Text,
                        longitude = txtLongitude.Text,
                        description = txtDescription.Text
                    };

                    _wa.ReplyMessage(new ReplyMsgArgs(message.from, location, message.id));
                }
                else
                {
                    var msgReplay = string.Format("Bpk/Ibu *{0}*, pesan *{1}* sudah kami terima. Silahkan ditunggu.",
                        pengirim, msg);

                    _wa.ReplyMessage(new ReplyMsgArgs(message.from, msgReplay, message.id));
                }                               
            }
        }

        private void OnReceiveMessagesHandler(IList<WhatsAppNETAPI.Message> messages, string sessionId)
        {
            foreach (var message in messages)
            {
                if (message.id == "status@broadcast") // status@broadcast -> dummy message, penanda load data selesai
                    continue;

                var msg = message.content;

                var pengirim = string.Empty;
                var group = string.Empty;

                var isGroup = message.group != null;

                if (isGroup) // pesan dari group
                {
                    group = string.IsNullOrEmpty(message.group.name) ? message.from : message.group.name;

                    var sender = message.group.sender;
                    pengirim = string.IsNullOrEmpty(sender.name) ? message.from : sender.name;
                }
                else
                    pengirim = string.IsNullOrEmpty(message.sender.name) ? message.from : message.sender.name;

                var data = string.Empty;

                if (isGroup)
                {
                    data = string.Format("[{0}] Group: {1}, Pesan teks: {2}, Pengirim: {3}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), group, msg, pengirim);
                }
                else
                {
                    data = string.Format("[{0}] Pengirim: {1}, Isi pesan: {2}",
                        message.datetime.ToString("yyyy-MM-dd HH:mm:ss"), pengirim, msg);
                }                

                // update UI dari thread yang berbeda
                lstPesanMasuk.Invoke(() =>
                {
                    lstPesanMasuk.Items.Add(data);
                    lstPesanMasuk.SelectedIndex = lstPesanMasuk.Items.Count - 1;
                });

                if (chkAutoReplay.Checked)
                {
                    var senderName = string.IsNullOrEmpty(message.sender.name) ? message.from : message.sender.name;

                    var msgReplay = string.Format("Bpk/Ibu *{0}*, pesan *{1}* sudah kami terima. Silahkan ditunggu.",
                            senderName, msg);

                    _wa.ReplyMessage(new ReplyMsgArgs(message.from, msgReplay, message.id));
                }

            }
        }

        private void OnReceiveMessageStatusHandler(WhatsAppNETAPI.MessageStatus msgStatus, string sessionId)
        {
            var status = msgStatus.status == "true" ? "BERHASIL" : "GAGAL";

            var msg = string.Format("Status pengiriman pesan ke {0}, status = {1}, messageId = {2}",
                msgStatus.send_to, status, msgStatus.messageId);

            // update UI dari thread yang berbeda
            lstPesanKeluar.Invoke(() =>
            {
                lstPesanKeluar.Items.Add(msg);
                lstPesanKeluar.SelectedIndex = lstPesanKeluar.Items.Count - 1;
            });
        }

        private void OnClientConnectedHandler(string sessionId)
        {
            System.Diagnostics.Debug.Print("ClientConnected on {0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }

        /// <summary>
        /// Menampilkan log INFO/ERROR yang dikirim dari node js
        /// </summary>
        /// <param name="level">Berisi INFO atau ERROR</param>
        /// <param name="message"></param>
        /// <param name="sessionId"></param>
        private void OnMonitoringLogHandler(string level, string message, string sessionId)
        {
            System.Diagnostics.Debug.Print("level: {0}, message: {1}", level, message);
        }

        #endregion

        private void btnLokasiWAAutomateNodejs_Click(object sender, EventArgs e)
        {            
            var folderName = Helper.ShowDialogOpenFolder();

            if (!string.IsNullOrEmpty(folderName)) txtLokasiWhatsAppNETAPINodeJs.Text = folderName;
        }

        private void btnLokasiPenyimpananFileAtauGambar_Click(object sender, EventArgs e)
        {
            var folderName = Helper.ShowDialogOpenFolder();

            if (!string.IsNullOrEmpty(folderName)) txtLokasiPenyimpananFileAtauGambar.Text = folderName;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void btnPilihGroup_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmPilihGroup("Pilih Group"))
            {
                _wa.OnReceiveGroups += frm.OnReceiveGroupsHandler; // subscribe event
                _wa.GetGroups(false);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _selectedGroup = frm.Group;

                    if (_selectedGroup != null) txtKontak.Text = _selectedGroup.name;
                }

                _wa.OnReceiveGroups -= frm.OnReceiveGroupsHandler; // unsubscribe event
            }
        }

        private void chkGroup_CheckedChanged(object sender, EventArgs e)
        {
            _selectedGroup = null;
            txtKontak.Clear();

            btnPilihGroup.Enabled = chkGroup.Checked;
            txtKontak.Enabled = !chkGroup.Checked;            
        }

        private void chkKirimPesanList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKirimPesanList.Checked)
            {
                chkKirimPesanDgGambar.Checked = false;
                chkKirimGambarDariUrl.Checked = false;
                chkKirimFileAja.Checked = false;
                chkKirimPesanButton.Checked = false;
                chkKirimPesanButtonDgGambar.Checked = false;
                chkKirimLokasi.Checked = false;

                txtFileGambar.Clear();
                txtFileDokumen.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
        }

        private void chkKirimPesanButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKirimPesanButton.Checked)
            {
                if (_wa.IsMultiDevice)
                {
                    MessageBox.Show("Maaf fitur pesan dengan tipe button belum support untuk multi device", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKirimPesanButton.Checked = false;
                    return;
                }

                chkKirimPesanDgGambar.Checked = false;
                chkKirimGambarDariUrl.Checked = false;
                chkKirimFileAja.Checked = false;
                chkKirimPesanList.Checked = false;
                chkKirimLokasi.Checked = false;
                chkKirimPesanButtonDgGambar.Checked = false;

                txtFileGambar.Clear();
                txtFileDokumen.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
        }

        private void btnSetStatus_Click(object sender, EventArgs e)
        {
            if (_wa.IsMultiDevice)
            {
                MessageBox.Show("Maaf fitur set status belum support untuk multi device", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var frm = new FrmSetStatus("Status", _wa))
            {
                frm.ShowDialog();
            }
        }

        private void btnInfoWANumber_Click(object sender, EventArgs e)
        {
            var msg = string.Format("Nomor WA: {0}\nMultiDevice: {1}", _wa.GetCurrentNumber, 
                _wa.IsMultiDevice);

            MessageBox.Show(msg, "Infomasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        

        private void chkMessageSentStatusSubscribe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMessageSentStatusSubscribe.Checked)
            {
                _wa.OnMessageAck += OnMessageAckHandler; // subscribe event
            }
            else
            {
                _wa.OnMessageAck -= OnMessageAckHandler; // unsubscribe event
                lstStatusPesanKeluar.Items.Clear();
            }
        }

        private void btnBatteryStatus_Click(object sender, EventArgs e)
        {
            if (_wa.IsMultiDevice)
            {
                MessageBox.Show("Maaf fitur cek battery status sudah tidak support untuk multi device", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _wa.GetBatteryStatus();            
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            _wa.GetCurrentState();
        }

        private void chkKirimPesanButtonDgGambar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKirimPesanButtonDgGambar.Checked)
            {
                if (_wa.IsMultiDevice)
                {
                    MessageBox.Show("Maaf fitur pesan dengan tipe button belum support untuk multi device", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKirimPesanButtonDgGambar.Checked = false;
                    return;
                }

                chkKirimPesanDgGambar.Checked = false;
                chkKirimGambarDariUrl.Checked = false;
                chkKirimFileAja.Checked = false;
                chkKirimPesanList.Checked = false;
                chkKirimLokasi.Checked = false;
                chkKirimPesanButton.Checked = false;

                txtFileGambar.Clear();
                txtFileDokumen.Clear();

                txtLatitude.Enabled = false;
                txtLongitude.Enabled = false;
                txtDescription.Enabled = false;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    tableCollection = result.Tables;
                    comboBox1.Items.Clear();
                    foreach (DataTable table in tableCollection)
                    {
                        comboBox1.Items.Add(table.TableName);
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message.ToString(), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public class Nomor
        {
            public string NO { get; set; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            List<Nomor> list = new List<Nomor>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nomor obj = new Nomor();
                obj.NO = dt.Rows[i]["NOMOR"].ToString();
                list.Add(obj);
            }
            dataGridView1.DataSource = list;
        }
    }
}
