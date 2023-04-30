using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class J_UIToggleControl : MonoBehaviour
{
    public bool textToggle;
    public GameObject onText;
    public GameObject offText;
    public GameObject debugLogText;

    // Start is called before the first frame update
    void Start()
    {
        textToggle = true;
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(UIToggle);        
    }

    public void UIToggle()
    {
        if (textToggle == true)
        {
            onText.SetActive(true);
            offText.SetActive(false);
            debugLogText.SetActive(false);
            textToggle = false;
        }
        else
        {
            onText.SetActive(false);
            offText.SetActive(true);
            debugLogText.SetActive(true);
            textToggle = true;
        }
    }
}
