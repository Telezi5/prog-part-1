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

        // Ask for name
        Console.Write("Enter your name: ");
        _userProfile.Name = Console.ReadLine();

        // Pass name to chatbot
        _responseService.SetUserName(_userProfile.Name);

        Console.WriteLine($"Welcome to CyberBot, {_userProfile.Name}!");

        while (true)
        {
            // ✅ Name instead of "You"
            Console.Write($"{_userProfile.Name}: ");
            string userInput = Console.ReadLine();

            // ✅ Exit condition
            if (userInput.ToLower().Contains("bye"))
            {
                string response = _responseService.GetResponse(userInput);
                Console.WriteLine("Bot: " + response);
                break; // ends the app
            }

            string responseNormal = _responseService.GetResponse(userInput);
            Console.WriteLine("Bot: " + responseNormal);
        }
    }
}