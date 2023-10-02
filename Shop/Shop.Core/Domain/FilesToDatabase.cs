namespace Shop.Core.Domain
{
    public class FilesToDatabase
    {
        public Guid Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public Guid? RealEstateId { get; set; }
    }
}
