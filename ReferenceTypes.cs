using System;

namespace CodeSharing
{
    public class ReferenceTypes
    {
        public void DoExample()
        {
            // client always exists, nice and clean
            var client = GetCurrentClient();
            DoStuffWithClient(client);









            // if we KNOW or ASSUME that client could not exist
            var maybeClient = GetCurrentClientId2();
            if (maybeClient != null)
            {
                DoStuffWithClient(client);
            }
            else
            {
                // handle non id situation
            }










            // if we forget to handle this null
            var someClient = GetCurrentClientId2();
            DoNestedStuffWithClient(client);
        }








        public Client GetCurrentClient()
        {
            return new Client { Id = 5, Name = "Marian" };
        }











        public Client GetCurrentClientId2()
        {
            return null;
        }






        private void DoStuffWithClient(Client client)
        {
            // do some stuff
            Console.WriteLine($"{client.Name}, is doing an action!");
            // Console.WriteLine($"{client?.Name}, is doing an action!");
        }







        private void DoNestedStuffWithClient(Client client)
        {
            ReportClient(client);
        }




        

        private void ReportClient(Client client)
        {
            DoNestedStuffWithClient(client);
        }
    }
}