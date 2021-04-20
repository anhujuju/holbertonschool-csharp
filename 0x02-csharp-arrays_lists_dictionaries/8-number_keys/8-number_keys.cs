using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        if (myDict == null)
            return -1;

        int count = 0;

        foreach (KeyValuePair<string, string> e in myDict)
            count++;

        return count;
    }
}
