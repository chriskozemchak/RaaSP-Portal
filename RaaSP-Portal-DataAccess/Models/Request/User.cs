using System;
namespace RaaSP_Portal_DataAccess.Models.Request
{
    public class User : IModelBase

    {
        public string Id { get; set; }

        //User Specific Model
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string CtsId { get; set; }

        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Active { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
