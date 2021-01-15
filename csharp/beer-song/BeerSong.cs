using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new StringBuilder();
        string bWord = "bottles";
        string bWord2 = "bottles";
        string cWord = "one";
        string dWord = "";

        for (int i = 1; i <= takeDown; i++)
        {

            if (startBottles - i < 0)
            {
                sb.Append($"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.");
                break;
            }

            dWord = (startBottles - i).ToString();

            if (startBottles - i <= 1)
            {
                bWord2 = "bottle";
            }

            if (startBottles - i == 0)
            {
                bWord = "bottle";
                cWord = "it";
                dWord = "no more";
                bWord2 = "bottles";
            }

            sb.Append($"{startBottles - i + 1} {bWord} of beer on the wall, {startBottles - i + 1} {bWord} of beer.\nTake {cWord} down and pass it around, {dWord} {bWord2} of beer on the wall.");

            if (takeDown - i > 0)
            {
                sb.Append("\n\n");
            }
        }

        return sb.ToString();
    }
}