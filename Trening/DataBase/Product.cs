//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trening.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Busket = new HashSet<Busket>();
            this.ProductMaterial = new HashSet<ProductMaterial>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> MinPrice { get; set; }
        public Nullable<int> IDProductType { get; set; }
        public Nullable<int> PeopleForProduction { get; set; }
        public Nullable<int> IDWorkshop { get; set; }
        public byte[] Photo { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Busket> Busket { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Workshop Workshop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }
    }
}
