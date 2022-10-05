namespace BL.Sub
{
    partial class frmListCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.cmbxMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtSearch);
            this.groupControl1.Controls.Add(this.cmbxMode);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(672, 89);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 28);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbxMode
            // 
            this.cmbxMode.Location = new System.Drawing.Point(433, 38);
            this.cmbxMode.Name = "cmbxMode";
            this.cmbxMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbxMode.Size = new System.Drawing.Size(181, 28);
            this.cmbxMode.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gcCustomers);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(12, 111);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(940, 391);
            this.groupControl2.TabIndex = 5;
            // 
            // gcCustomers
            // 
            this.gcCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCustomers.Location = new System.Drawing.Point(5, 31);
            this.gcCustomers.MainView = this.gvCustomers;
            this.gcCustomers.Name = "gcCustomers";
            this.gcCustomers.Size = new System.Drawing.Size(930, 355);
            this.gcCustomers.TabIndex = 0;
            this.gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomers});
            // 
            // gvCustomers
            // 
            this.gvCustomers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCustomers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCode,
            this.gcName,
            this.gcAddress,
            this.gcCity,
            this.gcPhone});
            this.gvCustomers.GridControl = this.gcCustomers;
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.OptionsBehavior.Editable = false;
            this.gvCustomers.DoubleClick += new System.EventHandler(this.gvCustomers_DoubleClick);
            // 
            // gcCode
            // 
            this.gcCode.Caption = "Code Customer";
            this.gcCode.FieldName = "cust_Code";
            this.gcCode.MinWidth = 25;
            this.gcCode.Name = "gcCode";
            this.gcCode.Visible = true;
            this.gcCode.VisibleIndex = 0;
            this.gcCode.Width = 94;
            // 
            // gcName
            // 
            this.gcName.Caption = "Name Customer";
            this.gcName.FieldName = "cust_Name";
            this.gcName.MinWidth = 25;
            this.gcName.Name = "gcName";
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 1;
            this.gcName.Width = 94;
            // 
            // gcAddress
            // 
            this.gcAddress.Caption = "Address";
            this.gcAddress.FieldName = "cust_Address";
            this.gcAddress.MinWidth = 25;
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.Visible = true;
            this.gcAddress.VisibleIndex = 2;
            this.gcAddress.Width = 94;
            // 
            // gcCity
            // 
            this.gcCity.Caption = "City";
            this.gcCity.FieldName = "cust_City";
            this.gcCity.MinWidth = 25;
            this.gcCity.Name = "gcCity";
            this.gcCity.Visible = true;
            this.gcCity.VisibleIndex = 3;
            this.gcCity.Width = 94;
            // 
            // gcPhone
            // 
            this.gcPhone.Caption = "Phone";
            this.gcPhone.FieldName = "cust_Phone";
            this.gcPhone.MinWidth = 25;
            this.gcPhone.Name = "gcPhone";
            this.gcPhone.Visible = true;
            this.gcPhone.VisibleIndex = 4;
            this.gcPhone.Width = 94;
            // 
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 518);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmListCustomers";
            this.Text = "List Customers";
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbxMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.ComboBoxEdit cmbxMode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraGrid.GridControl gcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gcCode;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gcCity;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhone;
    }
}