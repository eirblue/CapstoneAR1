using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class J_SceneChangeController : MonoBehaviour
{
    public GameObject scoreObject;

    public void EnterTitleScene()
    {
        Debug.Log("Load title scene");
        SceneManager.LoadScene(0);
    }

    public void EnterGameScene()
    {
        Debug.Log("Load game scene");
        SceneManager.LoadScene(1);
    }

    public void EnterEndingScene()
    {
        Debug.Log("Load ending scene");        
        SceneManager.LoadScene(2);        
    }

    public void EnterCreditScene()
    {
        Debug.Log("Load CreditScene");
        SceneManager.LoadScene(3);
    }

    public void EndGame()
    {
        Debug.LogWarning("End Game");
        Application.Quit();
    }


    // 게임 플레이 중 종료버튼(Exit button) 눌렀을 때
    public GameObject exitQuestion;
    public void ExitButtonWhilePlaying()
    {
        // 질문 & Yes, No button 활성화
        if (exitQuestion.activeInHierarchy == false)
        {
            exitQuestion.SetActive(true);
        }
    }

    // 팝업으로 정말 종료하겠습니까? >>>> No 선택 시 질분 & yes, no button 비활성화
    public void NotQuitting()
    {
        // 스스로 disable하기
        exitQuestion.SetActive(false);
    }
}
