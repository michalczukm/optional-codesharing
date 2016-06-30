namespace CodeSharing
{
    public class NullObjectPattern
    {
        public void DoExample()
        {
            // todo -> create NullObject
            var client = GetCurrentClient();

            // manipulate IClient
        }

        public IClient GetCurrentClient()
        {
            return new NullClient();
        }
    }

    public class NullClient : IClient
    {
        public int Id { get; set; } = -1;

        public string Name { get; set; } = "";
    }
}