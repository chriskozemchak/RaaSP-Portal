using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaaSP_Portal_DataAccess.Models.Environment
{
    [Table("INFO")]
    public class Info : IModelBase

    {
        public string Id { get; set; }

        //User Specific Model
        [Required(ErrorMessage = "Please Complete All Required Fields")]
        public string ProjectName { get; set; }
        [Required(ErrorMessage = "Please Complete All Required Fields")]
        public string ProjectType { get; set; }
        [Required(ErrorMessage = "Please Complete All Required Fields")]
        public string Description { get; set; }

        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Active { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
