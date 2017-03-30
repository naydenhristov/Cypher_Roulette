using System;

namespace Task17_Cypher_Roulette
{
    class Cypher_Roulette
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string  prevWord = (Console.ReadLine());
            
            string firstString = "", secondString = "", result = "";
            byte counterSpins = 0;
            int startValue = 0;

            if (prevWord.CompareTo("spin") != 0)
            {
                result = prevWord;
                startValue++;
            }
            else
            {
                counterSpins++;
            }
            
            for (int i = startValue; i < n; i++)
            {
                string currentWord = (Console.ReadLine());

                if (currentWord.CompareTo(prevWord) == 0)
                {
                    result = "";
                    firstString = "";
                    secondString = "";
                    counterSpins = 0;
                    if (currentWord.CompareTo("spin") == 0)
                    {
                        i--;
                        currentWord = "";
                    }
                }
                else if (counterSpins % 2 == 0)
                {
                    if (currentWord.CompareTo("spin") == 0)
                    {
                        counterSpins++;
                        secondString = result;
                        firstString = "";
                        i--;
                    }
                    else
                    {
                        firstString = result;
                        secondString = currentWord;
                    }
                }
                else
                {
                    if (currentWord.CompareTo("spin") == 0)
                    {
                        counterSpins++;
                        firstString = result;
                        secondString = "";
                        i--;
                    }
                    else
                    {
                        secondString = result;
                        firstString = currentWord;
                    }
                }
                                
                result = firstString + secondString;
                prevWord = currentWord;
                }
            
            Console.WriteLine(result);
        } 
    }
}
