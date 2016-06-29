public class PrimitiveTypes
{
    public void DoExample()
    {
        //  what if client doesn't exist?
        int id = GetCurrentClientId();
        DoStuffWithClientId(id);

        // so, we handle non-client situation
        int? maybeId = GetCurrentClientId2();

        if (maybeId.HasValue)
        {
            DoStuffWithClientId(maybeId.Value);
        }
        else
        {
            // handle non id situation
        }
    }

    public int GetCurrentClientId()
    {
        return 5;
    }

    public int? GetCurrentClientId2()
    {
        return null;
    }


    private void DoStuffWithClientId(int clientId)
    {
        // do some stuff
    }
}