using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class W_ScoreController : MonoBehaviour
{
    public int currScore;
    [SerializeField]
    public int disBallScore;

    public TextMeshProUGUI scoreText;

    public string scoreToCut;

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

    public string UpdateScore(int scoreToAdd)
    {
        currScore += scoreToAdd;
        scoreText.text = "Score: " + currScore;
        return scoreText.text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ballDestroy"))
        {
            Debug.Log($"{name} fell, the score is {disBallScore}");
            scoreToCut= UpdateScore(disBallScore);          
        }
    }
}
