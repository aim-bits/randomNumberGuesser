using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\nThis is a Guessing Game Platform.");
            rightInput: // goto Label for wrong input of stage selection

            Console.Write("Which level would you like to try out? Easy, Medium or Hard? ");
            string levelChoice = Console.ReadLine();

            Random r = new Random(); // FOR GETTING A RANDOM NUMBER

            // ============================  STAGE 1; EASY ====================================
            if (levelChoice.ToLower() == "easy"){       // ToLower(); converting string entered to lower case
                Console.WriteLine("\nYou have to predict a Number between 1-10");
                int guessCounter = 6;
                Console.WriteLine("You have " + guessCounter + " guesses");
                for (int i = 0; i < 6; i++){
                    correctGuessInput:             // GOTO LABEL FOR WRONG INPUT NUMBER GUESSING

                    int randomNumGenerator = r.Next(1,10);          // RANGE OF RANDOM NUMBER; FROM 1 TO 10
                    Console.Write("Guess the random Number: ");
                    string guess = Console.ReadLine();
                    int newGuess = 0;
                    if(int.TryParse(guess, out newGuess)){            // CONVERTING GUESS STRING TO INTEGER
                        if (newGuess == randomNumGenerator){
                            Console.WriteLine("You got it right!");
                            Console.WriteLine("random number is "+ randomNumGenerator);
                        }else if (newGuess < 1 || newGuess > 10){
                            Console.WriteLine("Please enter a Number between 1 and 10\n");
                            goto correctGuessInput;
                        }else if(newGuess != randomNumGenerator ){
                            Console.WriteLine("That was wrong");
                            Console.WriteLine("random number is "+ randomNumGenerator);
                        }    
                    }else{
                        Console.WriteLine("Please enter a Number from 1-6");
                    }
                   
                    guessCounter--;
                    Console.WriteLine("You have " + guessCounter + " guesses\n");
                    if(guessCounter == 0 && newGuess != randomNumGenerator){
                        Console.WriteLine("Game Over");

                    }
                }    
                Console.Write("Do you wish to play again? yes or no: \n");
                    string replay = Console.ReadLine();
                    if(replay.ToLower() == "yes"){
                        goto rightInput;
                    }else if(replay.ToLower() == "no"){
                        Console.Clear();
                    }

            // ===========================  STAGE 2; MEDIUM  =====================================
            } else if  (levelChoice.ToLower() == "medium"){
                Console.WriteLine("\nYou have to predict a Number between 1-20");
                int guessCounter = 4;
                Console.WriteLine("You have " + guessCounter + " guesses");
                for (int i = 0; i < 4; i++){
                    int randomNumGenerator = r.Next(1,20);   // RANGE OF RANDOM NUMBERS; FROM 1 TO 20
                    correctGuessInput:                      // GOTO LABEL FOR WRONG INPUT NUMBER GUESSING

                    Console.Write("Guess the random Number: ");
                    string guess = Console.ReadLine();
                    int newGuess = 0;
                    if(int.TryParse(guess, out newGuess)){
                        if (newGuess == randomNumGenerator){
                            Console.WriteLine("You got it right!");
                            Console.WriteLine("random number is "+ randomNumGenerator);
                        }else if (newGuess < 1 || newGuess > 20){
                            Console.WriteLine("Please enter a Number between 1 and 20\n");
                            goto correctGuessInput;
                        }else if(newGuess != randomNumGenerator ){
                            Console.WriteLine("That was wrong");
                            Console.WriteLine("random number is "+ randomNumGenerator);
                        }
                    }else{
                        Console.WriteLine("Please enter a Number from 1-20");
                    }
                   
                    guessCounter--;
                    Console.WriteLine("You have " + guessCounter + " guesses\n");
                    if(guessCounter == 0 && newGuess != randomNumGenerator){
                        Console.WriteLine("Game Over");
                    }  
                }
                Console.Write("Do you wish to play again? yes or no: \n");
                string replay = Console.ReadLine();
                if(replay.ToLower() == "yes"){
                    goto rightInput;
                }else if(replay.ToLower() == "no"){
                    Console.Clear();               // STOP RUNNING ROGRAM
                }

            //========================  STAGE 3; HARD  =========================
            }else if(levelChoice.ToLower() == "hard"){
                Console.WriteLine("\nYou have to predict a Number between 1-50");
                int guessCounter = 3;
                Console.WriteLine("You have " + guessCounter + " guesses");
                for (int i = 0; i < 3; i++){
                    correctGuessInput:                // GOTO LABEL FOR WRONG INPUT NUMBER GUESSING

                    int randomNumGenerator = r.Next(1,50);
                    Console.Write("Guess the random Number: ");
                    string guess = Console.ReadLine();
                    int newGuess = 0;
                    if(int.TryParse(guess, out newGuess)){
                        if (newGuess == randomNumGenerator){
                            Console.WriteLine("You got it right!");
                            Console.WriteLine("random number is "+ randomNumGenerator);
                        }else if (newGuess < 1 || newGuess > 20){
                            Console.WriteLine("Please enter a Number between 1 and 20\n");
                            goto correctGuessInput;
                        }else if(newGuess != randomNumGenerator ){
                            Console.WriteLine("That was wrong");
                            Console.WriteLine("random number is "+ randomNumGenerator); 
                        }    
                    }else{
                        Console.WriteLine("Please enter a Number from 1-50");
                    }
                   
                    guessCounter--;
                    Console.WriteLine("You have " + guessCounter + " guesses\n");
                    if(guessCounter == 0 && newGuess != randomNumGenerator){
                        Console.WriteLine("Game Over");
                    }
                }
                Console.Write("Do you wish to play again? yes or no: \n");
                string replay = Console.ReadLine();
                if(replay.ToLower() == "yes"){
                    goto rightInput;
                }else if(replay.ToLower() == "no"){
                    Console.Clear();
                }
                
            // ===================== WHEN USER ENTERS WRONG STAGE SELECTION =================
            }else if (levelChoice != "easy"){
                Console.WriteLine("Please select either easy or medium or hard");
                goto rightInput;
            }else if (levelChoice != "medium"){
                Console.WriteLine("Please select either easy or medium or hard");
                goto rightInput;
            }else if (levelChoice != "hard"){
                Console.WriteLine("Please select either easy or medium or hard");
                goto rightInput;
            }
          
        
        }
    }
}
