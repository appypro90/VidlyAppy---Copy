//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vidly.Api
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movy()
        {
            this.CustomerMovies = new HashSet<CustomerMovie>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime ReleasedDate { get; set; }
        public int NumberInStock { get; set; }
        public int GenreId { get; set; }
        public System.DateTime DateAdded { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerMovie> CustomerMovies { get; set; }
        public virtual Genre Genre { get; set; }
    }
}