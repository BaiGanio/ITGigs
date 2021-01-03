using System;

namespace _04.DecryptTheMessages
{
    class Program
    {
        // 1. Decrypt => Special characters are converted in the following way:
        //      ->     
        //      ->      N to Z => A to M
        //      ->      '+' => ' ' 
        //      ->      '%' => ','
        //      ->      ' A to M => N to Z &' => '.'
        //      ->      '#' => '?'
        //      ->      '$' => '!'
        //      ->      0-9 => stays the same
        //      ->      Letters are case sensitive
        // 2. Count Messages
        // 3. Between => 'Start' & 'End':
        //      - decrypt
        //      - show message content
        //      - count messages
        // •	On the first line print in format: “Total number of messages: N”
        //      – where N is the number of received and decrypted messages.
        // •	On the next N lines print the decrypted messages.
        // •	If no messages have been received print: “”
        static void Main()
        {
            // Input
            string someMessage = Console.ReadLine();

            // Logic
            bool endOfMessages = true;
            int messageCounter = 0;

            while (endOfMessages)
            {
                string decryptedMessage = Console.ReadLine();
                if (someMessage.Equals("START") || someMessage.Equals("start"))
                {
                    // ============================================================================= //   
                    if (decryptedMessage == "END" || decryptedMessage == "end")
                    {
                        endOfMessages = false;
                    }
                    // ============================================================================= // 
                    // ============================================================================= // 
                    if (string.IsNullOrEmpty(decryptedMessage))
                    {
                        messageCounter = 0;
                    }
                    else
                    {
                        messageCounter++;
                    }

                }
            }


            if (messageCounter == 0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", messageCounter);
            }
            
        }
    }
}
