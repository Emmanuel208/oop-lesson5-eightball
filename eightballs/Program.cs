using System;
using System.Collections.Generic;

namespace eightballs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Welcome to eightball============");



            Console.WriteLine("Ask any question? Dont be shy.");

            string question = Console.ReadLine();

            //=========================================================RANDOM NUMBER GENERATOR====================================================================


            int randomNumber;

            Random random = new Random();

            randomNumber = random.Next(1, 21);

            //*note* Print to check if random number works
            Console.WriteLine($"Random number is {randomNumber}");


            //List of possible answers. {Making use of of *List*}

            List<string> listOfPosibleAnswers = new List<string>();

            //From this point, answers are affirmative answers
            listOfPosibleAnswers.Add("It is certain.");
            listOfPosibleAnswers.Add("It is decidedly so.");
            listOfPosibleAnswers.Add("without a doubt.");
            listOfPosibleAnswers.Add("Yes definitely.");
            listOfPosibleAnswers.Add("You may rely on it");
            listOfPosibleAnswers.Add("As i see it, yes.");
            listOfPosibleAnswers.Add("Most likey.");
            listOfPosibleAnswers.Add("Outlook good.");
            listOfPosibleAnswers.Add("Yes.");
            listOfPosibleAnswers.Add("Signs point to yes.");

            //From this point answers are non-committal answers
            listOfPosibleAnswers.Add("Reply hazy, try again.");
            listOfPosibleAnswers.Add("Ask again later.");
            listOfPosibleAnswers.Add("Better not tell you now.");
            listOfPosibleAnswers.Add("Cannot predict now.");
            listOfPosibleAnswers.Add("Concentrate and ask again.");

            //From this point answers are negative
            listOfPosibleAnswers.Add("Don't count on it.");
            listOfPosibleAnswers.Add("My replay is no.");
            listOfPosibleAnswers.Add("My sources say no.");
            listOfPosibleAnswers.Add("Outlook not so good.");
            listOfPosibleAnswers.Add("very doubtful");


            //check if the *[]* works
            //Console.WriteLine(listOfPosibleAnswers[3]);


            //========= if else statment to assign random number to answer =========

            //yes i know there is most likey a qiucker way to get this done but it works for now

            if(randomNumber == 1)

            {
                Console.WriteLine(listOfPosibleAnswers[0]);

            }else if (randomNumber == 2)
            {
                Console.WriteLine(listOfPosibleAnswers[1]);

            }
            else if (randomNumber == 3)
            {
                Console.WriteLine(listOfPosibleAnswers[2]);

            }
            else if (randomNumber == 4)
            {
                Console.WriteLine(listOfPosibleAnswers[3]);

            }
            else if (randomNumber == 5)
            {
                Console.WriteLine(listOfPosibleAnswers[4]);

            }
            else if (randomNumber == 6)
            {
                Console.WriteLine(listOfPosibleAnswers[5]);

            }
            else if (randomNumber == 7)
            {
                Console.WriteLine(listOfPosibleAnswers[6]);

            }
            else if (randomNumber == 8)
            {
                Console.WriteLine(listOfPosibleAnswers[7]);

            }
            else if (randomNumber == 9)
            {
                Console.WriteLine(listOfPosibleAnswers[8]);

            }
            else if (randomNumber == 10)
            {
                Console.WriteLine(listOfPosibleAnswers[9]);

            }
            else if (randomNumber == 11)
            {
                Console.WriteLine(listOfPosibleAnswers[10]);

            }
            else if (randomNumber == 12)
            {
                Console.WriteLine(listOfPosibleAnswers[11]);

            }
            else if (randomNumber == 13)
            {
                Console.WriteLine(listOfPosibleAnswers[12]);

            }
            else if (randomNumber == 14)
            {
                Console.WriteLine(listOfPosibleAnswers[13]);

            }
            else if (randomNumber == 15)
            {
                Console.WriteLine(listOfPosibleAnswers[14]);

            }
            else if (randomNumber == 16)
            {
                Console.WriteLine(listOfPosibleAnswers[15]);

            }
            else if (randomNumber == 17)
            {
                Console.WriteLine(listOfPosibleAnswers[16]);

            }
            else if (randomNumber == 18)
            {
                Console.WriteLine(listOfPosibleAnswers[17]);

            }
            else if (randomNumber == 19)
            {
                Console.WriteLine(listOfPosibleAnswers[18]);

            }
            else if (randomNumber == 20)
            {
                Console.WriteLine(listOfPosibleAnswers[19]);

            }



        }
    }
}
//Chukwuemeka Emmanuel Obasi 23606