//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL.Db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SalesEntities : DbContext
    {
        public SalesEntities()
            : base("name=SalesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customer { get; set; }
    
        public virtual int Delete_Customer(string cust_Code)
        {
            var cust_CodeParameter = cust_Code != null ?
                new ObjectParameter("cust_Code", cust_Code) :
                new ObjectParameter("cust_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Customer", cust_CodeParameter);
        }
    
        public virtual int Delete_Customer_Completely(string cust_Code)
        {
            var cust_CodeParameter = cust_Code != null ?
                new ObjectParameter("cust_Code", cust_Code) :
                new ObjectParameter("cust_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Customer_Completely", cust_CodeParameter);
        }
    
        public virtual int Insert_Customer(string cust_Code, string cust_Name, string cust_Address, string cust_City, string cust_Country, string cust_Phone, string cust_Fax, string cust_Facebok, string cust_Email, string cust_Note, byte[] cust_Image, string cust_Pc_Name_Added, string cust_Pc_Name_Modified, string cust_Pc_Name_Deleted, string cust_User_Added, string cust_User_Modified, string cust_User_Deleted, Nullable<decimal> cust_Credit, Nullable<decimal> cust_Debit, Nullable<decimal> cust_Balance)
        {
            var cust_CodeParameter = cust_Code != null ?
                new ObjectParameter("cust_Code", cust_Code) :
                new ObjectParameter("cust_Code", typeof(string));
    
            var cust_NameParameter = cust_Name != null ?
                new ObjectParameter("cust_Name", cust_Name) :
                new ObjectParameter("cust_Name", typeof(string));
    
            var cust_AddressParameter = cust_Address != null ?
                new ObjectParameter("cust_Address", cust_Address) :
                new ObjectParameter("cust_Address", typeof(string));
    
            var cust_CityParameter = cust_City != null ?
                new ObjectParameter("cust_City", cust_City) :
                new ObjectParameter("cust_City", typeof(string));
    
            var cust_CountryParameter = cust_Country != null ?
                new ObjectParameter("cust_Country", cust_Country) :
                new ObjectParameter("cust_Country", typeof(string));
    
            var cust_PhoneParameter = cust_Phone != null ?
                new ObjectParameter("cust_Phone", cust_Phone) :
                new ObjectParameter("cust_Phone", typeof(string));
    
            var cust_FaxParameter = cust_Fax != null ?
                new ObjectParameter("cust_Fax", cust_Fax) :
                new ObjectParameter("cust_Fax", typeof(string));
    
            var cust_FacebokParameter = cust_Facebok != null ?
                new ObjectParameter("cust_Facebok", cust_Facebok) :
                new ObjectParameter("cust_Facebok", typeof(string));
    
            var cust_EmailParameter = cust_Email != null ?
                new ObjectParameter("cust_Email", cust_Email) :
                new ObjectParameter("cust_Email", typeof(string));
    
            var cust_NoteParameter = cust_Note != null ?
                new ObjectParameter("cust_Note", cust_Note) :
                new ObjectParameter("cust_Note", typeof(string));
    
            var cust_ImageParameter = cust_Image != null ?
                new ObjectParameter("cust_Image", cust_Image) :
                new ObjectParameter("cust_Image", typeof(byte[]));
    
            var cust_Pc_Name_AddedParameter = cust_Pc_Name_Added != null ?
                new ObjectParameter("cust_Pc_Name_Added", cust_Pc_Name_Added) :
                new ObjectParameter("cust_Pc_Name_Added", typeof(string));
    
            var cust_Pc_Name_ModifiedParameter = cust_Pc_Name_Modified != null ?
                new ObjectParameter("cust_Pc_Name_Modified", cust_Pc_Name_Modified) :
                new ObjectParameter("cust_Pc_Name_Modified", typeof(string));
    
            var cust_Pc_Name_DeletedParameter = cust_Pc_Name_Deleted != null ?
                new ObjectParameter("cust_Pc_Name_Deleted", cust_Pc_Name_Deleted) :
                new ObjectParameter("cust_Pc_Name_Deleted", typeof(string));
    
            var cust_User_AddedParameter = cust_User_Added != null ?
                new ObjectParameter("cust_User_Added", cust_User_Added) :
                new ObjectParameter("cust_User_Added", typeof(string));
    
            var cust_User_ModifiedParameter = cust_User_Modified != null ?
                new ObjectParameter("cust_User_Modified", cust_User_Modified) :
                new ObjectParameter("cust_User_Modified", typeof(string));
    
            var cust_User_DeletedParameter = cust_User_Deleted != null ?
                new ObjectParameter("cust_User_Deleted", cust_User_Deleted) :
                new ObjectParameter("cust_User_Deleted", typeof(string));
    
            var cust_CreditParameter = cust_Credit.HasValue ?
                new ObjectParameter("cust_Credit", cust_Credit) :
                new ObjectParameter("cust_Credit", typeof(decimal));
    
            var cust_DebitParameter = cust_Debit.HasValue ?
                new ObjectParameter("cust_Debit", cust_Debit) :
                new ObjectParameter("cust_Debit", typeof(decimal));
    
            var cust_BalanceParameter = cust_Balance.HasValue ?
                new ObjectParameter("cust_Balance", cust_Balance) :
                new ObjectParameter("cust_Balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Customer", cust_CodeParameter, cust_NameParameter, cust_AddressParameter, cust_CityParameter, cust_CountryParameter, cust_PhoneParameter, cust_FaxParameter, cust_FacebokParameter, cust_EmailParameter, cust_NoteParameter, cust_ImageParameter, cust_Pc_Name_AddedParameter, cust_Pc_Name_ModifiedParameter, cust_Pc_Name_DeletedParameter, cust_User_AddedParameter, cust_User_ModifiedParameter, cust_User_DeletedParameter, cust_CreditParameter, cust_DebitParameter, cust_BalanceParameter);
        }
    
        public virtual int Update_Customer(string cust_Code, string cust_Name, string cust_Address, string cust_City, string cust_Country, string cust_Phone, string cust_Fax, string cust_Facebok, string cust_Email, string cust_Note, byte[] cust_Image, string cust_Pc_Name_Added, string cust_Pc_Name_Modified, string cust_Pc_Name_Deleted, string cust_User_Added, string cust_User_Modified, string cust_User_Deleted, Nullable<decimal> cust_Credit, Nullable<decimal> cust_Debit, Nullable<decimal> cust_Balance)
        {
            var cust_CodeParameter = cust_Code != null ?
                new ObjectParameter("cust_Code", cust_Code) :
                new ObjectParameter("cust_Code", typeof(string));
    
            var cust_NameParameter = cust_Name != null ?
                new ObjectParameter("cust_Name", cust_Name) :
                new ObjectParameter("cust_Name", typeof(string));
    
            var cust_AddressParameter = cust_Address != null ?
                new ObjectParameter("cust_Address", cust_Address) :
                new ObjectParameter("cust_Address", typeof(string));
    
            var cust_CityParameter = cust_City != null ?
                new ObjectParameter("cust_City", cust_City) :
                new ObjectParameter("cust_City", typeof(string));
    
            var cust_CountryParameter = cust_Country != null ?
                new ObjectParameter("cust_Country", cust_Country) :
                new ObjectParameter("cust_Country", typeof(string));
    
            var cust_PhoneParameter = cust_Phone != null ?
                new ObjectParameter("cust_Phone", cust_Phone) :
                new ObjectParameter("cust_Phone", typeof(string));
    
            var cust_FaxParameter = cust_Fax != null ?
                new ObjectParameter("cust_Fax", cust_Fax) :
                new ObjectParameter("cust_Fax", typeof(string));
    
            var cust_FacebokParameter = cust_Facebok != null ?
                new ObjectParameter("cust_Facebok", cust_Facebok) :
                new ObjectParameter("cust_Facebok", typeof(string));
    
            var cust_EmailParameter = cust_Email != null ?
                new ObjectParameter("cust_Email", cust_Email) :
                new ObjectParameter("cust_Email", typeof(string));
    
            var cust_NoteParameter = cust_Note != null ?
                new ObjectParameter("cust_Note", cust_Note) :
                new ObjectParameter("cust_Note", typeof(string));
    
            var cust_ImageParameter = cust_Image != null ?
                new ObjectParameter("cust_Image", cust_Image) :
                new ObjectParameter("cust_Image", typeof(byte[]));
    
            var cust_Pc_Name_AddedParameter = cust_Pc_Name_Added != null ?
                new ObjectParameter("cust_Pc_Name_Added", cust_Pc_Name_Added) :
                new ObjectParameter("cust_Pc_Name_Added", typeof(string));
    
            var cust_Pc_Name_ModifiedParameter = cust_Pc_Name_Modified != null ?
                new ObjectParameter("cust_Pc_Name_Modified", cust_Pc_Name_Modified) :
                new ObjectParameter("cust_Pc_Name_Modified", typeof(string));
    
            var cust_Pc_Name_DeletedParameter = cust_Pc_Name_Deleted != null ?
                new ObjectParameter("cust_Pc_Name_Deleted", cust_Pc_Name_Deleted) :
                new ObjectParameter("cust_Pc_Name_Deleted", typeof(string));
    
            var cust_User_AddedParameter = cust_User_Added != null ?
                new ObjectParameter("cust_User_Added", cust_User_Added) :
                new ObjectParameter("cust_User_Added", typeof(string));
    
            var cust_User_ModifiedParameter = cust_User_Modified != null ?
                new ObjectParameter("cust_User_Modified", cust_User_Modified) :
                new ObjectParameter("cust_User_Modified", typeof(string));
    
            var cust_User_DeletedParameter = cust_User_Deleted != null ?
                new ObjectParameter("cust_User_Deleted", cust_User_Deleted) :
                new ObjectParameter("cust_User_Deleted", typeof(string));
    
            var cust_CreditParameter = cust_Credit.HasValue ?
                new ObjectParameter("cust_Credit", cust_Credit) :
                new ObjectParameter("cust_Credit", typeof(decimal));
    
            var cust_DebitParameter = cust_Debit.HasValue ?
                new ObjectParameter("cust_Debit", cust_Debit) :
                new ObjectParameter("cust_Debit", typeof(decimal));
    
            var cust_BalanceParameter = cust_Balance.HasValue ?
                new ObjectParameter("cust_Balance", cust_Balance) :
                new ObjectParameter("cust_Balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Customer", cust_CodeParameter, cust_NameParameter, cust_AddressParameter, cust_CityParameter, cust_CountryParameter, cust_PhoneParameter, cust_FaxParameter, cust_FacebokParameter, cust_EmailParameter, cust_NoteParameter, cust_ImageParameter, cust_Pc_Name_AddedParameter, cust_Pc_Name_ModifiedParameter, cust_Pc_Name_DeletedParameter, cust_User_AddedParameter, cust_User_ModifiedParameter, cust_User_DeletedParameter, cust_CreditParameter, cust_DebitParameter, cust_BalanceParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> MaxID_Customer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("MaxID_Customer");
        }
    
        public virtual ObjectResult<Select_Customer_Result> Select_Customer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Customer_Result>("Select_Customer");
        }
    
        public virtual ObjectResult<Customer> Select_Customer_By_Code(string cust_Code)
        {
            var cust_CodeParameter = cust_Code != null ?
                new ObjectParameter("cust_Code", cust_Code) :
                new ObjectParameter("cust_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("Select_Customer_By_Code", cust_CodeParameter);
        }
    
        public virtual ObjectResult<Customer> Select_Customer_By_Code(string cust_Code, MergeOption mergeOption)
        {
            var cust_CodeParameter = cust_Code != null ?
                new ObjectParameter("cust_Code", cust_Code) :
                new ObjectParameter("cust_Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("Select_Customer_By_Code", mergeOption, cust_CodeParameter);
        }
    }
}
