using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public enum Student
{

    Alice, Bob, Charlie, David,
    Eve, Fred, Ginny, Harriet,
    Ileana, Joseph, Kincaid, Larry

}

public class KindergartenGarden
{
    private readonly string diagram;
    public KindergartenGarden(string diagram)
    {
        this.diagram = diagram;
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var list = ConvertDiagram(diagram);
        var pots = list[];
    }

    private List<string> ConvertDiagram(string diagram)
    {
        var lst = new List<string>();

        var str = diagram.Split("\n");

        var words = new List<string>();

        for (int i = 0; i < str[0].Length - 1; i = i + 2)
        {
            string word = "";
            word.Append(str[0][i]);
            word.Append(str[0][i + 1]);

            word.Append(str[1][i]);
            word.Append(str[1][i + 1]);

            words.Add(word);
        }

        return words;

    }



}