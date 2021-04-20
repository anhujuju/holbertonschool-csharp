using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxScore = -1;
        string key = "None";

        if (myList == null)
            return key;

        foreach (KeyValuePair<string, int> e in myList)
        {
            if (e.Value > maxScore)
            {
                maxScore = e.Value;
                key = e.Key;
            }
        }

        return key;
    }
}
