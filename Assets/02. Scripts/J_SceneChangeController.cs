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


    // ���� �÷��� �� �����ư(Exit button) ������ ��
    public GameObject exitQuestion;
    public void ExitButtonWhilePlaying()
    {
        // ���� & Yes, No button Ȱ��ȭ
        if (exitQuestion.activeInHierarchy == false)
        {
            exitQuestion.SetActive(true);
        }
    }

    // �˾����� ���� �����ϰڽ��ϱ�? >>>> No ���� �� ���� & yes, no button ��Ȱ��ȭ
    public void NotQuitting()
    {
        // ������ disable�ϱ�
        exitQuestion.SetActive(false);
    }
}
