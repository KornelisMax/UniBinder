//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniBinderAPI.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public System.Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> Dislikes { get; set; }
        public string ImageLink { get; set; }
        public List<Subject> SubjectList { get; internal set; }
    }
}
