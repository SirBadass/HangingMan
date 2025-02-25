using System;
using System.Linq;

namespace HangingMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hanging man game

            Random rnd = new Random();

            bool eject = false;
            bool handlerWizard = false;

            bool randomQuestionMark = false;

            bool winQuestionMark = false;

            int difficulty = 0;

            string[] wordsDifficultyQuestionMark = null;
            string[] censorshipEngagedWord = null;
            string[] winWord = null;

            string pickedWord = string.Empty;


            string alphabet = "A B C D E F G L M N O P Q R S T U V W X Y Z";
            int health = 7;

            string easyWords = "Dog Cat Hat Sun Tree Car Fish Bird Moon Cup Apple Mop Star Be Shoe Ball Fox Bush Frog Deer Rock Rain Cap Bed Fan Poo Bee Milk Start Cake Bus Pencil Spoon Van Pear Book Duck Egg Flag Ship Soap Lamp Bread Pot Rose Boot Mug Key Hand Nail Doll Bag Fig Ho Hat Net Nook Star Bo Toad Boat Car Cup Pen Tree Boa Bat Fork Bell Sun Kit Drum Hen Ice Coat";
            string mediumWords = "Python Bumblebee Unicorn Octopus Elephant Jigsaw Galaxy Platypus Falcon Trampoline Igloo Telescope Tyrannosaurus Carousel Lighthouse Parachute Rollercoaster Metamorphosis Galapagos Narwhal Raccoon Marzipan Thermometer Chrysanthemum Iguana Asteroid Gyroscope Mill Noble Blunderbuss Musket Charisma Bombard Folk";
            string expertWords = "Hypnosis Baguette Pterodactyl Fjord Chandelier Pharaoh Kaleidoscope Apothecary Eccentric Chimera Photosynthesis Hologram Atmosphere Nephilim Millennium Centrifugal Phonograph Semaphore Bioluminescence Circumference Electromagnetism Archaeology Fibonacci Parley Handgonne Windlass";

            string[] easyDifficultyWords = easyWords.ToUpper().Split(' ');
            string[] mediumDifficultyWords = mediumWords.ToUpper().Split(' ');
            string[] expertDifficultyWords = expertWords.ToUpper().Split(' ');

            while (eject.Equals(false))
            {
                Console.Write("Please select your difficulty:\n Let me play daddy - 1\n Hard - 2\n Le Expert - 3\nDifficulty - ");                //difficulty selection
                while (handlerWizard.Equals(false))
                {
                    string difficultySelection = Console.ReadLine();
                    switch (difficultySelection)
                    {
                        case "1": Console.Write("Baby difficulty: on..."); difficulty = 1; handlerWizard = true; break;
                        case "2": Console.WriteLine("Good."); difficulty = 2; handlerWizard = true; break;
                        case "3": Console.WriteLine("Wow, Le experto here! We'll see how you will do smarty."); difficulty = 3; handlerWizard = true; break;
                        default: Console.WriteLine("Enter valid number!"); break;
                    }
                }
                handlerWizard = false;

                while (handlerWizard.Equals(false))
                {
                    Console.Write("Do you want to use RANDOM word or nah?\n Aye - 1\n No - 2\nSelection - ");                                      //random selection
                    string randomSelection = Console.ReadLine();
                    switch (randomSelection)
                    {
                        case "1": randomQuestionMark = true; handlerWizard = true; break;
                        case "2": randomQuestionMark = false; handlerWizard = true; break;
                        default: Console.WriteLine("Invalid selection, please try again."); break;
                    }
                }



                //difficulty logic
                switch (difficulty)
                {
                    case 1: wordsDifficultyQuestionMark = easyDifficultyWords; break;
                    case 2: wordsDifficultyQuestionMark = mediumDifficultyWords; break;
                    case 3: wordsDifficultyQuestionMark = expertDifficultyWords; break;
                }




                //random logic
                switch (randomQuestionMark)
                {
                    case true:
                        int randomPick = rnd.Next(wordsDifficultyQuestionMark.Length);
                        pickedWord = wordsDifficultyQuestionMark[randomPick]; break;                                          //used to solve win/loss
                    case false:
                        while (pickedWord != null)
                        {
                            Console.WriteLine("Number of words: " + wordsDifficultyQuestionMark.Length + "\nBear in mind, that number will be lower by one!");
                            Console.Write("Enter number of your word: ");
                            int number = int.Parse(Console.ReadLine()) - 1;
                            if (number > -1 && number < wordsDifficultyQuestionMark.Length) { pickedWord = wordsDifficultyQuestionMark[number]; break; };
                        }
                        break;
                }

                //engage censorship!
                int wordLength = pickedWord.Length;

                censorshipEngagedWord = new string[pickedWord.Length];
                winWord = new string[pickedWord.Length];
                for (int i = 0; i < pickedWord.Length; i++)
                {
                    censorshipEngagedWord[i] = "_";
                    winWord[i] = pickedWord[i].ToString();
                }





                // game logic
                while (winQuestionMark.Equals(false))
                {
                    Console.WriteLine("\nThe word has been picked, let's play!\nThere will be an alphabet to make it easyier for you!");
                    Console.WriteLine("Now, enter any symbol and pray that your hangman won't swing at the gallows:\n" + $"HP - {health}\n{alphabet}\n");

                    for (int i = 0; i < censorshipEngagedWord.Length; i++)
                    {
                        Console.Write(censorshipEngagedWord[i] + " ");
                    }
                    Console.WriteLine();

                    string userSymbol = Console.ReadLine().ToUpper();
                    switch (userSymbol)
                    {
                        case "A": alphabet = alphabet.Replace("A", "_"); break;
                        case "B": alphabet = alphabet.Replace("B", "_"); break;
                        case "C": alphabet = alphabet.Replace("C", "_"); break;
                        case "D": alphabet = alphabet.Replace("D", "_"); break;
                        case "E": alphabet = alphabet.Replace("E", "_"); break;
                        case "F": alphabet = alphabet.Replace("F", "_"); break;
                        case "G": alphabet = alphabet.Replace("G", "_"); break;
                        case "H": alphabet = alphabet.Replace("H", "_"); break;
                        case "I": alphabet = alphabet.Replace("I", "_"); break;
                        case "J": alphabet = alphabet.Replace("J", "_"); break;
                        case "K": alphabet = alphabet.Replace("K", "_"); break;
                        case "L": alphabet = alphabet.Replace("L", "_"); break;
                        case "M": alphabet = alphabet.Replace("M", "_"); break;
                        case "N": alphabet = alphabet.Replace("N", "_"); break;
                        case "O": alphabet = alphabet.Replace("O", "_"); break;
                        case "P": alphabet = alphabet.Replace("P", "_"); break;
                        case "Q": alphabet = alphabet.Replace("Q", "_"); break;
                        case "R": alphabet = alphabet.Replace("R", "_"); break;
                        case "S": alphabet = alphabet.Replace("S", "_"); break;
                        case "T": alphabet = alphabet.Replace("T", "_"); break;
                        case "U": alphabet = alphabet.Replace("U", "_"); break;
                        case "V": alphabet = alphabet.Replace("V", "_"); break;
                        case "W": alphabet = alphabet.Replace("W", "_"); break;
                        case "X": alphabet = alphabet.Replace("X", "_"); break;
                        case "Y": alphabet = alphabet.Replace("Y", "_"); break;
                        case "Z": alphabet = alphabet.Replace("Z", "_"); break;
                        case "": userSymbol = string.Empty; break;
                        default: userSymbol = string.Empty; break;
                    }

                    if (userSymbol != string.Empty)
                    {
                        for (int i = 0; i < censorshipEngagedWord.Length; i++)
                        {

                            if (pickedWord[i].Equals(userSymbol[0]))
                            {
                                censorshipEngagedWord[i] = userSymbol;
                            }

                        }
                        if (pickedWord.Contains(userSymbol[0]) == false) { health--; }


                        if (health.Equals(0)) // loss condition
                        {
                            Console.Clear();
                            Console.WriteLine("You lost!\n");
                            winQuestionMark = true;
                            break;
                        }


                        if (!censorshipEngagedWord.Contains("_")) //win condition
                        {
                            Console.Clear();
                            Console.WriteLine("You won!\n");
                            winQuestionMark = true;
                            break;
                        }
                    }
                    else { Console.WriteLine("Invalid symbol, try again."); }
                    Console.Clear();
                }
            }
        }
    }
}
