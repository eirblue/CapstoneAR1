using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class J_TouchRaycastController : MonoBehaviour
{
    public GameObject gameStage;
    [SerializeField]
    private Transform stageSpawnPos;
    [SerializeField]
    private Transform drawPos;


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit hit;
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.rigidbody != null)
                    {
                        stageSpawnPos = hit.transform;

                        Instantiate(gameStage, stageSpawnPos);
                    }
                }
            }
        }
        Debug.DrawRay(drawPos.position, drawPos.forward*10, Color.green, 10.0f,false);
    }
}
