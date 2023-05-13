using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_BallScoreScript : MonoBehaviour
{
    public int thisBallScore;
    public static int ballScore;

    public void Start()
    {
        ballScore = thisBallScore;
        Debug.Log($"{ballScore}");
    }
    public static int BallScoreReturner()
    {
        return ballScore;
    }
}
