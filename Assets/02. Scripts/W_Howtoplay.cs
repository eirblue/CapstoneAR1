using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class W_Howtoplay : MonoBehaviour
{
    public void Howtoplay()
    {
        Debug.Log("Load Howtoplay");
        SceneManager.LoadScene(0);
    }
    public void EnterHowToPlay()
    {
        Debug.Log("Load Howtoplay");
        SceneManager.LoadScene(4);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
