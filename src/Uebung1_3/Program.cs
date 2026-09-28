// ------------------------------
// Uebung1_3
// ------------------------------

namespace Uebung1_3;

class Program
{   
    static int GetNote(int points)
    {
        int note = 0;

        if (points < 12)
            {
                note = 5;
            }
            
            else if (points >= 12 && points < 15)
            {
                note = 4;
            }

            else if (points >= 15 && points < 18)
            {
                note = 3;
            }

            else if (points >= 18 && points < 21)
            {
                note = 2;
            }

            else if (points >= 21)
            {
                note = 1;
            }
        return note;
    }

    static string getNoteText()
    {
        
    }

    static void Main(string[] args)
    {
       string[] namen = {"Mayer","Huber","Gruber"};
       int[] punkte = {21,18,15};

       /*for(int i = 0; i < 3; i++)
        {
            if (punkte[i] < 12)
            {
                Console.WriteLine($"{namen[i]}: 5 (Nicht genügend)");
            }
            
            else if (punkte[i] >= 12 && punkte[i] < 15)
            {
                Console.WriteLine($"{namen[i]}: 4 (Genügend)");
            }

            else if (punkte[i] >= 15 && punkte[i] < 18)
            {
                Console.WriteLine($"{namen[i]}: 3 (Befriedigend)");
            }

            else if (punkte[i] >= 18 && punkte[i] < 21)
            {
                Console.WriteLine($"{namen[i]}: 2 (Gut)");
            }

            else if (punkte[i] >= 21)
            {
                Console.WriteLine($"{namen[i]}: 1 (Sehr Gut)");
            }
        } */
        for(int i = 0; i < 3; i++)
        {
            GetNote(punkte[i]);   
        }
    }
}
