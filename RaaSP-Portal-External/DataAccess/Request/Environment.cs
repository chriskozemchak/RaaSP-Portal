namespace RaaSP_Portal_Internal.DataAccess.Models.Request
{
    public class Environment: IModelBase

    {
        public string Id { get; set; }

        //Environment Specific Model
        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Active { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
