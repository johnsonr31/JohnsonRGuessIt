// Richard Johnson
// 10-20-22

// This is where we establish our variables
bool playAgain = true;
int num;
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


// This while loop will run as long as playAgain is true
while(playAgain == true)
{
    //
    Console.WriteLine("Want to Guess what Number I'm thinking of?");
    Console.Write("Type YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();
    isNumber = Int32.TryParse(yesNo, out num);

        if(yesNo == "NO" && isNumber != true)
        {
            // If the user types NO
            Console.WriteLine("Maybe another time, then.");
            Console.WriteLine(" ");
            playAgain = false;
        }
        else if(yesNo == "YES" && isNumber != true)
        {
            // If the user types YES
            Console.WriteLine("Alright.");
            Console.WriteLine(" ");
            Console.WriteLine("Do you want Easy Mode, Medium Mode, or Hard Mode");
            Console.WriteLine("Difficulty: ");
            input = Console.ReadLine();
            isNumber = Int32.TryParse(input, out num);

        }
        else
        {
            // If the user types something aside from YES or NO
        }

}