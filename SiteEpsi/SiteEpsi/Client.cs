//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteEpsi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<int> ZipCode { get; set; }
        public string City { get; set; }
        public int Role { get; set; }
    }
}
