using System;
using System.Windows.Forms;
using CipherLab.Views.Controls; 

namespace CipherLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UcHome homeUc = new UcHome();
            homeUc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(homeUc);
            homeUc.BringToFront();
        }

        private void SwitchControl(UserControl control)
        {
            pnlContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(control);
            control.BringToFront();
        }

        private void btnTextCrypto_Click(object sender, EventArgs e)
        {
            UcTextCrypto textCryptoControl = new UcTextCrypto();
            SwitchControl(textCryptoControl);
        }

        private void btnNavHistory_Click(object sender, EventArgs e)
        {
            UcHistory historyUc = new UcHistory();

            historyUc.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(historyUc);
            historyUc.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcHome homeUc = new UcHome();

            homeUc.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(homeUc);
            homeUc.BringToFront();
        }
    }
}