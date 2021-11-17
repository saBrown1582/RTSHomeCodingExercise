using System;
using System.Collections.Generic;
using System.Linq;

public class HomeCodingExercise
{
    public Dictionary<string, int> aboveBelow(List<int> list, int comparisonValue)
    {
        var returnValue = new Dictionary<string, int>();

        returnValue.Add("above", list.Where(i => i > comparisonValue).Count());
        returnValue.Add("below", list.Where(i => i < comparisonValue).Count());

        return returnValue;
    }

    public string stringRotation(string original, int rotationAmount)
    {
        if (rotationAmount < 0) throw new ArgumentException("rotationAmount must be positive");
        string returnValue;

        int modRotationAmount = rotationAmount % original.Length;
        int overflowCutoffIndex = original.Length - modRotationAmount;

        returnValue = original.Substring(overflowCutoffIndex, modRotationAmount) + original.Substring(0, overflowCutoffIndex);

        return returnValue;
    }
}
