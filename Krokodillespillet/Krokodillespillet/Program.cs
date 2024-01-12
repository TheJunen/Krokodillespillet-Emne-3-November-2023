// See https://aka.ms/new-console-template for more information
namespace Krokodillespillet
{
    class Program
    {
       static void Main(string[] args)
        {
            Program oppg = new Program();
            oppg.Krokodillespillet();
        }

        
       int poengsum = 0;
       public void Krokodillespillet()
        {
            Random haha = new Random();
            var yaya = haha.Next(2, 11);
            var koko = haha.Next(2, 11);
            Console.WriteLine("Write '<' if second number is larger, '=' if they are equal and '>' if first number is larger. One point will be added to score if correct, one point will be subtracted if wrong. The game is infinitive as long as you don't write other characters.");
            Console.WriteLine(yaya + "_" + koko);
            var yo = Console.ReadLine();
            if (yaya == koko && yo == "=")
            {
                poengsum++;
                Console.WriteLine("Du valgte riktig svar, og et poeng er lagt til i poengsum");
                Console.WriteLine("Poengsum er nå:" + " " + poengsum);
                Krokodillespillet();
            }
            else if (yaya < koko && yo == "<")
            {
                poengsum++;
                Console.WriteLine("Du valgte riktig svar, og et poeng er lagt til i poengsum");
                Console.WriteLine("Poengsum er nå:" + " " + poengsum);
                Krokodillespillet();
            }
            else if (yaya > koko && yo == ">")
            {
                poengsum++;
                Console.WriteLine("Du valgte riktig svar, og et poeng er lagt til i poengsum");
                Console.WriteLine("Poengsum er nå:" + " " + poengsum);
                Krokodillespillet();
            }
            else if(yo != "=" && yo != "<" && yo != ">")
            {
                poengsum--;
                Console.WriteLine("Incorrect input! Game over. Final score: " + poengsum);
            }
            else
            {
                poengsum--;
                Console.WriteLine("Du valgte feil svar, og et poeng er trukket fra poengsum");
                Console.WriteLine("Poengsum er nå:" + " " + poengsum);
                Krokodillespillet();
            }
        }
    }
}