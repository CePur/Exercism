using System.Collections.Generic;

public static class ProteinTranslation
{
    private readonly static Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            { "AUG","Methionine" },
            { "UUU","Phenylalanine" },
            { "UUC","Phenylalanine" },
            { "UUA","Leucine" },
            { "UUG","Leucine" },
            { "UCU","Serine" },
            { "UCC","Serine" },
            { "UCA","Serine" },
            { "UCG","Serine" },
            { "UAU","Tyrosine" },
            { "UAC","Tyrosine" },
            { "UGU","Cysteine" },
            { "UGC","Cysteine" },
            { "UGG","Tryptophan" },
            { "UAA","STOP" },
            { "UAG","STOP" },
            { "UGA","STOP" }

        };


    public static string[] Proteins(string strand)
    {
        var list = new List<string>();

        for (int i = 0; i < strand.Length; i += 3)
        {
            var protein = dict[strand.Substring(i, 3)];
            if (protein == "STOP") break;
            list.Add(protein);
        }

        return list.ToArray();
    }

}