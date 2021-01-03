using System;
using System.Collections.Generic;

namespace EncryptTheMessages
{
    internal class Program
    {
        private static void Main()
        {
            // The input data should be read from the console. The input will contain a random number of lines. The line that holds the keyword “START” or “start” will always be before the line that holds the keyword “END” or “end”. The input data will always be valid and in the format described. There is no need to check it explicitly.

            Dictionary<char, char> specialSymbolToBeReplaced = new Dictionary<char, char>()
            {
                {' ', '+'},
                {',', '%'},
                {'.', '&'},
                {'?', '#'},
                {'!', '$'}
            };

            List<string> encryptedMessages = new List<string>();

            string command = Console.ReadLine();

            while (command != "start" && command != "START")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            //Console.WriteLine(command);

            while (command != "end" && command != "END")
            {
                if (string.IsNullOrWhiteSpace(command))
                {
                    command = Console.ReadLine();
                    continue;
                }

                char[] messageToCharArray = command.ToCharArray();

                for (int i = 0; i < messageToCharArray.Length; i++)
                {
                    char currentChar = messageToCharArray[i];

                    if (specialSymbolToBeReplaced.ContainsKey(currentChar))
                    {
                        messageToCharArray[i] = specialSymbolToBeReplaced[currentChar];
                    }
                    else if (('a' <= currentChar && currentChar <= 'm') || ('A' <= currentChar && currentChar <= 'M'))
                    {
                        // +13 means =>  change 'a' to 'n'
                        messageToCharArray[i] = (char) (currentChar + 13);
                    }
                    else if (('n' <= currentChar && currentChar <= 'z') || ('N' <= currentChar && currentChar <= 'Z'))
                    {
                        // -13 means =>  change 'n' to 'a'
                        messageToCharArray[i] = (char) (currentChar - 13);
                    }
                }

                Array.Reverse(messageToCharArray);

                encryptedMessages.Add(new string(messageToCharArray));

                command = Console.ReadLine();
            }

            if (encryptedMessages.Count == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}",
                        encryptedMessages.Count);

                foreach (var message in encryptedMessages)
                {
                    Console.WriteLine(message);
                }
            }
            
        }
    }
}
