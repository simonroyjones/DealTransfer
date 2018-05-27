using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DealTransfer
{
    public partial class ContinueYN : Form
    {
        public ContinueYN()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            gv.OKFlag = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            gv.OKFlag = false;
            this.Close();
        }

        private void ContinueYN_Load(object sender, EventArgs e)
        {
            var ct = Clipboard.GetText();
            var accountIds = Regex.Split(ct, "\r\n").ToList();
            foreach (var accountid in accountIds)
            {
                listBox1.Items.Add(accountid);
            }
        }
    }
}
