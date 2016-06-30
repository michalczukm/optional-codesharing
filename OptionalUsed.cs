namespace CodeSharing
{
    public class OptionalUsed
    {
        public void DoExample()
        {
            Optional<Client> clientOptional = GetCurrentClient();

            if (clientOptional.HasValue)
            {
                Client client = clientOptional.Value;
                // use client
            }
            else 
            {
                // handle when client is absent
            }
        }
















        public void DontDoThisExample()
        {
            Optional<Client> clientOptional = GetCurrentClient();

            // if value is absent - you'll get InvalidOperationException
            Client client = clientOptional.Value;
        }














        public Optional<Client> GetCurrentClient()
        {
            var client = GetClientInternal();

            // return Optional<Client>.Of(client);
            // return client.ToOptional();
            return Optional<Client>.Absent();
        }

        private Client GetClientInternal() {
            return null;
        }
    }
}