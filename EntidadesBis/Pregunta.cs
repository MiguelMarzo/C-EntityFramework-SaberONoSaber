//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntidadesBis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pregunta
    {
        public Pregunta()
        {
            this.Respuestas = new HashSet<Respuesta>();
        }
    
        public int IDPREGUNTA { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<Respuesta> Respuestas { get; set; }
    }
}
