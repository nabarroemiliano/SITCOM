//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Habitacion
    {
        public Habitacion()
        {
            this.Disponibilidad = new HashSet<Disponibilidad>();
        }
    
        public int idHabitacion { get; set; }
        public Nullable<int> idTipoHabitacion { get; set; }
        public Nullable<int> cantidadBanios { get; set; }
        public Nullable<bool> balcon { get; set; }
        public Nullable<bool> heladera { get; set; }
        public Nullable<bool> microondas { get; set; }
        public Nullable<int> idHotel { get; set; }
        public string nombreHabitacion { get; set; }
    
        public virtual ICollection<Disponibilidad> Disponibilidad { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual TipoHabitacion TipoHabitacion { get; set; }
    }
}
