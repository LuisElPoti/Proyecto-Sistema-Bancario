//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NETBANKING
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCuentaBeneficiario
    {
        public int CuentaBeneficiarioID { get; set; }
        public string NoCuenta { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int BeneficiarioID { get; set; }
    
        public virtual TblBeneficiario TblBeneficiario { get; set; }
    }
}
