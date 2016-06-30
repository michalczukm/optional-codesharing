namespace CodeSharing
{
    public class Client : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IClient
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}