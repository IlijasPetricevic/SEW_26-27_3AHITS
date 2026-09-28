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

    static string GetNoteText(int note)
    {
        string noteText = "";

        if (note == 5)
        {
            noteText = "Nicht genügend";
        }

        else if (note == 4)
        {
            noteText = "Genügend";
        }

        else if (note == 3)
        {
            noteText = "Befriedigend";
        }

        else if (note == 2)
        {
            noteText = "Gut";
        }

        else if (note == 1)
        {
            noteText = "Sehr gut";
        }

        return noteText;
    }

    static void Main(string[] args)
    {
        string[] namen = {"Mayer", "Huber", "Gruber"};
        int[] punkte = {21, 18, 15};
        int note = 0;
        string noteText = "";


        for (int i = 0; i < 3; i++)
        {
            note = GetNote(punkte[i]);
            noteText = GetNoteText(note);

            Console.WriteLine($"{namen[i]}: {note} {noteText}");
        }
    }
}
