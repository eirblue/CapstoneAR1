using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class W_ScoreController : MonoBehaviour
{
    public int currScore;
    [SerializeField]
    public static int disBallScore;
    
    public TextMeshProUGUI scoreText;

    public static int ThisBallScoreReturner()
    {
        return disBallScore;
    }

    public void UpdateScore(int scoreToAdd)
    {
        currScore += scoreToAdd;
        scoreText.text = "Score: " + currScore;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ballDestroy"))
        {
            Debug.Log($"{name} fell, the score is {disBallScore}");
           
            UpdateScore(disBallScore);
        }
    }

    void Start()
    {
        currScore = 0;
        UpdateScore(currScore);
    }

    public void ResetScore()
    {
        currScore = 0;
        scoreText.text = "Score: " + currScore;
    }
}
