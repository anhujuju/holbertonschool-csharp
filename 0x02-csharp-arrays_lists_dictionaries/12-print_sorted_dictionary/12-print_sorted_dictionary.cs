using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);

        if (myDict == null)
            return;

        keys.Sort();

        foreach (string key in keys)
            Console.WriteLine($"{key}: {myDict[key]}");
    }
}
