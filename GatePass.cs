//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectHMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class GatePass
    {
        public int gate_id { get; set; }
        public string user_id { get; set; }
        public string gate_reason { get; set; }
        public System.DateTime gate_date { get; set; }
    
        public virtual UserDb UserDb { get; set; }
    }
}
