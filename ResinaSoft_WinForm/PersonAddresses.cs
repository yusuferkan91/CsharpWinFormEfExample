//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResinaSoft_WinForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonAddresses
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string AddressType { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
