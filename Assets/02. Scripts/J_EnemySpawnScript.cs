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

    [SerializeField]
    private Transform posRandomOffSet;

    void Start()
    {
        bossSpotNum = Random.Range(0, enemySpawnPoss.Count);
        barrierSpotNum = Random.Range(1, enemySpawnPoss.Count / 3);
        barrierSpawnedNum = barrierSpotNum;

        barrierSpotNum = 0;

        for (int i = 0; i < enemySpawnPoss.Count; i++)
        {
            if (i == bossSpotNum && bossSpotSelected == false)
            {
                // posRandomOffSet.position = enemySpawnPoss[i].transform.position + new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f));                
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
