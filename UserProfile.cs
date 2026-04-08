public class UserProfile
{

    public string GetArt()
    {
        string art = @"  ______   ______  _____ ____  ____   ___ _____ 
 / ___\ \ / / __ )| ____|  _ \| __ ) / _ \_   _|
| |    \ V /|  _ \|  _| | |_) |  _ \| | | || |  
| |___  | | | |_) | |___|  _ <| |_) | |_| || |  
 \____| |_| |____/|_____|_| \_\____/ \___/ |_|  ";

        return art;
    }


    public void PrintArt()
    {
        Console.WriteLine(GetArt());
    }
}
//Class UserProfile