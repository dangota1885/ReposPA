using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Example.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public DateTime? Birthdate { get; set; }
        public MembershipType  MembershipType{ get; set; }
    }
}