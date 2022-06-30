using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputText=Console
                .ReadLine().Split(' ');
            var ran = new Random();

            for (int i = 0; i < inputText.Length; i++)
            {
                int raundomIndex=ran.Next(i,inputText.Length);
                string temp=inputText[i];
                inputText[i]=inputText[raundomIndex];
                inputText[raundomIndex]=temp;
            }
            Console.WriteLine(String.Join(Environment.NewLine,inputText));

        }
    }
}
