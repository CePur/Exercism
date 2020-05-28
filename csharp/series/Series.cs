using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength < 1 || string.IsNullOrWhiteSpace(numbers) || sliceLength > numbers.Length)
            throw new ArgumentException();

        int arraySize =numbers.Length - sliceLength + 1;

        string[] answer = new string[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            answer[i] = numbers.Substring(i, sliceLength);
        }

        return answer;
    }
}