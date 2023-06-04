using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_SpawnPosRandomizer : MonoBehaviour
{
    [SerializeField]
    private float randomOffset;
    void Start()
    {
        transform.position += RandomPosSet(randomOffset);
    }

    Vector3 RandomPosSet(float _ranFlt)
    {
        float xPos = Random.Range(-_ranFlt, _ranFlt);
        float yPos = Random.Range(-_ranFlt, _ranFlt);
        float zPos = Random.Range(-_ranFlt, _ranFlt);

        return new Vector3(xPos,yPos,zPos);
    }
}
