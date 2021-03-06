﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RaaSP_Portal_External.DataAccess.Models.Request
{
    public class User

    {
        public string Id { get; set; }

        //User Specific Model
        [Required (ErrorMessage = "Please Complete All Required Fields")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Complete All Required Fields")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Complete All Required Fields")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Complete All Required Fields")]
        public string Type { get; set; }

        public string Phone { get; set; }
        public string CtsId { get; set; }

        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Active { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
