// Richard Johnson
// 10-20-22

// This is where we declare our variables
bool playAgain = true;
int num;
int difficulty;
int easy = 11;
int medium = 51;
int hard = 101;
int winningNum = 0;
int maximum = 0;
int guess = 0;
int guessCount = 0;
string input;
string? option;
bool validNum = false;
bool isNumber;


    Console.WriteLine("Want to Guess what Number I'm thinking of?");
    Console.Write("Type YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
    isNumber = Int32.TryParse(yesNo, out num);

// This while loop will run as long as playAgain is true
while(playAgain == true)
{

        if(yesNo == "NO" && isNumber != true)
        {
            // If the user types NO
            Console.WriteLine("Maybe another time, then.");
            Console.WriteLine(" ");
            playAgain = false;
        }
        else if(yesNo == "YES" && isNumber != true)
        {
            // If the user types YES, the program will ask them to choose a difficulty
            Console.WriteLine("Alright.");
            Console.WriteLine(" ");
            Console.WriteLine("Do you want Easy, Medium, or Hard?");
            Console.WriteLine(" ");
            Console.WriteLine("Easy: Between 1 and 10");
            Console.WriteLine("Medium: Between 1 and 50");
            Console.WriteLine("Hard: Between 1 and 100");
            Console.Write("Difficulty: ");
            option = Console.ReadLine();
            option = option.ToUpper();
            
            while (option != "EASY" && option != "MEDIUM" && option != "HARD")
            {
                //
                Console.WriteLine("Invalid Input.");
                Console.Write("Please select EASY, MEDIUM, or HARD: ");
                option = Console.ReadLine();
                option = option.ToUpper();
            }
            Console.WriteLine($"You chose {option}.");

            Random random = new Random();

            if (option == "EASY")
            {
                // if EASY is chosen, the player will guess from 10 numbers
                winningNum = random.Next(1, easy);
                maximum = easy - 1;
            }
            if (option == "MEDIUM")
            {
                // if MEDIUM is chosen, the player will guess from 50 numbers
                winningNum = random.Next(1, medium);
                maximum = medium - 1;
            }
            if(option == "HARD")
            {
                // if HARD is chosen, the player will guess from 100 numbers
                winningNum = random.Next(1, hard);
                maximum = hard - 1;
            }

            while(validNum == false)
            {
                guess = 0;
                Console.Write($"Enter a number between 1 and {maximum}: ");
                input = Console.ReadLine();
                validNum = Int32.TryParse(input, out guess);
                if (validNum == true)
                {
                    if((guess <= maximum) &&(guess >= 1))
                    {
                        //
                        validNum = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Input: Please pick a whole number in the established range.");
                        validNum = false;
                        guessCount++;
                    }
                }
                else
                {
                    // 
                    Console.WriteLine("Invalid Input: Please pick a whole number");
                    guessCount++;
                }
                
            }
            while(validNum == true)
            {
                //
                if(guess == winningNum)
                {
                    guessCount++;
                    Console.WriteLine($"{winningNum} is the correct answer!");
                    Console.WriteLine($"It took {guessCount} attempts to find it.");
                    Console.WriteLine($" ");
                    Console.Write($"Do you want to play again? YES or NO:");
                    guessCount = 0;
                    input = Console.ReadLine();
                    input = input.ToUpper();
                    
                        if(input == "NO")
                        {
                            // If the user answers NO, the program will set the bools to false and end
                            Console.WriteLine("Then it is time to say goodbye");
                            validNum = false;
                            playAgain = false;
                        }
                        else if (input == "YES")
                        {
                            // If the user answers YES, the program will reset and allow them to play again
                            Console.WriteLine("Good.");
                            validNum = false;
                            playAgain = true;
                            guess = 0;
                        }
                        else
                        {
                            // If the player types something aside from YES or NO, the program will loop until they answer either YES or NO
                            Console.WriteLine("I said answer YES or NO.");
                        }

                }else if(guess > winningNum)
                {
                    // If the user's guess is too high, the program will inform them it is too high
                    Console.WriteLine("That guess is too high.");
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                    validNum = Int32.TryParse(input, out guess);
                    guessCount++;
                }
                else
                {
                    //
                    Console.WriteLine("That guess is too low.");
                    Console.WriteLine("Please try again: ");
                    input = Console.ReadLine();
                    validNum = Int32.TryParse(input, out guess);
                    guessCount++;
                }
            }

        }
        else
        {
            // If the user types something aside from YES or NO
            Console.WriteLine("Please type YES or NO");
        }

}