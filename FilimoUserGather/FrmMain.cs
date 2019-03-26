using FilimoUserGather.UserGather;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace FilimoUserGather
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        UserGather.Events.UserGathred ug = new UserGather.Events.UserGathred();
        List<String> GatheredUsernames = new List<string>();
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_link.Text))
                MessageBox.Show("Fill link !");
            else
            {
                try
                {
                    UserInputs.Count = txt_count.Value.ToString();
                    UserInputs.GenreLink = txt_link.Text;

                    ug.UsergathredEvent += Ug_UsergathredEvent;

                    Filimo filimo = new Filimo(this.ug);

                    Thread t = new Thread(() => { filimo.Begin(); });
                    t.IsBackground = true;
                    t.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown problem while Gathering usernames !" + Environment.NewLine + ex.Message);
                }
            }
        }
        String savePath = Application.StartupPath + "\\users.txt";
        private void Ug_UsergathredEvent(String username)
        {
            GatheredUsernames.Add(username);

            InvokeHelper(txt_users, () => { txt_users.Text += username + Environment.NewLine; });
            File.WriteAllLines(savePath, GatheredUsernames);
        }

        private void InvokeHelper(Control c, Action action)
        {
            if (c.InvokeRequired)
                c.Invoke((MethodInvoker)delegate { action(); });
            else
                action();
        }
        private void btn_clearUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (GatheredUsernames.Count > 0)
                {
                    if (!txt_users.Text.Equals(""))
                    {
                        var r = GatheredUsernames.Distinct();

                        txt_users.Clear();
                        foreach (var i in r)
                            txt_users.Text += i + Environment.NewLine;

                        File.WriteAllLines(savePath.Replace(".txt","") + "-cleaned.txt", GatheredUsernames);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wait for end the progress !");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/MHNCR0Soft");
        }
    }
}
