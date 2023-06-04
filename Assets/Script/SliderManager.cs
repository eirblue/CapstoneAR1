using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{//하아아아아아아아아ㅏㅏㅏㅏㅏ
    public Slider sliderA;

    float sliderperc;
    float slidermax;

    float handcoord;
    float stagecoord;
    GameObject coordscript;

    Color tooFar = new Color(1.0f, 0.0f, 0.0f);
    Color midClose = new Color(0.5f, 1.0f, 0.0f);
    Color tooClose = new Color(0.0f, 1.0f, 0.0f);
    public GameObject sliderFiller;
    void Awake()
    {
        sliderperc = 100.0f;
        slidermax = 100.0f;
    }

    void Start()
    {
        coordscript = GameObject.Find("CanvasUI");
        //sliderA.maxValue = 0.001f;
    }    
        
    void Update()
    {
        handcoord = coordscript.GetComponent<HandCoordinate>().handPos.y;
        stagecoord = coordscript.GetComponent<HandCoordinate>().stagePos.y;
        sliderA.value = Mathf.Abs(handcoord - stagecoord) * 2;
     /*
        
        if (coordscript.GetComponent<HandCoordinate>().handStageDistance.y >= 1)
        {
            sliderFiller.GetComponent<Image>().color = tooFar;
            sliderA.value = 0.0f;
        }
        else
        {
            float hsDistance = Mathf.Abs(coordscript.GetComponent<HandCoordinate>().handStageDistance.y);
            if (hsDistance <= 0.085f)
            {
                // Green
                sliderFiller.GetComponent<Image>().color = tooClose;
            }
            else if (hsDistance <= 0.087f)
            {
                // Orange
                sliderFiller.GetComponent<Image>().color = midClose;
            }
            else
            {
                //Red
                sliderFiller.GetComponent<Image>().color = tooFar;
            }
            sliderA.value = 1.0f - hsDistance;
        }
       */ 
    }
}
