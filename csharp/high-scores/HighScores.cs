using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> completeList { get; private set; }

    public HighScores(List<int> list) => completeList = list;

    public List<int> Scores() => completeList;

    public int Latest() => completeList.Last();

    public int PersonalBest() => completeList.Max();

    public List<int> PersonalTopThree() => completeList.OrderByDescending(i => i).Take(3).ToList();

}