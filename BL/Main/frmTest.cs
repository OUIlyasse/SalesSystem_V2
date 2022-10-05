using BL.Sub;
using System;

namespace BL.Main
{
    public partial class frmTest : DevExpress.XtraEditors.XtraForm
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListCustomers f = new frmListCustomers();
            f.ShowDialog();
        }
    }
}