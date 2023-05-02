using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallYPosController : MonoBehaviour
{
    [SerializeField]
    float xPosNum;
    [SerializeField]
    float yPosNum;
    [SerializeField]
    float zPosNum;
    [SerializeField]
    Vector3 resetPos;

    Rigidbody ballRb;
    
    void Start()
    {
        xPosNum = transform.position.x;
        yPosNum = transform.position.y;
        zPosNum = transform.position.z;
        ballRb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("playBoard"))
        {
            Debug.LogWarning($"{name} touched the play board");
            ballRb.useGravity = true;
            ballRb.constraints = RigidbodyConstraints.FreezePositionY;            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("playBoard"))
        {
            Debug.LogWarning($"{name} escaped the play board");
            ballRb.useGravity = true;
            ballRb.constraints = RigidbodyConstraints.None;            
        }
    }
}