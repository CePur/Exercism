using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        int binary = int.Parse(Convert.ToString(commandValue, 2));
        var strList = new List<string>();
        string word = "";

        var reserved = binary > 10000 ? true : false;
        if (reserved == true) binary = binary - 10000;

        for (int i = 0; i < 4; i++)
        {
            if (binary % 10 == 1)
            {
                switch (i)
                {
                    case 0:
                        word = "wink";
                        break;

                    case 1:
                        word = "double blink";
                        break;
                    case 2:
                        word = "close your eyes";
                        break;
                    case 3:
                        word = "jump";
                        break;
                }

                strList.Add(word);
                binary = binary - 1;
            }

            binary = binary / 10;
        }

        if (reserved) strList.Reverse();
        return strList.ToArray();
    }
}
