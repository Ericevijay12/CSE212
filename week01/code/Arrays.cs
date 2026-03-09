using System;
using System.Collections.Generic;

public static class Arrays
{
    public static double[] MultiplesOf(double number, int count)
    {
        // Step 1: Initialize array of size 'count'
        // Step 2: Loop 'count' times to calculate multiples
        double[] results = new double[count];
        for (int i = 0; i < count; i++)
        {
            results[i] = number * (i + 1);
        }
        return results;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Check for empty list or zero effective rotation
        if (data.Count == 0 || amount % data.Count == 0) return;

        // Step 2: Calculate split point and slice the list
        int effectiveAmount = amount % data.Count;
        int startingIndex = data.Count - effectiveAmount;
        
        List<int> suffix = data.GetRange(startingIndex, effectiveAmount);
        data.RemoveRange(startingIndex, effectiveAmount);
        data.InsertRange(0, suffix);
    }
}
