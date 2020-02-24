namespace Domain.Entities
{
    public class Chemical : Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAddress { get; set; }
    }
}