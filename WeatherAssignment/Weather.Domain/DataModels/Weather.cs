//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weather.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weather
    {
        public int Pk_Weather_Id { get; set; }
        public string Temp1 { get; set; }
        public string Temp2 { get; set; }
        public string Temp3 { get; set; }
        public string Temp4 { get; set; }
        public string Temp5 { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        public string Icon3 { get; set; }
        public string Icon4 { get; set; }
        public string Icon5 { get; set; }
        public Nullable<System.DateTime> Created1 { get; set; }
        public Nullable<System.DateTime> Created2 { get; set; }
        public Nullable<System.DateTime> Created3 { get; set; }
        public Nullable<System.DateTime> Created4 { get; set; }
        public Nullable<System.DateTime> Created5 { get; set; }
        public Nullable<int> Fk_City_Id { get; set; }
    
        public virtual City City { get; set; }
    }
}
