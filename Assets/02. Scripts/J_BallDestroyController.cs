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
    private J_BallScoreScript ballScoreIndividual;

    private void Start()
    {
        currScore = 0;
        scoreTextObject = GameObject.Find("Scor(TMP)");
        scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
    }


    public int UpdateScore(int scoreToAdd)
    {
        currScore += scoreToAdd;
        scoreText.text = "Score: " + currScore;
        return currScore;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("balls") || collision.gameObject.CompareTag("ballsJuingong"))// || collision.gameObject.CompareTag("ballsBoss")
        {
            Debug.Log($"{collision.gameObject.name} has escaped. Now deleting.111111111111111111111111111111111111111111111111");     

            disBallScore = collision.gameObject.GetComponent<J_BallScoreScript>().thisBallScore;
            Debug.Log($"Ball destroyed: {collision.gameObject.name}, Score: {disBallScore} - 999999999999999999999999999999999999999999999999999");

            // 점수 더하기
            UpdateScore(disBallScore);

            Destroy(collision.gameObject);
        }
    }
}
