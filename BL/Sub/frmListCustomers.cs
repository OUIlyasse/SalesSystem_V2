using BL.iSub;
using DL.Db;
using System.Linq;

namespace BL.Sub
{
    public partial class frmListCustomers : iListForm
    {
        #region Variables
        SalesEntities db = new SalesEntities();
        #endregion Variables
        #region Override
        public override void GetData()
        {
            gcCustomers.DataSource = db.Select_Customer();
        }
        public override void Add_Data()
        {
            frmCustomer frm = new frmCustomer(this);
            frm.Text = "Add Customer";
            frm.ShowDialog();
        }
        #endregion Override
        public frmListCustomers()
        {
            InitializeComponent();
        }

        private void gvCustomers_DoubleClick(object sender, System.EventArgs e)
        {
            if (gvCustomers.RowCount > 0)
            {
                var row = gvCustomers.FocusedRowHandle;
                string name = gvCustomers.GetRowCellValue(row, "cust_Code").ToString();
                System.Windows.Forms.MessageBox.Show(name);
                Customer c = db.Select_Customer_By_Code(name).FirstOrDefault();
                frmCustomer frm = new frmCustomer(this, c.cust_Code, c.cust_Name, c.cust_Address, c.cust_City, c.cust_Country, c.cust_Phone, c.cust_Fax, c.cust_Email, c.cust_Facebok, c.cust_Note, c.cust_Debit.ToString(), c.cust_Credit.ToString(), c.cust_Balance.ToString(), "", c.cust_Image);
                frm.Text = "Modify Customer";
                frm.ShowDialog();
            }
        }
    }
}