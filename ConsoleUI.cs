using Prog_part_1.Services;

public class ConsoleUI
{
    private AudioPlayer _audioPlayer;
    private ResponseServices _responseService;
    private UserProfile _userProfile;
    public ConsoleUI()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        _userProfile = new UserProfile();
        _audioPlayer = new AudioPlayer();
        _responseService = new ResponseServices();
    }

    public void Start()
    {
        _userProfile.PrintArt();
        _audioPlayer.Greetings();

        Console.WriteLine("Welcome to CyberBot!");

        while (true)
        {
            Console.Write("You:  ");
            string userInput = Console.ReadLine();


            string response = _responseService.GetResponse(userInput);
            Console.WriteLine("Bot: " + response);
        }
    }
}
