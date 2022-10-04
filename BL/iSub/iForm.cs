using System;

namespace BL.iSub
{
    public partial class iForm : DevExpress.XtraEditors.XtraForm
    {
        #region Code
        public virtual void Add_Data()
        {
        }
        public virtual void Update_Data()
        {
        }
        public virtual void Delete_Data()
        {
        }
        public virtual void Load_Data()
        {
        }
        #endregion Code
        public iForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void iForm_Activated(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}