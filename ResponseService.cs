using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_part_1.Services
{
    public class ResponseServices
    {
        private string userName = "";   // ✅ NEW

        public void SetUserName(string name)   // ✅ NEW
        {
            userName = name;
        }

        public string GetResponse(string respond)
        {
            respond = respond.ToLower();

            if (respond.Contains("hello"))
            {
                return $"Hello {userName}! Welcome to CyberBot, how are you doing?";
            }
            else if (respond.Contains("good"))
            {
                return $"I'm also doing great, {userName}!";
            }
            else if (respond.Contains("what can i ask"))
            {
                return "You can ask me about passwords ,updates ,backups ,phishing ,social media ,privacy ,public wifi ,downloads ,vpn ,antivirus ,hack ,two factor and safe browsing.";
            }

            else if (respond.Contains("passwords"))
            {
                return "Strong passwords should be at least 8–12 characters long, include uppercase and lowercase letters, numbers, and symbols. Avoid using personal information like your name or birthdate, and never reuse passwords across different accounts.";
            }

            else if (respond.Contains("updates"))
            {
                return "Keeping your software updated is important because updates often fix security vulnerabilities and improve performance.";
            }

            else if (respond.Contains("backups"))
            {
                return "Regularly back up your important data to avoid losing it in case of a cyber attack or hardware failure.";
            }

            else if (respond.Contains("phishing"))
            {
                return "Phishing is when attackers try to trick you into giving personal information like passwords or bank details. Always check the sender’s email address, avoid clicking suspicious links, and never share sensitive information online unless you're sure the source is safe.";
            }

            else if (respond.Contains("social media"))
            {
                return "Be careful what you share on social media. Avoid posting personal details like your location, phone number, or travel plans.";
            }

            else if (respond.Contains("privacy"))
            {
                return "Always review your privacy settings on apps and websites to control who can see your personal information.";
            }

            else if (respond.Contains("safe browsing"))
            {
                return "Safe browsing means protecting yourself online by using secure websites (look for HTTPS), avoiding unknown downloads, keeping your antivirus updated, and not clicking on suspicious ads or pop-ups.";
            }

            else if (respond.Contains("vpn"))
            {
                return "A VPN (Virtual Private Network) encrypts your internet connection and helps protect your privacy, especially when using public Wi-Fi.";
            }

            else if (respond.Contains("public wifi"))
            {
                return "Public Wi-Fi can be risky. Avoid logging into sensitive accounts and consider using a VPN to keep your data secure.";
            }

            else if (respond.Contains("download"))
            {
                return "Only download files from trusted sources. Malicious downloads can contain viruses or spyware that harm your device.";
            }

            else if (respond.Contains("2fa") || respond.Contains("two factor"))
            {
                return "Two-factor authentication (2FA) adds an extra layer of security by requiring a second form of verification, like a code sent to your phone. It helps protect your accounts even if your password is stolen.";
            }

            else if (respond.Contains("hack") || respond.Contains("hacked"))
            {
                return "If you think you've been hacked, immediately change your passwords, enable two-factor authentication, and check your accounts for suspicious activity.";
            }

            else if (respond.Contains("antivirus"))
            {
                return "Antivirus software helps detect and remove malicious programs. Make sure to keep it updated and run regular scans to stay protected.";
            }

            else if (respond.Contains("thank"))
            {
                return $"You're welcome, {userName}! Please stay safe online ";
            }

            else if (respond.Contains("bye"))
            {
                return $"Goodbye {userName}! Have a safe and secure day!";
            }

            else
            {
                return "I didn't quite understand that. Could you rephrase?";
            }
        }
    }
}