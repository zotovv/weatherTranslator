using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherTranslator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите какое-либо слово о погоде на русском языке: ");
            string userWord = Console.ReadLine();

            switch(userWord)
            { 
                case "дождь": Console.WriteLine("rain");
                    break;
                case "снег":  Console.WriteLine("snow");
                    break;                   
                case "гроза": Console.WriteLine("storm");
                    break;                   
                case "жара":  Console.WriteLine("heat");
                    break;                    
                case "холод": Console.WriteLine("cold");
                    break;                  
                case "мороз": Console.WriteLine("frost");
                    break;                    
                case "облако": Console.WriteLine("cloud");
                    break;
                case "туча": Console.WriteLine("cloud");
                    break;                   
                case "ветер": Console.WriteLine("wind");
                    break;                   
                case "метель": Console.WriteLine("blizzard");
                    break;                   
                case "град": Console.WriteLine("hail");
                    break;
                    
                default:
                    Console.WriteLine("Такое слово я пока не знаю.");
                    break;
                    
            }

            Console.ReadKey();

        }
    }
}
