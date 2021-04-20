using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList == null)
            return null;

        List<bool> result = new List<bool>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
                result.Add(true);
            else
                result.Add(false);
        }

        return result;
    }
}
