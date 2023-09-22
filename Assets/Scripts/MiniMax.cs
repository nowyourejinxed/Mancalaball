using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMax : MonoBehaviour
{
    int miniMax(int depth, int index, bool isMax, int scores[], int h)
    {
        if (depth == h)
        {
            return scores[index];
        }

        if (isMax)
        {
            return Math.Max(miniMax(depth + 1; index * 2, false, scores, h), miniMax(depth + 1, index * 2 + 1, false, scores, h));
        }
        else
        {
            return Math.Min(miniMax(depth + 1; index * 2, true, scores, h), miniMax(depth + 1, index * 2 + 1, true, scores, h))
        }
    }

    int StaticEvaluator()
    {
        int totalScore = 0;
        //code for evaluation
        return totalScore;
    }
}
