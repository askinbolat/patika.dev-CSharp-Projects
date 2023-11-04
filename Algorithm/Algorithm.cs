using System;

namespace algorithm
{
    public class RemoveCharacter
    {
        public void Remove()
        {
        
            Console.WriteLine("Aralarında virgül kullanarak bir ifade ve bir sayı giriniz: ");
            string input=Console.ReadLine();
            
            string[] inputArray = input.Split(',');
            string word =inputArray[0];
            int number =int.Parse(inputArray[1]);

            if (word.Length>number)
            {
                string newWord =word.Remove(number,1);
                Console.WriteLine(newWord);
            }
            else
            {
                Console.WriteLine(word);
            }
            
        }
    }
}

