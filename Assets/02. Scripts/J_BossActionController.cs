using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_BossActionController : MonoBehaviour
{
    private GameObject juingongObject;

    [SerializeField]
    private float chaseSpeed;

    private Rigidbody bossRb;

    private void Start()
    {
        juingongObject = GameObject.FindWithTag("ballsJuingong");
        bossRb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 lookDirection = (juingongObject.transform.position -
              transform.position).normalized;
        bossRb.AddForce(lookDirection * chaseSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
            // 주인공과 충돌 시 소리가 남
    }

}
