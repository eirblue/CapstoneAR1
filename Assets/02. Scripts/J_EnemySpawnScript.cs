using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_EnemySpawnScript : MonoBehaviour
{
    public List<GameObject> enemySpawnPoss = new List<GameObject>();

    public GameObject enemies;
    public GameObject boss;

    [SerializeField]
    private bool bossSpotSelected = false;
    [SerializeField]
    private int bossSpotNum;


    void Start()
    {
        bossSpotNum = Random.Range(0, enemySpawnPoss.Count);

        for (int i = 0; i < enemySpawnPoss.Count; i++)
        {
            if (i == bossSpotNum && bossSpotSelected == false)
            {
                Instantiate(boss, enemySpawnPoss[i].transform);
                bossSpotSelected = true;
            }
            else
            {
                Instantiate(enemies, enemySpawnPoss[i].transform);
            }
        }
    }
}
