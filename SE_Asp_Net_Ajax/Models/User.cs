using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SE_Asp_Net_Ajax.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Can not be blank Name")]
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }
    }
}