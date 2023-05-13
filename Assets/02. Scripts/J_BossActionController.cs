using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_BossActionController : MonoBehaviour
{
    private GameObject juingongObject;
    [SerializeField]
    private float chaseSpeed;
    private Rigidbody bossRb;

    [SerializeField]
    float settedTime;
    float chaseTime;

    bool startChasing;
    
    private void Start()
    {
        chaseTime = 0.0f;
        startChasing = false;

        juingongObject = GameObject.FindWithTag("ballsJuingong");
        bossRb = GetComponent<Rigidbody>();
                
    }
    void Update()
    {
        if (startChasing == false)
        {
            chaseTime += Time.deltaTime;
        }

        if (chaseTime >= settedTime)
        {
            ChaseJuingong();
            startChasing = true;
        }
    }

    void ChaseJuingong()
    {
        Vector3 lookDirection = (juingongObject.transform.position - transform.position).normalized;
        bossRb.AddForce(lookDirection * chaseSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 주인공과 충돌 시 소리가 남
    }

}
