using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class J_BallDestroyController : MonoBehaviour
{
    public int currScore;
    public int disBallScore;
    public GameObject scoreTextObject;
    public TextMeshProUGUI scoreText;
    private W_ScoreController wScoreCon;

    private void Start()
    {
        wScoreCon = new W_ScoreController();

        
        scoreTextObject = GameObject.Find("Scor(TMP)");
        scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(int scoreToAdd)
    {
        scoreToAdd = disBallScore;
        currScore += scoreToAdd;
        scoreText.text = "Score: " + currScore;

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("balls") || collision.gameObject.CompareTag("ballsJuingong"))
        {
            Debug.Log($"{collision.gameObject.name} has escaped. Now deleting.111111111111111111111111111111111111111111111111");
            Debug.Log($"Woohyun sososososososososososo cute");

            disBallScore = W_ScoreController.ThisBallScoreReturner();

            UpdateScore(currScore);
            // 점수 더하기

            Destroy(collision.gameObject);
        }
    }
}
