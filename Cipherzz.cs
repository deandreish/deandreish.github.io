using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading;


namespace Substitution_Cipher
{
    class Game
    {
        string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789 ";
        string Substitute = "cjgiv95xq14zybou8ls0pehkw7 dmft2a3nr6";
        public void Start()
        {
            WriteLine("Are you encoding or decoding a message? A for encode, C for decode, Exit to exit the program.");
            string Answer = ReadLine();
            if (Answer.ToLower() == "a")
            {
                Encode();
            }
            else if (Answer.ToLower() == "c")
            {
                Decode();
            }
            else if (Answer.ToLower() == "exit")
            {
                Environment.Exit(0);
            }
            else
            {
                WriteLine("Improper response.");
                Start();
            }
            
        }
        public void Decode()
        {
            //Ask user for message/prompt, and then encode the message.
            WriteLine("What is your message? ");
            string Message = ReadLine().ToLower();
            string CodedMessage = "";
            char[] MessageCharArray = Message.ToCharArray();
            char[] SubstituteCharArray = Substitute.ToCharArray();
            char[] AlphabetCharArray = Alphabet.ToCharArray();
            for (int i = 0; i < MessageCharArray.Length; i++)
            {
                //Determine the character used in the current message character
                int CurrentIndex = Array.IndexOf(SubstituteCharArray, MessageCharArray[i]);
                string ReplacedCharacter = AlphabetCharArray[CurrentIndex].ToString();
                //WriteLine($"{MessageCharArray[i]}={CurrentIndex}->{ReplacedCharacter}");
                CodedMessage += ReplacedCharacter;
            }
            WriteLine(CodedMessage);
            Intermission();
        }
        public void Encode()
        {
            //Ask user for message/prompt, and then encode the message.
            WriteLine("What is your message? ");
            string Message = ReadLine().ToLower();
            string CodedMessage = "";
            char[] MessageCharArray = Message.ToCharArray();
            char[] SubstituteCharArray = Substitute.ToCharArray();
            char[] AlphabetCharArray = Alphabet.ToCharArray();
            for (int i = 0; i < MessageCharArray.Length; i++)
            {
                //Determine the character used in the current message character
                int CurrentIndex = Array.IndexOf(AlphabetCharArray, MessageCharArray[i]);
                string ReplacedCharacter = SubstituteCharArray[CurrentIndex].ToString();
                //WriteLine($"{MessageCharArray[i]}={CurrentIndex}->{ReplacedCharacter}");
                CodedMessage += ReplacedCharacter;
            }
            WriteLine(CodedMessage);
            Intermission();
        }
        public void Intermission()
        {
            WriteLine("Do you have another message?");
            string Answer = ReadLine();
            if (Answer.ToLower() == "yes")
            {
                WriteLine("Taking you back to the main menu...");
                Start();
            }
            else if (Answer.ToLower() == "no")
            {
                WriteLine("Alright, have a good day :)");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {
                WriteLine("I'm sorry, I didn't hear that.");
                Intermission();
            }
        }
    }
}
