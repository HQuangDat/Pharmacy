//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int Account_ID { get; set; }
        public string Account_username { get; set; }
        public string Account_password { get; set; }
        public string Account_DisplayName { get; set; }
        public Nullable<int> Account_Category_ID { get; set; }
        public Nullable<int> Staff_ID { get; set; }
    
        public virtual Account_Category Account_Category { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
