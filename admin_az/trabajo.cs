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
    
    public partial class trabajo
    {
        public int idtrabajo { get; set; }
        public Nullable<int> idcita { get; set; }
        public string asunto { get; set; }
        public Nullable<double> monto { get; set; }
    
        public virtual cita cita { get; set; }
    }
}
