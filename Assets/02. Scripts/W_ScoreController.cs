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






    // Start is called before the first frame update
    void Start()
    {
        currScore = 0;
        UpdateScore(currScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
