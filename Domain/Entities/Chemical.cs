namespace Domain.Entities
{
    public class Chemical : Product
    {
        public string LabName { get; set; }
        public Address Address { get; set; }
    }
}