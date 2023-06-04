using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public Slider sliderA;

    float sliderperc;
    float slidermax;

    float handcoord;
    float stagecoord;
    GameObject coordscript;
    // Start is called before the first frame update
    void Start()
    {
        coordscript = GameObject.Find("CanvasUI");


    }
    void Awake()
    {
        sliderperc = 100.0f;
        slidermax = 100.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        handcoord = coordscript.GetComponent<HandCoordinate>().position.y;
        stagecoord = coordscript.GetComponent<HandCoordinate>().stagepos.y;
        sliderA.value = Mathf.Abs(handcoord - stagecoord) * 2;
    }
}
