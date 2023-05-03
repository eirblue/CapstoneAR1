using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_ReturnButtonController : MonoBehaviour
{
    public GameObject returnBtn;

    IEnumerator Start()
    {
        Debug.LogWarning("Credit scene loaded. Activate the return button in 3 seconds");
        yield return StartCoroutine("WaitAndActivateReturnBtn");
    }

    // 3초 뒤 타이틀 씬 리턴 버튼 활성화    
    IEnumerator WaitAndActivateReturnBtn()
    {
        yield return new WaitForSeconds(3.0f);
        if (returnBtn.activeInHierarchy == false)
        {
            returnBtn.SetActive(true);
            Debug.LogWarning("Return button activated");
        }
    }
}
