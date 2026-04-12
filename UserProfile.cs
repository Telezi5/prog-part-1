using System;

public class UserProfile
{
    public string Name { get; set; }   // ✅ NEW

    public string GetArt()
    {
        string art = @"  __   __  __ __  __   __ ___ 
 / _\ \ / / _ )| __|  _ \| _ ) / _ \_   _|
| |    \ V /|  _ \|  | | |) |  _ \| | | || |  
| |_  | | | |) | |_|  _ <| |) | |_| || |  
 \_| || |_/|_|| \\_/ \_/ |_|  ";

        return art;
    }

    public void PrintArt()
    {
        Console.WriteLine(GetArt());
    }
}
//Class UserProfile