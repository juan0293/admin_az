//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace admin_az
{
    using System;
    using System.Collections.Generic;
    
    public partial class cierre
    {
        public int idcierre { get; set; }
        public Nullable<int> idusuario { get; set; }
        public Nullable<double> efectivo { get; set; }
        public Nullable<double> deposito { get; set; }
        public Nullable<double> tarjeta { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
