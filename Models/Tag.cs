namespace CollectionHub.Models
{
    public class Tag
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Count { get; set; } = 1;
    }
}