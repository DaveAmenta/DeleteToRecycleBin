using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// David Amenta - DaveAmenta.com
// 05/05/08

namespace DeleteToRecycleBin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnRecycle.Enabled = false;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OFD.Filter = "All Files|*.*";
            OFD.ShowDialog();
            OFD.Multiselect = false;

            if (OFD.FileName != "")
            {
                if (System.IO.File.Exists(OFD.FileName))
                {
                    txtFile.Text = OFD.FileName;
                    btnRecycle.Enabled = true;
                }
            }
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            if (RecybleBin.Send(txtFile.Text))
            {
                txtFile.Text = "";
                btnRecycle.Enabled = false;
            }
            else
            {
                MessageBox.Show("There was an error trying to move the file to the recycle bin", "Error");
            }

        }
    }
}
