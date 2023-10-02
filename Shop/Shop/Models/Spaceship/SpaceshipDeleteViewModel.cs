namespace Shop.Models.Spaceship
{
    public class SpaceshipDeleteViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Passengers { get; set; }
        public int EnginePower { get; set; }
        public int Crew { get; set; }
        public string Company { get; set; }
        public int CargoWeight { get; set; }

        public List<FileToApiViewModel> FileToApiViewModels { get; set; }
            = new List<FileToApiViewModel>();

        //only in database
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
