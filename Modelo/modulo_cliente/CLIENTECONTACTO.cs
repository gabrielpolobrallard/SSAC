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
    
    public partial class CLIENTECONTACTO
    {
        public long IDTabla { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Direccion1 { get; set; }
        public string CodigoPostal1 { get; set; }
        public string Pais1 { get; set; }
        public string Direccion2 { get; set; }
        public string CodigoPostal2 { get; set; }
        public string Pais2 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string EMail1 { get; set; }
        public string EMail2 { get; set; }
        public string EMail3 { get; set; }
        public string Observacion { get; set; }
        public string Localidad1 { get; set; }
        public string Localidad2 { get; set; }
    
        public virtual CLIENTE CLIENTE1 { get; set; }
    }
}
