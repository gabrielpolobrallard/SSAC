//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSAC.Modelo.modulo_cliente
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTEESTIMAGEN
    {
        public int idTabla { get; set; }
        public Nullable<int> Establecimiento { get; set; }
        public byte[] Imagen { get; set; }
        public string Epigrafe { get; set; }
    
        public virtual CLIENTEESTABLECIMIENTO CLIENTEESTABLECIMIENTO { get; set; }
    }
}
