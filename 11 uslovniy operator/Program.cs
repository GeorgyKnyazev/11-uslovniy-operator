using System;

namespace _11_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            char firstsymbol = '(';
            int lenghtText;
            int maximumNumberOfConsecutiveCharacters = 0;
            int numberOfConsecutiveCharacters = 0;
            Console.WriteLine("Введите последовательность символов ( и )");
            inputText = Console.ReadLine();
            lenghtText = inputText.Length;
            Console.WriteLine(lenghtText);
                       
            for (int i = 0; i < lenghtText; i++)
            {
                if (inputText[i] == firstsymbol)
                {
                    numberOfConsecutiveCharacters++;
                }
                else
                {
                    numberOfConsecutiveCharacters--;
                    if (numberOfConsecutiveCharacters < 0)
                    {
                        break;
                    }
                }
                if (numberOfConsecutiveCharacters > maximumNumberOfConsecutiveCharacters)
                {
                        maximumNumberOfConsecutiveCharacters = numberOfConsecutiveCharacters;
                }
            }
            if (numberOfConsecutiveCharacters == 0)
            {
                Console.WriteLine("строка коректна. Максимальная глубина: " + maximumNumberOfConsecutiveCharacters);
            }
            else
            {
                Console.WriteLine("Строка не коректна");
            }
            
           
        }
    }
}
