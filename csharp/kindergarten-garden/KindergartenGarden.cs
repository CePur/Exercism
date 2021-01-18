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
        var pots = list[(int)(Student)Enum.Parse(typeof(Student), student)];
        var result = new List<Plant>();

        foreach (var p in pots)
        {
            Plant plant = new Plant();

            switch (p.ToString())
            {
                case "V":
                    plant = Plant.Violets;
                    break;
                case "R":
                    plant = Plant.Radishes;
                    break;
                case "C":
                    plant = Plant.Clover;
                    break;
                case "G":
                    plant = Plant.Grass;
                    break;
            }

            result.Add(plant);
        }
        return result;
    }

    private List<string> ConvertDiagram(string diagram)
    {
        var str = diagram.Split("\n");
        var words = new List<string>();

        for (int i = 0; i < str[0].Length - 1; i = i + 2)
        {
            StringBuilder strBldr = new StringBuilder();
            strBldr.Append(str[0][i]);
            strBldr.Append(str[0][i + 1]);

            strBldr.Append(str[1][i]);
            strBldr.Append(str[1][i + 1]);

            words.Add(strBldr.ToString());
        }
        return words;
    }
}


