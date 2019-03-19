using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsWebApi.Models
{
    public partial class Contact
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string FirstName { get; set; }
        [StringLength(10)]
        public string LastName { get; set; }
        [StringLength(10)]
        public string City { get; set; }
        [StringLength(10)]
        public string Address { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(10)]
        public string Telephone { get; set; }
        [StringLength(10)]
        public string Email { get; set; }
    }
}