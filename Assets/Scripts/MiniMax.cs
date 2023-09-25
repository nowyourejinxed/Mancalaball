using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MiniMax
{
    public static int miniMax()
    {
        if (/*is leaf*/)
        {
            return 0/*leaf*/;
        }

        if (/*Maximizing move*/)
        {
            //find maximum value
            //for loop - check left and right
            //if beta <= alpha - break
            //return Math.Max(miniMax(depth + 1; index * 2, false, scores, h), miniMax(depth + 1, index * 2 + 1, false, scores, h));
        }
        //if minimizing move
        else
        {
            //find minimum value
            //for loop - check left and right
            //if beta <= alpha - break
            //return Math.Min(miniMax(depth + 1; index * 2, true, scores, h), miniMax(depth + 1, index * 2 + 1, true, scores, h));
        }
    }

    int StaticEvaluator()
    {
        int totalScore = 0;
        //code for evaluation
        return totalScore;
    }
}
