using System;

namespace BL.iSub
{
    public partial class iListForm : DevExpress.XtraEditors.XtraForm
    {
        #region Code
        public virtual void GetData()
        {
        }
        public virtual void Add_Data()
        {
        }
        #endregion Code
        public iListForm()
        {
            InitializeComponent();
        }

        private void iListForm_Activated(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Data();
        }
    }
}