using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class W_TimeScript : MonoBehaviour
{
    public float playTime;
    public float playTimestatic;
    public TextMeshProUGUI timeText;
    public GameObject timeObject;
    private J_SceneChangeController endScene;


    // Start is called before the first frame update
    void Start()
    {
        timeObject = GameObject.Find("time(TMP)");
        timeText = timeObject.GetComponent<TextMeshProUGUI>();
        endScene = new J_SceneChangeController();
        playTimestatic = playTime;

    }

    // Update is called once per frame
    void Update()
    {
        playTime -= Time.deltaTime;
        Debug.Log(playTime);

        if (playTime <= 0.0f)
        {
            Debug.Log("game over");
            //gmae over
            endScene.EnterEndingScene();

        }
        timeText.text = "Time: " + (int)playTime / 60 + "m " + (int)playTime % 60 + "s";

        


    }
}
