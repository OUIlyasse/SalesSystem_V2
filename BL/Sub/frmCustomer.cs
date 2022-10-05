using BL.iSub;
using DevExpress.XtraEditors;
using DL.Db;
using iTools;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BL.Sub
{
    public partial class frmCustomer : iForm
    {
        #region Variables
        SalesEntities db = new SalesEntities();
        frmListCustomers frm;
        #endregion Variables

        #region Codes
        public string getCode()
        {
            return string.Format("{0}{1:000000}", Properties.Settings.Default.cust_Code.ToString(), Convert.ToInt32(getMax()));
        }
        public string getMax()
        {
            return db.MaxID_Customer().SingleOrDefault().ToString();
        }
        public void newRecord()
        {
            iProc.Clear(groupControl1, groupControl2);
            txtCode.Text = getCode();
            txtName.Focus();
        }
        public void getData()
        {
            frm.gcCustomers.DataSource = db.Select_Customer();
        }

        #endregion Codes

        #region Override
        public override void verifyButtons(XtraForm f, string txt)
        {
            base.verifyButtons(this, "Add Customer");
        }
        public override void Add_Data()
        {
            if (validateData.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (picImage.Image == null)
                        {
                            db.Insert_Customer(
                           txtCode.Text, iProc.UppercaseFirst(txtName.Text), iProc.UppercaseFirst(txtAddress.Text), iProc.UppercaseFirst(txtCity.Text), iProc.UppercaseFirst(cmbxCountry.Text), txtPhone.Text, txtFax.Text, txtFacebook.Text, txtEmail.Text,
                            txtNote.Text, null, null, null, null, null, null, null, null, null, null
                            );
                        }
                        else
                        {
                            db.Insert_Customer(
                           txtCode.Text, iProc.UppercaseFirst(txtName.Text), iProc.UppercaseFirst(txtAddress.Text), iProc.UppercaseFirst(txtCity.Text), iProc.UppercaseFirst(cmbxCountry.Text), txtPhone.Text, txtFax.Text, txtFacebook.Text, txtEmail.Text,
                            txtNote.Text, iProc.ImageCrypte(picImage), null, null, null, null, null, null, null, null, null
                            );
                        }
                        db.SaveChanges();
                        transaction.Commit();
                        iProc.msgBox("Your Customer is added correctly", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newRecord();
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iProc.msgBox(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public override void Update_Data()
        {
            if (validateData.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (picImage.Image == null)
                        {
                            db.Update_Customer(
                            txtCode.Text, iProc.UppercaseFirst(txtName.Text), iProc.UppercaseFirst(txtAddress.Text), iProc.UppercaseFirst(txtCity.Text), iProc.UppercaseFirst(cmbxCountry.Text), txtPhone.Text, txtFax.Text, txtFacebook.Text, txtEmail.Text,
                            txtNote.Text, null, null, null, null, null, null, null, null, null, null
                            );
                        }
                        else
                        {
                            db.Update_Customer(
                           txtCode.Text, iProc.UppercaseFirst(txtName.Text), iProc.UppercaseFirst(txtAddress.Text), iProc.UppercaseFirst(txtCity.Text), iProc.UppercaseFirst(cmbxCountry.Text), txtPhone.Text, txtFax.Text, txtFacebook.Text, txtEmail.Text,
                            txtNote.Text, iProc.ImageCrypte(picImage), null, null, null, null, null, null, null, null, null
                            );
                        }
                        db.SaveChanges();
                        transaction.Commit();
                        iProc.msgBox("Your Customer is modified correctly", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newRecord();
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iProc.msgBox(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public override void Delete_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Delete_Customer(txtCode.Text);
                    db.SaveChanges();
                    transaction.Commit();
                    iProc.msgBox("Your Customer is deleted correctly", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newRecord();
                    getData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    iProc.msgBox(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Override
        public frmCustomer(frmListCustomers f)
        {
            InitializeComponent();
            frm = f;
        }
        public frmCustomer(frmListCustomers f, string code, string name, string address, string city, string country, string phone, string fax, string email, string facebook, string note, string debit, string credit, string balance, string status, byte[] img)
        {
            InitializeComponent();
            frm = f;
            txtCode.Text = code;
            txtName.Text = name;
            txtAddress.Text = address;
            txtCity.Text = city;
            cmbxCountry.Text = country;
            txtPhone.Text = phone;
            txtFax.Text = fax;
            txtEmail.Text = email;
            txtFacebook.Text = facebook;
            txtNote.Text = note;
            txtDebit.Text = debit;
            txtCredit.Text = credit;
            txtBalance.Text = balance;
            txtStatus.Text = status;
            //picImage.Image = img;
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if (Text == "Add Customer")
            {
                newRecord();
            }
        }

        private void lnkChoose_Click(object sender, EventArgs e)
        {
            ofdImages.FileName = "";
            ofdImages.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(ofdImages.FileName);
            }
        }
    }
}