using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_EnemySpawnScript : MonoBehaviour
{
    public List<GameObject> enemySpawnPoss = new List<GameObject>();

    public GameObject enemies;
    public GameObject boss;
    public GameObject barrier;

    [SerializeField]
    private bool bossSpotSelected = false;
    [SerializeField]
    private int bossSpotNum;

    [SerializeField]
    private int barrierSpotNum;
    [SerializeField]
    private int barrierSpawnedNum;

    void Start()
    {
        bossSpotNum = Random.Range(0, enemySpawnPoss.Count);
        barrierSpotNum = Random.Range(1, enemySpawnPoss.Count / 2);
        barrierSpawnedNum = barrierSpotNum;

        for (int i = 0; i < enemySpawnPoss.Count; i++)
        {
            if (i == bossSpotNum && bossSpotSelected == false)
            {
                Instantiate(boss, enemySpawnPoss[i].transform);
                bossSpotSelected = true;
            }
            else if (i <= barrierSpotNum && barrierSpawnedNum != 0)
            {
                Instantiate(barrier, enemySpawnPoss[i].transform);
                barrierSpawnedNum -= 1;
            }
            else
            {
                Instantiate(enemies, enemySpawnPoss[i].transform);
            }
        }
    }
}
