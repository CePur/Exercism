using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var array = nucleotide.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            switch (array[i])
            {
                case 'G' : 
                    array[i] = 'C';
                    break;
                case 'C' : 
                    array[i] = 'G';
                    break;                
                case 'T' : 
                    array[i] = 'A';
                    break;
                case 'A' : 
                    array[i] = 'U';
                    break;                
            }
        }

        return new string(array);
        
    }
}