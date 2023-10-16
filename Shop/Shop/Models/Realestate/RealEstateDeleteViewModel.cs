namespace Shop.Models.Realestate
{
    public class RealEstateDeleteViewModel
    {
        public Guid? Id { get; set; }
        public string Address { get; set; }
        public float SizeSqrM { get; set; }
        public int RoomCount { get; set; }
        public int Floor { get; set; }
        public string BuildingType { get; set; }
        public DateTime BuiltInYear { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<ImageToDatabaseViewModel> ImageToDatabase { get; set; } = new List<ImageToDatabaseViewModel>();
    }
}
