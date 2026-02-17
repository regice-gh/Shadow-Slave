namespace ShadowSlave.Shared.Models
{
    public class Gateway
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Region { get; set; }
        public int? LocationId { get; set; }
        public Location? Location { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAnchored { get; set; }
    }
}