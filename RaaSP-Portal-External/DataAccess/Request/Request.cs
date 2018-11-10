namespace RaaSP_Portal_External.DataAccess.Models.Request
{
    public class Request : IModelBase

    {
        public string Id { get; set; }

        //Request Specific Model
        public string TypeId { get; set; }
        public string State { get; set; }


        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Active { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
