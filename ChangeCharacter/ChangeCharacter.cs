using System;

namespace ChangeCharacter
{
    public class Change
    {
        public void ChangeToChar()
        {
            Console.Write("Bir string ifade girin:");
            string[] inputArray= Console.ReadLine().Split(' ');
            string[] newInputArray= new string[inputArray.Length];
            
            for (int i = 0; i < inputArray.Length; i++)
            {   
                if (inputArray[i].Length<=1)
                {
                    newInputArray[i]=inputArray[i];
                }
                else
                {
                    char firstChar= inputArray[i][0];
                    char lastChar= inputArray[i][inputArray[i].Length-1];
                    string newWord= lastChar + inputArray[i].Substring(1,inputArray[i].Length-2)+firstChar;
                    newInputArray[i]=newWord;
                }
            }
            foreach (var item in newInputArray)
            {
                Console.Write(item+" ");
            }
        }
    }
}