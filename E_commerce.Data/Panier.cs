//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_commerce.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Panier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Panier()
        {
            this.Quantité_produit = new HashSet<Quantité_produit>();
        }
    
        public int id_panier { get; set; }
        public Nullable<decimal> prixtotal { get; set; }
        public Nullable<int> id_client { get; set; }
        public Nullable<int> id_cmd { get; set; }
    
        public virtual Commande Commande { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quantité_produit> Quantité_produit { get; set; }
    }
}